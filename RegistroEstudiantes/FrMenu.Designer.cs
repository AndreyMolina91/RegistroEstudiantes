
namespace RegistroEstudiantes
{
    partial class FrMenu
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
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.Labelemail = new System.Windows.Forms.Label();
            this.TextBoxNID = new System.Windows.Forms.TextBox();
            this.Labelnid = new System.Windows.Forms.Label();
            this.TextBoxApellido = new System.Windows.Forms.TextBox();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.Labelapellido = new System.Windows.Forms.Label();
            this.Labelnombre = new System.Windows.Forms.Label();
            this.buttonFotoEstudiante = new System.Windows.Forms.Button();
            this.pictureBoxFotoEstudiante = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GridViewEstudiantes = new System.Windows.Forms.DataGridView();
            this.ButtonPrimerPag = new System.Windows.Forms.Button();
            this.buttonAntPagina = new System.Windows.Forms.Button();
            this.buttonSigPagina = new System.Windows.Forms.Button();
            this.buttonUltPagina = new System.Windows.Forms.Button();
            this.labelNumPagina = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.TextBoxBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalirSistema = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Red;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(339, 542);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(87, 31);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.Crimson;
            this.buttonCancelar.Location = new System.Drawing.Point(432, 542);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(87, 31);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAgregar.FlatAppearance.BorderSize = 0;
            this.buttonAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.Color.White;
            this.buttonAgregar.Location = new System.Drawing.Point(246, 542);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(87, 31);
            this.buttonAgregar.TabIndex = 5;
            this.buttonAgregar.Text = "AGREGAR";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.BackColor = System.Drawing.Color.White;
            this.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxEmail.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxEmail.Location = new System.Drawing.Point(269, 458);
            this.TextBoxEmail.Multiline = true;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(228, 18);
            this.TextBoxEmail.TabIndex = 3;
            this.TextBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            this.TextBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEmail_KeyPress);
            // 
            // Labelemail
            // 
            this.Labelemail.AutoSize = true;
            this.Labelemail.BackColor = System.Drawing.Color.Transparent;
            this.Labelemail.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelemail.ForeColor = System.Drawing.Color.White;
            this.Labelemail.Location = new System.Drawing.Point(271, 437);
            this.Labelemail.Name = "Labelemail";
            this.Labelemail.Size = new System.Drawing.Size(42, 15);
            this.Labelemail.TabIndex = 7;
            this.Labelemail.Text = "email";
            // 
            // TextBoxNID
            // 
            this.TextBoxNID.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxNID.Location = new System.Drawing.Point(269, 416);
            this.TextBoxNID.Multiline = true;
            this.TextBoxNID.Name = "TextBoxNID";
            this.TextBoxNID.Size = new System.Drawing.Size(228, 18);
            this.TextBoxNID.TabIndex = 2;
            this.TextBoxNID.TextChanged += new System.EventHandler(this.TextBoxNID_TextChanged);
            this.TextBoxNID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNID_KeyPress);
            // 
            // Labelnid
            // 
            this.Labelnid.AutoSize = true;
            this.Labelnid.BackColor = System.Drawing.Color.Transparent;
            this.Labelnid.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelnid.ForeColor = System.Drawing.Color.White;
            this.Labelnid.Location = new System.Drawing.Point(271, 395);
            this.Labelnid.Name = "Labelnid";
            this.Labelnid.Size = new System.Drawing.Size(28, 15);
            this.Labelnid.TabIndex = 5;
            this.Labelnid.Text = "NID";
            // 
            // TextBoxApellido
            // 
            this.TextBoxApellido.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxApellido.Location = new System.Drawing.Point(269, 374);
            this.TextBoxApellido.Multiline = true;
            this.TextBoxApellido.Name = "TextBoxApellido";
            this.TextBoxApellido.Size = new System.Drawing.Size(228, 18);
            this.TextBoxApellido.TabIndex = 1;
            this.TextBoxApellido.TextChanged += new System.EventHandler(this.TextBoxApellido_TextChanged);
            this.TextBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxApellido_KeyPress);
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxNombre.Location = new System.Drawing.Point(269, 332);
            this.TextBoxNombre.Multiline = true;
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(228, 18);
            this.TextBoxNombre.TabIndex = 0;
            this.TextBoxNombre.TextChanged += new System.EventHandler(this.TextBoxNombre_TextChanged);
            this.TextBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNombre_KeyPress);
            // 
            // Labelapellido
            // 
            this.Labelapellido.AutoSize = true;
            this.Labelapellido.BackColor = System.Drawing.Color.Transparent;
            this.Labelapellido.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelapellido.ForeColor = System.Drawing.Color.White;
            this.Labelapellido.Location = new System.Drawing.Point(271, 353);
            this.Labelapellido.Name = "Labelapellido";
            this.Labelapellido.Size = new System.Drawing.Size(63, 15);
            this.Labelapellido.TabIndex = 3;
            this.Labelapellido.Text = "Apellido";
            // 
            // Labelnombre
            // 
            this.Labelnombre.AutoSize = true;
            this.Labelnombre.BackColor = System.Drawing.Color.Transparent;
            this.Labelnombre.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelnombre.ForeColor = System.Drawing.Color.White;
            this.Labelnombre.Location = new System.Drawing.Point(271, 311);
            this.Labelnombre.Name = "Labelnombre";
            this.Labelnombre.Size = new System.Drawing.Size(49, 15);
            this.Labelnombre.TabIndex = 1;
            this.Labelnombre.Text = "Nombre";
            // 
            // buttonFotoEstudiante
            // 
            this.buttonFotoEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.buttonFotoEstudiante.BackgroundImage = global::RegistroEstudiantes.Properties.Resources.buscarfoto;
            this.buttonFotoEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFotoEstudiante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFotoEstudiante.FlatAppearance.BorderSize = 0;
            this.buttonFotoEstudiante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonFotoEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonFotoEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFotoEstudiante.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFotoEstudiante.ForeColor = System.Drawing.Color.White;
            this.buttonFotoEstudiante.Location = new System.Drawing.Point(380, 257);
            this.buttonFotoEstudiante.Name = "buttonFotoEstudiante";
            this.buttonFotoEstudiante.Size = new System.Drawing.Size(32, 31);
            this.buttonFotoEstudiante.TabIndex = 4;
            this.buttonFotoEstudiante.UseVisualStyleBackColor = false;
            this.buttonFotoEstudiante.Click += new System.EventHandler(this.buttonFotoEstudiante_Click);
            // 
            // pictureBoxFotoEstudiante
            // 
            this.pictureBoxFotoEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFotoEstudiante.Image = global::RegistroEstudiantes.Properties.Resources.logoestudiante;
            this.pictureBoxFotoEstudiante.Location = new System.Drawing.Point(269, 170);
            this.pictureBoxFotoEstudiante.Name = "pictureBoxFotoEstudiante";
            this.pictureBoxFotoEstudiante.Size = new System.Drawing.Size(143, 118);
            this.pictureBoxFotoEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFotoEstudiante.TabIndex = 0;
            this.pictureBoxFotoEstudiante.TabStop = false;
            this.pictureBoxFotoEstudiante.Click += new System.EventHandler(this.pictureBoxFotoEstudiante_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(266, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "INFORMACIÓN ESTUDIANTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(564, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "LISTADO ESTUDIANTES";
            // 
            // GridViewEstudiantes
            // 
            this.GridViewEstudiantes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GridViewEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewEstudiantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridViewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewEstudiantes.Location = new System.Drawing.Point(567, 170);
            this.GridViewEstudiantes.Name = "GridViewEstudiantes";
            this.GridViewEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewEstudiantes.Size = new System.Drawing.Size(449, 368);
            this.GridViewEstudiantes.TabIndex = 0;
            this.GridViewEstudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewEstudiantes_CellClick);
            this.GridViewEstudiantes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GridViewEstudiantes_KeyUp);
            // 
            // ButtonPrimerPag
            // 
            this.ButtonPrimerPag.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPrimerPag.BackgroundImage = global::RegistroEstudiantes.Properties.Resources.primero;
            this.ButtonPrimerPag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonPrimerPag.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonPrimerPag.FlatAppearance.BorderSize = 0;
            this.ButtonPrimerPag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonPrimerPag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonPrimerPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPrimerPag.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPrimerPag.ForeColor = System.Drawing.Color.White;
            this.ButtonPrimerPag.Location = new System.Drawing.Point(707, 552);
            this.ButtonPrimerPag.Name = "ButtonPrimerPag";
            this.ButtonPrimerPag.Size = new System.Drawing.Size(32, 27);
            this.ButtonPrimerPag.TabIndex = 9;
            this.ButtonPrimerPag.UseVisualStyleBackColor = false;
            this.ButtonPrimerPag.Click += new System.EventHandler(this.ButtonPrimerPag_Click);
            // 
            // buttonAntPagina
            // 
            this.buttonAntPagina.BackColor = System.Drawing.Color.Transparent;
            this.buttonAntPagina.BackgroundImage = global::RegistroEstudiantes.Properties.Resources.anterior;
            this.buttonAntPagina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAntPagina.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAntPagina.FlatAppearance.BorderSize = 0;
            this.buttonAntPagina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonAntPagina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAntPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAntPagina.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAntPagina.ForeColor = System.Drawing.Color.White;
            this.buttonAntPagina.Location = new System.Drawing.Point(755, 552);
            this.buttonAntPagina.Name = "buttonAntPagina";
            this.buttonAntPagina.Size = new System.Drawing.Size(18, 27);
            this.buttonAntPagina.TabIndex = 10;
            this.buttonAntPagina.UseVisualStyleBackColor = false;
            this.buttonAntPagina.Click += new System.EventHandler(this.buttonAntPagina_Click);
            // 
            // buttonSigPagina
            // 
            this.buttonSigPagina.BackColor = System.Drawing.Color.Transparent;
            this.buttonSigPagina.BackgroundImage = global::RegistroEstudiantes.Properties.Resources.siguiente;
            this.buttonSigPagina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSigPagina.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSigPagina.FlatAppearance.BorderSize = 0;
            this.buttonSigPagina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSigPagina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSigPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSigPagina.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSigPagina.ForeColor = System.Drawing.Color.White;
            this.buttonSigPagina.Location = new System.Drawing.Point(790, 552);
            this.buttonSigPagina.Name = "buttonSigPagina";
            this.buttonSigPagina.Size = new System.Drawing.Size(18, 27);
            this.buttonSigPagina.TabIndex = 11;
            this.buttonSigPagina.UseVisualStyleBackColor = false;
            this.buttonSigPagina.Click += new System.EventHandler(this.buttonSigPagina_Click);
            // 
            // buttonUltPagina
            // 
            this.buttonUltPagina.BackColor = System.Drawing.Color.Transparent;
            this.buttonUltPagina.BackgroundImage = global::RegistroEstudiantes.Properties.Resources.ultimo;
            this.buttonUltPagina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUltPagina.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonUltPagina.FlatAppearance.BorderSize = 0;
            this.buttonUltPagina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonUltPagina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonUltPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUltPagina.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUltPagina.ForeColor = System.Drawing.Color.White;
            this.buttonUltPagina.Location = new System.Drawing.Point(826, 552);
            this.buttonUltPagina.Name = "buttonUltPagina";
            this.buttonUltPagina.Size = new System.Drawing.Size(32, 27);
            this.buttonUltPagina.TabIndex = 12;
            this.buttonUltPagina.UseVisualStyleBackColor = false;
            this.buttonUltPagina.Click += new System.EventHandler(this.buttonUltPagina_Click);
            // 
            // labelNumPagina
            // 
            this.labelNumPagina.AutoSize = true;
            this.labelNumPagina.BackColor = System.Drawing.Color.Transparent;
            this.labelNumPagina.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumPagina.ForeColor = System.Drawing.Color.White;
            this.labelNumPagina.Location = new System.Drawing.Point(960, 541);
            this.labelNumPagina.Name = "labelNumPagina";
            this.labelNumPagina.Size = new System.Drawing.Size(43, 13);
            this.labelNumPagina.TabIndex = 10;
            this.labelNumPagina.Text = "Página";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(592, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "BUSCAR";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numericUpDown1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(567, 542);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 22);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // TextBoxBuscar
            // 
            this.TextBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxBuscar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxBuscar.Location = new System.Drawing.Point(595, 28);
            this.TextBoxBuscar.Multiline = true;
            this.TextBoxBuscar.Name = "TextBoxBuscar";
            this.TextBoxBuscar.Size = new System.Drawing.Size(168, 18);
            this.TextBoxBuscar.TabIndex = 8;
            this.TextBoxBuscar.TextChanged += new System.EventHandler(this.TextBoxBuscar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RegistroEstudiantes.Properties.Resources.iconopngsistema;
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::RegistroEstudiantes.Properties.Resources.buscarfoto;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(567, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // btnSalirSistema
            // 
            this.btnSalirSistema.BackColor = System.Drawing.Color.Transparent;
            this.btnSalirSistema.BackgroundImage = global::RegistroEstudiantes.Properties.Resources.salir;
            this.btnSalirSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalirSistema.FlatAppearance.BorderSize = 0;
            this.btnSalirSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirSistema.Location = new System.Drawing.Point(1016, 4);
            this.btnSalirSistema.Name = "btnSalirSistema";
            this.btnSalirSistema.Size = new System.Drawing.Size(50, 42);
            this.btnSalirSistema.TabIndex = 17;
            this.btnSalirSistema.UseVisualStyleBackColor = false;
            this.btnSalirSistema.Click += new System.EventHandler(this.btnSalirSistema_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(1025, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "SALIR";
            // 
            // FrMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::RegistroEstudiantes.Properties.Resources.fondogeneral1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 621);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirSistema);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextBoxBuscar);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNumPagina);
            this.Controls.Add(this.buttonUltPagina);
            this.Controls.Add(this.buttonSigPagina);
            this.Controls.Add(this.buttonAntPagina);
            this.Controls.Add(this.ButtonPrimerPag);
            this.Controls.Add(this.GridViewEstudiantes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonFotoEstudiante);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.pictureBoxFotoEstudiante);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.Labelemail);
            this.Controls.Add(this.TextBoxNID);
            this.Controls.Add(this.Labelnid);
            this.Controls.Add(this.TextBoxNombre);
            this.Controls.Add(this.TextBoxApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Labelnombre);
            this.Controls.Add(this.Labelapellido);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label Labelemail;
        private System.Windows.Forms.TextBox TextBoxNID;
        private System.Windows.Forms.Label Labelnid;
        private System.Windows.Forms.TextBox TextBoxApellido;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.Label Labelapellido;
        private System.Windows.Forms.Label Labelnombre;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.PictureBox pictureBoxFotoEstudiante;
        private System.Windows.Forms.Button buttonFotoEstudiante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView GridViewEstudiantes;
        private System.Windows.Forms.Button ButtonPrimerPag;
        private System.Windows.Forms.Button buttonAntPagina;
        private System.Windows.Forms.Button buttonSigPagina;
        private System.Windows.Forms.Button buttonUltPagina;
        private System.Windows.Forms.Label labelNumPagina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox TextBoxBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalirSistema;
        private System.Windows.Forms.Label label1;
    }
}

