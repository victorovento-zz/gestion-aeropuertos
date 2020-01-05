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
    public partial class SellPass : Form
    {
        SQLiteConnection cadenaconexion = BaseDatos.ConectarBD();

        long contador = 44;
        int tempAsientos = 0;

        int[] cantRes = new int[3];
        public SellPass()
        {
            InitializeComponent();

            if (cantRes[0] == 0)
            {
                clase1.Checked = false;
                clase1.Enabled = false;
            }
            else
            {
                clase1.Checked = true;
                clase1.Enabled = true;
            }

            if (cantRes[1] == 0)
            {
                clase2.Checked = false;
                clase2.Enabled = false;
            }
            else
            {
                clase2.Checked = true;
                clase2.Enabled = true;
            }

            if (cantRes[2] == 0)
            {
                clase3.Checked = false;
                clase3.Enabled = false;
            }
            else
            {
                clase3.Checked = true;
                clase3.Enabled = true;
            }

            cadenaconexion.Open();
            SQLiteCommand comando = new SQLiteCommand("SELECT Fecha,NumeroTerminal FROM Vuelos", cadenaconexion);
            SQLiteDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                comboBox2.Items.Add((registro["Fecha"].ToString()) + " TERM: " + registro["NumeroTerminal"].ToString());
            }
            cadenaconexion.Close();


        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SellPass_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string codvuelo = comboBox2.Text.ToString();
            string[] asientosOcupados = new string[1];
            string[] numeroMatricula = new string[1];
            char[] x = comboBox2.Text.ToCharArray();
            cadenaconexion.Open();
            SQLiteCommand comando = new SQLiteCommand("SELECT CAO FROM Vuelos WHERE Fecha = '" + x[0] + x[1] + x[2] + x[3] + x[4] + x[5] + x[6] + x[7] + x[8] + x[9] + x[10] +
                x[11] + x[12] + x[13] + x[14] + x[15] + "'", cadenaconexion);
            SQLiteDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                asientosOcupados[0] = registro["CAO"].ToString();
            }

            SQLiteCommand comando8 = new SQLiteCommand("SELECT NumeroMatricula FROM Vuelos WHERE Fecha = '" + x[0] + x[1] + x[2] + x[3] + x[4] + x[5] + x[6] + x[7] + x[8] + x[9] + x[10] +
                x[11] + x[12] + x[13] + x[14] + x[15] + "'", cadenaconexion);

            SQLiteDataReader registro8 = comando8.ExecuteReader();
            while (registro8.Read())
            {
                numeroMatricula[0] = registro8["NumeroMatricula"].ToString();
            }


            SQLiteCommand comando1 = new SQLiteCommand("SELECT CantAsientosTotales FROM Aviones WHERE NumeroMatricula = " +
                "'" + numeroMatricula[0] + "'", cadenaconexion);
            SQLiteDataReader registro1 = comando1.ExecuteReader();
            int[] cantAsientosTotales = new int[1];

            while (registro1.Read())
            {
                cantAsientosTotales[0] = Int32.Parse(registro1["CantAsientosTotales"].ToString());
            }


            int asOcup = Int32.Parse(asientosOcupados[0]);
            int resta = cantAsientosTotales[0] - asOcup;
            asientosrestantes.Text = resta.ToString();


            int[] temp2 = new int[1];
            int[] temp3 = new int[1];
            int[] temp4 = new int[1];

            SQLiteCommand comando2 = new SQLiteCommand("SELECT COUNT(*) FROM Pasaje WHERE ClaseVuelo = '1' " +
                "AND Fecha = '" + codvuelo + "'", cadenaconexion);
            SQLiteDataReader registro2 = comando2.ExecuteReader();
            while (registro2.Read())
            {
                temp2[0] = Int32.Parse(registro2["count(*)"].ToString());
            }

            SQLiteCommand comando3 = new SQLiteCommand("SELECT COUNT(*) FROM Pasaje WHERE ClaseVuelo = '2' " +
                "AND Fecha = '" + codvuelo + "'", cadenaconexion);
            SQLiteDataReader registro3 = comando3.ExecuteReader();

            while (registro3.Read())
            {
                temp3[0] = Int32.Parse(registro3["count(*)"].ToString());
            }
            SQLiteCommand comando4 = new SQLiteCommand("SELECT COUNT(*) FROM Pasaje WHERE ClaseVuelo = '3' " +
                "AND Fecha = '" + codvuelo + "'", cadenaconexion);
            SQLiteDataReader registro4 = comando4.ExecuteReader();
            while (registro4.Read())
            {
                temp4[0] = Int32.Parse(registro4["count(*)"].ToString());
            }

            cantRes[0] = (15 * cantAsientosTotales[0] / 100) - temp2[0];
            cantRes[1] = (25 * cantAsientosTotales[0] / 100) - temp3[0];
            cantRes[2] = (60 * cantAsientosTotales[0] / 100) - temp4[0];
            tempAsientos = cantAsientosTotales[0];

            primeraclase.Text = cantRes[0].ToString();
            segundaClase.Text = cantRes[1].ToString();
            terceraClase.Text = cantRes[2].ToString();







            if (cantRes[0] == 0)
            {
                clase1.Checked = false;
                clase1.Enabled = false;
            }
            else
            {
                clase1.Checked = true;
                clase1.Enabled = true;
            }

            if (cantRes[1] == 0)
            {
                clase2.Checked = false;
                clase2.Enabled = false;
            }
            else
            {
                clase2.Checked = true;
                clase2.Enabled = true;
            }

            if (cantRes[2] == 0)
            {
                clase3.Checked = false;
                clase3.Enabled = false;
            }
            else
            {
                clase3.Checked = true;
                clase3.Enabled = true;
            }

            string arrOrsal = null;

            SQLiteCommand comando5 = new SQLiteCommand("SELECT Arribo FROM Vuelos WHERE " +
                "Fecha = '" + x[0] + x[1] + x[2] + x[3] + x[4] + x[5] + x[6] + x[7] + x[8] + x[9] + x[10] +
                x[11] + x[12] + x[13] + x[14] + x[15] + "'", cadenaconexion);
            SQLiteDataReader registro5 = comando5.ExecuteReader();
            string[] temp5 = new string[1];
            while (registro5.Read())
            {
                temp5[0] = registro5["Arribo"].ToString();
            }

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


            SQLiteCommand comando6 = new SQLiteCommand("SELECT Ciudad FROM Vuelos WHERE " +
                "Fecha = '" + x[0] + x[1] + x[2] + x[3] + x[4] + x[5] + x[6] + x[7] + x[8] + x[9] + x[10] +
                x[11] + x[12] + x[13] + x[14] + x[15] + "'", cadenaconexion);
            SQLiteDataReader registro6 = comando6.ExecuteReader();

            while (registro6.Read())
            {
                city[0] = registro6["Ciudad"].ToString();
            }

            string infovuelo = arrOrsal + city[0];
            label18.Text = infovuelo;



            SQLiteCommand comando9 = new SQLiteCommand("SELECT NumeroAsiento FROM Pasaje WHERE Fecha = '" + codvuelo + "'", cadenaconexion);
            SQLiteDataReader registro9 = comando9.ExecuteReader();
            int p = 0;

            bool asientoDisp = true;
            string asTemp = noAsiento.Text.Trim();
            string[] temp = new string[1];

            SQLiteCommand comando20 = new SQLiteCommand("SELECT COUNT(*) FROM Pasaje WHERE NumeroAsiento = '" + noAsiento.Text.Trim() +
                "' AND Fecha = '" + x[0] + x[1] + x[2] + x[3] + x[4] + x[5] + x[6] + x[7] + x[8] + x[9] + x[10] +
                x[11] + x[12] + x[13] + x[14] + x[15] + "'", cadenaconexion);
            SQLiteDataReader registro20 = comando20.ExecuteReader();
            while (registro20.Read())
            {
                temp[0] = (registro20["count(*)"].ToString());
            }
            if (temp[0].Equals("1"))
            {
                asientoDisp = false;
            }
            if (temp[0].Equals("0"))
            {
                asientoDisp = true;
            }

            if (asientoDisp && !noAsiento.Text.Equals("") && !noAsiento.Text.Equals("0"))
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
            }
            else
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }


            cadenaconexion.Close();
            Pasaje.CalcularPrecio(cadenaconexion, comboBox2, precioLabel);

        }

        private void nombrePersona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (noAsiento.Text.Length >= 50)
            {
                e.Handled = true;
            }
            Validation.SoloLetras(e);
        }

        private void pasaporte_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validation.SoloNumeros(e);
            if (noAsiento.Text.Length >= 12)
            {
                e.Handled = true;
            }

        }

        private void noAsiento_TextChanged(object sender, EventArgs e)
        {
            cadenaconexion.Open();
            bool asientoDisp = true;
            string asTemp = noAsiento.Text.Trim();
            string temp = null;

            SQLiteCommand comando2 = new SQLiteCommand("SELECT COUNT(*) FROM Pasaje WHERE NumeroAsiento = '" + noAsiento.Text.Trim() +
                "' AND Fecha = '" + comboBox2.Text.Trim() + "'", cadenaconexion);
            SQLiteDataReader registro2 = comando2.ExecuteReader();
            while (registro2.Read())
            {
                temp = (registro2["count(*)"].ToString());
            }
            if (temp.Equals("1"))
            {
                asientoDisp = false;
            }
            if (temp.Equals("0"))
            {
                asientoDisp = true;
            }

            if (asientoDisp && !noAsiento.Text.Equals("") && !noAsiento.Text.Equals("0")
                && !noAsiento.Text.Equals("00") && !noAsiento.Text.Equals("000")
                && !noAsiento.Text.Equals("0000")
                )
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
            }
            else
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            cadenaconexion.Close();

        }

        private void SellPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.SoloNumeros(e);
        }



        private void noAsiento_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void clase2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clase1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea añadir el pasaje?", "Añadir pasaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {



                string clase = null;
                if (clase1.Checked)
                {
                    clase = "1";
                }
                if (clase2.Checked)
                {
                    clase = "2";
                }
                if (clase3.Checked)
                {
                    clase = "3";
                }

                bool asientoDisp = true;
                string asTemp = noAsiento.Text.Trim();
                string temp = null;

                cadenaconexion.Open();
                SQLiteCommand comando2 = new SQLiteCommand("SELECT COUNT(*) FROM Pasaje WHERE NumeroAsiento = '" + noAsiento.Text.Trim() +
                    "' AND Fecha = '" + comboBox2.Text.Trim() + "'", cadenaconexion);

                SQLiteDataReader registro2 = comando2.ExecuteReader();
                while (registro2.Read())
                {
                    temp = (registro2["count(*)"].ToString());
                }
                cadenaconexion.Close();

                if (temp.Equals("1"))
                {
                    asientoDisp = false;
                }
                if (temp.Equals("0"))
                {
                    asientoDisp = true;
                }

                if ((!(NombrePersona.Text.Equals(""))) && (!(pasaporte.Text.Equals(""))) &&
                (!(comboBox2.Text.Equals("Seleccionar vuelo"))) && (!(noAsiento.Text.Equals(""))))
                {


                    if (pasaporte.Text.Length == 12)
                    {


                        if (asientoDisp)
                        {


                            if (!(asientosrestantes.Text.Equals("")))
                            {
                                if ((Int32.Parse(noAsiento.Text) <= tempAsientos) && (Int32.Parse(noAsiento.Text) != 0))
                                {
                                    try
                                    {
                                        cadenaconexion.Open();
                                        string sql = string.Format("INSERT INTO Pasaje Values('{0}','{1}','{2}','{3}','{4}','{5}')", NombrePersona.Text.Trim(),
                                        pasaporte.Text.Trim(), comboBox2.Text.Trim(), precioLabel.Text.Trim(), clase, noAsiento.Text.Trim());
                                        SQLiteCommand comando = new SQLiteCommand(sql, cadenaconexion);
                                        comando.ExecuteNonQuery();
                                        cadenaconexion.Close();
                                        MessageBox.Show("Se ha guardado correctamente");
                                        cadenaconexion.Open();
                                        string sql2 = string.Format("UPDATE Vuelos SET CAO = (Vuelos.CAO + 1)  WHERE Fecha = '" + comboBox2.Text + "'");
                                        comando = new SQLiteCommand(sql2, cadenaconexion);
                                        comando.ExecuteNonQuery();
                                        cadenaconexion.Close();
                                        NombrePersona.Text = "";
                                        pasaporte.Text = "";
                                        noAsiento.Text = "";
                                        pictureBox3.Visible = false;
                                        pictureBox4.Visible = true;
                                        comboBox2.SelectedIndex = 1;

                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("No se ha guardado el vuelo");
                                    }

                                }
                                else
                                {
                                    DialogResult resultado = new DialogResult();
                                    MensajeDeError error = new MensajeDeError("Asiento no existe");
                                    resultado = error.ShowDialog();
                                }
                            }
                            else
                            {
                                DialogResult resultado = new DialogResult();
                                MensajeDeError error = new MensajeDeError("No hay asientos disponibles");
                                resultado = error.ShowDialog();
                            }
                        }
                        else
                        {
                            DialogResult resultado = new DialogResult();
                            MensajeDeError error = new MensajeDeError("Asiento ocupado");
                            resultado = error.ShowDialog();
                        }
                    }
                    else
                    {
                        DialogResult resultado = new DialogResult();
                        MensajeDeError error = new MensajeDeError("Error de pasaporte");
                        resultado = error.ShowDialog();
                    }
                }
                else
                {
                    DialogResult resultado = new DialogResult();
                    MensajeDeError error = new MensajeDeError("Faltan campos por llenar");
                    resultado = error.ShowDialog();
                }
            }

        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoEscribir(e);
        }

        private void pasaporte_TextChanged(object sender, EventArgs e)
        {
            if (pasaporte.Text.Length == 12)
            {
                bienP.Visible = true;
                errorP.Visible = false;
            }
            else
            {
                bienP.Visible = false;
                errorP.Visible = true;
            }
        }

        private void nombrePersona_TextChanged(object sender, EventArgs e)
        {
            if (NombrePersona.Text.Equals(""))
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }
    }
}
