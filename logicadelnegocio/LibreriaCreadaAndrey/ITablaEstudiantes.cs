using data; //immport para tener acceso a la clase con el modelado de tablaestudiantes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicadelnegocio.LibreriaCreadaAndrey
{
    public interface ITablaEstudiantes //Sin implementar
    {
        ////Acá creamos los metodos que vamos a usar para
        ////Obtener datos de estudiantes, modificarlos y/o eliminarlos
        ////metodos que conectarán con Postgres

        //Task<IEnumerable<TablaEstudiantes>> GetTablaEstudiantes(); //Interfaz que me devolverá todos los estudiantes
        
        ////Metodos tipo task que devolverán solo 1 elemento
        //Task<TablaEstudiantes> Getid(int id);

        //Task<bool> InsertarEstudiante(TablaEstudiantes estudiante);

        //Task<bool> UpdateEstudiante(TablaEstudiantes estudiante);

        //Task<bool> DeleteEstudiante(TablaEstudiantes estudiante);

    }
}
