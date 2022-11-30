// ex12.cs
using System;
using System.Windows;
using System.Windows.Media;

class Program
{
    [STAThread]
    public static void Main()
    {
        Application app = new Application();

        Window win = new Window();

        win.Width = 400;
        win.Height = 400;
        win.Title = "EX12";
        win.Topmost = true;

        win.Background = new SolidColorBrush(Colors.Green);                

        app.Run(win);
    }
}
