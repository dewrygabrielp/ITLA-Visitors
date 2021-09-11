using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class frmConfiguration : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        
        public frmConfiguration()
        {
            InitializeComponent();
            
            chkEliminar.Checked = false;
            this.btnEliminar.Enabled = false;
            this.ttmensaje.SetToolTip(txtUsuario, "Enter username");
            this.ttmensaje.SetToolTip(txtAccess, "Select user level");
            this.ttmensaje.SetToolTip(txtPassword, "Enter a password");
        }

        ///habilitar controles
        #region Controles
        public void habilitar(bool valor)
        {
            txtNombre.ReadOnly = !valor;
            txtApellido.ReadOnly = !valor;
            txtUsuario.ReadOnly = !valor;
            txtPassword.ReadOnly = !valor;
            txtAccess.ReadOnly = !valor;

        }

        public void botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.habilitar(true);
                this.btnRegistrar.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.habilitar(false);
                this.btnRegistrar.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }
        public void limpiar()
        {
            lblID.Text = "0";
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtAccess.Text = string.Empty;

        }
        private void mensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Configuration Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Configuration Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region CRUD
        public void mostrar()
        {

            this.dgvUsuarios.DataSource = N_Login.verLogin();
            this.columns();
            lblCantidad.Text = "Quantity users: " + Convert.ToString(this.dgvUsuarios.Rows.Count);
        }
        private void columns()
        {
            this.dgvUsuarios.Columns[0].Visible = false;
            this.dgvUsuarios.Columns[1].Visible = false;


        }
        private void registrar()
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.botones();
            this.limpiar();
            this.habilitar(true);
            txtUsuario.Focus();
        }

        private void guardar()
        {
            
            try
            {
                string respuesta = "";
                if (txtAccess.Text == string.Empty || txtUsuario.Text == string.Empty || txtPassword.Text == string.Empty)
                {
                    this.mensajeError("Some data remains to be entered");
                    this.ErrorIcon.SetError(txtUsuario, "Enter user name");
                    this.ErrorIcon.SetError(txtAccess, "Enter a level username correct!");
                    this.ErrorIcon.SetError(txtPassword, "Enter a passsword");
                    this.mensajeOk("Remember add Administrator or General on level access");

                }
                else
                {
                    if (this.IsNuevo)
                    {
                        respuesta = N_Login.Insertar(this.txtNombre.Text, this.txtApellido.Text, dtpFecha.Value, this.txtUsuario.Text, this.txtPassword.Text, this.txtAccess.Text.Trim().ToUpper());
                    }

                    else
                    {
                        respuesta = N_Login.Editar(Convert.ToInt32(this.lblID.Text), this.txtNombre.Text, this.txtApellido.Text, dtpFecha.Value, this.txtUsuario.Text, this.txtPassword.Text, this.txtAccess.Text.Trim().ToUpper());
                    }
                    if (this.IsNuevo)
                    {
                        if (respuesta.Equals("OK"))
                        {
                            this.mensajeOk("The new user has been added to the Database");

                        }
                        else
                        {
                            this.mensajeOk("User has been edited successfully");
                        }
                        
                    }
                    else
                    {
                        this.mensajeOk("User has been edited successfully");
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.botones();
                    this.limpiar();
                    this.mostrar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }   
        private void editar()
        {
            if (!lblID.Text.Equals(""))
            {
                this.IsEditar = true;
                this.IsNuevo = false;
                this.botones();
                this.habilitar(true);
            }
            else
            {
                this.mensajeError("You must first select a user");
            }
        }
        private void eliminar()
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Do you really want to delete the Records?", "Configuration Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (opcion == DialogResult.Yes)
                {
                    string codigo;
                    string respuesta = "";

                    foreach (DataGridViewRow row in dgvUsuarios.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            respuesta = N_Login.Eliminar(Convert.ToInt32(codigo));

                            if (respuesta.Equals("OK"))
                            {
                                this.mensajeOk("Registry was successfully deleted");
                            }
                            else
                            {
                                this.mensajeError(respuesta);
                            }
                        }
                    }
                    this.mostrar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }
        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dgvUsuarios.Columns[0].Visible = true;
                this.btnEliminar.Enabled = true;

            }
            else
            {
                this.dgvUsuarios.Columns[0].Visible = false;
                this.btnEliminar.Enabled = false;
            }
        }
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUsuarios.Columns["RowEliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvUsuarios.Rows[e.RowIndex].Cells["RowEliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);

            }
        }
        private void cancelar()
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.botones();
            this.limpiar();
            this.habilitar(false);
        }
        #endregion


        private void frmConfiguration_Load(object sender, EventArgs e)
        {
            this.mostrar();
            this.habilitar(false);
        }
        #region DatagridView

       
        private void dgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            this.lblID.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);
            this.txtNombre.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["Name"].Value);
            this.txtApellido.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["Last Name"].Value);
            this.txtUsuario.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["Username"].Value);
            this.txtPassword.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["Password"].Value);
            dtpFecha.Value = Convert.ToDateTime(this.dgvUsuarios.CurrentRow.Cells["Date of Birth"].Value);
            this.txtAccess.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["Access level"].Value);
        }
        #endregion
        #region botones crud
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.registrar();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.guardar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.editar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.eliminar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cancelar();
        }

        #endregion

        private void btnfrmPrincipal_MouseHover(object sender, EventArgs e)
        {
            if (this.BackColor == Color.FromArgb(0, 122, 204))
                this.BackColor = Color.FromArgb(192, 0, 0);


        }

        private void btnfrmPrincipal_MouseLeave(object sender, EventArgs e)
        {
            if (this.BackColor == Color.FromArgb(192, 0, 0))
                this.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void btnfrmPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            if (this.btnCerrar.BackColor == Color.FromArgb(0, 122, 204))
                this.btnCerrar.BackColor = Color.FromArgb(192, 0, 0);

        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            if (this.btnCerrar.BackColor == Color.FromArgb(192, 0, 0))
                this.btnCerrar.BackColor = Color.FromArgb(0, 122, 204);

        }

        private void btnMin_MouseHover(object sender, EventArgs e)
        {
            if (this.btnMin.BackColor == Color.FromArgb(0, 122, 204))
            {
                this.btnMin.BackColor = Color.White;
                this.btnMin.ForeColor = Color.FromArgb(0, 122, 204);
            }
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            if (this.btnMin.BackColor == Color.White)
            {
                this.btnMin.BackColor = Color.FromArgb(0, 122, 204);
                this.btnMin.ForeColor = Color.White;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Do you really want to exit the application?", "Configuration Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Minimized)

                WindowState = FormWindowState.Normal;

        }
    }
}
