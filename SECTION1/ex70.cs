// ex70.cs
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

public class MainWindow : System.Windows.Window
{
    protected void InitializeComponent()
    {
        Grid grid = null;

        using (FileStream fs = new FileStream("../../ex70.xaml", FileMode.Open))
        {
            grid = (Grid)XamlReader.Load(fs);
        }

        this.Content = grid;

        Button btn = (Button)grid.FindName("button1");

        btn.Click += Btn_Click;
        
    }

    private void Btn_Click(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("button click");
    }

    public MainWindow()
    {
        InitializeComponent();
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
