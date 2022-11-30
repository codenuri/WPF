// ex32.cs - WPF 프로그램의 기본 구조
using System;
using System.Windows;

public class MainWindow : System.Windows.Window
{
    public MainWindow()
    {

    }
}

public class App : System.Windows.Application
{
    public App()
    {
      
    }

    [STAThread]
    public static void Main()
    {
        App app = new App();

        MainWindow win = new MainWindow();

        app.Run(win);
    }
}
