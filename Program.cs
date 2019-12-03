using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Aeropuerto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new splash());
        }

        public static void consulta(String consulta)
        {
            SQLiteConnection cadenaconexion = new SQLiteConnection("Data Source = J:/ ProyectoFinal / Aeropuerto / basesdedatos.db");
            cadenaconexion.Open();

            string cons = consulta;
            SQLiteCommand comando = new SQLiteCommand(consulta, cadenaconexion);
            SQLiteDataReader datos = comando.ExecuteReader();
        }
    }
}
