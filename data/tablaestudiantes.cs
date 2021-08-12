using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping; //hacemos referencia de uso a la libreria que instalamos linq2db mapping para mapear la llave primaria de la base de datos

namespace data
{
    public class TablaEstudiantes //hacemos publica la clase tablaestudiante con la que modelaremos la base de datos
    {
        //Propiedades de la libreria Linq2db
        [PrimaryKey, Identity] //Mapeamos la llave primaria 
        //creamos propiedades publicas a la clase tablaestudiantes
        public int id { set; get; } //propiedad que modela la columna id de la tablaestudiante en la base de datos
        public string nombre { set; get; } //propiedad que modela la columna nombre de la tablaestudiante en la base de datos
        public string apellido { set; get; } //propiedad que modela la columna apellido de la tablaestudiante en la base de datos
        public string nid { set; get; } //propiedad que modela la columna nid de la tablaestudiante en la base de datos
        public string email { set; get; } //propiedad que modela la columna email de la tablaestudiante en la base de datos

        public byte[] imagen { set; get; } //propiedad de tipo array tipo byte donde vamos a almacenar la informacion de la imagen


    }
}
