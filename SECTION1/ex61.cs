// ex61.cs
using System;
using System.Windows;
using System.Windows.Controls;

public class MainWindow : System.Windows.Window
{
    private Grid grid = null;

    protected void InitializeComponent()
    {
        grid = new Grid();

        grid.RowDefinitions.Add(new RowDefinition());
        grid.RowDefinitions.Add(new RowDefinition());

        grid.ColumnDefinitions.Add(new ColumnDefinition());
        grid.ColumnDefinitions.Add(new ColumnDefinition());

        this.Content = grid;

        Button btn1 = new Button();
        btn1.Content = "확인1";

        Button btn2 = new Button();
        btn2.Content = "확인2";

        Button btn3 = new Button();
        btn3.Content = "확인3";

        Button btn4 = new Button();
        btn4.Content = "확인4";

        Grid.SetRow(btn1, 0);
        Grid.SetColumn(btn1, 0);

        Grid.SetRow(btn2, 0);
        Grid.SetColumn(btn2, 1);

        Grid.SetRow(btn3, 1);
        Grid.SetColumn(btn3, 0);

        Grid.SetRow(btn4, 1);
        Grid.SetColumn(btn4, 1);

        grid.Children.Add(btn1);
        grid.Children.Add(btn2);
        grid.Children.Add(btn3);
        grid.Children.Add(btn4);

        btn1.Click += Btn1_Click;
        btn2.Click += Btn2_Click;
        btn3.Click += Btn3_Click;
        btn4.Click += Btn3_Click;
    }

    public MainWindow()
    {
        InitializeComponent();

    }

    private void Btn3_Click(object sender, RoutedEventArgs e)
    {
        Button btn = sender as Button;
        string s = btn.Content as string;

        Console.WriteLine($"{s} Click");
    }

    private void Btn2_Click(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("확인2 Click");
    }

    private void Btn1_Click(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("확인1 Click");
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
