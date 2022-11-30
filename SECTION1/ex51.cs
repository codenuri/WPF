// ex51.cs
using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

public class MainWindow : System.Windows.Window
{
    public MainWindow()
    {
        BitmapImage bitmap = new BitmapImage();

        bitmap.BeginInit();
        bitmap.UriSource = new Uri("D:\\totoro.jpg");
        bitmap.EndInit();

        Image img = new Image();
        img.Source = bitmap;
        img.Stretch = System.Windows.Media.Stretch.Fill;

        this.Content = img;
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
