using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using DotNetLabs.Windows.Services;
using DotNetLabs.Windows.Views.UserControls;
using MessageBox = System.Windows.MessageBox;

namespace DotNetLabs.Windows.Views;

public enum FileManipulationType
{
    Open,
    Save
}

public partial class FigureManipulationWindow : Window
{
    private FileManipulationType m_manipulationType;

    public FigureManipulationWindow()
    {
        InitializeComponent();
    }

    public FileManipulationType ManipulationType
    {
        get => m_manipulationType;
        set
        {
            m_manipulationType = value;

            switch (value)
            {
                case FileManipulationType.Open:
                    FileManipulationButton.Content = "Open";
                    break;
                case FileManipulationType.Save:
                    FileManipulationButton.Content = "Save";
                    break;
            }
        }
    }

    public Func<IEnumerable<Character>>? SaveCallback { get; set; }
    public Action<IEnumerable<Character>>? OpenCallback { get; set; }

    private void PathSelectionButton_OnClick(object sender, RoutedEventArgs e)
    {
        FileDialog fileDialog = ManipulationType == FileManipulationType.Open ? new OpenFileDialog() : new SaveFileDialog();

        if (BinarySerializationRadioButton.IsChecked == true)
        {
            fileDialog.Filter = "Bin files (*.bin)|*.bin";
        } 
        else if (XMLSerializationRadioButton.IsChecked == true)
        {
            fileDialog.Filter = "XML files (*.xml)|*.xml";
        }

        if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
            SelectedPath.Text = fileDialog.FileName;
        }
    }

    private void FileManipulationButton_OnClick(object sender, RoutedEventArgs e)
    {
        ICharacterSerializer serializationService = null;
        var characters = Enumerable.Empty<Character>();

        if (BinarySerializationRadioButton.IsChecked == true)
        {
            serializationService = new BinaryCharacterSerializer { FileName = SelectedPath.Text };
        }
        else if (XMLSerializationRadioButton.IsChecked == true)
        {
            serializationService = new XMLCharacterSerializer { FileName = SelectedPath.Text };
        }

        switch (ManipulationType)
        {
            case FileManipulationType.Open:
                if (!File.Exists(SelectedPath.Text))
                {
                    MessageBox.Show($"Path {SelectedPath.Text} is not exists", 
                        "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                
                characters = serializationService.DeserializeCharacter();
                OpenCallback?.Invoke(characters);
                break;
            case FileManipulationType.Save:
                characters = SaveCallback?.Invoke() ?? Enumerable.Empty<Character>();
                serializationService.SerializeCharacter(characters);
                break;
        }

        MessageBox.Show($"Characters were {(ManipulationType == FileManipulationType.Open ? "Loaded" : "Saved")}", 
            "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        
        Close();
    }
}