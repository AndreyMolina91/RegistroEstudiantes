using logicadelnegocio.LibreriaCreadaAndrey; //llamamos a la libreria creada en la carpeta de logicadenegocio que contiene las imagenes
//de esta manera podemos hacer que Estudiantes herede de ClaseCargarImagen
using System;
using System.Collections.Generic;
using System.Drawing; //Referencia de using para usar las propiedades Color
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToDB;
using data; //hacemos referencia al proyecto data para hacer uso de sus clases ConexionBD de la cual vamos a heredar informacion

namespace logicadelnegocio
{
    public class Estudiantes : LibreriaClases  //esta libreria contiene los objetos con los metodos y procedimientos de las clases de logicanegocio
    {
        private List<TextBox> listaTextBox;
        private List<Label> listaLabel;
        private PictureBox contenedordefoto;
        private Bitmap imagenbitmap; //inicializamos el objeto en el que vamos a capturar la imagen por defecto del picturebox
        //private LibreriaClases ObjLibreriaClases; ya no es necesario este objeto ya que estamos heredando de la clase libreriadecalses
        private DataGridView DataGridDatosEstudiantes; //objeto de la clase datagridview
        private NumericUpDown ContadorRegistrosNumUpDown; //Objeto de la clase numericupdown al que le pasaremos consulta de la base de datos y dirá cuantos registros veremos en el datagridview
        private Paginador<TablaEstudiantes> _Paginador;
        private string _accion = "insert";
        
        
        //metodo constructor de la clase que recibe un parametro tipo list, list, object
        public Estudiantes(List<TextBox> listaTextBox, List<Label> listaLabel, object[] contenedorobjetos2) 
        {
            this.listaTextBox = listaTextBox;
            this.listaLabel = listaLabel;
            contenedordefoto = (PictureBox)contenedorobjetos2[0];
            //Inicializamos el ObjetoLibreriaClases ya que no heredaremos mas de ella y en su lugar heredaremos de la clase conexion
            // ObjLibreriaClases = new LibreriaClases(); ya no necesitamos este objeto ya que heredamos de la libreriadeclases
            imagenbitmap = (Bitmap)contenedorobjetos2[1]; //le asignamos a ese objeto el contenido de formato bitmap, este contenido esta en la posicion 1 de contenedordeobjetos en form1
            DataGridDatosEstudiantes = (DataGridView)contenedorobjetos2[2];//le asignamos al objeto DataGridDatosEstudiantes de tipo datagridview la posicion 2 del contenedordeobjetos del form1
            ContadorRegistrosNumUpDown = (NumericUpDown)contenedorobjetos2[3]; //Le asignamos al nuevo objeto la posicion3 de la lista contenedorobjetos2

            Restablecercontroles(); //Ejecutamos el metodo restablecer controles creado abajo
        }
        public void Registrar()
        {
            if (listaTextBox[0].Text.Equals(""))//Si el campo de texto está vacio (TextBox posicion 2 = NID
            {
                MessageBox.Show("Nombre de Estudiante requerido");
                listaLabel[0].Text = "Nombre requerido";
                listaLabel[0].ForeColor = Color.Red;
                listaLabel[0].Focus();
            }
            else
            {

                if (listaTextBox[1].Text.Equals(""))
                {
                    MessageBox.Show("Apellido de Estudiante requerido");
                    listaLabel[1].Text = "Apellido requerido";
                    listaLabel[1].ForeColor = Color.Red;
                    listaLabel[1].Focus();
                }

                else
                {

                    if (listaTextBox[2].Text.Equals(""))
                    {
                        MessageBox.Show("Identificación de Estudiante requerido");
                        listaLabel[2].Text = "ID requerido";
                        listaLabel[2].ForeColor = Color.Red;
                        listaLabel[2].Focus();
                    }
                    else
                    {
                        if (listaTextBox[3].Text.Equals(""))
                        {
                            MessageBox.Show("Email de Estudiante requerido");
                            listaLabel[3].Text = "email requerido";
                            listaLabel[3].ForeColor = Color.Red;
                            listaLabel[3].Focus();
                        }
                        else
                        {
                            if (ObjEventosTextBox.Validacion_Email(listaTextBox[3].Text))
                            {
                                //Creamos un nuevo objeto que verificara el email si esta o no registrado en la tabla estudiante de la BD
                                //El bojeto contiene la información del objeto _tablaestudiantes el cual es una lista en conexionBD
                                //Where indica donde y en sus parentesis creamos el objeto u que contendrá la propiedad email
                                //la propiedad email que está contenida en tablaestudiantes mapeada
                                //Equals que indica si es igual a(el email escrito en el textbox de la posicion 3
                                //si el caso es que no entonces lo envia a una lista()
                                var usuario = _tablaestudiantes.Where(u => u.email.Equals(listaTextBox[3].Text)).ToList();
                                if (usuario.Count.Equals(0))//Si usuario es igual a 0 ejecuta el metodo guardardatos de abajo
                                {
                                    guardardatos();
                                    MessageBox.Show("Estudiante Registrado correctamente");
                                    DataGridDatosEstudiantes.Show();
                                }
                                else //de lo contrario, el label se pone en rojo y cambia su texto al de email ya registrado
                                {
                                    if (usuario[0].id.Equals(idEstudiante)) //Los comparamos con la variable creada en obtenerestudiante
                                    {                                        
                                        guardardatos();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ya existe un Estudiante registrado con ese email");
                                        listaLabel[3].Text = "email ya registrado";
                                        listaLabel[3].ForeColor = Color.Red;
                                        listaLabel[3].Focus();
                                    }
                                }
                            }
                            else //de lo contrario si no es valido el email (Validacion en clase eventostextbox heredada por libreriadeclases
                            //ejecuta el siguiente mensaje o procedimiento
                            {
                                
                                listaLabel[3].Text = "email no valido";
                                listaLabel[3].ForeColor = Color.Red;
                                listaLabel[3].Focus();
                            }
                        }
                    }
                }
            }

        }
        private int _num_pagina = 1, _reg_por_pagina = 3;
        public void BuscarEstudiante(string campo)
        {
            List<TablaEstudiantes> query = new List<TablaEstudiantes>();
            int inicio = (_num_pagina - 1) * _reg_por_pagina;
            if (campo.Equals(""))
            {
                query = _tablaestudiantes.ToList();
            }
            else
            {
                query = _tablaestudiantes.Where(c => c.nombre.StartsWith(campo) || c.apellido.StartsWith(campo) || c.nid.StartsWith(campo)).ToList();
            }
            if (0<query.Count )
            {
                DataGridDatosEstudiantes.DataSource = query.Select(c =>new
                {
                    c.id,
                    c.nombre,
                    c.apellido,
                    c.nid,
                    c.email,
                    c.imagen
                }).Skip(inicio).Take(_reg_por_pagina).ToList();
                DataGridDatosEstudiantes.Columns[0].Visible = false;
                DataGridDatosEstudiantes.Columns[5].Visible = false; //No mostramos la columna imagen en el datagrid
                DataGridDatosEstudiantes.Columns[3].DefaultCellStyle.BackColor = Color.WhiteSmoke;

            }
        }

        private int idEstudiante = 0;
        public void ObtenerEstudiante()
        {
            _accion = "update";
            idEstudiante = Convert.ToInt32(DataGridDatosEstudiantes.CurrentRow.Cells[0].Value);
            listaTextBox[0].Text = Convert.ToString(DataGridDatosEstudiantes.CurrentRow.Cells[1].Value);
            listaTextBox[1].Text = Convert.ToString(DataGridDatosEstudiantes.CurrentRow.Cells[2].Value);
            listaTextBox[2].Text = Convert.ToString(DataGridDatosEstudiantes.CurrentRow.Cells[3].Value);
            listaTextBox[3].Text = Convert.ToString(DataGridDatosEstudiantes.CurrentRow.Cells[4].Value);

            try
            {
                byte[] ArregloImagen = (byte[])DataGridDatosEstudiantes.CurrentRow.Cells[5].Value;
                contenedordefoto.Image = ObjCargarImagen.ByteArrayAImagen(ArregloImagen);

            }
            catch (Exception)
            {

                contenedordefoto.Image = imagenbitmap; //Mostramos imagen por defecto en el picturebox
            }
        }

        //El siguiente objeto lo usaremos en el metodo restablecer
        private List<TablaEstudiantes> listaEstudiante; //Creamos un objeto de la calse list que contendra los datos de la clase TablaEstudiantes
        public void Paginador(String metodo)
        {
            switch (metodo)
            {
                case "Primero":
                    _num_pagina = _Paginador.Primero();
                    break;
                case "Anterior":
                    _num_pagina = _Paginador.Anterior();
                    break;
                case "Siguiente":
                    _num_pagina = _Paginador.Siguiente();
                    break;
                case "Ultimo":
                    _num_pagina = _Paginador.Ultimo();
                    break;
            }
            BuscarEstudiante("");
        }

        public void Seleccionar_Paginas()
        {
            _num_pagina = 1; //Inicializamos la variable en 1 
            _reg_por_pagina = (int)ContadorRegistrosNumUpDown.Value; //Al objeto registro por pagina le asignamos el valor del control
            var listaSelPag = _tablaestudiantes.ToList(); //Creamos un objeto al que le asignamos la lista de estudiantes de la clase conexionBD
            if (0<listaSelPag.Count) //condicion si el objeto tablaestudiantes es mayor a 0 es porque esta obteniendo registros, si es asi entonces...
            {
                _Paginador = new Paginador<TablaEstudiantes>(listaEstudiante, listaLabel[4], _reg_por_pagina); //Ejecuta nuestro paginador
                BuscarEstudiante("");//Ejecutamos el metodo 

            }
        }

        public void Eliminar()
        {
            if (idEstudiante.Equals(0))
            {
                MessageBox.Show("Seleccione un Estudiante");
            }
            else
            {
                if (MessageBox.Show("¿Esta seguro de que desea eliminar este estudiante?" , "Eliminar Estudiante", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    _tablaestudiantes.Where(u => u.id.Equals(idEstudiante)).Delete();
                    MessageBox.Show("Usuario Eliminado correctamente");
                    Restablecercontroles();
                }
            }
        }

        public void Restablecercontroles()
        {
            _accion = "insert";
            _num_pagina = 1; //Para cuando ejecutemos el metodo indicarle al paginador que pase a la primera pagina
            idEstudiante = 0; //ID estudiante = 0 al ejecutar el metodo
            contenedordefoto.Image = imagenbitmap; //al contenedordefoto en la propiedad image le asignamos la imagen por defecto capturada en imagenbitmap
            listaLabel[0].Text = "Nombre";
            listaLabel[1].Text = "Apellido";
            listaLabel[2].Text = "NID";
            listaLabel[3].Text = "Email";
            listaLabel[0].ForeColor = Color.DarkGray;
            listaLabel[1].ForeColor = Color.DarkGray;
            listaLabel[2].ForeColor = Color.DarkGray;
            listaLabel[3].ForeColor = Color.DarkGray;
            listaTextBox[0].Text = "";
            listaTextBox[1].Text = "";
            listaTextBox[2].Text = "";
            listaTextBox[3].Text = "";
            listaEstudiante = _tablaestudiantes.ToList(); //Al objeto creado le vamos a asignar la informacion de la coleccion de datos de la clase tablaestudiantes
            //Creamos un procedimiento que verificará si el objeto listaestudiantes contiene datos
            if (0 < listaEstudiante.Count) //si contiene datos entonces...
            {
                _Paginador = new Paginador<TablaEstudiantes>(listaEstudiante, listaLabel[4], _reg_por_pagina); //los parametros deben ser iguales a los creados en la clase paginador
                //al objeto paginador le asignamos
                //los datos de la
                //clase paginador y en parametros
                //la listaEstudiantes,
                //la label de la posicion 4 que
                //es la que indica num de paginas
                //y el registro de paginas que indicará
                //el numero de pagina en la que nos
                //encontramos
            }
            BuscarEstudiante("");

        }

        private void guardardatos()
        {
                //Creamos un try catch para gestionar el registro de datos en la base de datos y sus excepciones
                BeginTransactionAsync();//Administrador de registros de datos a la base de datos
                try
                {

                    var ImagenArray = ObjCargarImagen.Convertir_Imagen_AByte(contenedordefoto.Image);
                switch (_accion) //La variable accion fue inicializada con el texto de actualizar y insertar
                {
                    case "insert":
                        //Vamos a crear una instancia de la clase Conexion para insertar datos a la tabla
                        //var bd = new ConexionBD();
                        //bd.Insert(new TablaEstudiantes //metodo insert en clase tablaestudiantes, propiedades asignamos los textbox
                        //{
                        //    nombre = listaTextBox[0].Text, //a la propiedad nombre de tablaestudiantes le asignamos el texto del textbox en la posicion 0 de a lista = textboxnombre
                        //    apellido = listaTextBox[1].Text,
                        //    nid = listaTextBox[2].Text,
                        //    email = listaTextBox[3].Text

                        //});

                        //El metodo anterior que ha sido comentado funciona perfectamente para insertar datos a la BD

                        //Nuevo metodo con el objeto de ConexionBD llamado _tablaestudiantes 
                        //del cual llamaremos las propiedades que mapeamos en la clase tablaestudiantes 
                        // acceederemos a esas propiedades mediante el parametro objeto al cual llamaremos e
                        //con este objeto tendremos acceso a las propiedades mapeadas en tablaestudiantes
                        
                        _tablaestudiantes.Value(e => e.nombre, listaTextBox[0].Text)
                                .Value(e => e.apellido, listaTextBox[1].Text)
                                .Value(e => e.nid, listaTextBox[2].Text)
                                .Value(e => e.email, listaTextBox[3].Text)
                                .Value(e => e.imagen, ImagenArray)
                                .Insert();

                        break;
                    case "update": //Procedimiento en el switch case que nos permite actualizar los registros de estudiantes en la base de datos
                        if (MessageBox.Show("¿Esta seguro de que desea modificar este estudiante?", "Modificar Estudiante", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                        {  
                            MessageBox.Show("Estudiante Modificado correctamente");
                            _tablaestudiantes.Where(u => u.id.Equals(idEstudiante))
                                   .Set(u => u.nombre, listaTextBox[0].Text)
                                   .Set(u => u.apellido, listaTextBox[1].Text)
                                   .Set(u => u.nid, listaTextBox[2].Text)
                                   .Set(u => u.email, listaTextBox[3].Text)
                                   .Set(u => u.imagen, ImagenArray)
                                   .Update();
                        }
                        break;
                }
                    CommitTransaction(); //Con este Commit podemos informarle al BegintransactionAsync() que el procedimiento es correcto y se pueden insertar datos en la DB
                Restablecercontroles();
                }
                catch (Exception)
                {
                    RollbackTransaction(); //Metodo que indica que se ha generado una excepcion y no inserta la informacion en la base de datos
                }
            }
        }
    }
