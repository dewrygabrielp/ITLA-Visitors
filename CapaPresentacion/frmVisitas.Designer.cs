namespace CapaPresentacion
{
    partial class frmVisitas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisitas));
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEntryTime = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.cbxEdificio = new System.Windows.Forms.ComboBox();
            this.cbxCarrera = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.bunifuDragTop = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pcbTitulo = new System.Windows.Forms.PictureBox();
            this.cbxAula = new System.Windows.Forms.ComboBox();
            this.lblAula = new System.Windows.Forms.Label();
            this.ErrorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdVisita = new System.Windows.Forms.TextBox();
            this.btnLimpiarImagen = new System.Windows.Forms.PictureBox();
            this.btnCargarImagen = new System.Windows.Forms.PictureBox();
            this.pcbPhoto = new System.Windows.Forms.PictureBox();
            this.txtApellido = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiarImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCargarImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(494, 337);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(62, 20);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Edifice:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(515, 226);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reason:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(478, 443);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Departure Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(157, 443);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Entry Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(169, 385);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(169, 334);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Career:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(152, 275);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Last Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(169, 219);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Name:";
            // 
            // dtpEntryTime
            // 
            this.dtpEntryTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntryTime.Location = new System.Drawing.Point(257, 443);
            this.dtpEntryTime.Name = "dtpEntryTime";
            this.dtpEntryTime.Size = new System.Drawing.Size(127, 22);
            this.dtpEntryTime.TabIndex = 24;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskedTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(104)))), ((int)(((byte)(175)))));
            this.maskedTextBox1.HidePromptOnLeave = true;
            this.maskedTextBox1.Location = new System.Drawing.Point(251, 393);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ResetOnPrompt = false;
            this.maskedTextBox1.ResetOnSpace = false;
            this.maskedTextBox1.Size = new System.Drawing.Size(184, 22);
            this.maskedTextBox1.TabIndex = 25;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkbMail_MaskInputRejected);
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDepartureTime.Location = new System.Drawing.Point(618, 441);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.Size = new System.Drawing.Size(127, 22);
            this.dtpDepartureTime.TabIndex = 32;
            // 
            // cbxEdificio
            // 
            this.cbxEdificio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxEdificio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(104)))), ((int)(((byte)(175)))));
            this.cbxEdificio.FormattingEnabled = true;
            this.cbxEdificio.Location = new System.Drawing.Point(604, 337);
            this.cbxEdificio.Name = "cbxEdificio";
            this.cbxEdificio.Size = new System.Drawing.Size(125, 25);
            this.cbxEdificio.TabIndex = 33;
            // 
            // cbxCarrera
            // 
            this.cbxCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxCarrera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(104)))), ((int)(((byte)(175)))));
            this.cbxCarrera.FormattingEnabled = true;
            this.cbxCarrera.Location = new System.Drawing.Point(251, 337);
            this.cbxCarrera.Name = "cbxCarrera";
            this.cbxCarrera.Size = new System.Drawing.Size(125, 25);
            this.cbxCarrera.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(328, 132);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Photo:";
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(104)))), ((int)(((byte)(175)))));
            this.txtReason.Location = new System.Drawing.Point(604, 219);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReason.Size = new System.Drawing.Size(179, 93);
            this.txtReason.TabIndex = 37;
            // 
            // btnBack
            // 
            this.btnBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnBack.Controls.Add(this.pictureBox2);
            this.btnBack.Controls.Add(this.pictureBox3);
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(187, 61);
            this.btnBack.TabIndex = 43;
            this.btnBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.flechaback;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.btnBackInquieres;
            this.pictureBox3.Location = new System.Drawing.Point(49, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(809, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnMin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMin.Size = new System.Drawing.Size(38, 67);
            this.btnMin.TabIndex = 44;
            this.btnMin.Text = "-";
            this.btnMin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(847, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.btnCerrar.Size = new System.Drawing.Size(38, 67);
            this.btnCerrar.TabIndex = 45;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // bunifuDragTop
            // 
            this.bunifuDragTop.Fixed = true;
            this.bunifuDragTop.Horizontal = true;
            this.bunifuDragTop.TargetControl = this.pcbTitulo;
            this.bunifuDragTop.Vertical = true;
            // 
            // pcbTitulo
            // 
            this.pcbTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcbTitulo.Image = global::CapaPresentacion.Properties.Resources.TitleRegisterVisitors;
            this.pcbTitulo.Location = new System.Drawing.Point(0, 0);
            this.pcbTitulo.Name = "pcbTitulo";
            this.pcbTitulo.Size = new System.Drawing.Size(886, 67);
            this.pcbTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbTitulo.TabIndex = 38;
            this.pcbTitulo.TabStop = false;
            // 
            // cbxAula
            // 
            this.cbxAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxAula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(104)))), ((int)(((byte)(175)))));
            this.cbxAula.FormattingEnabled = true;
            this.cbxAula.Location = new System.Drawing.Point(640, 393);
            this.cbxAula.Name = "cbxAula";
            this.cbxAula.Size = new System.Drawing.Size(125, 25);
            this.cbxAula.TabIndex = 47;
            // 
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAula.Location = new System.Drawing.Point(494, 395);
            this.lblAula.Name = "lblAula";
            this.lblAula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAula.Size = new System.Drawing.Size(130, 20);
            this.lblAula.TabIndex = 46;
            this.lblAula.Text = "Site or classroom";
            // 
            // ErrorIcon
            // 
            this.ErrorIcon.ContainerControl = this;
            // 
            // ttmensaje
            // 
            this.ttmensaje.IsBalloon = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(98, 132);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Visitor No. :";
            this.label9.Visible = false;
            // 
            // txtIdVisita
            // 
            this.txtIdVisita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdVisita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdVisita.ForeColor = System.Drawing.Color.White;
            this.txtIdVisita.Location = new System.Drawing.Point(193, 132);
            this.txtIdVisita.Name = "txtIdVisita";
            this.txtIdVisita.Size = new System.Drawing.Size(100, 22);
            this.txtIdVisita.TabIndex = 49;
            this.txtIdVisita.Visible = false;
            // 
            // btnLimpiarImagen
            // 
            this.btnLimpiarImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnLimpiarImagen.Image = global::CapaPresentacion.Properties.Resources.icons8_formato_claro_48;
            this.btnLimpiarImagen.Location = new System.Drawing.Point(550, 154);
            this.btnLimpiarImagen.Name = "btnLimpiarImagen";
            this.btnLimpiarImagen.Size = new System.Drawing.Size(53, 50);
            this.btnLimpiarImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnLimpiarImagen.TabIndex = 51;
            this.btnLimpiarImagen.TabStop = false;
            this.btnLimpiarImagen.Click += new System.EventHandler(this.btnLimpiarImagen_Click_1);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCargarImagen.Image = global::CapaPresentacion.Properties.Resources.icons8_subir_48;
            this.btnCargarImagen.Location = new System.Drawing.Point(550, 88);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(53, 48);
            this.btnCargarImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCargarImagen.TabIndex = 50;
            this.btnCargarImagen.TabStop = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click_1);
            // 
            // pcbPhoto
            // 
            this.pcbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbPhoto.Image = global::CapaPresentacion.Properties.Resources.file;
            this.pcbPhoto.Location = new System.Drawing.Point(406, 88);
            this.pcbPhoto.Name = "pcbPhoto";
            this.pcbPhoto.Size = new System.Drawing.Size(124, 115);
            this.pcbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPhoto.TabIndex = 36;
            this.pcbPhoto.TabStop = false;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtApellido.BackgroundImage")));
            this.txtApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtApellido.Icon = ((System.Drawing.Image)(resources.GetObject("txtApellido.Icon")));
            this.txtApellido.Location = new System.Drawing.Point(251, 256);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(193, 56);
            this.txtApellido.TabIndex = 31;
            this.txtApellido.text = "";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNombre.BackgroundImage")));
            this.txtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtNombre.Icon = ((System.Drawing.Image)(resources.GetObject("txtNombre.Icon")));
            this.txtNombre.Location = new System.Drawing.Point(251, 197);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(193, 71);
            this.txtNombre.TabIndex = 26;
            this.txtNombre.text = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(677, 165);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 38);
            this.btnGuardar.TabIndex = 52;
            this.btnGuardar.Text = "Save";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(468, 503);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(133, 38);
            this.btnEditar.TabIndex = 53;
            this.btnEditar.Text = "Edit";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(640, 503);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 38);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "Cancel";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(677, 98);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(157, 54);
            this.btnRegistrar.TabIndex = 55;
            this.btnRegistrar.Text = "Register new";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(886, 588);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiarImagen);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.txtIdVisita);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxAula);
            this.Controls.Add(this.lblAula);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pcbTitulo);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.pcbPhoto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxCarrera);
            this.Controls.Add(this.cbxEdificio);
            this.Controls.Add(this.dtpDepartureTime);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dtpEntryTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmVisitas";
            this.Opacity = 0.95D;
            this.Text = "frmVisitas";
            this.Load += new System.EventHandler(this.frmVisitas_Load);
            this.btnBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiarImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCargarImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEntryTime;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private Bunifu.Framework.UI.BunifuTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuTextbox txtApellido;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.ComboBox cbxEdificio;
        private System.Windows.Forms.ComboBox cbxCarrera;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pcbPhoto;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.PictureBox pcbTitulo;
        private System.Windows.Forms.Panel btnBack;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label btnMin;
        private System.Windows.Forms.Label btnCerrar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragTop;
        private System.Windows.Forms.ComboBox cbxAula;
        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.ErrorProvider ErrorIcon;
        private System.Windows.Forms.ToolTip ttmensaje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdVisita;
        private System.Windows.Forms.PictureBox btnLimpiarImagen;
        private System.Windows.Forms.PictureBox btnCargarImagen;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}