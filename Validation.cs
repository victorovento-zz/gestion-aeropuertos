using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aeropuerto
{
    class Validation
    {
        public static void SoloLetras(KeyPressEventArgs V)
        {
            if (Char.IsLetter(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                
            V.Handled = true;
            // DialogResult resultado = new DialogResult();
            // MensajeDeError error = new MensajeDeError("Entre solo letras");

            //resultado = error.ShowDialog();
                
                
            }
        }

        public static void SoloNumeros(KeyPressEventArgs V)
        {
            if (Char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
           //DialogResult resultado = new DialogResult();
           //   MensajeDeError error = new MensajeDeError("Entre solo números");

           //  resultado = error.ShowDialog();
            }
        }

        public static void SoloDoubles(KeyPressEventArgs V)
        {
            if (Char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (V.KeyChar.ToString().Equals("."))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
          //   DialogResult resultado = new DialogResult();
          //    MensajeDeError error = new MensajeDeError("Entre solo números");

          //resultado = error.ShowDialog();
            }
        }

        public static void NoEscribir(KeyPressEventArgs V)
        {
            if (Char.IsDigit(V.KeyChar))
            {
                V.Handled = true;
            }
            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = true;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = true;
            }
            else if (V.KeyChar.ToString().Equals("."))
            {
                V.Handled = true;
            }
            else
            {
                V.Handled = true;
                //   DialogResult resultado = new DialogResult();
                //    MensajeDeError error = new MensajeDeError("Entre solo números");

                //resultado = error.ShowDialog();
            }
        }


    }
}
    

