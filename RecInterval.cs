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
    public partial class RecInterval : Form
    {
        SQLiteConnection cadenaconexion = BaseDatos.ConectarBD();

        public RecInterval()
        {
            InitializeComponent();
            cadenaconexion.Open();
            SQLiteCommand comando = new SQLiteCommand("SELECT Fecha FROM Vuelos ORDER BY Fecha", cadenaconexion);
            SQLiteDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                InicioCB.Items.Add(registro["Fecha"].ToString());
            }
            cadenaconexion.Close();
        }

        private void RecInterval_Load(object sender, EventArgs e)
        {

        }

        private void InicioCB_SelectedIndexChanged(object sender, EventArgs e)
        {
                 
            FinalCB.Items.Clear();
            FinalCB.Text = "Final";
            cadenaconexion.Open();
            SQLiteCommand comando = new SQLiteCommand("SELECT Fecha FROM Vuelos WHERE Fecha >= '" +InicioCB.Text +"' ORDER BY Fecha", cadenaconexion);
            SQLiteDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                FinalCB.Items.Add(registro["Fecha"].ToString());
            }
            cadenaconexion.Close();

            if (!FinalCB.Text.Equals("Final"))
            {
                {
                    string inicio = InicioCB.Text;
                    string final = FinalCB.Text;
                    Pasaje.recaudadoIntervalo(cadenaconexion, inicio, final, label3, label4);
                }
            }
            else
            {
                label3.Text = "000000.00";
                label4.Text = "X VUELOS";
            }
        }

        private void FinalCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadenaconexion.Open();
            SQLiteCommand comando = new SQLiteCommand("SELECT PrecioPasaje FROM Pasaje WHERE " +
                "Fecha >= '"+InicioCB.Text + "' AND Fecha <= '"+FinalCB.Text+ "'", cadenaconexion);
            SQLiteDataReader registro = comando.ExecuteReader();
            int c = 0;
            
            double sum = 0;
            while (registro.Read())
            {
                sum = sum + double.Parse(registro["PrecioPasaje"].ToString());
                c++;
            }
            cadenaconexion.Close();
            label3.Text = "$ " + sum.ToString();
            label4.Text = c.ToString() + " VUELOS";
        }
    }
}
