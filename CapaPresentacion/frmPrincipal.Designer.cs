namespace CapaPresentacion
{
    partial class frmPrincipal
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlConfM = new System.Windows.Forms.Panel();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.lblHour = new System.Windows.Forms.Label();
            this.bdcMoverpnlTop = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.bdcMoverlblWe = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pcbITLA = new System.Windows.Forms.PictureBox();
            this.pcTitulo = new System.Windows.Forms.PictureBox();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnEdificio = new System.Windows.Forms.Button();
            this.btnCarreras = new System.Windows.Forms.Button();
            this.btnAulas = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnVisitas = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pcITLA = new System.Windows.Forms.PictureBox();
            this.pnlLeft.SuspendLayout();
            this.pnlConfM.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbITLA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcITLA)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlLeft.Controls.Add(this.btnManager);
            this.pnlLeft.Controls.Add(this.pnlConfM);
            this.pnlLeft.Controls.Add(this.lblHora);
            this.pnlLeft.Controls.Add(this.pnlMenu);
            this.pnlLeft.Controls.Add(this.btnMenu);
            this.pnlLeft.Controls.Add(this.pcITLA);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(206, 578);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlConfM
            // 
            this.pnlConfM.Controls.Add(this.btnEdificio);
            this.pnlConfM.Controls.Add(this.btnCarreras);
            this.pnlConfM.Controls.Add(this.btnAulas);
            this.pnlConfM.Controls.Add(this.btnUser);
            this.pnlConfM.Controls.Add(this.pnlDown);
            this.pnlConfM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConfM.Location = new System.Drawing.Point(0, 329);
            this.pnlConfM.Name = "pnlConfM";
            this.pnlConfM.Size = new System.Drawing.Size(206, 249);
            this.pnlConfM.TabIndex = 6;
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.Color.White;
            this.pnlDown.Location = new System.Drawing.Point(0, 200);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(715, 48);
            this.pnlDown.TabIndex = 2;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Javanese Text", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHora.Location = new System.Drawing.Point(250, 502);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(78, 54);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.btnRegistro);
            this.pnlMenu.Controls.Add(this.btnVisitas);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 182);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(206, 93);
            this.pnlMenu.TabIndex = 2;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnCerrar);
            this.panelTop.Controls.Add(this.pcTitulo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(206, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(512, 64);
            this.panelTop.TabIndex = 1;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Yi Baiti", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMin.Location = new System.Drawing.Point(430, -14);
            this.btnMin.Name = "btnMin";
            this.btnMin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.btnMin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMin.Size = new System.Drawing.Size(38, 64);
            this.btnMin.TabIndex = 48;
            this.btnMin.Text = "-";
            this.btnMin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Yi Baiti", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCerrar.Location = new System.Drawing.Point(474, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnCerrar.Size = new System.Drawing.Size(38, 64);
            this.btnCerrar.TabIndex = 49;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Controls.Add(this.pcbITLA);
            this.PanelContenedor.Controls.Add(this.lblHour);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(206, 64);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(512, 514);
            this.PanelContenedor.TabIndex = 2;
            // 
            // lblHour
            // 
            this.lblHour.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHour.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblHour.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHour.Location = new System.Drawing.Point(0, 0);
            this.lblHour.Name = "lblHour";
            this.lblHour.Padding = new System.Windows.Forms.Padding(0, 22, 0, 0);
            this.lblHour.Size = new System.Drawing.Size(512, 75);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "Fecha y hora";
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bdcMoverpnlTop
            // 
            this.bdcMoverpnlTop.Fixed = true;
            this.bdcMoverpnlTop.Horizontal = true;
            this.bdcMoverpnlTop.TargetControl = this.pcITLA;
            this.bdcMoverpnlTop.Vertical = true;
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // bdcMoverlblWe
            // 
            this.bdcMoverlblWe.Fixed = true;
            this.bdcMoverlblWe.Horizontal = true;
            this.bdcMoverlblWe.TargetControl = this.pcTitulo;
            this.bdcMoverlblWe.Vertical = true;
            // 
            // pcbITLA
            // 
            this.pcbITLA.Image = global::CapaPresentacion.Properties.Resources.pngITLA2;
            this.pcbITLA.Location = new System.Drawing.Point(3, 78);
            this.pcbITLA.Name = "pcbITLA";
            this.pcbITLA.Size = new System.Drawing.Size(506, 433);
            this.pcbITLA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbITLA.TabIndex = 1;
            this.pcbITLA.TabStop = false;
            // 
            // pcTitulo
            // 
            this.pcTitulo.Image = global::CapaPresentacion.Properties.Resources.TitleInstitute;
            this.pcTitulo.Location = new System.Drawing.Point(0, 0);
            this.pcTitulo.Name = "pcTitulo";
            this.pcTitulo.Size = new System.Drawing.Size(438, 64);
            this.pcTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcTitulo.TabIndex = 0;
            this.pcTitulo.TabStop = false;
            // 
            // btnManager
            // 
            this.btnManager.BackColor = System.Drawing.Color.White;
            this.btnManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManager.FlatAppearance.BorderSize = 0;
            this.btnManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnManager.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnManager.Image = global::CapaPresentacion.Properties.Resources.icons8_menú_24;
            this.btnManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManager.Location = new System.Drawing.Point(0, 275);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(206, 48);
            this.btnManager.TabIndex = 7;
            this.btnManager.Text = "  Configuration Manager";
            this.btnManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManager.UseCompatibleTextRendering = true;
            this.btnManager.UseVisualStyleBackColor = false;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click_1);
            // 
            // btnEdificio
            // 
            this.btnEdificio.BackColor = System.Drawing.Color.White;
            this.btnEdificio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdificio.FlatAppearance.BorderSize = 0;
            this.btnEdificio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEdificio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEdificio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdificio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEdificio.Image = global::CapaPresentacion.Properties.Resources.icons8_edificios_de_la_ciudad_48;
            this.btnEdificio.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEdificio.Location = new System.Drawing.Point(0, 149);
            this.btnEdificio.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.btnEdificio.Name = "btnEdificio";
            this.btnEdificio.Size = new System.Drawing.Size(206, 51);
            this.btnEdificio.TabIndex = 9;
            this.btnEdificio.Text = "Configuration Edifice";
            this.btnEdificio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdificio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdificio.UseCompatibleTextRendering = true;
            this.btnEdificio.UseVisualStyleBackColor = false;
            this.btnEdificio.Click += new System.EventHandler(this.btnEdificio_Click);
            // 
            // btnCarreras
            // 
            this.btnCarreras.BackColor = System.Drawing.Color.White;
            this.btnCarreras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCarreras.FlatAppearance.BorderSize = 0;
            this.btnCarreras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCarreras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCarreras.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarreras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCarreras.Image = global::CapaPresentacion.Properties.Resources.icons8_universidad_50;
            this.btnCarreras.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCarreras.Location = new System.Drawing.Point(0, 98);
            this.btnCarreras.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.btnCarreras.Name = "btnCarreras";
            this.btnCarreras.Size = new System.Drawing.Size(206, 51);
            this.btnCarreras.TabIndex = 8;
            this.btnCarreras.Text = "Configuration Career";
            this.btnCarreras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarreras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCarreras.UseCompatibleTextRendering = true;
            this.btnCarreras.UseVisualStyleBackColor = false;
            this.btnCarreras.Click += new System.EventHandler(this.btnCarreras_Click);
            // 
            // btnAulas
            // 
            this.btnAulas.BackColor = System.Drawing.Color.White;
            this.btnAulas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAulas.FlatAppearance.BorderSize = 0;
            this.btnAulas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAulas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAulas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAulas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAulas.Image = global::CapaPresentacion.Properties.Resources.icons8_cursos_48;
            this.btnAulas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAulas.Location = new System.Drawing.Point(0, 47);
            this.btnAulas.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.btnAulas.Name = "btnAulas";
            this.btnAulas.Size = new System.Drawing.Size(206, 51);
            this.btnAulas.TabIndex = 7;
            this.btnAulas.Text = "Configuration Classroom";
            this.btnAulas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAulas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAulas.UseCompatibleTextRendering = true;
            this.btnAulas.UseVisualStyleBackColor = false;
            this.btnAulas.Click += new System.EventHandler(this.btnAulas_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUser.Image = global::CapaPresentacion.Properties.Resources.icons8_herramientas_del_administrador_48;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(206, 47);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "Configuration Users";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseCompatibleTextRendering = true;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.White;
            this.btnRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRegistro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRegistro.Image = global::CapaPresentacion.Properties.Resources.icons8_editar_usuaria_48;
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(0, 45);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnRegistro.Size = new System.Drawing.Size(206, 43);
            this.btnRegistro.TabIndex = 3;
            this.btnRegistro.Text = "Register";
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistro.UseCompatibleTextRendering = true;
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnVisitas
            // 
            this.btnVisitas.BackColor = System.Drawing.Color.White;
            this.btnVisitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisitas.FlatAppearance.BorderSize = 0;
            this.btnVisitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnVisitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnVisitas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnVisitas.Image = global::CapaPresentacion.Properties.Resources.icons8_espionaje_60;
            this.btnVisitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitas.Location = new System.Drawing.Point(0, 0);
            this.btnVisitas.Name = "btnVisitas";
            this.btnVisitas.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnVisitas.Size = new System.Drawing.Size(206, 45);
            this.btnVisitas.TabIndex = 2;
            this.btnVisitas.Text = "Consult visits";
            this.btnVisitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisitas.UseCompatibleTextRendering = true;
            this.btnVisitas.UseVisualStyleBackColor = false;
            this.btnVisitas.Click += new System.EventHandler(this.btnVisitas_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMenu.Image = global::CapaPresentacion.Properties.Resources.icons8_menú_24;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 142);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(206, 40);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "    Menu";
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseCompatibleTextRendering = true;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pcITLA
            // 
            this.pcITLA.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcITLA.Image = global::CapaPresentacion.Properties.Resources.logoitla;
            this.pcITLA.Location = new System.Drawing.Point(0, 0);
            this.pcITLA.Name = "pcITLA";
            this.pcITLA.Size = new System.Drawing.Size(206, 142);
            this.pcITLA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcITLA.TabIndex = 5;
            this.pcITLA.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(718, 578);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.Opacity = 0.95D;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlConfM.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.PanelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbITLA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcITLA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnVisitas;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Label lblHora;
        private Bunifu.Framework.UI.BunifuDragControl bdcMoverpnlTop;
        private System.Windows.Forms.Timer timerHora;
        private Bunifu.Framework.UI.BunifuDragControl bdcMoverlblWe;
        private System.Windows.Forms.PictureBox pcTitulo;
        private System.Windows.Forms.PictureBox pcITLA;
        private System.Windows.Forms.Panel pnlConfM;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label btnMin;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.PictureBox pcbITLA;
        private System.Windows.Forms.Button btnEdificio;
        private System.Windows.Forms.Button btnCarreras;
        private System.Windows.Forms.Button btnAulas;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Panel pnlDown;
    }
}