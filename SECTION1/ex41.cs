// ex41.cs
using System;
using System.Windows;
using System.Windows.Input;

public class MainWindow : System.Windows.Window
{
    public void Fn()
    {
        Console.WriteLine("MainWindow Fn");
    }
}

public class App : System.Windows.Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        ((MainWindow)this.MainWindow).Fn();
    }

    protected override void OnExit(ExitEventArgs e)
    {
        base.OnExit(e);
        //((MainWindow)this.MainWindow).Fn();

        Console.WriteLine($"{this.MainWindow == null}");
    }

    [STAThread]
    public static void Main()
    {
        App app = new App();

        MainWindow win = new MainWindow();

        //app.MainWindow = win;

        app.Run(win); 
    }
}
