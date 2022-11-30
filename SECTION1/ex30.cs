// ex30.cs
using System;
using System.Windows;

public class MainWindow : System.Windows.Window
{
}

public class App : System.Windows.Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        Console.WriteLine("OnStartup");
    }

    protected override void OnExit(ExitEventArgs e)
    {
        base.OnExit(e);
        Console.WriteLine("OnExit");
    }

    [STAThread]
    public static void Main()
    {
        App app = new App();

        MainWindow win = new MainWindow();

        app.Run(win);
    }
}
