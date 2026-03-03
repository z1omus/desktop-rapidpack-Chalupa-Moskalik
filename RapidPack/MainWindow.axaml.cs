using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Utilities;

namespace RapidPack;

public partial class MainWindow : Window
{

    private TextBlock _weight;
    private TextBlock _length;
    private TextBlock _height;
    private TextBlock _width;
    private CheckBox _express;
    private ComboBox _type;
    
    
    public MainWindow()
    {
        InitializeComponent();
    }

    public void SubmitButton_Click(object? sender, RoutedEventArgs e)
    {
        var weight  = int.TryParse(_weight.Text,  out var parsedWeight) ? parsedWeight : 0;
        var length = int.TryParse(_length.Text,  out var parsedLength) ? parsedWeight : 0;
        var height = int.TryParse(_height.Text,  out var parsedHeight) ? parsedWeight : 0;
        var width = int.TryParse(_width.Text,  out var parsedWidth) ? parsedWeight : 0;
        var express = Express.IsChecked == true? "ekspresowa": "zwykła";
        var type = (Type.SelectedItem as ComboBoxItem)?.Content?.ToString();
        var calculator = new ParcelCalculator();
        Summary.Text = $"podsumowanie{calculator.GetPrice(weight, length, height, width, express, type)}\n{calculator.IsOverweight(weight)}";
    }

    
}