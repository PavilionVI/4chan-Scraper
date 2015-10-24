using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Windows.Forms;

class Scraper
{
    private const string ImageURL = @"http://i.4cdn.org/{0}/{1}{2}";
    private const string JsonURL = @"http://a.4cdn.org/{0}/thread/{1}.json";

    private readonly HttpClient _client;
    private readonly ThreadData _thread;

    private readonly Action _action;

    public Scraper(ThreadData td, Action act)
    {
        var handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            AutomaticDecompression = DecompressionMethods.GZip & DecompressionMethods.Deflate,

            UseCookies = false,
            UseProxy = false
        };

        _client = new HttpClient(handler);
        _thread = td;

        _action = act;
    }

    public async Task<List<Post>> CollectFileURLs(bool webm, bool dups)
    {
        var response = await DownloadStringAsync(string.Format(JsonURL, _thread.Board, _thread.Thread));
        if (string.IsNullOrEmpty(response)) return null;

        return await Task.Run(() =>
         {
             var files = JsonUtil.Deserialize<FThread>(response).posts.Where(p => !string.IsNullOrEmpty(p.tim)).ToList();

             if (!webm) files.RemoveAll(p => p.ext == ".webm");
             if (dups) files = files.Distinct().ToList();

             return files;
         });
    }

    public async Task DownloadFileAsync(Form f, Post p, bool useName, string dir)
    {
        try
        {
            var url = string.Format(ImageURL, _thread.Board, p.tim, p.ext);
            var name = (useName ? p.tim : p.filename) + p.ext;

            string threadDir = Path.Combine(dir, _thread.Thread);
            Directory.CreateDirectory(threadDir);

            var fBytes = await _client.GetByteArrayAsync(url);
            File.WriteAllBytes(Path.Combine(threadDir, name), fBytes);

            TitleBuilder.Build(f, name, true);
            _action.Invoke();
        }
        catch
        {
            File.Delete(Path.Combine(dir, _thread.Thread, (useName ? p.tim : p.filename) + p.ext));
        }
    }

    public async Task<string> DownloadStringAsync(string url)
    {
        try
        {
            var response = await _client.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
        catch
        {
            return string.Empty;
        }
    }
}