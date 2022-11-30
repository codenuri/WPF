// ex31.cs
using System;
using System.Windows;

public class MainWindow : System.Windows.Window
{
}

public class App : System.Windows.Application
{
    public App()
    {
        this.Startup += App_Startup;
    }

    private void App_Startup(object sender, StartupEventArgs e)
    {
        Console.WriteLine("App_Startup");
    }

    [STAThread]
    public static void Main()
    {
        App app = new App();

        MainWindow win = new MainWindow();

        app.Run(win);
    }
}
