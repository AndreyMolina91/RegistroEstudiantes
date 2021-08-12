using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace logicadelnegocio.LibreriaCreadaAndrey
{
    public class ClaseCargarImagen
    {
        private OpenFileDialog fotocargada = new OpenFileDialog();

        public void CargarImagen(PictureBox pictureBox)
        {
            pictureBox.WaitOnLoad = true; //EStablecemos la propiedad waitonload que significa que la imagen se carga de forma sincronica
            fotocargada.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp";
            fotocargada.ShowDialog();
            if (fotocargada.FileName != string.Empty)
            {
                pictureBox.ImageLocation = fotocargada.FileName;
            }
        }

        public byte[] Convertir_Imagen_AByte(Image imagen)
        {
            var convertirimagen = new ImageConverter(); //en la variable almacenaremos los datos de nuestra imagen convertida en byte
            return (byte[])convertirimagen.ConvertTo(imagen, typeof(byte[])); //esa informacion de la imagen la retornamos y lo vamos a convertir en un array de tipo byte
            //Al convertirloo en byte lo almacenaremos en un array de tipo byte y lo retornaremos
        }

        public Image ByteArrayAImagen(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            return Image.FromStream(ms);
        }
    }
}