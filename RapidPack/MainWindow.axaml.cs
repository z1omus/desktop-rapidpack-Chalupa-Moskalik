using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Utilities;

namespace RapidPack;

public partial class MainWindow : Window
{

    public MainWindow()
    {
        InitializeComponent();
    }

    public void SubmitButton_Click(object? sender, RoutedEventArgs e)
    {
        double.TryParse(Weight.Text,  out var parsedWeight);
        double.TryParse(Length.Text,  out var parsedLength);
        double.TryParse(Height.Text,  out var parsedHeight);
        double.TryParse(Width.Text,  out var parsedWidth);

        var express = Express.IsChecked == true? "ekspresowa": "zwykła";
        var type = (Type.SelectedItem as ComboBoxItem)?.Content?.ToString();
        var calculator = new ParcelCalculator();
        Summary.Text = $"podsumowanie\n cena: {calculator.GetPrice(parsedWeight, parsedLength, parsedHeight, parsedWidth, express, type)}" +
        $"\nwaga: {parsedWeight}\nwymiary: {parsedLength} x {parsedHeight} x {parsedWidth}\ndostawa :{express}\ntyp przesyłki:  {type}";
    }


    private void Weight_OnTextChanging(object? s, TextChangingEventArgs e)
    {
        var box = s as TextBox;

        if (int.TryParse(box.Text, out int weight))
        {
            if (weight > 30)
            {
                Overweight.Text = "Za duża waga!";
            }
        }
    }
}
