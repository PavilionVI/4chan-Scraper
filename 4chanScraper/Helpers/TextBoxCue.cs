using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public static class TextBoxCue
{
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);

    private const int EM_SETCUEBANNER = 0x1501;

    public static void SetCue(Control control, string text)
    {
        SendMessage(control.Handle, EM_SETCUEBANNER, IntPtr.Zero, text);
    }
}