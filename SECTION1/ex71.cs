// ex71.cs, ex71.xaml
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

public class MainWindow : System.Windows.Window
{
    protected override void OnMouseDown(MouseButtonEventArgs e)
    {
        base.OnMouseDown(e);
        Console.WriteLine("MouseDown");
    }
}

public class App : System.Windows.Application
{
    [STAThread]
    public static void Main()
    {
        App app = new App();

        //MainWindow win = new MainWindow();

        Window win = null;

        using (FileStream fs = new FileStream("../../ex71.xaml", FileMode.Open))
        {
            win = (Window)XamlReader.Load(fs);
        }

        app.Run(win);
    }
}
