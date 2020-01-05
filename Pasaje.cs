using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aeropuerto
{
    class Pasaje
    {
        private string nombrePersona;
        private string pasaporte;
        private string fecha;
        private float precioPasaje;
        private string claseVuelo;
        private string numeroAsiento;

        public Pasaje(string nombrePersona, string pasaporte, string fecha, float precioPasaje, string claseVuelo, string numeroAsiento)
        {
            this.NombrePersona = nombrePersona;
            this.Pasaporte = pasaporte;
            this.Fecha = fecha;
            this.PrecioPasaje = precioPasaje;
            this.ClaseVuelo = claseVuelo;
            this.NumeroAsiento = numeroAsiento;
        }

        public string NombrePersona { get => nombrePersona; set => nombrePersona = value; }
        public string Pasaporte { get => pasaporte; set => pasaporte = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public float PrecioPasaje { get => precioPasaje; set => precioPasaje = value; }
        public string ClaseVuelo { get => claseVuelo; set => claseVuelo = value; }
        public string NumeroAsiento { get => numeroAsiento; set => numeroAsiento = value; }

        public static DataTable cargarPersonas()
        {
            SQLiteConnection cadenaconexion = BaseDatos.ConectarBD();

            cadenaconexion.Open();
            SQLiteDataAdapter da;
            da = new SQLiteDataAdapter("SELECT NombrePersona,Pasaporte, Fecha FROM Pasaje WHERE ClaseVuelo = '1'", cadenaconexion);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cadenaconexion.Close();
            return dt;
        }

        public static void CalcularPrecio(SQLiteConnection cadenaconexion, ComboBox comboBox2, Label precioLabel)
        {
            string[] i = new string[1];
            bool isInternacional = false;
            string[] precios = new string[3];
            string[] cantKM = new string[1];

            cadenaconexion.Open();
            SQLiteCommand comando = new SQLiteCommand("SELECT Precios FROM Precios", cadenaconexion);
            SQLiteDataReader registro = comando.ExecuteReader();

            int p = 0;
            while (registro.Read())
            {
                precios[p] = registro["Precios"].ToString();
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
            char[] x = comboBox2.Text.ToCharArray();
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
            precioLabel.Text = precio.ToString();
            cadenaconexion.Close();
        }

        public static void recaudadoIntervalo(SQLiteConnection cadenaconexion, string inicio, string final, Label label3, Label label4)
        {
            cadenaconexion.Open();
            SQLiteCommand comando2 = new SQLiteCommand("SELECT PrecioPasaje FROM Pasaje WHERE " +
                "Fecha >= '" + inicio + "' AND Fecha <= '" + final + "'", cadenaconexion);
            SQLiteDataReader registro2 = comando2.ExecuteReader();
            int c = 0;

            double sum = 0;
            while (registro2.Read())
            {
                sum = sum + double.Parse(registro2["PrecioPasaje"].ToString());
                c++;
            }
            cadenaconexion.Close();
            label3.Text = "$ " + sum.ToString();
            label4.Text = c.ToString() + " VUELOS";
        }
    }
}
