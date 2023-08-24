using System.Windows;
using System.Windows.Media;

namespace DotNetLabs.Windows.Views.UserControls;

public class Smile : FrameworkElement
{
    public static readonly DependencyProperty EyeRadiusProperty = DependencyProperty.Register(
        nameof(EyeRadius), typeof(double), typeof(Smile), new PropertyMetadata(default(double)));

    public static readonly DependencyProperty FaceRadiusProperty = DependencyProperty.Register(
        nameof(FaceRadius), typeof(double), typeof(Smile), new PropertyMetadata(default(double)));

    public static readonly DependencyProperty CenterProperty = DependencyProperty.Register(
        nameof(Center), typeof(Point), typeof(Smile), new PropertyMetadata(default(Point)));

    private readonly Pen m_pen;
    
    public Smile() : this(2, 10)  { }

    public Smile(double eyeRadius, double faceRadius)
    {
        EyeRadius = eyeRadius;
        FaceRadius = faceRadius;
        m_pen = new Pen(Brushes.Black, 1);
    }
    
    public double EyeRadius
    {
        get => (double)GetValue(EyeRadiusProperty);
        set => SetValue(EyeRadiusProperty, value);
    }

    public double FaceRadius
    {
        get => (double)GetValue(FaceRadiusProperty);
        set => SetValue(FaceRadiusProperty, value);
    }

    public Point Center
    {
        get => (Point)GetValue(CenterProperty);
        set => SetValue(CenterProperty, value);
    }

    protected override void OnRender(DrawingContext drawingContext)
    {
        base.OnRender(drawingContext);
        
        drawingContext.DrawEllipse(Brushes.White, m_pen, Center, FaceRadius, FaceRadius);
        drawingContext.DrawEllipse(Brushes.White, m_pen, new Point(Center.X - FaceRadius / 3, Center.Y - FaceRadius / 4 * 2), EyeRadius, EyeRadius);
        drawingContext.DrawEllipse(Brushes.White, m_pen, new Point(Center.X + FaceRadius / 3, Center.Y - FaceRadius / 4 * 2), EyeRadius, EyeRadius);
        
        drawingContext.DrawLine(m_pen, 
            new Point(Center.X - FaceRadius * 0.6, Center.Y + FaceRadius * 0.25), 
            new Point(Center.X - FaceRadius * 0.3, Center.Y + FaceRadius * 0.45));
        
        drawingContext.DrawLine(m_pen, 
            new Point(Center.X - FaceRadius * 0.3, Center.Y + FaceRadius * 0.45), 
            new Point(Center.X + FaceRadius * 0.3, Center.Y + FaceRadius * 0.45));
        
        drawingContext.DrawLine(m_pen, 
            new Point(Center.X + FaceRadius * 0.3, Center.Y + FaceRadius * 0.45), 
            new Point(Center.X + FaceRadius * 0.6, Center.Y + FaceRadius * 0.25));

    }
}