using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Aeropuerto
{
    public partial class splash : Form
    {      
        String[] arregloC = { "Hola", "Cargando base de datos", "Cargando vuelos", "Cargando Pasajes"
            , "Arreglando algunas cosas", "Buscando al dragón"};

        public splash()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(2);
            if(progressBar1.Value == 10)
            {
                label1.Text = arregloC[1];
            }

            if (progressBar1.Value == 25)
            {
                label1.Text = arregloC[2];
            }

            if (progressBar1.Value == 50)
            {
                label1.Text = arregloC[4];
            }

            if (progressBar1.Value == 100)
            {
                this.timer1.Stop();
                                                
                this.Hide();
                MainPage p = new MainPage();
                p.Show();
            }
        }

        
    }
}
