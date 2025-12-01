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
        /// metodo para convertir una imagen a un arreglo de bytes
        public static byte[] ImagenABytes(Image imagen)
        {
            /// verifica si la imagen es nula
            if (imagen == null) return null;

            /// utiliza un MemoryStream para guardar la imagen en formato JPEG
            using (MemoryStream ms = new MemoryStream())
            {
                /// Se crea una copia de la imagen para evitar errores
                using (Bitmap bmp = new Bitmap(imagen)) 
                {
                    /// Guarda la imagen en el MemoryStream en formato JPEG
                    bmp.Save(ms, ImageFormat.Jpeg);
                }
                /// retorna el arreglo de bytes del MemoryStream
                return ms.ToArray();
            }
        }

        /// metodo para convertir un arreglo de bytes a una imagen
        public static Image BytesAImagen(byte[] bytes)
        {
            /// verifica si el arreglo de bytes es nulo
            if (bytes == null) return null;

            /// utiliza un MemoryStream para leer los bytes y crear la imagen
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                /// retorna la imagen creada a partir del MemoryStream
                return Image.FromStream(ms);
            }
        }
    }
}
