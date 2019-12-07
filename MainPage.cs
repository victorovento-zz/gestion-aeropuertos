using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace Aeropuerto
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            AbrirFormHija(new AddFlight());
        }

        public void pantalla()
        {
            Application.Run(new splash());
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd , int wMsg , int waram, int lParam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelSubMenu_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new RecFlight());
            buttonVUVU.BackColor = panelContenedor.BackColor;
            button2.BackColor = pictureBox3.BackColor;
            button5.BackColor = pictureBox3.BackColor;
            button4.BackColor = pictureBox3.BackColor;
            button3.BackColor = panelContenedor.BackColor;
            button1.BackColor = pictureBox3.BackColor;
            button10.BackColor = pictureBox3.BackColor;
            button1.BackColor = pictureBox3.BackColor;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new RecInterval());
            button10.BackColor = panelContenedor.BackColor;
            button2.BackColor = pictureBox3.BackColor;
            button5.BackColor = pictureBox3.BackColor;
            button4.BackColor = pictureBox3.BackColor;
            button3.BackColor = panelContenedor.BackColor;
            buttonVUVU.BackColor = pictureBox3.BackColor;
            button1.BackColor = pictureBox3.BackColor;
            button7.BackColor = pictureBox3.BackColor;
        }
        /*
         * Esta es la funcion
         * para llamar formularios hijos
         */
        public void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

   

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Dashboard());
            button7.BackColor = panelContenedor.BackColor;
            button2.BackColor = pictureBox3.BackColor;
            button5.BackColor = pictureBox3.BackColor;
            button4.BackColor = pictureBox3.BackColor;
            button3.BackColor = pictureBox3.BackColor;
            buttonVUVU.BackColor = pictureBox3.BackColor;
            button10.BackColor = pictureBox3.BackColor;
            button1.BackColor = pictureBox3.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new AddFlight());
            button1.BackColor = panelContenedor.BackColor;
            button2.BackColor = pictureBox3.BackColor;
            button5.BackColor = pictureBox3.BackColor;
            button4.BackColor = pictureBox3.BackColor;
            button3.BackColor = pictureBox3.BackColor;
            buttonVUVU.BackColor = pictureBox3.BackColor;
            button10.BackColor = pictureBox3.BackColor;
            button7.BackColor = pictureBox3.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new SellPass());
            button2.BackColor = panelContenedor.BackColor;
            button1.BackColor = pictureBox3.BackColor;
            button5.BackColor = pictureBox3.BackColor;
            button4.BackColor = pictureBox3.BackColor;
            button3.BackColor = pictureBox3.BackColor;
            buttonVUVU.BackColor = pictureBox3.BackColor;
            button10.BackColor = pictureBox3.BackColor;
            button7.BackColor = pictureBox3.BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new PersonList());
            button5.BackColor = panelContenedor.BackColor;
            button2.BackColor = pictureBox3.BackColor;
            button1.BackColor = pictureBox3.BackColor;
            button4.BackColor = pictureBox3.BackColor;
            button3.BackColor = pictureBox3.BackColor;
            buttonVUVU.BackColor = pictureBox3.BackColor;
            button10.BackColor = pictureBox3.BackColor;
            button7.BackColor = pictureBox3.BackColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FlightList());
            button4.BackColor = panelContenedor.BackColor;
            button2.BackColor = pictureBox3.BackColor;
            button5.BackColor = pictureBox3.BackColor;
            button1.BackColor = pictureBox3.BackColor;
            button3.BackColor = pictureBox3.BackColor;
            buttonVUVU.BackColor = pictureBox3.BackColor;
            button10.BackColor = pictureBox3.BackColor;
            button7.BackColor = pictureBox3.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new RecFlight());
            button3.BackColor = panelContenedor.BackColor;
            button2.BackColor = pictureBox3.BackColor;
            button5.BackColor = pictureBox3.BackColor;
            button4.BackColor = pictureBox3.BackColor;
            button1.BackColor = pictureBox3.BackColor;
            buttonVUVU.BackColor = panelContenedor.BackColor;
            button10.BackColor = pictureBox3.BackColor;
            button7.BackColor = pictureBox3.BackColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToShortDateString();
        }
    }
}
