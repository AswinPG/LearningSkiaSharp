using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LearningSkiaSharp.Controls
{
    public class Circle : ContentView
    {
        public Circle()
        {
            var Canvas = new SKCanvasView();
            Canvas.PaintSurface += Canvas_PaintSurface;
        }

        private void Canvas_PaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            SKSurface sKSurface = e.Surface;
            SKCanvas sKCanvas = sKSurface.Canvas;

            sKCanvas.Clear(SKColors.Red);
        }
    }
}
