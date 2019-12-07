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
        public AddFlight()
        {
            InitializeComponent();
            nacional.Checked = true;
            comboBox1.Text = "Cuba";
            comboBox1.Enabled = false;
            arribo.Checked = true;

            SQLiteConnection cadenaconexion = new SQLiteConnection("Data Source = C:/AEROPUERTO/basesdedatos.db");
            cadenaconexion.Open();
            SQLiteCommand comando = new SQLiteCommand("SELECT NumeroMatricula FROM Aviones", cadenaconexion);
            SQLiteDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                comboBox2.Items.Add(registro["NumeroMatricula"].ToString());
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
            string pais, Ciudad, isInternacional, isArribo, cod, na;

            if (internacional.Checked == true)
            {
                isInternacional = "1";
            }
            else
            {
                isInternacional = "0";
            }

            if (arribo.Checked == true)
            {
                isArribo = "1";
            }
            else
            {
                isArribo = "0";
            }

            string km, numeroTerminal, d, m, y;
            pais = comboBox1.Text.ToUpper(); 
            Ciudad = textBox1.Text.ToUpper();
            km = textBox2.Text.ToUpper();
            numeroTerminal = comboBox3.Text.ToUpper();
            d = textBox4.Text.ToUpper();
            m = textBox5.Text.ToUpper();
            y = textBox6.Text.ToUpper();
            na = comboBox2.Text.ToUpper();

            if(d.Equals("1") && d.Equals("2") && d.Equals("3") && d.Equals("4") &&
                d.Equals("5") && d.Equals("6") && d.Equals("7") && d.Equals("8") && d.Equals("9"))
            {
                d = "0" + d;
            }
            if (m.Equals("1") && m.Equals("2") && m.Equals("3") && m.Equals("4") &&
                m.Equals("5") && m.Equals("6") && m.Equals("7") && m.Equals("8") && m.Equals("9"))
            {
                m = "0" + m;
            }

            string fecha = textBox6.Text.ToString() + "/" + textBox5.Text.ToString() + "/" + textBox4.Text.ToString() + " " + domainUpDown1.Text + ":" +domainUpDown2.Text;
            cod = label11.Text;
            string prov = comboBox4.Text;

            if ((((Int32.Parse(m) == 1) || (Int32.Parse(m) == 3 || (Int32.Parse(m) == 5) || (Int32.Parse(m) == 7) || (Int32.Parse(m) == 8)
                || (Int32.Parse(m) == 10) || (Int32.Parse(m) == 12))) && (Int32.Parse(d) <= 31)) ||
                (((Int32.Parse(m) == 4) || (Int32.Parse(m) == 6) || (Int32.Parse(m) == 9) || (Int32.Parse(m) == 11)) && (Int32.Parse(d) <= 30))
                ||((Int32.Parse(m) == 2)&& (Int32.Parse(d) <= 28))|| ((Int32.Parse(m) == 2) && (Int32.Parse(d) <= 29)&&((Int32.Parse(y)==2000)||
                (Int32.Parse(y) == 2004)|| (Int32.Parse(y) == 2008) || (Int32.Parse(y) == 2012) || (Int32.Parse(y) == 2016) || 
                (Int32.Parse(y) == 2020))))
            {


                if (Int32.Parse(m) <= 12 && Int32.Parse(m) >= 1)
                {


                    if (Int32.Parse(y) <= 2020 && Int32.Parse(y) >= 2000)
                    {


                        if (!(pais.Equals("")) && (!(km.Equals(""))) &&
                            (!(isInternacional.Equals(""))) && (!(isArribo.Equals(""))) && (!(numeroTerminal.Equals(""))) &&
                            (!(d.Equals(""))) && (!(m.Equals(""))) && (!(y.Equals(""))) && (!(cod.Equals(""))) && (!(cod.Equals(""))))
                        {


                            if (internacional.Checked == true && (!(Ciudad.Equals(""))))
                            {
                                try
                                {
                                    SQLiteConnection cadenaconexion = new SQLiteConnection("Data Source = C:/AEROPUERTO/basesdedatos.db");
                                    cadenaconexion.Open();
                                    //string sql = "SELECT * FROM Vuelos";
                                    string sql = string.Format("INSERT INTO Vuelos Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", isInternacional, isArribo,
                                        fecha, numeroTerminal, pais, Ciudad, km, "0", comboBox2.Text.ToString());
                                    SQLiteCommand comando = new SQLiteCommand(sql, cadenaconexion);
                                    comando.ExecuteNonQuery();
                                    cadenaconexion.Close();
                                    MessageBox.Show("Se ha guardado correctamente");
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    textBox4.Text = "";
                                    textBox5.Text = "";
                                    textBox6.Text = "";
                                    
                                    cadenaconexion.Open();
                                    SQLiteDataReader registro = comando.ExecuteReader();

                                    while (registro.Read())
                                    {
                                        comboBox2.Items.Add(registro["NumeroMatricula"].ToString());
                                    }
                                    cadenaconexion.Close();
                                }
                                catch (Exception)
                                {
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    textBox4.Text = "";
                                    textBox5.Text = "";
                                    textBox6.Text = "";
                                }
                            }
                            if (internacional.Checked == false)
                            {
                                try
                                {
                                    SQLiteConnection cadenaconexion = new SQLiteConnection("Data Source = C:/AEROPUERTO/basesdedatos.db");
                                    cadenaconexion.Open();
                                    //string sql = "SELECT * FROM Vuelos";
                                    string sql = string.Format("INSERT INTO Vuelos Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", isInternacional, isArribo,
                                        fecha, numeroTerminal, "Cuba", prov, km, "0", comboBox2.Text.ToString());
                                    SQLiteCommand comando = new SQLiteCommand(sql, cadenaconexion);
                                    comando.ExecuteNonQuery();
                                    cadenaconexion.Close();
                                    MessageBox.Show("Se ha guardado correctamente");
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    textBox4.Text = "";
                                    textBox5.Text = "";
                                    textBox6.Text = "";
                                    
                                    cadenaconexion.Open();
                                    SQLiteDataReader registro = comando.ExecuteReader();

                                    while (registro.Read())
                                    {
                                        comboBox2.Items.Add(registro["NumeroMatricula"].ToString());
                                    }
                                    cadenaconexion.Close();
                                }
                                catch (Exception)
                                {
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    textBox4.Text = "";
                                    textBox5.Text = "";
                                    textBox6.Text = "";
                                  
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
                    else
                    {
                        DialogResult resultado = new DialogResult();
                        MensajeDeError error = new MensajeDeError("El año debe ser entre 2000 y 2020");
                        resultado = error.ShowDialog();
                    }
                }
                else
                {
                    DialogResult resultado = new DialogResult();
                    MensajeDeError error = new MensajeDeError(m + " no es un mes...");
                    resultado = error.ShowDialog();
                }
            }
            else
            {
                DialogResult resultado = new DialogResult();
                MensajeDeError error = new MensajeDeError("Compruebe el dia");
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
                    //if (arribo.Checked)
                    //{
                    //    char[] arrtemp = textBox1.Text.ToCharArray();
                    //    nombrevuelo = arrtemp[0] + arrtemp[1] + arrtemp[2] + "-HAV";
                    //    label11.Text = nombrevuelo;
                    //}
                    //else
                    //{
                    //    char[] arrtemp = textBox1.Text.ToCharArray();
                    //    nombrevuelo = "HAV-" + arrtemp[0] + arrtemp[1] + arrtemp[2];
                    //    label11.Text = nombrevuelo;
                    //}
                }
                else
                {
                    comboBox1.Enabled = false;
                    //textBox3.Enabled = true;
                    //if (arribo.Checked)
                    //{
                    //    char[] arrtemp = comboBox4.Text.ToCharArray();
                    //    nombrevuelo = arrtemp[0] + arrtemp[1] + arrtemp[2] + "-HAV";
                    //    label11.Text = nombrevuelo;
                    //}
                    //else
                    //{
                    //    char[] arrtemp = comboBox4.Text.ToCharArray();
                    //    nombrevuelo = "HAV-" + arrtemp[0] + arrtemp[1] + arrtemp[2];
                    //    label11.Text = nombrevuelo;
                    //}
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
           //if (textBox1.Text.Length >= 3)
            //{
            //    if(internacional.Checked == true)
            //    {
            //        if (arribo.Checked)
            //        {
            //            char[] arrtemp = textBox1.Text.ToCharArray();
            //            nombrevuelo = arrtemp[0] + arrtemp[1] + arrtemp[2] + "-HAV";
            //            label11.Text = nombrevuelo;
            //        }
            //        else
            //        {
            //            char[] arrtemp = textBox1.Text.ToCharArray();
            //            nombrevuelo = "HAV-" + arrtemp[0] + arrtemp[1] + arrtemp[2] ;
            //            label11.Text = nombrevuelo;
            //        }
            //    }
            //    else
            //    {
            //        if (arribo.Checked)
            //        {
            //            char[] arrtemp = textBox1.Text.ToCharArray();
            //            nombrevuelo = arrtemp[0] + arrtemp[1] + arrtemp[2] + "-HAV";
            //            label11.Text = nombrevuelo;
            //        }
            //        else
            //        {
            //            char[] arrtemp = textBox1.Text.ToCharArray();
            //            nombrevuelo = "HAV-" + arrtemp[0] + arrtemp[1] + arrtemp[2];
            //            label11.Text = nombrevuelo;
            //        }
            //    }
            //}
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void AddFlight_Load(object sender, EventArgs e)
        {

        }

        private void AddFlight_VisibleChanged(object sender, EventArgs e)
        {
         
        }
    }
}
