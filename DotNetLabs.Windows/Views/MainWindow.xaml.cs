using System.Windows;
using System.Windows.Controls;

namespace DotNetLabs.Windows.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void SetUserControl(UserControl userControl)
        {
            LabsContainer.Children.Clear();
            LabsContainer.Children.Add(userControl);
        }
    }
}