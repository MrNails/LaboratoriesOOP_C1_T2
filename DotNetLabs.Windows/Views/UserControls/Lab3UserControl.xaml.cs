using System.Windows;
using System.Windows.Controls;

namespace DotNetLabs.Windows.Views.UserControls;

public partial class Lab3UserControl : UserControl
{
    private Point m_offset;
    private double m_eyeRadius;
    private double m_faceRadius;
    
    public Lab3UserControl()
    {
        InitializeComponent();

        m_offset = new Point();
        m_eyeRadius = 1.5;
        m_faceRadius = 10;
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        DrawSurface.Children.Add(new Smile
        {
            Center = m_offset,
            EyeRadius = m_eyeRadius += 1,
            FaceRadius = m_faceRadius += 5 
        });

        m_offset = new Point(m_offset.X + 20, m_offset.Y + 8);
    }
}