using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace DotNetLabs.Windows.Views.UserControls;

public sealed class Character : FrameworkElement
{
    public static readonly DependencyProperty CharacterToDrawProperty = DependencyProperty.Register(
        nameof(CharacterToDraw), typeof(char), typeof(Character), new PropertyMetadata(' '));

    public static readonly DependencyProperty FontProperty = DependencyProperty.Register(
        nameof(Font), typeof(FontFamily), typeof(Character), new PropertyMetadata(default(FontFamily)));
    
    public static readonly DependencyProperty ColorProperty = DependencyProperty.Register(
        nameof(Color), typeof(Brush), typeof(Character), new PropertyMetadata(Brushes.White));
    
    public static readonly DependencyProperty CenterProperty = DependencyProperty.Register(
        nameof(Center), typeof(Point), typeof(Character), new PropertyMetadata(default(Point)));

    
    public Character() : this(' ', Brushes.White, new FontFamily("Times New Roman"))  {  }

    public Character(char c, Brush color, FontFamily fontFamily)
    {
        CharacterToDraw = c;
        Color = color;
        Font = fontFamily;
    }
    
    public char CharacterToDraw
    {
        get => (char)GetValue(CharacterToDrawProperty);
        set => SetValue(CharacterToDrawProperty, value);
    }

    public FontFamily Font
    {
        get => (FontFamily)GetValue(FontProperty);
        set => SetValue(FontProperty, value);
    }

    public Brush Color
    {
        get => (Brush)GetValue(ColorProperty);
        set => SetValue(ColorProperty, value);
    }
    
    public Point Center
    {
        get => (Point)GetValue(CenterProperty);
        set => SetValue(CenterProperty, value);
    }

    protected override void OnRender(DrawingContext drawingContext)
    {
        base.OnRender(drawingContext);
        Draw(drawingContext);
    }

    private void Draw(DrawingContext drawingContext)
    {
        var formattedText = new FormattedText(CharacterToDraw.ToString(), CultureInfo.InvariantCulture, FlowDirection.LeftToRight,
            new Typeface(Font, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal), 16, Color, 96);
        
        drawingContext.DrawText(formattedText, Center);
    }
}