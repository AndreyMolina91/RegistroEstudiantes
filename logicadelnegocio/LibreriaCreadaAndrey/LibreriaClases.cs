using data; //agregamos el using data para poder heredar de la clase conexionBD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicadelnegocio.LibreriaCreadaAndrey
{
    public class LibreriaClases : ConexionBD //Heredaremos de la clase Conexion para luego heredar en clase estudiantes libreria y conexion
    {
        //Como no podemos heredar de varias clases hemos creado esta clase llamada libreria de clases
        //en esta libreria creamos objetos de las clases ubicadas en la carpeta libreriacreadaandrey
        //al crear estos objetos podemos hacer uso de sus metodos, subclases etc
        //con estos objetos podremos heredar en la clase Estudiantes o Form1 los metodos creados en las clases para
        //generar validaciones, procedimientos, carga de datos, etc.
        public ClaseCargarImagen ObjCargarImagen = new ClaseCargarImagen();
        public EventosTextBox ObjEventosTextBox = new EventosTextBox();
        
    }
}
