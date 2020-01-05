using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aeropuerto
{
    class Precio
    {
        private string nombre;
        private float precios;

        public Precio(string nombre, float precios)
        {
            this.Nombre = nombre;
            this.precios = precios;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Precios { get => precios; set => precios = value; }

        public static void cambiarPrecios(string [] arr, TextBox textBox1, TextBox textBox4, TextBox textBox2,Label label7, Label label8, Label label9)
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
            catch (SQLiteException)
            {
                DialogResult resultado = new DialogResult();
                MensajeDeError error = new MensajeDeError("Ha ocurrido un error");
                resultado = error.ShowDialog();
            }
        }

        public static void cargarPrecios(SQLiteConnection cadenaconexion, string [] arr)
        {
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
        } 
    }
}
