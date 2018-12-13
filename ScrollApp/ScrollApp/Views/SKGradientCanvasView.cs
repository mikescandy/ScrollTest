using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace ScrollApp.Views
{
    public class SKGradientCanvasView : SKCanvasView
    {


        protected override async void OnPaintSurface(SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKCanvas canvas = args.Surface.Canvas;

            canvas.Clear();

            var color1 = SKColor.Parse("#222327");

            var colors = new SKColor[] { color1.WithAlpha(0), color1.WithAlpha(153), color1.WithAlpha(180), color1.WithAlpha(255) };
            var startPoint = new SKPoint(0, info.Height / 2);
            var endPoint = new SKPoint(0, info.Height);

           

            using (var shader = SKShader.CreateLinearGradient(startPoint, endPoint, colors, new[] { 0f, .5f, .9f, 1f }, SKShaderTileMode.Clamp))
            {
                using (var paint = new SKPaint { Style = SKPaintStyle.Fill, Shader = shader })
                {
                    canvas.DrawRect(new SKRect(0, info.Height / 2, info.Width, info.Height), paint);
                }
            }
        }
    }

    public class SKCircleGradientCanvasView : SKCanvasView
    {
        protected override void OnPaintSurface(SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKCanvas canvas = args.Surface.Canvas;

            canvas.Clear();

            var colors = new SKColor[] {  SKColors.Black.WithAlpha(153), SKColors.Black.WithAlpha(0) };
            var startPoint = new SKPoint(0,0);
        

            using (var shader = SKShader.CreateRadialGradient(startPoint, args.Info.Width/2, colors, null, SKShaderTileMode.Clamp))
            {
                using (var paint = new SKPaint { Style = SKPaintStyle.Fill, Shader = shader })
                {
                    canvas.DrawRect(args.Info.Rect, paint);
                }
            }
        }
    }
}
