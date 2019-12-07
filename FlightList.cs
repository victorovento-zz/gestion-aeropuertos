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

        SQLiteConnection cadenaconexion = new SQLiteConnection("Data Source = C:/AEROPUERTO/basesdedatos.db");

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
                            cadenaconexion.Open();
                            SQLiteDataAdapter da;
                            da = new SQLiteDataAdapter("SELECT Fecha, Pais, Ciudad, CantidadKM, " +
                                "Arribo, CAO FROM Vuelos WHERE NumeroTerminal = '" + comboBox3.Text + "' AND Fecha LIKE '%" + y+"/"+m+"/"+d + "%'", cadenaconexion);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;

                            cadenaconexion.Close();
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
            if (terminalRB.Checked)
            {
                panelTerminal.Visible = true;
                panelPrecios.Visible = false;
            }
            else
            {
                panelTerminal.Visible = false;
                panelPrecios.Visible = true;
            }
        }

        private void preciosRB_CheckedChanged(object sender, EventArgs e)
        {
            if (preciosRB.Checked)
            {
                ListaEnlazada<Vuelo> lista = new ListaEnlazada<Vuelo>();
                cadenaconexion.Open();
                SQLiteCommand comando = new SQLiteCommand("SELECT * FROM Vuelos", cadenaconexion);
                SQLiteDataReader registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    bool internacional = false;
                    if ((registro["Internacional"].ToString().Equals("1")))
                    {
                        internacional = true;
                    }else if ((registro["Internacional"].ToString().Equals("0")))
                    {
                        internacional = false;
                    }

                    bool arribo = false;
                    if ((registro["Arribo"].ToString().Equals("1")))
                    {
                        arribo = true;
                    }
                    else if ((registro["Arribo"].ToString().Equals("0")))
                    {
                        arribo = false;
                    }

                    string[] i = new string[1];
                    bool isInternacional = false;
                    string[] precios = new string[3];
                    string[] cantKM = new string[1];

                    //   SQLiteConnection cadenaconexion = new SQLiteConnection("Data Source = C:/AEROPUERTO/basesdedatos.db");
                    cadenaconexion.Open();
                    SQLiteCommand comando4 = new SQLiteCommand("SELECT Precios FROM Precios", cadenaconexion);
                    SQLiteDataReader registro4 = comando4.ExecuteReader();

                    int p = 0;
                    while (registro4.Read())
                    {
                        precios[p] = registro4["Precios"].ToString();
                        p++;
                    }
                    SQLiteCommand comando2 = new SQLiteCommand("SELECT Internacional FROM Vuelos", cadenaconexion);
                    SQLiteDataReader registro2 = comando2.ExecuteReader();

                    while (registro2.Read())
                    {
                        i[0] = registro2["Internacional"].ToString();
                    }
                    if (i[0].Equals("0"))
                    {
                        isInternacional = false;
                    }
                    if (i[0].Equals("1"))
                    {
                        isInternacional = true;
                    }
                    char[] x = registro["Fecha"].ToString().ToCharArray();
                    SQLiteCommand comando3 = new SQLiteCommand("SELECT CantidadKM FROM Vuelos WHERE Fecha = '" + x[0] + x[1] + x[2] + x[3] + x[4] + x[5] + x[6] + x[7] + x[8] + x[9] + x[10] +
                        x[11] + x[12] + x[13] + x[14] + x[15] + "'", cadenaconexion);
                    SQLiteDataReader registro3 = comando3.ExecuteReader();

                    while (registro3.Read())
                    {
                        cantKM[0] = registro3["CantidadKM"].ToString();
                    }

                    float precio = 0;
                    if (isInternacional)
                    {
                        precio = float.Parse(precios[1]) + (float)0.10 * (float.Parse(cantKM[0]) + float.Parse(precios[1]));
                    }
                    else
                    {
                        precio = float.Parse(precios[0]) + (float)0.20 * (float.Parse(cantKM[0]) + float.Parse(precios[1]));
                    }
                    
                    cadenaconexion.Close();

                    Vuelo vuelo = new Vuelo(internacional,arribo, registro["Fecha"].ToString(),
                        registro["NumeroTerminal"].ToString(), registro["Pais"].ToString(),
                        registro["Ciudad"].ToString(), registro["CantidadKM"].ToString(),
                        Int32.Parse(registro["CAO"].ToString()), registro["NueroMatricula"].ToString(),precio);

                    lista.add(vuelo);


                }
                cadenaconexion.Close();
            }
        }
    }
}
