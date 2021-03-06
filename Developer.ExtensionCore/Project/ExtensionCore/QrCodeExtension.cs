using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ExtensionCore
{
    public static class QrCodeExtension
    {
        public static string GetBase64String(string valueQrCode)
        {
            string imagemQrCode = string.Empty;

            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using QRCodeData qrCodeData = qrGenerator.CreateQrCode(valueQrCode, QRCodeGenerator.ECCLevel.Q);
                using QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    qrCodeImage.Save(memoryStream, ImageFormat.Png);
                    imagemQrCode = Convert.ToBase64String(memoryStream.ToArray());
                }
            }

            return imagemQrCode;
        }

        public static byte[] GetArray(string valueQrCode)
        {
            byte[] imagemQrCode = null;

            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using QRCodeData qrCodeData = qrGenerator.CreateQrCode(valueQrCode, QRCodeGenerator.ECCLevel.Q);
                using QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    qrCodeImage.Save(memoryStream, ImageFormat.Png);
                    imagemQrCode = memoryStream.ToArray();
                }
            }

            return imagemQrCode;
        }


    }
}
