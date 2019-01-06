using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Media;

namespace Projekt
{
    class SaveJPG
    {
     public void ExportToJpeg(String path, InkCanvas surface)
    {
        double
                x1 = surface.Margin.Left,
                x2 = surface.Margin.Top,
                x3 = surface.Margin.Right,
                x4 = surface.Margin.Bottom;

        if (path == null) return;

        surface.Margin = new Thickness(0, 0, 0, 0);

        Size size = new Size(surface.Width, surface.Height);
        surface.Measure(size);
        surface.Arrange(new Rect(size));

        RenderTargetBitmap renderBitmap =
         new RenderTargetBitmap(
           (int)size.Width,
           (int)size.Height,
           96,
           96,
           PixelFormats.Default);
        renderBitmap.Render(surface);
        using (FileStream fs = File.Open(path, FileMode.Create))
        {
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(renderBitmap));
            encoder.Save(fs);
        }
        surface.Margin = new Thickness(x1, x2, x3, x4);
    }
}
}
