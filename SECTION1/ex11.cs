// ex11.cs
using System;
using System.Windows;

class Program
{
    [STAThread]
    public static void Main()
    {
        Application app = new Application();

        Window win = new Window();

        // win.Show();
        // app.MainWindow = win;
        // app.Run();

        app.Run(win);
    }
}
