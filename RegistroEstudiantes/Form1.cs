using data;
using logicadelnegocio; //using para poder hacer referencia o crear objetos de la subclase Estudiante dentro de la clase logicadenegocio
using logicadelnegocio.LibreriaCreadaAndrey; //using para poder crear objetos de la libreriadeclases
using System;
using System.Collections.Generic;
using System.ComponentModel;
using LinqToDB;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToDB.Common;
using FluentAssertions.Common;

namespace RegistroEstudiantes
{
    public partial class Form1 : Form
    {
        //Despues de haber creado la referencia dentro de RegistroEstudiantes de = Logicadelnegocio
        //creamos un objeto de la clase RegistroEstudiantes

        private Estudiantes estudiante; //Hacemos uso de todos los metodos y datos en la clase  Estudiante incluyendo las herencias de Libreria de clases
        //private LibreriaClases ObjLibreriaClases;
        public Form1()
        {
                       

            //METODO CONSTRUCTOR FORM1
            InitializeComponent();           

            GridViewEstudiantes.Hide();
            TextBoxBuscar.Hide();
            label2.Hide();
            ButtonPrimerPag.Hide();
            buttonSigPagina.Hide();
            buttonAntPagina.Hide();
            buttonUltPagina.Hide();
            //ObjLibreriaClases = new LibreriaClases();
            //variable que contendra un list de los textbox
            var listaTextBox = new List<TextBox>();
            listaTextBox.Add(TextBoxNombre);
            listaTextBox.Add(TextBoxApellido);
            listaTextBox.Add(TextBoxNID);
            listaTextBox.Add(TextBoxEmail);
            var listaLabel = new List<Label>();
            listaLabel.Add(Labelnombre);
            listaLabel.Add(Labelapellido);
            listaLabel.Add(Labelnid);
            listaLabel.Add(Labelemail);
            listaLabel.Add(labelNumPagina);
            //Creamos un array de tipo Object para almacenar la inormacion del picturebox de la imagen de estudiantes
            Object[] contenedorObjetos = {
                pictureBoxFotoEstudiante,
                Properties.Resources.logoestudiante, //buscarestudiante es la imagen guardada en la carpeta Resources de la clase RegistroEstudiantes
                GridViewEstudiantes, //A la coleccion de objetos contenedorimagenestudiante le agregamos un objeto mas, el gridview del form1            
                numericUpDown1//Agregamos al contenedor el objeto numericupdonw
            };//Ahora el objeto lo enviamos como parametro al constructor estudiante de la clase Estudiantes

            //el objeto estudiante que inicializamos arriba como privado, le vamos a pasar los parametro que requiera para construir
            estudiante = new Estudiantes(listaTextBox, listaLabel, contenedorObjetos); //ahora debemos crear un metodo constructor a la clase estudiante que reciba ese parametro

        }

        private void pictureBoxFotoEstudiante_Click(object sender, EventArgs e)
        {
           
        }

        private void TextBoxNombre_TextChanged(object sender, EventArgs e)
        {
            Labelnombre.Text = "Nombre";

            if (TextBoxNombre.Text.Equals(""))
            {
                Labelnombre.ForeColor = Color.Gray;               
            }
            else
            {
                Labelnombre.ForeColor = Color.Navy;
            }
        }

        private void TextBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.ObjEventosTextBox.Validacion_Textbox_SoloTexto(e);
            
        }

        private void TextBoxApellido_TextChanged(object sender, EventArgs e)
        {
            Labelapellido.Text = "Apellido";
            if (TextBoxApellido.Text.Equals(""))
            {
                Labelapellido.ForeColor = Color.Gray;
                Labelapellido.Text = "Apellido";
            }
            else
            {
                Labelapellido.ForeColor = Color.Navy;
            }
        }

        private void TextBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.ObjEventosTextBox.Validacion_Textbox_SoloTexto(e);
        }

        private void TextBoxNID_TextChanged(object sender, EventArgs e)
        {
            Labelnid.Text = "NID";
            if (TextBoxNID.Text.Equals(""))
            {
                Labelnid.ForeColor = Color.Gray;
                Labelnid.Text = "NID";
            }
            else
            {
                Labelnid.ForeColor = Color.Navy;
            }
        }

        private void TextBoxNID_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.ObjEventosTextBox.Validacion_Textbox_SoloNumeros(e);
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            Labelemail.Text = "Email";
            if (TextBoxEmail.Text.Equals(""))
            {
                Labelemail.ForeColor = Color.Gray;
                Labelemail.Text = "Email";
            }
            else
            {
                Labelemail.ForeColor = Color.Navy;
            }
        }

        private void TextBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            estudiante.Registrar(); //Agregamos referencia data e instalamos el paquete de datosde linq2db en la clase Form1 para hacer uso de sus procedimientos con conexion a la base de datos
        }

        private void buttonFotoEstudiante_Click(object sender, EventArgs e)
        {
            //llamamos el objeto inicializaado con la clase Estudiantes, objeto cargar imagen creado en la clase libreriadeclases y usamos el metodo cargaimagen de la clase cargarimagen
            estudiante.ObjCargarImagen.CargarImagen(pictureBoxFotoEstudiante); //con el objeto estudiante de la sub clase Estudiantes llamamos al metodo
            //cargarimagen, dentro de los parametros ponemos el control pictureboxfotoestudiante que esta en el diseñador
            //ahora en el evento click del pictureboxestudiante al hacerle click podemos cargar una imagen desde el ordenador o pc
            
        }

        private void TextBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            GridViewEstudiantes.Show();
            estudiante.BuscarEstudiante(TextBoxBuscar.Text);
        }

        private void ButtonPrimerPag_Click(object sender, EventArgs e)
        {
            estudiante.Paginador("Primero");
        }

        private void buttonAntPagina_Click(object sender, EventArgs e)
        {
            estudiante.Paginador("Anterior");
        }

        private void buttonSigPagina_Click(object sender, EventArgs e)
        {
            estudiante.Paginador("Siguiente");
        }

        private void buttonUltPagina_Click(object sender, EventArgs e)
        {
            estudiante.Paginador("Ultimo");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ButtonPrimerPag.Show();
            buttonSigPagina.Show();
            buttonAntPagina.Show();
            buttonUltPagina.Show();
            GridViewEstudiantes.Show();
            estudiante.Seleccionar_Paginas();
            
        }

        private void GridViewEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewEstudiantes.Rows.Count != 0)
            {
                estudiante.ObtenerEstudiante();
            }
        }

        private void GridViewEstudiantes_KeyUp(object sender, KeyEventArgs e)
        {
            if (GridViewEstudiantes.Rows.Count != 0)
                estudiante.ObtenerEstudiante();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            estudiante.Eliminar();
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            estudiante.Restablecercontroles();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Show();
            TextBoxBuscar.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label2.Show();
            TextBoxBuscar.Show();
            ButtonPrimerPag.Show();
            buttonSigPagina.Show();
            buttonAntPagina.Show();
            buttonUltPagina.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Show();
            TextBoxBuscar.Show();
            GridViewEstudiantes.Show();
            ButtonPrimerPag.Show();
            buttonSigPagina.Show();
            buttonAntPagina.Show();
            buttonUltPagina.Show();
        }
    }
}
