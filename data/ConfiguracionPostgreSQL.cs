using Npgsql;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;


namespace data
{
    public class ConfiguracionPostgreSQL 
    {
        public ConfiguracionPostgreSQL()
        {
            
        }
        //public ConfiguracionPostgreSQL(string connectionString) => ConnectionString = connectionString;

        //public string ConnectionString { get; set; }

        public bool Propiedad { get; set; }

        //Crear objetos de tipo TextBox

        private List<TextBox> listaTextBoxFrLogin;
        

        public ConfiguracionPostgreSQL(List<TextBox> textBox)
        {
            this.listaTextBoxFrLogin = textBox;
                    
        }
        public bool Login()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; Port=5432; User=postgres; Password = admin; Database = estudiantesBD");
            NpgsqlCommand comm = new NpgsqlCommand("select usuario,clave from usuario where usuario='"+listaTextBoxFrLogin[0]+"'and clave='"+listaTextBoxFrLogin[1]+"'", conn);

            conn.Open();
            NpgsqlDataReader dataReader = comm.ExecuteReader();
            
            if(dataReader.Read())
            {               
                MessageBox.Show("Acceso autorizado al sistema");                
                return true;
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
                return false;
            }

           

        }
    }
}
