namespace Aeropuerto
{
    partial class AddFlight
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.internacional = new System.Windows.Forms.RadioButton();
            this.nacional = new System.Windows.Forms.RadioButton();
            this.salida = new System.Windows.Forms.RadioButton();
            this.arribo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Añadir vuelo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "País";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Distancia";
            // 
            // internacional
            // 
            this.internacional.AutoSize = true;
            this.internacional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.internacional.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.internacional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.internacional.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internacional.ForeColor = System.Drawing.Color.White;
            this.internacional.Location = new System.Drawing.Point(9, 11);
            this.internacional.Name = "internacional";
            this.internacional.Size = new System.Drawing.Size(140, 29);
            this.internacional.TabIndex = 5;
            this.internacional.TabStop = true;
            this.internacional.Text = "Internacional";
            this.internacional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.internacional.UseVisualStyleBackColor = true;
            this.internacional.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // nacional
            // 
            this.nacional.AutoSize = true;
            this.nacional.Checked = true;
            this.nacional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nacional.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.nacional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nacional.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nacional.ForeColor = System.Drawing.Color.White;
            this.nacional.Location = new System.Drawing.Point(155, 11);
            this.nacional.Name = "nacional";
            this.nacional.Size = new System.Drawing.Size(104, 29);
            this.nacional.TabIndex = 6;
            this.nacional.TabStop = true;
            this.nacional.Text = "Nacional";
            this.nacional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nacional.UseVisualStyleBackColor = true;
            this.nacional.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // salida
            // 
            this.salida.AutoSize = true;
            this.salida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salida.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.salida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salida.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salida.ForeColor = System.Drawing.Color.White;
            this.salida.Location = new System.Drawing.Point(155, 16);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(80, 29);
            this.salida.TabIndex = 8;
            this.salida.TabStop = true;
            this.salida.Text = "Salida";
            this.salida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.salida.UseVisualStyleBackColor = true;
            this.salida.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // arribo
            // 
            this.arribo.AutoSize = true;
            this.arribo.Checked = true;
            this.arribo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arribo.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.arribo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arribo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arribo.ForeColor = System.Drawing.Color.White;
            this.arribo.Location = new System.Drawing.Point(9, 16);
            this.arribo.Name = "arribo";
            this.arribo.Size = new System.Drawing.Size(82, 29);
            this.arribo.TabIndex = 7;
            this.arribo.TabStop = true;
            this.arribo.Text = "Arribo";
            this.arribo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.arribo.UseVisualStyleBackColor = true;
            this.arribo.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Terminal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(396, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Día";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(478, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 30);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(565, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 30);
            this.label8.TabIndex = 12;
            this.label8.Text = "Año";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(141, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 26);
            this.textBox1.TabIndex = 13;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(141, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 26);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(438, 218);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(39, 26);
            this.textBox4.TabIndex = 16;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(526, 218);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(39, 26);
            this.textBox5.TabIndex = 17;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(614, 218);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(56, 26);
            this.textBox6.TabIndex = 18;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox1.DisplayMember = "Cuba";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Afganistán",
            "Akrotiri",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Anguila",
            "Antártida",
            "Antigua y Barbuda",
            "Antillas Neerlandesas",
            "Arabia Saudí",
            "Arctic Ocean",
            "Argelia",
            "Argentina",
            "Armenia",
            "Aruba",
            "Ashmore andCartier Islands",
            "Atlantic Ocean",
            "Australia",
            "Austria",
            "Azerbaiyán",
            "Bahamas",
            "Bahráin",
            "Bangladesh",
            "Barbados",
            "Bélgica",
            "Belice",
            "Benín",
            "Bermudas",
            "Bielorrusia",
            "Birmania Myanmar",
            "Bolivia",
            "Bosnia y Hercegovina",
            "Botsuana",
            "Brasil",
            "Brunéi",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Bután",
            "Cabo Verde",
            "Camboya",
            "Camerún",
            "Canadá",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Clipperton Island",
            "Colombia",
            "Comoras",
            "Congo",
            "Coral Sea Islands",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfil",
            "Costa Rica",
            "Croacia",
            "Dhekelia",
            "Dinamarca",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "El Vaticano",
            "Emiratos Árabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Etiopía",
            "Filipinas",
            "Finlandia",
            "Fiyi",
            "Francia",
            "Gabón",
            "Gambia",
            "Gaza Strip",
            "Georgia",
            "Ghana",
            "Gibraltar",
            "Granada",
            "Grecia",
            "Groenlandia",
            "Guam",
            "Guatemala",
            "Guernsey",
            "Guinea",
            "Guinea Ecuatorial",
            "Guinea-Bissau",
            "Guyana",
            "Haití",
            "Honduras",
            "Hong Kong",
            "Hungría",
            "India",
            "Indian Ocean",
            "Indonesia",
            "Irán",
            "Iraq",
            "Irlanda",
            "Isla Bouvet",
            "Isla Christmas",
            "Isla Norfolk",
            "Islandia",
            "Islas Caimán",
            "Islas Cocos",
            "Islas Cook",
            "Islas Feroe",
            "Islas Georgia del Sur y Sandwich del Sur",
            "Islas Heard y McDonald",
            "Islas Malvinas",
            "Islas Marianas del Norte",
            "IslasMarshall",
            "Islas Pitcairn",
            "Islas Salomón",
            "Islas Turcas y Caicos",
            "Islas Vírgenes Americanas",
            "Islas Vírgenes Británicas",
            "Israel",
            "Italia",
            "Jamaica",
            "Jan Mayen",
            "Japón",
            "Jersey",
            "Jordania",
            "Kazajistán",
            "Kenia",
            "Kirguizistán",
            "Kiribati",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letonia",
            "Líbano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Macao",
            "Macedonia",
            "Madagascar",
            "Malasia",
            "Malaui",
            "Maldivas",
            "Malí",
            "Malta",
            "Man, Isle of",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "Mayotte",
            "México",
            "Micronesia",
            "Moldavia",
            "Mónaco",
            "Mongolia",
            "Montserrat",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Navassa Island",
            "Nepal",
            "Nicaragua",
            "Níger",
            "Nigeria",
            "Niue",
            "Noruega",
            "Nueva Caledonia",
            "Nueva Zelanda",
            "Omán",
            "Pacific Ocean",
            "Países Bajos",
            "Pakistán",
            "Palaos",
            "Panamá",
            "Papúa-Nueva Guinea",
            "Paracel Islands",
            "Paraguay",
            "Perú",
            "Polinesia Francesa",
            "Polonia",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Reino Unido",
            "República Centroafricana",
            "República Checa",
            "República Democrática del Congo",
            "República Dominicana",
            "Ruanda",
            "Rumania",
            "Rusia",
            "Sáhara Occidental",
            "Samoa",
            "Samoa Americana",
            "San Cristóbal y Nieves",
            "San Marino",
            "San Pedro y Miquelón",
            "San Vicente y las Granadinas",
            "Santa Helena",
            "Santa Lucía",
            "Santo Tomé y Príncipe",
            "Senegal",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Siria",
            "Somalia",
            "Southern Ocean",
            "Spratly Islands",
            "Sri Lanka",
            "Suazilandia",
            "Sudáfrica",
            "Sudán",
            "Suecia",
            "Suiza",
            "Surinam",
            "Svalbard y Jan Mayen",
            "Tailandia",
            "Taiwán",
            "Tanzania",
            "Tayikistán",
            "TerritorioBritánicodel Océano Indico",
            "Territorios Australes Franceses",
            "Timor Oriental",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trinidad y Tobago",
            "Túnez",
            "Turkmenistán",
            "Turquía",
            "Tuvalu",
            "Ucrania",
            "Uganda",
            "Unión Europea",
            "Uruguay",
            "Uzbekistán",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Wakanda",
            "Wake Island",
            "Wallis y Futuna",
            "West Bank",
            "World",
            "Yemen",
            "Yibuti",
            "Zambia",
            "Zimbabue"});
            this.comboBox1.Location = new System.Drawing.Point(141, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 33);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(526, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 41);
            this.button1.TabIndex = 20;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.salida);
            this.panel1.Controls.Add(this.arribo);
            this.panel1.Location = new System.Drawing.Point(392, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 55);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.internacional);
            this.panel2.Controls.Add(this.nacional);
            this.panel2.Location = new System.Drawing.Point(392, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 51);
            this.panel2.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(286, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 30);
            this.label10.TabIndex = 44;
            this.label10.Text = "KM";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox2.DisplayMember = "Seleccionar Avión";
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(141, 258);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(186, 33);
            this.comboBox2.TabIndex = 48;
            this.comboBox2.Text = "Seleccionar avión";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(69, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 30);
            this.label12.TabIndex = 47;
            this.label12.Text = "Avión";
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
            this.comboBox3.Location = new System.Drawing.Point(141, 215);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(186, 33);
            this.comboBox3.TabIndex = 49;
            this.comboBox3.Text = "1";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.comboBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox3_KeyPress);
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox4.DisplayMember = "Cuba";
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.ForeColor = System.Drawing.Color.White;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "PINAR DEL RÍO",
            "ARTEMISA",
            "LA HABANA",
            "MAYABEQUE",
            "MATANZAS",
            "CIENFUEGOS",
            "VILLA CLARA",
            "SANCTI SPIRITUS",
            "CIEGO DE AVILA",
            "CAMAGUEY",
            "LAS TUNAS",
            "GRANMA",
            "HOLGUIN",
            "SANTIAGO DE CUBA",
            "GUANTÁNAMO",
            "ISLA DE LA JUVENTUD"});
            this.comboBox4.Location = new System.Drawing.Point(141, 137);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(186, 33);
            this.comboBox4.TabIndex = 50;
            this.comboBox4.Text = "PINAR DEL RÍO";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            this.comboBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox4_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(425, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 30);
            this.label9.TabIndex = 51;
            this.label9.Text = "Hora";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(542, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 30);
            this.label11.TabIndex = 52;
            this.label11.Text = ":";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.domainUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domainUpDown1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDown1.ForeColor = System.Drawing.Color.White;
            this.domainUpDown1.Items.Add("00");
            this.domainUpDown1.Items.Add("01");
            this.domainUpDown1.Items.Add("02");
            this.domainUpDown1.Items.Add("03");
            this.domainUpDown1.Items.Add("04");
            this.domainUpDown1.Items.Add("05");
            this.domainUpDown1.Items.Add("06");
            this.domainUpDown1.Items.Add("07");
            this.domainUpDown1.Items.Add("08");
            this.domainUpDown1.Items.Add("09");
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Items.Add("11");
            this.domainUpDown1.Items.Add("12");
            this.domainUpDown1.Items.Add("13");
            this.domainUpDown1.Items.Add("14");
            this.domainUpDown1.Items.Add("15");
            this.domainUpDown1.Items.Add("16");
            this.domainUpDown1.Items.Add("17");
            this.domainUpDown1.Items.Add("18");
            this.domainUpDown1.Items.Add("19");
            this.domainUpDown1.Items.Add("20");
            this.domainUpDown1.Items.Add("21");
            this.domainUpDown1.Items.Add("22");
            this.domainUpDown1.Items.Add("23");
            this.domainUpDown1.Location = new System.Drawing.Point(484, 263);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(57, 33);
            this.domainUpDown1.TabIndex = 53;
            this.domainUpDown1.Text = "12";
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.domainUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domainUpDown2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDown2.ForeColor = System.Drawing.Color.White;
            this.domainUpDown2.Items.Add("00");
            this.domainUpDown2.Items.Add("01");
            this.domainUpDown2.Items.Add("02");
            this.domainUpDown2.Items.Add("03");
            this.domainUpDown2.Items.Add("04");
            this.domainUpDown2.Items.Add("05");
            this.domainUpDown2.Items.Add("06");
            this.domainUpDown2.Items.Add("07");
            this.domainUpDown2.Items.Add("08");
            this.domainUpDown2.Items.Add("09");
            this.domainUpDown2.Items.Add("10");
            this.domainUpDown2.Items.Add("11");
            this.domainUpDown2.Items.Add("12");
            this.domainUpDown2.Items.Add("13");
            this.domainUpDown2.Items.Add("14");
            this.domainUpDown2.Items.Add("15");
            this.domainUpDown2.Items.Add("16");
            this.domainUpDown2.Items.Add("17");
            this.domainUpDown2.Items.Add("18");
            this.domainUpDown2.Items.Add("19");
            this.domainUpDown2.Items.Add("20");
            this.domainUpDown2.Items.Add("21");
            this.domainUpDown2.Items.Add("22");
            this.domainUpDown2.Items.Add("23");
            this.domainUpDown2.Items.Add("24");
            this.domainUpDown2.Items.Add("25");
            this.domainUpDown2.Items.Add("26");
            this.domainUpDown2.Items.Add("27");
            this.domainUpDown2.Items.Add("28");
            this.domainUpDown2.Items.Add("29");
            this.domainUpDown2.Items.Add("30");
            this.domainUpDown2.Items.Add("31");
            this.domainUpDown2.Items.Add("32");
            this.domainUpDown2.Items.Add("33");
            this.domainUpDown2.Items.Add("34");
            this.domainUpDown2.Items.Add("35");
            this.domainUpDown2.Items.Add("36");
            this.domainUpDown2.Items.Add("37");
            this.domainUpDown2.Items.Add("38");
            this.domainUpDown2.Items.Add("39");
            this.domainUpDown2.Items.Add("40");
            this.domainUpDown2.Items.Add("41");
            this.domainUpDown2.Items.Add("42");
            this.domainUpDown2.Items.Add("43");
            this.domainUpDown2.Items.Add("44");
            this.domainUpDown2.Items.Add("45");
            this.domainUpDown2.Items.Add("46");
            this.domainUpDown2.Items.Add("47");
            this.domainUpDown2.Items.Add("48");
            this.domainUpDown2.Items.Add("49");
            this.domainUpDown2.Items.Add("50");
            this.domainUpDown2.Items.Add("51");
            this.domainUpDown2.Items.Add("52");
            this.domainUpDown2.Items.Add("53");
            this.domainUpDown2.Items.Add("54");
            this.domainUpDown2.Items.Add("55");
            this.domainUpDown2.Items.Add("56");
            this.domainUpDown2.Items.Add("57");
            this.domainUpDown2.Items.Add("58");
            this.domainUpDown2.Items.Add("59");
            this.domainUpDown2.Location = new System.Drawing.Point(559, 263);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(57, 33);
            this.domainUpDown2.TabIndex = 54;
            this.domainUpDown2.Text = "00";
            // 
            // AddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Aeropuerto.Properties.Resources.vuelo2;
            this.ClientSize = new System.Drawing.Size(682, 550);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFlight";
            this.Text = "AddFlight";
            this.Load += new System.EventHandler(this.AddFlight_Load);
            this.VisibleChanged += new System.EventHandler(this.AddFlight_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton internacional;
        private System.Windows.Forms.RadioButton nacional;
        private System.Windows.Forms.RadioButton salida;
        private System.Windows.Forms.RadioButton arribo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
    }
}