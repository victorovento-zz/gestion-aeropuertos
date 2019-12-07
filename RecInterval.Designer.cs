namespace Aeropuerto
{
    partial class RecInterval
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InicioCB = new System.Windows.Forms.ComboBox();
            this.FinalCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(177, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 100);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dinero Recaudado\r\nen un intervalo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Aeropuerto.Properties.Resources.money_blurred;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FinalCB);
            this.panel1.Controls.Add(this.InicioCB);
            this.panel1.Location = new System.Drawing.Point(80, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 377);
            this.panel1.TabIndex = 52;
            // 
            // InicioCB
            // 
            this.InicioCB.BackColor = System.Drawing.SystemColors.HotTrack;
            this.InicioCB.DisplayMember = "Cuba";
            this.InicioCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InicioCB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicioCB.ForeColor = System.Drawing.Color.White;
            this.InicioCB.FormattingEnabled = true;
            this.InicioCB.Location = new System.Drawing.Point(23, 42);
            this.InicioCB.Name = "InicioCB";
            this.InicioCB.Size = new System.Drawing.Size(186, 33);
            this.InicioCB.TabIndex = 53;
            this.InicioCB.Text = "Inicio";
            this.InicioCB.SelectedIndexChanged += new System.EventHandler(this.InicioCB_SelectedIndexChanged);
            // 
            // FinalCB
            // 
            this.FinalCB.BackColor = System.Drawing.SystemColors.HotTrack;
            this.FinalCB.DisplayMember = "Cuba";
            this.FinalCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinalCB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalCB.ForeColor = System.Drawing.Color.White;
            this.FinalCB.FormattingEnabled = true;
            this.FinalCB.Location = new System.Drawing.Point(311, 42);
            this.FinalCB.Name = "FinalCB";
            this.FinalCB.Size = new System.Drawing.Size(186, 33);
            this.FinalCB.TabIndex = 54;
            this.FinalCB.Text = "Final";
            this.FinalCB.SelectedIndexChanged += new System.EventHandler(this.FinalCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(185, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "Seleccione el intervalo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 62F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(456, 97);
            this.label3.TabIndex = 55;
            this.label3.Text = "000000.00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(184, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 34);
            this.label4.TabIndex = 56;
            this.label4.Text = "X VUELOS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecInterval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Aeropuerto.Properties.Resources.monenene1111;
            this.ClientSize = new System.Drawing.Size(682, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecInterval";
            this.Text = "RecInterval";
            this.Load += new System.EventHandler(this.RecInterval_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FinalCB;
        private System.Windows.Forms.ComboBox InicioCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}