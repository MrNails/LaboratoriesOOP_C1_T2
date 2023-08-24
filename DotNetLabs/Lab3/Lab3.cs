using System.Windows;
using DotNetLabs.Windows.Views;
using DotNetLabs.Windows.Views.UserControls;
using OOP_Labs_C1_T2.Core;

namespace DotNetLabs.Lab3;

public sealed class Lab3 : IExecutable
{
    public void Execute()
    {
        var mainWindow = new MainWindow();
        mainWindow.SetUserControl(new Lab3UserControl());

        mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        mainWindow.Focus();
        mainWindow.ShowDialog();
    }
}