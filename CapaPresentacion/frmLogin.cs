using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            ttmensaje.SetToolTip(txtUsuario, "enter username");
            ttmensaje.SetToolTip(txtPassword, "enter  a password");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("No record entered", "Itla visitors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorIcon.SetError(txtUsuario, "fill in the fields");
                errorIcon.SetError(txtPassword, "fill in the fields");
            }
            else
            {

                DataTable datos = N_Login.MostrarUsuarios(this.txtUsuario.Text, this.txtPassword.Text);
                //Validar Usuarios if exists

                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("this user is not registered in our database", "Itla visitors", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    frmPrincipal Pl = new frmPrincipal();
                    Pl.IdUsuario = datos.Rows[0][0].ToString();
                    Pl.Nombre = datos.Rows[0][1].ToString();
                    Pl.Apellido = datos.Rows[0][2].ToString();
                    // Pl.Usuario = datos.Rows[0][3].ToString();
                    // Pl.Password = datos.Rows[0][4].ToString();
                    Pl.Acceso = datos.Rows[0][6].ToString();

                    Pl.Show();
                    this.Hide();
                }


            }

        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password...")
            {
                txtPassword.Text = string.Empty;
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUsuario_MouseEnter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Type user...")
            {
                this.txtUsuario.Text = string.Empty;
            }
        }

    }
}

