﻿using System;
using System.Windows.Forms;

public class TitleBuilder
{
    public static void Build(Form f, string s, bool ellipsis = true)
    {
        f.Text = string.Join(" | ", "4chan Scraper", s + (ellipsis ? "..." : string.Empty));
    }
}