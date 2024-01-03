using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System.IO;

namespace Weland
{
    public class ImageUtilities
    {
        public static Gdk.Pixbuf ImageToPixbuf(Image<Rgba32> bitmap)
        {
            using var stream = new MemoryStream();
            bitmap.SaveAsBmp(stream);
            stream.Position = 0;
            return new Gdk.Pixbuf(stream);
        }

        public static Image<Rgba32> ResizeImage(Image<Rgba32> bitmap, int width, int height)
        {
            return bitmap.Clone(x => x.Resize(width, height));
        }

        public static Image<Rgba32> RotateBitmap(Image<Rgba32> bitmap, float degrees)
        {
            return bitmap.Clone(x => x.Rotate(degrees));
        }
    }
}