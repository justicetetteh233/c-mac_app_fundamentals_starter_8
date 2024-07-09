using Microsoft.Maui.Graphics;
using System.Collections.Generic;

namespace starter8
{
    public class DrawingViewDrawable : IDrawable
    {
        private List<PointF> _points;

        public DrawingViewDrawable()
        {
            _points = new List<PointF>();
        }

        public void AddPoint(PointF point)
        {
            _points.Add(point);
        }

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            if (_points.Count > 1)
            {
                for (int i = 0; i < _points.Count - 1; i++)
                {
                    canvas.StrokeColor = Colors.Black;
                    canvas.StrokeSize = 2;
                    canvas.DrawLine(_points[i], _points[i + 1]);
                }
            }
        }
    }
}
