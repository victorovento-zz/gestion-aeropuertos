using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aeropuerto
{
    public partial class FlightList : Form
    {

        SQLiteConnection cadenaconexion = BaseDatos.ConectarBD();

        public FlightList()
        {
            InitializeComponent();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.SoloNumeros(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.SoloNumeros(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.SoloNumeros(e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            LlenarTabla();
        }

        private void LlenarTabla()
        {

            string d = textBox4.Text.ToUpper();
            string m = textBox5.Text.ToUpper();
            string y = textBox6.Text.ToUpper();

            if (d.Equals("1") || d.Equals("2") || d.Equals("3") || d.Equals("4") ||
                d.Equals("5") || d.Equals("6") || d.Equals("7") || d.Equals("8") || d.Equals("9"))
            {
                d = "0" + d;
            }
            if (m.Equals("1") || m.Equals("2") || m.Equals("3") || m.Equals("4") ||
                m.Equals("5") || m.Equals("6") || m.Equals("7") || m.Equals("8") || m.Equals("9"))
            {
                m = "0" + m;
            }

            string fecha = y + "/" + m + "/" + d;

            if (!textBox4.Text.Equals("") && !textBox5.Text.Equals("") && !textBox6.Text.Equals(""))
            {
                if ((((Int32.Parse(m) == 1) || (Int32.Parse(m) == 3 || (Int32.Parse(m) == 5) || (Int32.Parse(m) == 7) || (Int32.Parse(m) == 8)
                    || (Int32.Parse(m) == 10) || (Int32.Parse(m) == 12))) && (Int32.Parse(d) <= 31)) ||
                    (((Int32.Parse(m) == 4) || (Int32.Parse(m) == 6) || (Int32.Parse(m) == 9) || (Int32.Parse(m) == 11)) && (Int32.Parse(d) <= 30))
                    || ((Int32.Parse(m) == 2) && (Int32.Parse(d) <= 28)) || ((Int32.Parse(m) == 2) && (Int32.Parse(d) <= 29) && ((Int32.Parse(y) == 2000) ||
                    (Int32.Parse(y) == 2004) || (Int32.Parse(y) == 2008) || (Int32.Parse(y) == 2012) || (Int32.Parse(y) == 2016) ||
                    (Int32.Parse(y) == 2020))))
                {
                    if (Int32.Parse(m) <= 12 && Int32.Parse(m) >= 1)
                    {


                        if (Int32.Parse(y) <= 2020 && Int32.Parse(y) >= 2000)
                        {
                            Vuelo.ObtenerVuelosTerminal(dataGridView1, cadenaconexion, comboBox3,y,m,d);
                        }
                    }
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            LlenarTabla();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            LlenarTabla();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarTabla();

        }

        private void terminalRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void preciosRB_CheckedChanged(object sender, EventArgs e)
        {
            if (preciosRB.Checked)
            {
                panelPrecios.Visible = true;
                panelTerminal.Visible = false;

                Vuelo.ordenarPrecios(cadenaconexion, listBox1);

            }
            else
            {
                panelPrecios.Visible = false;
                panelTerminal.Visible = true;
            }
        }

        private void panelPrecios_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
