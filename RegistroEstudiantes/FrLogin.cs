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

            Form frm = new FrMenu();
            NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; Port=5432; User Id=postgres; Password = Admin; Database = estudiantesBD");
            NpgsqlCommand comm = new NpgsqlCommand("select usuario,clave from usuario where usuario='" + TxtBxUsuario.Text + "'and clave='" + TxtBxClave.Text + "'", conn);

            conn.Open();
            NpgsqlDataReader dataReader = comm.ExecuteReader();

            if (dataReader.Read())
            {
                MessageBox.Show("Acceso autorizado al sistema");
                frm.Show();

            }
            else
            {
                MessageBox.Show("Datos incorrectos");

            }

        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            Login();
        }
    }   
    
}
