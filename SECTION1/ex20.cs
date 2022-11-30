// ex20.cs
using System;
using System.Windows;
using System.Windows.Input;

public class MainWindow : System.Windows.Window
{
    protected override void OnMouseDown(MouseButtonEventArgs e)
    {
        base.OnMouseDown(e);

        Point pt = e.GetPosition(this);

        this.Title = $"{pt.X}, {pt.Y}";
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
