using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace TheTalosCompanion
{
    internal class MLA
    {
        public static string DecodeQrcode(Image image)
        {
            var source = new BitmapLuminanceSource(new Bitmap(image));
            BinaryBitmap bitmap = new BinaryBitmap(new HybridBinarizer(source));
            Result result = new QRCodeReader().decode(bitmap);
            if (result != null)
            {
                return result.Text;
            }
            else
            {
                return "Could not decode qrcode!";
            }
        }

        public static string DecodeHex(string hex)
        {
            try
            {
                List<string> charList = hex.Replace(" ", "").Chunk(2).Select(x => new string(x)).ToList();
                return String.Join("", charList.Select(hex => Convert.ToChar(Convert.ToUInt32(hex, 16))));
            }
            catch
            {
                return "Invalid input";
            }
        }
    }
}
