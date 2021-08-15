using data;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEstudiantes
{
    public partial class FrLogin : Form
    {
        public FrLogin()
        {
            InitializeComponent();
              

        }

        private void Login()
        {
            //Creamos un objeto de la clase Form al que le asignaremos el form menu
            Form frm = new FrMenu();
            //Comando de conexion mediante postgresql con la libreria npgsql
            NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; Port=5432; User Id=postgres; Password = Admin; Database = estudiantesBD");
            //Comando que ejecuta el query a la base de datos con los controles del formlogin
            NpgsqlCommand comm = new NpgsqlCommand("select usuario,clave from usuario where usuario='" + TxtBxUsuario.Text + "'and clave='" + TxtBxClave.Text + "'", conn);
            //Abrimos conexion
            conn.Open();
            //creamos un datareader de la libreria npgsql y le asignamos el comando + el metodo ejecutar reader
            NpgsqlDataReader dataReader = comm.ExecuteReader();

            //Si el datareader al que le asignamos el comando lee
            if (dataReader.Read())
            {
                //ejecuta un mensaje que indica que el acceso ha sido autorizado y abre el Form Menu mediante la variable a la que le asignamos esa clase de diseño
                MessageBox.Show("Acceso autorizado al sistema");
                frm.Show();

            }
            else
            {
                //De lo contrario enviamos este mensaje y limpiamos lo controles
                MessageBox.Show("Datos incorrectos");
                TxtBxUsuario.Clear();
                TxtBxClave.Clear();
            }

        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void TxtBxClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Login();
            }

        }
    }   
    
}
