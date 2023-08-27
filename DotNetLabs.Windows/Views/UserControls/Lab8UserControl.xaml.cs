using System.Windows;
using System.Windows.Controls;
using DotNetLabs.Windows.ViewModels;

namespace DotNetLabs.Windows.Views.UserControls;

public partial class Lab8UserControl : UserControl
{
    private bool m_isAdding;

    public Lab8UserControl()
    {
        InitializeComponent();

        DataContext = new Lab8ViewModel();
    }

    private void CreateNewStudentButton_OnClick(object sender, RoutedEventArgs e)
    {
        m_isAdding = true;

        AddButton.IsEnabled = true;
        CreateNewStudentButton.IsEnabled = false;
        UpdateButton.IsEnabled = false;
        DeleteButton.IsEnabled = false;
    }

    private void ClearSelectionButton_OnClick(object sender, RoutedEventArgs e)
    {
        m_isAdding = false;
        AddButton.IsEnabled = false;
        CreateNewStudentButton.IsEnabled = true;
        UpdateButton.IsEnabled = true;
        DeleteButton.IsEnabled = true;
    }

    private void AddButton_OnClick(object sender, RoutedEventArgs e)
    {
        m_isAdding = false;
        AddButton.IsEnabled = false;
        CreateNewStudentButton.IsEnabled = true;
        UpdateButton.IsEnabled = true;
        DeleteButton.IsEnabled = true;
    }
}