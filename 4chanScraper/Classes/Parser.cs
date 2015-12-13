using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
public class Parser
{
    private Regex _reg;
    private readonly string _url;

    public Parser(string url)
    {
        _reg = new Regex(@"4chan.org\/([a-z,0-9]{1,3})\/thread\/([0-9]+)");

        _url = url;
    }

    public bool IsValid()
    {
        return Parse().Count() != 0;
    }

    public Task<ThreadData> BuildThreadData()
    {
        var parsed = Parse();

        return Task.Run(() =>
        {
            return new ThreadData()
            {
                Board = parsed.First(),
                Thread = parsed.Last()
            };
        });
    }

    private IEnumerable<string> Parse()
    {
        return _reg.Matches(_url).Cast<Match>().SelectMany(m => m.Groups.Cast<Capture>().Skip(1).Select(c => c.Value));
    }
}
