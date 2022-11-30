// ex50.cs
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

public class MainWindow : System.Windows.Window
{
    public MainWindow()
    {
        //    this.Content = "Hello";

        Button btn = new Button();

        btn.Content = "OK";

        this.Content = btn;
    }
}

public class App : System.Windows.Application
{
    [STAThread]
    public static void Main()
    {
        App app = new App();

        MainWindow win = new MainWindow();

        app.Run(win);
    }
}
