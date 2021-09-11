namespace CapaPresentacion
{
    partial class frmConsultarVisitas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVisitantes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cbxEdificio = new System.Windows.Forms.ComboBox();
            this.lblEdificio = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragTop = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pcbTitulo = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pcbPhoto = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.RowEliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblEdificie = new System.Windows.Forms.Label();
            this.lblclass = new System.Windows.Forms.Label();
            this.lblcar = new System.Windows.Forms.Label();
            this.lblnam = new System.Windows.Forms.Label();
            this.lbllast = new System.Windows.Forms.Label();
            this.lblreas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitantes)).BeginInit();
            this.btnBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisitantes
            // 
            this.dgvVisitantes.AllowUserToAddRows = false;
            this.dgvVisitantes.AllowUserToDeleteRows = false;
            this.dgvVisitantes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvVisitantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVisitantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisitantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvVisitantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVisitantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisitantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVisitantes.ColumnHeadersHeight = 28;
            this.dgvVisitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVisitantes.ColumnHeadersVisible = false;
            this.dgvVisitantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowEliminar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVisitantes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVisitantes.DoubleBuffered = true;
            this.dgvVisitantes.EnableHeadersVisualStyles = false;
            this.dgvVisitantes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvVisitantes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvVisitantes.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvVisitantes.Location = new System.Drawing.Point(2, 233);
            this.dgvVisitantes.Name = "dgvVisitantes";
            this.dgvVisitantes.ReadOnly = true;
            this.dgvVisitantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVisitantes.RowHeadersVisible = false;
            this.dgvVisitantes.RowHeadersWidth = 46;
            this.dgvVisitantes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVisitantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisitantes.Size = new System.Drawing.Size(1029, 218);
            this.dgvVisitantes.TabIndex = 0;
            this.dgvVisitantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisitantes_CellContentClick);
            this.dgvVisitantes.Click += new System.EventHandler(this.dgvVisitantes_Click);
            // 
            // cbxEdificio
            // 
            this.cbxEdificio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxEdificio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(104)))), ((int)(((byte)(175)))));
            this.cbxEdificio.FormattingEnabled = true;
            this.cbxEdificio.Location = new System.Drawing.Point(112, 96);
            this.cbxEdificio.Name = "cbxEdificio";
            this.cbxEdificio.Size = new System.Drawing.Size(125, 25);
            this.cbxEdificio.TabIndex = 37;
            this.cbxEdificio.Click += new System.EventHandler(this.cbxEdificio_Click);
            // 
            // lblEdificio
            // 
            this.lblEdificio.AutoSize = true;
            this.lblEdificio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdificio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEdificio.Location = new System.Drawing.Point(16, 94);
            this.lblEdificio.Name = "lblEdificio";
            this.lblEdificio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEdificio.Size = new System.Drawing.Size(74, 22);
            this.lblEdificio.TabIndex = 34;
            this.lblEdificio.Text = "Edifice:";
            // 
            // btnBack
            // 
            this.btnBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnBack.Controls.Add(this.pictureBox2);
            this.btnBack.Controls.Add(this.pictureBox1);
            this.btnBack.Location = new System.Drawing.Point(2, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(187, 61);
            this.btnBack.TabIndex = 42;
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
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.btnBackInquieres;
            this.pictureBox1.Location = new System.Drawing.Point(49, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.pcbTitulo.Image = global::CapaPresentacion.Properties.Resources.TitleInquieres;
            this.pcbTitulo.Location = new System.Drawing.Point(0, 0);
            this.pcbTitulo.Name = "pcbTitulo";
            this.pcbTitulo.Size = new System.Drawing.Size(1031, 61);
            this.pcbTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbTitulo.TabIndex = 39;
            this.pcbTitulo.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Yi Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(955, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Padding = new System.Windows.Forms.Padding(7, 20, 0, 5);
            this.btnMin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMin.Size = new System.Drawing.Size(38, 61);
            this.btnMin.TabIndex = 46;
            this.btnMin.Text = "-";
            this.btnMin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Yi Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(993, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.btnCerrar.Size = new System.Drawing.Size(37, 61);
            this.btnCerrar.TabIndex = 47;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotal.Location = new System.Drawing.Point(316, 94);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(53, 22);
            this.lblTotal.TabIndex = 48;
            this.lblTotal.Text = "Total";
            // 
            // pcbPhoto
            // 
            this.pcbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbPhoto.Image = global::CapaPresentacion.Properties.Resources.file;
            this.pcbPhoto.Location = new System.Drawing.Point(510, 67);
            this.pcbPhoto.Name = "pcbPhoto";
            this.pcbPhoto.Size = new System.Drawing.Size(124, 113);
            this.pcbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPhoto.TabIndex = 49;
            this.pcbPhoto.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(676, 100);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 37);
            this.btnEliminar.TabIndex = 50;
            this.btnEliminar.Text = "Delete";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.chkEliminar.Image = global::CapaPresentacion.Properties.Resources.icons8_eliminar_48;
            this.chkEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkEliminar.Location = new System.Drawing.Point(811, 96);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkEliminar.Size = new System.Drawing.Size(176, 48);
            this.chkEliminar.TabIndex = 51;
            this.chkEliminar.Text = "Press  for delete";
            this.chkEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // RowEliminar
            // 
            this.RowEliminar.HeaderText = "Delete";
            this.RowEliminar.Name = "RowEliminar";
            this.RowEliminar.ReadOnly = true;
            this.RowEliminar.Visible = false;
            // 
            // lblEdificie
            // 
            this.lblEdificie.AutoSize = true;
            this.lblEdificie.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdificie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEdificie.Location = new System.Drawing.Point(38, 208);
            this.lblEdificie.Name = "lblEdificie";
            this.lblEdificie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEdificie.Size = new System.Drawing.Size(51, 17);
            this.lblEdificie.TabIndex = 52;
            this.lblEdificie.Text = "Edificie";
            // 
            // lblclass
            // 
            this.lblclass.AutoSize = true;
            this.lblclass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblclass.Location = new System.Drawing.Point(172, 208);
            this.lblclass.Name = "lblclass";
            this.lblclass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblclass.Size = new System.Drawing.Size(69, 17);
            this.lblclass.TabIndex = 53;
            this.lblclass.Text = "Classroom";
            // 
            // lblcar
            // 
            this.lblcar.AutoSize = true;
            this.lblcar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcar.Location = new System.Drawing.Point(297, 208);
            this.lblcar.Name = "lblcar";
            this.lblcar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblcar.Size = new System.Drawing.Size(49, 17);
            this.lblcar.TabIndex = 54;
            this.lblcar.Text = "Career";
            // 
            // lblnam
            // 
            this.lblnam.AutoSize = true;
            this.lblnam.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnam.Location = new System.Drawing.Point(431, 208);
            this.lblnam.Name = "lblnam";
            this.lblnam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblnam.Size = new System.Drawing.Size(44, 17);
            this.lblnam.TabIndex = 55;
            this.lblnam.Text = "Name";
            // 
            // lbllast
            // 
            this.lbllast.AutoSize = true;
            this.lbllast.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllast.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbllast.Location = new System.Drawing.Point(535, 208);
            this.lbllast.Name = "lbllast";
            this.lbllast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbllast.Size = new System.Drawing.Size(68, 17);
            this.lbllast.TabIndex = 57;
            this.lbllast.Text = "LastName";
            // 
            // lblreas
            // 
            this.lblreas.AutoSize = true;
            this.lblreas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblreas.Location = new System.Drawing.Point(684, 208);
            this.lblreas.Name = "lblreas";
            this.lblreas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblreas.Size = new System.Drawing.Size(51, 17);
            this.lblreas.TabIndex = 58;
            this.lblreas.Text = "Reason";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(896, 208);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Entry";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(946, 208);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "Departure";
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmail.Location = new System.Drawing.Point(818, 208);
            this.lblmail.Name = "lblmail";
            this.lblmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblmail.Size = new System.Drawing.Size(33, 17);
            this.lblmail.TabIndex = 61;
            this.lblmail.Text = "Mail";
            // 
            // frmConsultarVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1031, 453);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblreas);
            this.Controls.Add(this.lbllast);
            this.Controls.Add(this.lblnam);
            this.Controls.Add(this.lblcar);
            this.Controls.Add(this.lblclass);
            this.Controls.Add(this.lblEdificie);
            this.Controls.Add(this.chkEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pcbPhoto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pcbTitulo);
            this.Controls.Add(this.cbxEdificio);
            this.Controls.Add(this.lblEdificio);
            this.Controls.Add(this.dgvVisitantes);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultarVisitas";
            this.Text = "frmConsultarVisitas";
            this.Load += new System.EventHandler(this.frmConsultarVisitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitantes)).EndInit();
            this.btnBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvVisitantes;
        private System.Windows.Forms.ComboBox cbxEdificio;
        private System.Windows.Forms.Label lblEdificio;
        private System.Windows.Forms.PictureBox pcbTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel btnBack;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragTop;
        private System.Windows.Forms.Label btnMin;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pcbPhoto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RowEliminar;
        private System.Windows.Forms.Label lblEdificie;
        private System.Windows.Forms.Label lblclass;
        private System.Windows.Forms.Label lblcar;
        private System.Windows.Forms.Label lblnam;
        private System.Windows.Forms.Label lbllast;
        private System.Windows.Forms.Label lblreas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblmail;
    }
}