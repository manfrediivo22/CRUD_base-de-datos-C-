
namespace Ejercicio_Controles
{
    partial class Ejer_Controles
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejer_Controles));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_lista = new System.Windows.Forms.TextBox();
            this.bt_borrar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.bt_Salir = new System.Windows.Forms.Button();
            this.lst_preferencia = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_Nuevo = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_NACIONALIDAD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RB_O = new System.Windows.Forms.RadioButton();
            this.RB_F = new System.Windows.Forms.RadioButton();
            this.RB_M = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 43);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(799, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos Opcionales";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.txt_lista);
            this.groupBox3.Controls.Add(this.bt_borrar);
            this.groupBox3.Controls.Add(this.bt_agregar);
            this.groupBox3.Controls.Add(this.bt_Salir);
            this.groupBox3.Controls.Add(this.lst_preferencia);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.bt_Nuevo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(-4, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(803, 541);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Otros Datos de usuario";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txt_lista
            // 
            this.txt_lista.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_lista.Location = new System.Drawing.Point(15, 228);
            this.txt_lista.Multiline = true;
            this.txt_lista.Name = "txt_lista";
            this.txt_lista.Size = new System.Drawing.Size(184, 34);
            this.txt_lista.TabIndex = 6;
            this.txt_lista.TextChanged += new System.EventHandler(this.txt_lista_TextChanged);
            // 
            // bt_borrar
            // 
            this.bt_borrar.BackColor = System.Drawing.Color.Indigo;
            this.bt_borrar.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_borrar.Location = new System.Drawing.Point(665, 120);
            this.bt_borrar.Name = "bt_borrar";
            this.bt_borrar.Size = new System.Drawing.Size(132, 61);
            this.bt_borrar.TabIndex = 5;
            this.bt_borrar.Text = "Borrar Lista";
            this.bt_borrar.UseVisualStyleBackColor = false;
            this.bt_borrar.Click += new System.EventHandler(this.bt_borrar_Click);
            this.bt_borrar.MouseEnter += new System.EventHandler(this.bt_borrar_MouseEnter);
            this.bt_borrar.MouseLeave += new System.EventHandler(this.bt_borrar_MouseLeave);
            // 
            // bt_agregar
            // 
            this.bt_agregar.ForeColor = System.Drawing.Color.Black;
            this.bt_agregar.Image = ((System.Drawing.Image)(resources.GetObject("bt_agregar.Image")));
            this.bt_agregar.Location = new System.Drawing.Point(53, 54);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(112, 167);
            this.bt_agregar.TabIndex = 4;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            this.bt_agregar.MouseEnter += new System.EventHandler(this.bt_agregar_MouseEnter);
            this.bt_agregar.MouseLeave += new System.EventHandler(this.bt_agregar_MouseLeave);
            // 
            // bt_Salir
            // 
            this.bt_Salir.BackColor = System.Drawing.Color.Yellow;
            this.bt_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Salir.ForeColor = System.Drawing.Color.Black;
            this.bt_Salir.Location = new System.Drawing.Point(672, 187);
            this.bt_Salir.Name = "bt_Salir";
            this.bt_Salir.Size = new System.Drawing.Size(113, 89);
            this.bt_Salir.TabIndex = 3;
            this.bt_Salir.Text = "Salir";
            this.bt_Salir.UseVisualStyleBackColor = false;
            this.bt_Salir.Click += new System.EventHandler(this.bt_Salir_Click);
            this.bt_Salir.MouseEnter += new System.EventHandler(this.bt_Salir_MouseEnter);
            this.bt_Salir.MouseLeave += new System.EventHandler(this.bt_Salir_MouseLeave);
            // 
            // lst_preferencia
            // 
            this.lst_preferencia.BackColor = System.Drawing.Color.Peru;
            this.lst_preferencia.Font = new System.Drawing.Font("Sitka Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_preferencia.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lst_preferencia.FormattingEnabled = true;
            this.lst_preferencia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lst_preferencia.ItemHeight = 28;
            this.lst_preferencia.Location = new System.Drawing.Point(10, 268);
            this.lst_preferencia.Name = "lst_preferencia";
            this.lst_preferencia.Size = new System.Drawing.Size(222, 144);
            this.lst_preferencia.TabIndex = 3;
            this.lst_preferencia.SelectedIndexChanged += new System.EventHandler(this.lst_preferencia_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "Preferencias";
            // 
            // bt_Nuevo
            // 
            this.bt_Nuevo.BackColor = System.Drawing.Color.Aqua;
            this.bt_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Nuevo.Location = new System.Drawing.Point(672, 25);
            this.bt_Nuevo.Name = "bt_Nuevo";
            this.bt_Nuevo.Size = new System.Drawing.Size(113, 89);
            this.bt_Nuevo.TabIndex = 1;
            this.bt_Nuevo.Text = "Nuevo";
            this.bt_Nuevo.UseVisualStyleBackColor = false;
            this.bt_Nuevo.Click += new System.EventHandler(this.bt_Nuevo_Click);
            this.bt_Nuevo.MouseEnter += new System.EventHandler(this.bt_Nuevo_MouseEnter);
            this.bt_Nuevo.MouseLeave += new System.EventHandler(this.bt_Nuevo_MouseLeave);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ForeColor = System.Drawing.Color.Blue;
            this.tabPage1.Location = new System.Drawing.Point(4, 43);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(799, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Personales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(509, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 396);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Perfil";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 365);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 29);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 255);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.CB_NACIONALIDAD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.RB_O);
            this.groupBox1.Controls.Add(this.RB_F);
            this.groupBox1.Controls.Add(this.RB_M);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Telefono);
            this.groupBox1.Controls.Add(this.txt_Direccion);
            this.groupBox1.Controls.Add(this.txt_Apellido);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 517);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Usuario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CB_NACIONALIDAD
            // 
            this.CB_NACIONALIDAD.FormattingEnabled = true;
            this.CB_NACIONALIDAD.Items.AddRange(new object[] {
            "A",
            "Afganistan",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Antigua y Barbuda",
            "Arabia Saudita / Arabia Saudí",
            "Argelia",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaiyán",
            "B",
            "Bahamas",
            "Bangladés",
            "Barbados",
            "Baréin",
            "Bélgica",
            "Belice",
            "Bielorrusia",
            "Benín",
            "Birmania / Myanmar",
            "Bolivia",
            "Bosnia y Herzegovina / Bosnia-Herzegovina",
            "Botsuana",
            "Brasil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Bután",
            "C",
            "Cabo Verde",
            "Camboya",
            "Camerún",
            "Canadá",
            "Catar",
            "República Centroafricana",
            "Chad",
            "República Checa / Chequia",
            "Chile",
            "China",
            "Chipre",
            "Colombia",
            "Comoras",
            "República del Congo",
            "República Democrática del Congo",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfil",
            "Costa Rica",
            "Croacia",
            "Cuba",
            "D",
            "Dinamarca",
            "Dominica",
            "República Dominicana",
            "E",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "Emiratos Árabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Etiopía",
            "F",
            "Filipinas",
            "Finlandia",
            "Fiyi",
            "Francia",
            "G",
            "Gabón",
            "Gambia",
            "Georgia",
            "Ghana",
            "Granada",
            "Grecia",
            "Guatemala",
            "Guinea",
            "Guinea-Bisáu",
            "Guinea Ecuatorial",
            "Guyana",
            "H",
            "Haití",
            "Honduras",
            "Hungría",
            "I",
            "India",
            "Indonesia",
            "Irak",
            "Irán",
            "Irlanda",
            "Islandia",
            "Israel",
            "Italia",
            "J",
            "Jamaica",
            "Japón",
            "Jordania",
            "K",
            "Kazajistán",
            "Kenia",
            "Kirguistán",
            "Kiribati",
            "Kuwait",
            "L",
            "Laos",
            "Lesoto",
            "Letonia",
            "Líbano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "M",
            "Macedonia del Norte",
            "Madagascar",
            "Malasia",
            "Malaui",
            "Maldivas",
            "Mali / Malí",
            "Malta",
            "Marruecos",
            "Islas Marshall",
            "Mauricio",
            "Mauritania",
            "México",
            "Micronesia",
            "Moldavia",
            "Mónaco",
            "Mongolia",
            "Montenegro",
            "Mozambique",
            "N",
            "Namibia",
            "Nauru",
            "Nepal",
            "Nicaragua",
            "Níger",
            "Nigeria",
            "Noruega",
            "Nueva Zelanda / Nueva Zelandia",
            "O",
            "Omán",
            "P",
            "Países Bajos",
            "Pakistán",
            "Palaos",
            "Palestina",
            "Panamá",
            "Papúa Nueva Guinea",
            "Paraguay",
            "Perú",
            "Polonia",
            "Portugal",
            "R",
            "Reino Unido",
            "Ruanda",
            "Rumania / Rumanía",
            "Rusia",
            "S",
            "Islas Salomón",
            "Samoa",
            "San Cristóbal y Nieves",
            "San Marino",
            "San Vicente y las Granadinas",
            "Santa Lucía",
            "Santo Tomé y Príncipe",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Siria",
            "Somalia",
            "Sri Lanka",
            "Suazilandia / Esuatini",
            "Sudáfrica",
            "Sudán",
            "Sudán del Sur",
            "Suecia",
            "Suiza",
            "Surinam",
            "T",
            "Tailandia",
            "Tanzania",
            "Tayikistán",
            "Timor Oriental",
            "Togo",
            "Tonga",
            "Trinidad y Tobago",
            "Túnez",
            "Turkmenistán",
            "Turquía",
            "Tuvalu",
            "U",
            "Ucrania",
            "Uganda",
            "Uruguay",
            "Uzbekistán",
            "V",
            "Vanuatu",
            "Ciudad del Vaticano",
            "Venezuela",
            "Vietnam",
            "Y",
            "Yemen",
            "Yibuti",
            "Z",
            "Zambia",
            "Zimbabue"});
            this.CB_NACIONALIDAD.Location = new System.Drawing.Point(273, 418);
            this.CB_NACIONALIDAD.Name = "CB_NACIONALIDAD";
            this.CB_NACIONALIDAD.Size = new System.Drawing.Size(156, 26);
            this.CB_NACIONALIDAD.TabIndex = 13;
            this.CB_NACIONALIDAD.Text = "Seleccione";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(33, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nacionalidad";
            // 
            // RB_O
            // 
            this.RB_O.AutoSize = true;
            this.RB_O.BackColor = System.Drawing.Color.Transparent;
            this.RB_O.ForeColor = System.Drawing.Color.Cyan;
            this.RB_O.Location = new System.Drawing.Point(112, 374);
            this.RB_O.Name = "RB_O";
            this.RB_O.Size = new System.Drawing.Size(60, 22);
            this.RB_O.TabIndex = 11;
            this.RB_O.Text = "Otro";
            this.RB_O.UseVisualStyleBackColor = false;
            // 
            // RB_F
            // 
            this.RB_F.AutoSize = true;
            this.RB_F.BackColor = System.Drawing.Color.Transparent;
            this.RB_F.ForeColor = System.Drawing.Color.Cyan;
            this.RB_F.Location = new System.Drawing.Point(112, 346);
            this.RB_F.Name = "RB_F";
            this.RB_F.Size = new System.Drawing.Size(100, 22);
            this.RB_F.TabIndex = 10;
            this.RB_F.Text = "Femenino";
            this.RB_F.UseVisualStyleBackColor = false;
            // 
            // RB_M
            // 
            this.RB_M.AutoSize = true;
            this.RB_M.BackColor = System.Drawing.Color.Transparent;
            this.RB_M.ForeColor = System.Drawing.Color.Cyan;
            this.RB_M.Location = new System.Drawing.Point(112, 318);
            this.RB_M.Name = "RB_M";
            this.RB_M.Size = new System.Drawing.Size(103, 22);
            this.RB_M.TabIndex = 9;
            this.RB_M.Text = "Masculino";
            this.RB_M.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(6, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sexo";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Telefono.Location = new System.Drawing.Point(217, 168);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(212, 24);
            this.txt_Telefono.TabIndex = 7;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Direccion.Location = new System.Drawing.Point(217, 130);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(212, 24);
            this.txt_Direccion.TabIndex = 6;
            this.txt_Direccion.TextChanged += new System.EventHandler(this.txt_Direccion_TextChanged);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Apellido.Location = new System.Drawing.Point(217, 91);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(212, 24);
            this.txt_Apellido.TabIndex = 5;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Nombre.Location = new System.Drawing.Point(217, 48);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(212, 24);
            this.txt_Nombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(33, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(33, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(33, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(40, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 577);
            this.tabControl1.TabIndex = 0;
            // 
            // Ejer_Controles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(818, 592);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ejer_Controles";
            this.Text = "Controles";
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_Salir;
        private System.Windows.Forms.ListBox lst_preferencia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_Nuevo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CB_NACIONALIDAD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RB_O;
        private System.Windows.Forms.RadioButton RB_F;
        private System.Windows.Forms.RadioButton RB_M;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button bt_borrar;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.TextBox txt_lista;
    }
}

