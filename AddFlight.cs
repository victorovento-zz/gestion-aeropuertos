using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Aeropuerto
{
    public partial class AddFlight : Form
    {

        string nombrevuelo = "XXX-XXX";
        public AddFlight()
        {
            InitializeComponent();
            nacional.Checked = true;
            comboBox1.Text = "Cuba";
            comboBox1.Enabled = false;
            arribo.Checked = true;

            SQLiteConnection cadenaconexion = new SQLiteConnection("Data Source = C:/AEROPUERTO/basesdedatos.db");
            cadenaconexion.Open();
            SQLiteCommand comando = new SQLiteCommand("SELECT NombreAvion FROM Aviones", cadenaconexion);
            SQLiteDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                comboBox2.Items.Add(registro["NombreAvion"].ToString());
            }
            cadenaconexion.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Botones();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Botones();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b, i, arr, cod, na;

            if (internacional.Checked == true)
            {
                i = "1";
            }
            else
            {
                i = "0";
            }

            if (arribo.Checked == true)
            {
                arr = "1";
            }
            else
            {
                arr = "0";
            }

            string km, ter, d, m, y;
            a = comboBox1.Text.ToUpper();
            b = textBox1.Text.ToUpper();
            km = textBox2.Text.ToUpper();
            ter = comboBox3.Text.ToUpper();
            d = textBox4.Text.ToUpper();
            m = textBox5.Text.ToUpper();
            y = textBox6.Text.ToUpper();
            na = comboBox2.Text.ToUpper();

            cod = label11.Text;
            string prov = comboBox4.Text;

            if (!(a.Equals("")) && (!(b.Equals(""))) && (!(km.Equals(""))) &&
                (!(i.Equals(""))) && (!(arr.Equals(""))) && (!(ter.Equals(""))) &&
                (!(d.Equals(""))) && (!(m.Equals(""))) && (!(y.Equals(""))) && (!(cod.Equals(""))) && (!(cod.Equals(""))))
            {
                
                if (internacional.Checked == true) {
                    try
                    {
                        SQLiteConnection cadenaconexion = new SQLiteConnection("Data Source = C:/AEROPUERTO/basesdedatos.db");
                        cadenaconexion.Open();
                        //string sql = "SELECT * FROM Vuelos";
                        string sql = string.Format("INSERT INTO Vuelos(NombrePais, NombreCiudad, CantKM, intern, Arribo, NumTerm, Dia, Mes, Year, NombreVuelo, Avion) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", a, b, km, i, arr, ter, d, m, y, cod, na);
                        SQLiteCommand comando = new SQLiteCommand(sql, cadenaconexion);
                        comando.ExecuteNonQuery();
                        cadenaconexion.Close();
                        MessageBox.Show("Se ha guardado correctamente");
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido el siguiente error" + error.Message);
                    }
                }
                else
                {
                    try
                    {
                        SQLiteConnection cadenaconexion = new SQLiteConnection("Data Source = C:/AEROPUERTO/basesdedatos.db");
                        cadenaconexion.Open();
                        //string sql = "SELECT * FROM Vuelos";
                        string sql = string.Format("INSERT INTO Vuelos(NombrePais, NombreCiudad, CantKM, intern, Arribo, NumTerm, Dia, Mes, Year, NombreVuelo, Avion) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", a, prov, km, i, arr, ter, d, m, y, cod, na);
                        SQLiteCommand comando = new SQLiteCommand(sql, cadenaconexion);
                        comando.ExecuteNonQuery();
                        cadenaconexion.Close();
                        MessageBox.Show("Se ha guardado correctamente");
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido el siguiente error" + error.Message);
                    }
                }
                    

                
            }
            else
            {
                DialogResult resultado = new DialogResult();
                MensajeDeError error = new MensajeDeError("Faltan datos por llenar...");
                resultado = error.ShowDialog();
            }
        }
    


        
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Botones();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.SoloLetras(e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Botones();
        }

        private void Botones()
        {
            if (internacional.Checked == true)
            {
                comboBox1.Enabled = true;
                comboBox1.Text = "México";
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox1.Text = "Cuba";
            }

            if (nacional.Checked == true)
            {
                comboBox4.Visible = true;
                textBox1.Visible = false;
            }
            else
            {
                comboBox4.Visible = false;
                textBox1.Visible = true;
            }

            if (textBox1.Text.Length >= 3)
            {
                if (internacional.Checked == true)
                {
                    comboBox1.Enabled = true;
                    //textBox3.Enabled = true;
                    if (arribo.Checked)
                    {
                        char[] arrtemp = textBox1.Text.ToCharArray();
                        nombrevuelo = arrtemp[0] + arrtemp[1] + arrtemp[2] + "-HAV";
                        label11.Text = nombrevuelo;
                    }
                    else
                    {
                        char[] arrtemp = textBox1.Text.ToCharArray();
                        nombrevuelo = "HAV-" + arrtemp[0] + arrtemp[1] + arrtemp[2];
                        label11.Text = nombrevuelo;
                    }
                }
                else
                {
                    comboBox1.Enabled = false;
                    //textBox3.Enabled = true;
                    if (arribo.Checked)
                    {
                        char[] arrtemp = comboBox4.Text.ToCharArray();
                        nombrevuelo = arrtemp[0] + arrtemp[1] + arrtemp[2] + "-HAV";
                        label11.Text = nombrevuelo;
                    }
                    else
                    {
                        char[] arrtemp = comboBox4.Text.ToCharArray();
                        nombrevuelo = "HAV-" + arrtemp[0] + arrtemp[1] + arrtemp[2];
                        label11.Text = nombrevuelo;
                    }
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.SoloNumeros(e);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 3)
            {
                if(internacional.Checked == true)
                {
                    if (arribo.Checked)
                    {
                        char[] arrtemp = textBox1.Text.ToCharArray();
                        nombrevuelo = arrtemp[0] + arrtemp[1] + arrtemp[2] + "-HAV";
                        label11.Text = nombrevuelo;
                    }
                    else
                    {
                        char[] arrtemp = textBox1.Text.ToCharArray();
                        nombrevuelo = "HAV-" + arrtemp[0] + arrtemp[1] + arrtemp[2] ;
                        label11.Text = nombrevuelo;
                    }
                }
                else
                {
                    if (arribo.Checked)
                    {
                        char[] arrtemp = textBox1.Text.ToCharArray();
                        nombrevuelo = arrtemp[0] + arrtemp[1] + arrtemp[2] + "-HAV";
                        label11.Text = nombrevuelo;
                    }
                    else
                    {
                        char[] arrtemp = textBox1.Text.ToCharArray();
                        nombrevuelo = "HAV-" + arrtemp[0] + arrtemp[1] + arrtemp[2];
                        label11.Text = nombrevuelo;
                    }
                }
            }
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoEscribir(e);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoEscribir(e);

        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoEscribir(e);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoEscribir(e);

        }
    }
}
