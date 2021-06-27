using System.Drawing;
using System.IO;

namespace SmartRead.WinUI.Helpers
{
    public static class ImageHelper
    {
        public static Image ByteArrayToSystemDrawing(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
            ms.Write(byteArrayIn, 0, byteArrayIn.Length);
            return Image.FromStream(ms, true);
        }

        public static byte[] SystemDrawingToByteArray(Image image)
        {
            MemoryStream stream = new MemoryStream();
            image?.Save(stream, image.RawFormat);
            return stream.ToArray();
        }
    }
}
