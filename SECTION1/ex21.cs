// ex21.cs
using System;
using System.Windows;
using System.Windows.Input;

public class MainWindow : System.Windows.Window
{

}

class Program
{
    [STAThread]
    public static void Main()
    {
        Application app = new Application();

        MainWindow win = new MainWindow();

        win.MouseDown += Win_MouseDown;

        app.Run(win);
    }

    private static void Win_MouseDown(object sender, 
                              MouseButtonEventArgs e)
    {
        Window win = (Window)sender;

        Point pt = e.GetPosition(win);

        win.Title = $"{pt.X}, {pt.Y}";
    }
}
