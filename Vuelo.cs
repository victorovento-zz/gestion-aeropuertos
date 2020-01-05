using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace Aeropuerto
{
    class Vuelo
    {
        private bool isInternacional;
        private bool isArribo;
        private string fecha;
        private string numeroTerminal;
        private string pais;
        private string ciudad;
        private string cantKM;
        private int CAO;
        private string numeroMatricula;
        private float precio;
        private ListaEnlazada<Pasaje> listaPasajes;

        public Vuelo(bool isInternacional, bool isArribo, string fecha, string numeroTerminal, string pais, string ciudad, string cantKM, int cAO, string numeroMatricula, float precio)
        {
            this.IsInternacional = isInternacional;
            this.IsArribo = isArribo;
            this.Fecha = fecha;
            this.NumeroTerminal = numeroTerminal;
            this.Pais = pais;
            this.Ciudad = ciudad;
            this.CantKM = cantKM;
            this.CAO = cAO;
            this.NumeroMatricula = numeroMatricula;
            this.Precio = precio;
        }

        public bool IsInternacional { get => isInternacional; set => isInternacional = value; }
        public bool IsArribo { get => isArribo; set => isArribo = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string NumeroTerminal { get => numeroTerminal; set => numeroTerminal = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string CantKM { get => cantKM; set => cantKM = value; }
        public int CAO1 { get => CAO; set => CAO = value; }
        public string NumeroMatricula { get => numeroMatricula; set => numeroMatricula = value; }
        public float Precio { get => precio; set => precio = value; }
        internal ListaEnlazada<Pasaje> ListaPasajes { get => listaPasajes; set => listaPasajes = value; }

        /*
         * Obtiene los vuelos de una terminal seleccionada
         * y los pasa a un DataGrid en la interfaz FlightList
         * */
        public static void ObtenerVuelosTerminal(DataGridView DataGridView1, SQLiteConnection cadenaconexion, ComboBox comboBox3, string y, string m, string d)
        {
        cadenaconexion.Open();
                            SQLiteDataAdapter da;
        da = new SQLiteDataAdapter("SELECT Fecha, Pais, Ciudad, CantidadKM, " +
                                "Arribo, CAO FROM Vuelos WHERE NumeroTerminal = '" + comboBox3.Text + "' AND Fecha LIKE '%" + y + "/" + m + "/" + d + "%'", cadenaconexion);
        DataTable dt = new DataTable();
        da.Fill(dt);
        DataGridView1.DataSource = dt;

        cadenaconexion.Close();
        }

        /*
         * Ordena los precios y los muestra en una lista
         * */
        public static void ordenarPrecios(SQLiteConnection cadenaconexion, ListBox listBox1)
        {
            cadenaconexion.Open();
            ListaEnlazada<Vuelo> lista = new ListaEnlazada<Vuelo>();
            SQLiteCommand comando = new SQLiteCommand("SELECT * FROM Vuelos", cadenaconexion);
            SQLiteDataReader registro = comando.ExecuteReader();

            bool ii = false;
            bool ia = false;
            string f, nt, pais, c, ckm;
            int cao;
            string nm;
            float precio;

            while (registro.Read())
            {
                if (registro["Internacional"].ToString().Equals("1"))
                {
                    ii = true;
                }
                else if (registro["Internacional"].ToString().Equals("0"))
                {
                    ii = false;
                }

                if (registro["Arribo"].ToString().Equals("1"))
                {
                    ia = true;
                }
                else if (registro["Arribo"].ToString().Equals("0"))
                {
                    ia = false;
                }
                f = registro["Fecha"].ToString();
                nt = registro["NumeroTerminal"].ToString();
                pais = registro["Pais"].ToString();
                c = registro["Ciudad"].ToString();
                ckm = registro["CantidadKM"].ToString();
                cao = Int32.Parse(registro["CAO"].ToString());
                nm = registro["NumeroMatricula"].ToString();

                string i = null;
                bool isInternacional = false;
                string[] precios = new string[3];
                string cantKM = null;


                SQLiteCommand comando2 = new SQLiteCommand("SELECT Internacional FROM Vuelos", cadenaconexion);
                SQLiteDataReader registro2 = comando2.ExecuteReader();

                while (registro2.Read())
                {
                    i = registro2["Internacional"].ToString();
                }
                if (i.Equals("0"))
                {
                    isInternacional = false;
                }
                if (i.Equals("1"))
                {
                    isInternacional = true;
                }

                SQLiteCommand comando5 = new SQLiteCommand("SELECT Precios FROM Precios", cadenaconexion);
                SQLiteDataReader registro5 = comando5.ExecuteReader();

                int count = 0;
                while (registro5.Read())
                {
                    precios[count] = registro5["Precios"].ToString();
                    count++;
                }
                if (isInternacional)
                {
                    precio = float.Parse(precios[1]) + (float)0.10 * (float.Parse(ckm) + float.Parse(precios[1]));
                }
                else
                {
                    precio = float.Parse(precios[0]) + (float)0.20 * (float.Parse(ckm) + float.Parse(precios[1]));
                }


                Vuelo v = new Vuelo(ii, ia, f, nt, pais, c, ckm, cao, nm, precio);
                lista.add(v);
            }

            lista.mergeSort(lista.head);


            int contador = 0;
            listBox1.Items.Clear();

            while (contador < lista.Size)
            {
                string aaa;
                if (lista.get(contador).IsArribo)
                {
                    aaa = "Arribo";
                }
                else
                {
                    aaa = "Salida";
                }

                listBox1.Items.Add(" " + (contador + 1) + "   " + lista.get(contador).Pais.ToString()
                    + "   " + lista.get(contador).Ciudad.ToString() + " - " + lista.get(contador).Fecha.ToString() + "  " + aaa + "  "
                    + " - Precio: $" + lista.get(contador).Precio.ToString());

                contador++;

            }


            cadenaconexion.Close();
        }
    }
}
