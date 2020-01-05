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
    public partial class RecFlight : Form
    {
        public RecFlight()
        {
            InitializeComponent();
            SQLiteConnection cadenaconexion = BaseDatos.ConectarBD();
            cadenaconexion.Open();
            SQLiteCommand comando = new SQLiteCommand("SELECT Fecha,NumeroTerminal FROM Vuelos", cadenaconexion);
            SQLiteDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                comboBox2.Items.Add((registro["Fecha"].ToString())+" TERM: " + registro["NumeroTerminal"].ToString());
            }
            cadenaconexion.Close();
        }

        private void RecFlight_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string arrOrsal = null;
            char[] x = comboBox2.Text.ToCharArray();
            SQLiteConnection cadenaconexion = new SQLiteConnection("Data Source = C:/AEROPUERTO/basesdedatos.db");
            cadenaconexion.Open();
            SQLiteCommand comando = new SQLiteCommand("SELECT PrecioPasaje FROM Pasaje WHERE Fecha = '" +comboBox2.Text + "'", cadenaconexion);
            SQLiteDataReader registro = comando.ExecuteReader();

            double sum = 0;
            while (registro.Read())
            {
               sum = sum + double.Parse(registro["PrecioPasaje"].ToString());
            }
            cadenaconexion.Close();

            label2.Text = "$ " + sum.ToString();
            

            cadenaconexion.Open();//22
            SQLiteCommand comando5 = new SQLiteCommand("SELECT Arribo FROM Vuelos WHERE " +
                "Fecha= '" + x[0]+x[1] + x[2] + x[3] + x[4] + x[5] + x[6] + x[7] + x[8] + x[9] + x[10] +
                x[11] + x[12] + x[13] + x[14] + x[15] + "' AND " +
                "NumeroTerminal = '" + x[23] + "'", cadenaconexion);
            SQLiteDataReader registro5 = comando5.ExecuteReader();
            string[] temp5 = new string[1];
            
            while (registro5.Read())
            {
                temp5[0] = registro5["Arribo"].ToString();
            }

            cadenaconexion.Close();
            if (temp5[0].Equals("1"))
            {
                arrOrsal = "ARRIBO - ";
            }
            if (temp5[0].Equals("0"))
            {
                arrOrsal = "SALIDA - ";
            }

            string[] city = new string[1];
            city[0] = null;

            cadenaconexion.Open();
            SQLiteCommand comando6 = new SQLiteCommand("SELECT Ciudad FROM Vuelos WHERE " +
                "Fecha= '" + x[0] + x[1] + x[2] + x[3] + x[4] + x[5] + x[6] + x[7] + x[8] + x[9] + x[10] +
                x[11] + x[12] + x[13] + x[14] + x[15] + "' AND " +
                "NumeroTerminal = '" + x[23] + "'", cadenaconexion);
            SQLiteDataReader registro6 = comando6.ExecuteReader();

            while (registro6.Read())
            {
                city[0] = registro6["Ciudad"].ToString();
            }
            cadenaconexion.Close();
            string infovuelo = arrOrsal + city[0];
            label3.Text = infovuelo;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoEscribir(e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
