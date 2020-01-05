namespace Aeropuerto
{
    partial class FlightList
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTerminal = new System.Windows.Forms.Panel();
            this.panelPrecios = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.preciosRB = new System.Windows.Forms.RadioButton();
            this.terminalRB = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTerminal.SuspendLayout();
            this.panelPrecios.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de vuelos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox3.DisplayMember = "Cuba";
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.White;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox3.Location = new System.Drawing.Point(296, 14);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(186, 33);
            this.comboBox3.TabIndex = 51;
            this.comboBox3.Text = "1";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(199, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 30);
            this.label5.TabIndex = 50;
            this.label5.Text = "Terminal";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(429, 63);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(56, 26);
            this.textBox6.TabIndex = 57;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(341, 63);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(39, 26);
            this.textBox5.TabIndex = 56;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(253, 63);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(39, 26);
            this.textBox4.TabIndex = 55;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(380, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 30);
            this.label8.TabIndex = 54;
            this.label8.Text = "Año";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(293, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 30);
            this.label7.TabIndex = 53;
            this.label7.Text = "Mes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(211, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 30);
            this.label6.TabIndex = 52;
            this.label6.Text = "Día";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(0)))), ((int)(((byte)(96)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.Size = new System.Drawing.Size(565, 312);
            this.dataGridView1.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12.75F);
            this.label2.Location = new System.Drawing.Point(340, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 69);
            this.label2.TabIndex = 59;
            this.label2.Text = "Leyenda:\r\nArribo: 0= Salida 1= Arribo\r\nCAO = Cantidad de Asientos Ocupados";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelTerminal
            // 
            this.panelTerminal.BackgroundImage = global::Aeropuerto.Properties.Resources.vuelo_back;
            this.panelTerminal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTerminal.Controls.Add(this.label2);
            this.panelTerminal.Controls.Add(this.dataGridView1);
            this.panelTerminal.Controls.Add(this.textBox6);
            this.panelTerminal.Controls.Add(this.textBox5);
            this.panelTerminal.Controls.Add(this.textBox4);
            this.panelTerminal.Controls.Add(this.label8);
            this.panelTerminal.Controls.Add(this.label7);
            this.panelTerminal.Controls.Add(this.label6);
            this.panelTerminal.Controls.Add(this.comboBox3);
            this.panelTerminal.Controls.Add(this.label5);
            this.panelTerminal.Location = new System.Drawing.Point(3, 43);
            this.panelTerminal.Name = "panelTerminal";
            this.panelTerminal.Size = new System.Drawing.Size(680, 501);
            this.panelTerminal.TabIndex = 60;
            // 
            // panelPrecios
            // 
            this.panelPrecios.BackgroundImage = global::Aeropuerto.Properties.Resources.vuelo_back;
            this.panelPrecios.Controls.Add(this.listBox1);
            this.panelPrecios.Controls.Add(this.label3);
            this.panelPrecios.Location = new System.Drawing.Point(1, 47);
            this.panelPrecios.Name = "panelPrecios";
            this.panelPrecios.Size = new System.Drawing.Size(679, 501);
            this.panelPrecios.TabIndex = 62;
            this.panelPrecios.Visible = false;
            this.panelPrecios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrecios_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(120, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(425, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vuelos Ordenados por su precio";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.preciosRB);
            this.panel2.Controls.Add(this.terminalRB);
            this.panel2.Location = new System.Drawing.Point(482, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 38);
            this.panel2.TabIndex = 61;
            // 
            // preciosRB
            // 
            this.preciosRB.AutoSize = true;
            this.preciosRB.Checked = true;
            this.preciosRB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.preciosRB.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.preciosRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preciosRB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciosRB.ForeColor = System.Drawing.Color.White;
            this.preciosRB.Location = new System.Drawing.Point(102, 5);
            this.preciosRB.Name = "preciosRB";
            this.preciosRB.Size = new System.Drawing.Size(90, 29);
            this.preciosRB.TabIndex = 9;
            this.preciosRB.TabStop = true;
            this.preciosRB.Text = "Precios";
            this.preciosRB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.preciosRB.UseVisualStyleBackColor = true;
            this.preciosRB.CheckedChanged += new System.EventHandler(this.preciosRB_CheckedChanged);
            // 
            // terminalRB
            // 
            this.terminalRB.AutoSize = true;
            this.terminalRB.Checked = true;
            this.terminalRB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.terminalRB.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.terminalRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.terminalRB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminalRB.ForeColor = System.Drawing.Color.White;
            this.terminalRB.Location = new System.Drawing.Point(6, 5);
            this.terminalRB.Name = "terminalRB";
            this.terminalRB.Size = new System.Drawing.Size(101, 29);
            this.terminalRB.TabIndex = 8;
            this.terminalRB.TabStop = true;
            this.terminalRB.Text = "Terminal";
            this.terminalRB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.terminalRB.UseVisualStyleBackColor = true;
            this.terminalRB.CheckedChanged += new System.EventHandler(this.terminalRB_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(85, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(468, 329);
            this.listBox1.TabIndex = 3;
            // 
            // FlightList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Aeropuerto.Properties.Resources.vuelo2;
            this.ClientSize = new System.Drawing.Size(682, 550);
            this.Controls.Add(this.panelPrecios);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTerminal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlightList";
            this.Text = "FlightList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTerminal.ResumeLayout(false);
            this.panelTerminal.PerformLayout();
            this.panelPrecios.ResumeLayout(false);
            this.panelPrecios.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTerminal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton preciosRB;
        private System.Windows.Forms.RadioButton terminalRB;
        private System.Windows.Forms.Panel panelPrecios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
    }
}