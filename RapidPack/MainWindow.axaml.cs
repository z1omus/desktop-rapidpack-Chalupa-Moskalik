using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Utilities;

namespace RapidPack;

public partial class MainWindow : Window
{

    public TextBox _weight;
    public TextBox _length;
    public TextBox _height;
    public TextBox _width;
    public CheckBox _express;
    public ComboBox _type;
    
    public MainWindow()
    {
        InitializeComponent();

        _weight = this.FindControl<TextBox>("Weight");
        _length = this.FindControl<TextBox>("Length");
        _height = this.FindControl<TextBox>("Height");
        _width = this.FindControl<TextBox>("Width");
        _express = this.FindControl<CheckBox>("Express");
        _type = this.FindControl<ComboBox>("Type");
    }

    public void SubmitButton_Click(object? sender, RoutedEventArgs e)
    {
        var weight = double.TryParse(_weight.Text,  out var parsedWeight) ? parsedWeight : 0;
        var length = double.TryParse(_length.Text,  out var parsedLength) ? parsedWeight : 0;
        var height = double.TryParse(_height.Text,  out var parsedHeight) ? parsedWeight : 0;
        var width = double.TryParse(_width.Text,  out var parsedWidth) ? parsedWeight : 0;
        var express = Express.IsChecked == true? "ekspresowa": "zwykła";
        var type = (Type.SelectedItem as ComboBoxItem)?.Content?.ToString();
        var calculator = new ParcelCalculator();
        Summary.Text = $"podsumowanie\n cena: {calculator.GetPrice(parsedWeight, parsedLength, parsedHeight, parsedWidth, express, type)}\nwaga: {parsedWeight}\nwymiary: {parsedLength} x {parsedHeight} x {parsedWidth}\ndostawa :{express}\ntyp przesyłki:  {type}";
    }

    
}
