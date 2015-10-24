using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4chanScraper
{
    public partial class frmMain : Form
    {
        private FolderBrowserDialog _fbd;

        public frmMain()
        {
            InitializeComponent();

            _fbd = new FolderBrowserDialog
            {
                Description = "Select a base directory. A sub-folder for the thread will be created automatically.",
                RootFolder = Environment.SpecialFolder.Desktop
            };
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            txtPath.Clear();

            if (_fbd.ShowDialog() == DialogResult.OK)
            {
                ToggleGroupBoxes(true);
                txtPath.Text = _fbd.SelectedPath;
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            pbMain.Value = 0;

            var parser = new Parser(txtThread.Text);
            if (!parser.IsValid()) return;

            ToggleGroupBoxes(false);
            TitleBuilder.Build(this, "Initializing");

            var scraper = new Scraper(await parser.BuildThreadData(), UpdateProgress);

            var files = await scraper.CollectFileURLs(cbWEBM.Checked, cbDuplicates.Checked);
            if (files == null) return;

            pbMain.Maximum = files.Count;
            await Task.WhenAll(files.Select(p => scraper.DownloadFileAsync(this, p, rbUID.Checked, txtPath.Text)));

            ToggleGroupBoxes(true);
            TitleBuilder.Build(this, "Completed", false);
        }

        private void UpdateProgress()
        {
            pbMain.Increment(1);
        }

        private void ToggleGroupBoxes(bool state)
        {
            foreach (var gb in this.Controls.OfType<GroupBox>())
                gb.Enabled = state;
        }

        private void rbUID_CheckedChanged(object sender, EventArgs e)
        {
            cbDuplicates.Enabled = rbOrg.Checked;
            cbDuplicates.Checked = rbOrg.Checked;
        }

        private void txtThread_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnStart_Click(sender, EventArgs.Empty);
        }
    }
}
