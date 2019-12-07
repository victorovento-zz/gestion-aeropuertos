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
    public partial class Dashboard : Form
    {
        string [] arr = new string[3];
        public Dashboard()
        {
            InitializeComponent();
            SQLiteConnection cadenaconexion = new SQLiteConnection("Data Source = C:/AEROPUERTO/basesdedatos.db");
            cadenaconexion.Open();
            SQLiteCommand comando = new SQLiteCommand("SELECT Precios FROM Precios", cadenaconexion);
            SQLiteDataReader registro = comando.ExecuteReader();

            
            int p = 0;
            while (registro.Read())
            {
                arr[p] = registro["Precios"].ToString();
                p++;
            }

            cadenaconexion.Close();
            label7.Text = arr[0];
            label8.Text = arr[1];
            label9.Text = arr[2];

            textBox1.Text = arr[0];
            textBox4.Text = arr[1];
            textBox2.Text = arr[2];
        }
        
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.SoloDoubles(e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.SoloDoubles(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.SoloDoubles(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text.Equals("")) && !(textBox2.Text.Equals("")) && !(textBox4.Text.Equals(""))){
               if(!(textBox1.Text.Equals("0")) && !(textBox2.Text.Equals("0")) && !(textBox4.Text.Equals("0")))
                {

                    try
                    {
                    arr[0] = textBox1.Text;
                    arr[1] = textBox4.Text;
                    arr[2] = textBox2.Text;

                    SQLiteConnection cadenaconexion = new SQLiteConnection("Data Source = C:/AEROPUERTO/basesdedatos.db");
                    cadenaconexion.Open();
                    //string sql = "SELECT * FROM Vuelos";
                    string sql = string.Format("UPDATE Precios SET Precios =('{0}')  WHERE Nombre = \"Nacional\" ", arr[0]);
                    SQLiteCommand comando = new SQLiteCommand(sql, cadenaconexion);
                    comando.ExecuteNonQuery();
                        
                        sql = string.Format("UPDATE Precios SET Precios = ('{0}')  WHERE Nombre = \"Internacional\" ", arr[1]);
                        comando = new SQLiteCommand(sql, cadenaconexion);
                        comando.ExecuteNonQuery();

                        sql = string.Format("UPDATE Precios SET Precios =('{0}')  WHERE Nombre = \"KM\" ", arr[2]);
                        comando = new SQLiteCommand(sql, cadenaconexion);
                        comando.ExecuteNonQuery();
                        cadenaconexion.Close();

                    MessageBox.Show("Se han cambiado los precios");
                        label7.Text = arr[0];
                        label8.Text = arr[1];
                        label9.Text = arr[2];
                    }
                    catch(SQLiteException)
                    {
                        DialogResult resultado = new DialogResult();
                        MensajeDeError error = new MensajeDeError("Ha ocurrido un error");
                        resultado = error.ShowDialog();
                    }
                    

                }
                else
                {
                    DialogResult resultado = new DialogResult();
                    MensajeDeError error = new MensajeDeError("No pueden haber campos vacíos");
                    resultado = error.ShowDialog();
                }
            }
            else
            {
                DialogResult resultado = new DialogResult();
                MensajeDeError error = new MensajeDeError("En este mundo ya nada es gratis");
                resultado = error.ShowDialog();
            }
        }
    }
}
