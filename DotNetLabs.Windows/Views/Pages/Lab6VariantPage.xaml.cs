using System;
using System.Windows;
using System.Windows.Controls;

namespace DotNetLabs.Windows.Views.Pages;

public partial class Lab6VariantPage : Page
{
    public Lab6VariantPage()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        if (!double.TryParse(HeightTextBox.Text, out var height))
        {
            MessageBox.Show("Height text box have wrong value.", "Error",
                MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        if (!double.TryParse(RadiusTextBox.Text, out var radius))
        {
            MessageBox.Show("Radius text box have wrong value.", "Error",
                MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }
        
        SideSurfaceAreaRun.Text = (2 * Math.PI * radius * height).ToString();
        BarrelVolumeRun.Text = (Math.PI * Math.Pow(radius, 2) * height).ToString();
    }
}