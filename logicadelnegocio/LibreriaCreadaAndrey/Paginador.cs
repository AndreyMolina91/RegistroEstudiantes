using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //importamos este using para usar los controles Label, etc

namespace logicadelnegocio.LibreriaCreadaAndrey
{
    public class Paginador<T> //Asignamos la clase de forma publica y la hacemos generica <T>
    {
        private List<T> _dataList; //Objeto de clase list
        private Label _label; //objeto de clase Label
        private static int maxReg, _reg_por_pagina, pageCount, numPag = 1;

        //Metodo constructor con objetos como parametros 

        public Paginador(List<T> dataList, Label label, int reg_por_pagina) //Parametros que recibirá la clase paginador
        {
            _dataList = dataList;
            _label = label;
            _reg_por_pagina = reg_por_pagina;
            CargarDatos();
        }

        private void CargarDatos()
        {
            numPag = 1;
            maxReg = _dataList.Count;
            pageCount = (maxReg / _reg_por_pagina);

            if ((maxReg % _reg_por_pagina)>0)
            {
                pageCount += 1;
            }
            _label.Text = $"Página {pageCount}";
        }
        public int Primero()
        {
            numPag = 1;
            _label.Text = $"Página {numPag}/{pageCount}";
            return numPag;
        }
        public int Anterior()
        {
            if (numPag > 1)
            {
                numPag -= 1;
                _label.Text = $"Página {numPag}/{pageCount}";
            }
            return numPag;
        }

        public int Siguiente()
        {
            if (numPag == pageCount)
            
                numPag -= 1;
            if (numPag < pageCount)
            {
                numPag += 1;
                _label.Text = $"Página {numPag}/{pageCount}";
            }
            return numPag;
        }

        public int Ultimo()
        {
            numPag = pageCount;
            _label.Text = $"Página {numPag}/{pageCount}";
            return numPag;
        }



    }
}
