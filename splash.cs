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
            if(progressBar1.Value == 100)
            {
                this.timer1.Stop();
                                                
                this.Hide();
                MainPage p = new MainPage();
                p.Show();
            }
        }

        
    }
}
