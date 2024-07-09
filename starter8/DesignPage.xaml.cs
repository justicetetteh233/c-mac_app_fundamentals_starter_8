namespace starter8;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System.Collections.Generic;

public partial class DesignPage : ContentPage
{
    private DrawingViewDrawable _drawable;
    private bool _isDrawing;

    public DesignPage()
    {
        InitializeComponent();
        _drawable = new DrawingViewDrawable();
        drawingView.Drawable = _drawable;
    }

    private void OnDrawingViewStartInteraction(object sender, TouchEventArgs e)
    {
        _isDrawing = true;
        _drawable.AddPoint(e.Touches[0]);
        drawingView.Invalidate();
    }

    private void OnDrawingViewDragInteraction(object sender, TouchEventArgs e)
    {
        if (_isDrawing)
        {
            _drawable.AddPoint(e.Touches[0]);
            drawingView.Invalidate();
        }
    }

    private void OnDrawingViewEndInteraction(object sender, TouchEventArgs e)
    {
        _isDrawing = false;
    }
}
