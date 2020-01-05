using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Aeropuerto
{
    static class BaseDatos
    {
        public static SQLiteConnection ConectarBD()
        {
            SQLiteConnection cadenaconexion = new SQLiteConnection("Data Source = C:/AEROPUERTO/basesdedatos.db");
            return cadenaconexion;
        }


        
    }
}
