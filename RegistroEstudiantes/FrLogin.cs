using data;
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
    public partial class FrLogin : FrMenu
    {
        public FrLogin()
        {
            InitializeComponent();
            var listaTextBox2 = new List<TextBox>(); //Lista de textbox que enviaremos por parametros a la clase ConfiguracionPostgreSQL
            listaTextBox2.Add(TxtBxUsuario);
            listaTextBox2.Add(TxtBxClave);
            

        }

       

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            ConfiguracionPostgreSQL.Login();

            if (ConfiguracionPostgreSQL.Login()) //Está almacenando informacoón como null, y necesitamos que sea True o False para ejecutar el query a la BD
            {
                Form frmDesactive = new FrLogin();
                frmDesactive.Close();                
                Form frmActive = new FrMenu();
                frmActive.Show();
            }
            else
            {
                MessageBox.Show("Algo salio mal en la conexion a la BD");
            }
                 
        }
    }
}
