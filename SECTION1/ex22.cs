// ex22.cs
using System;
using System.Windows;
using System.Windows.Input;

public class MainWindow : System.Windows.Window
{
    public MainWindow()
    {
        this.MouseDown += MainWindow_MouseDown;
    }

    private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
    {
        Window win = (Window)sender;

        Point pt = e.GetPosition(this);

        win.Title = $"{pt.X}, {pt.Y}";
    }
}


class Program
{
    [STAThread]
    public static void Main()
    {
        Application app = new Application();

        MainWindow win = new MainWindow();

        app.Run(win);
    } 
}
