// ex40.cs
using System;
using System.Windows;
using System.Windows.Input;

public class MainWindow : System.Windows.Window
{
    protected override void OnMouseDown(MouseButtonEventArgs e)
    {
        base.OnMouseDown(e);

        //Application.Current.Shutdown();
        ((App)Application.Current).Fn();
    }
}

public class App : System.Windows.Application
{
    public void Fn() { Console.WriteLine("Fn"); }

    [STAThread]
    public static void Main()
    {
        App app = new App();

        MainWindow win = new MainWindow();

        app.Run(win);
    }
}
