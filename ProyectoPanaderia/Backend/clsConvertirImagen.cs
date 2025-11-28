using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ProyectoPanaderia.Backend
{
    public class clsConvertirImagen
    {
        public static byte[] ImagenABytes(Image imagen)
        {
            if (imagen == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public static Image BytesAImagen(byte[] bytes)
        {
            if (bytes == null) return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        //private byte[] ConvertirImg()
        //{
        //    ImageConverter img = new ImageConverter();
        //    byte[] bytes = (byte[])img.ConvertTo(new Bitmap(//Aquí va tu imagen, typeof(byte[]));
        //    return bytes;
        //}

        //private Image ByteAImagen()
        //{
        //    MemoryStream ms = new MemoryStream(//Aquí va tu imagen);
        //    Bitmap bm = null;
        //    bm = new Bitmap(ms);
        //    return bm;

        //}
    }
}
