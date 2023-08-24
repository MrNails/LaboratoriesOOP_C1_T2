using System.Windows;
using DotNetLabs.Windows.Views;
using DotNetLabs.Windows.Views.UserControls;
using OOP_Labs_C1_T2.Core;

namespace DotNetLabs.Lab5;

public sealed class Lab5 : IExecutable
{
    public void Execute()
    {
        var mainWindow = new MainWindow();
        mainWindow.SetUserControl(new Lab5UserControl());

        mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        mainWindow.Focus();
        mainWindow.ShowDialog();
    }
}