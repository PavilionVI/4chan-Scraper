using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class TitleBuilder
{
    public static void Build(Form f, string s, bool ellipsis = true)
    {
        f.Text = string.Join(" | ", "4chan Scraper", s);
    }
}