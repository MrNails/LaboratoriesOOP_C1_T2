using System;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using MessageBox = System.Windows.MessageBox;
using UserControl = System.Windows.Controls.UserControl;

namespace DotNetLabs.Windows.Views.UserControls;

public partial class Lab5UserControl : UserControl
{
    private FontFamily? selectedFontFamily;
    
    public Lab5UserControl()
    {
        InitializeComponent();
    }

    private void FontSelectionButton_OnClick(object sender, RoutedEventArgs e)
    {
        var fd = new FontDialog();

        if (fd.ShowDialog() == DialogResult.OK)
        {
            var font = fd.Font;
            selectedFontFamily = new FontFamily(font.FontFamily.Name);
            SelectedFont.Text = font.FontFamily.Name;
        }
    }

    private void AddCharacterButton_OnClick(object sender, RoutedEventArgs e)
    {
        if (selectedFontFamily == null)
        {
            MessageBox.Show("Font not selected", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        if (string.IsNullOrEmpty(NewCharTextBox.Text))
        {
            MessageBox.Show("Character must exists", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        var c = new Character(NewCharTextBox.Text[0],
            new SolidColorBrush(CharacterColorPicker.SelectedColor ?? Colors.Black), 
            selectedFontFamily)
        {
            Center = new Point(Random.Shared.Next(0, (int)DrawingSurface.ActualWidth), Random.Shared.Next(0, (int)DrawingSurface.ActualHeight))
        };
        
        DrawingSurface.Children.Add(c);
    }

    private void OpenItem_OnClick(object sender, RoutedEventArgs e)
    {
        var fileManipulator = new FigureManipulationWindow
        {
            ManipulationType = FileManipulationType.Open
        };

        fileManipulator.OpenCallback += c =>
        {
            DrawingSurface.Children.Clear();
            foreach (var character in c)
            {
                DrawingSurface.Children.Add(character);   
            }
        };

        fileManipulator.ShowDialog();
    }

    private void SaveItem_OnClick(object sender, RoutedEventArgs e)
    {
        var fileManipulator = new FigureManipulationWindow
        {
            ManipulationType = FileManipulationType.Save
        };

        fileManipulator.SaveCallback += () => DrawingSurface.Children.OfType<Character>().ToList();
        fileManipulator.ShowDialog();
    }
}