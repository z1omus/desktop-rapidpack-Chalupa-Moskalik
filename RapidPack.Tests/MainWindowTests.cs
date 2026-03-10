using Avalonia.Controls;
using Avalonia.Headless.XUnit;
using Avalonia.Interactivity;

namespace RapidPack.Tests;

public class MainWindowTests
{
   [AvaloniaFact]
   public void CreateWindow_ShouldCreateANewWindow()
   {
      var window = new MainWindow();
      Assert.NotNull(window);
   }

   [AvaloniaFact]
   public void ShouldShowError_WhenOverweght()
   {
      var window = new MainWindow();
      var weight = window.FindControl<TextBox>("Weight");
      var overweight = window.FindControl<TextBlock>("Overweight");
      var button = window.FindControl<Button>("SubmitButton");
      button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
      double.TryParse(weight.Text,  out var parsedWeight);
      parsedWeight = 33;
      Assert.Equal("Za wysoka waga!!!!!!!",  overweight.Text);
      
   }
}