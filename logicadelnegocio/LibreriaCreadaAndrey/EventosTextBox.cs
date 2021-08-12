using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //Using para validacion de emailaddress
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logicadelnegocio.LibreriaCreadaAndrey
{
    public class EventosTextBox
    {
        public void Validacion_Textbox_SoloTexto(KeyPressEventArgs e)
        {
            //A continuacion pondremos una serie de validaciones para utilizar en los textbox
            //Condicion que solo nos permmite ingresar datos de tipo texto 
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }//Condicion que no permite dar saltos de linea al presionar la tecla enter
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            //Condicion que nos permite utilizar la tecla borrar o backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //condicion que nos permite utilizar la tecla espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }

        public void Validacion_Textbox_SoloNumeros(KeyPressEventArgs e)
        {
            //A continuacion pondremos una serie de validaciones para utilizar en los textbox
            //Condicion que solo nos permmite ingresar datos de tipo texto 
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }//Condicion que no permite dar saltos de linea al presionar la tecla enter
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            //Condicion que nos permite utilizar la tecla borrar o backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //condicion que nos permite utilizar la tecla espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = true; }
            else { e.Handled = true; }
        }

        public bool Validacion_Email(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }
    }
}
