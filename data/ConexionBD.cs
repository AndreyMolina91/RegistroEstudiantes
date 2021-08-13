using LinqToDB; //libreria para importar Interface de tipo ITable
using LinqToDB.Data; //hacemos referencia al using de la libreria que instalamos llamada Linq2db
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql; //Using de referencia para usar las clases de conexion con postgres

namespace data
{
    public class ConexionBD : DataConnection //Clase de la libreria Linq2db
    {
         
        //Metodo que conecta a la base de datos MySql, SqlServer y Postgres segun la cadena de conexion creada en appconfig del proyecto principal RegistroEstudiantes
        public ConexionBD() : base("ANDREYBDSQLSERVER") { }

        //creamos un objeto publico de tipo Table de la libreria Linq2db 

        //La Interface nos conecta a la tablaestudiantes de la base de datos utilizando la conexion de base("ANDREYBDMYSQL")

        //La libreria linqtodb va a vincular la tabla en la base de datos llamada igual al objeto creado en ITable<>

        //Las propiedades deben tener el get para poder retornar datos siempre
        public ITable<TablaEstudiantes> _tablaestudiantes { get { return GetTable<TablaEstudiantes>(); } }

        //Ya que tenemos la conexion realizada vamos al proyecto logicadelnegocio para pasarle la informacion del servidor que la
        //obtenemos por medio del proyecto Data....
    }
    
}
