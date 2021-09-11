using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmEdificio : Form
    {
        private bool IsNuevo = false;
        private string ID = "";
        public frmEdificio()
        {
            InitializeComponent();
            ttmensaje.SetToolTip(txtNombre, "Write the name of the installation");
            ttmensaje.SetToolTip(btnGuardar, "Press to save");
            ttmensaje.SetToolTip(btnEliminar, "Press to delete");
        }
        private void Mostrar()
        {
            this.dgvEdificio.DataSource = N_Visitas.MostrarEdificio();
           dgvEdificio.Columns[0].Visible = false;
            lblTotal.Text = "Total buildings: " + Convert.ToString(dgvEdificio.Rows.Count);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEdificio.Rows.Count > 0)
                {
                    DialogResult dialog;

                    dialog = MessageBox.Show("are you sure you want to delete the edificie?", "Installations edificies controls", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        ID = Convert.ToString(dgvEdificio.CurrentRow.Cells["IdEdificio"].Value);
                        N_Visitas.EliminarEdificio(Convert.ToInt32(ID));
                        MessageBox.Show("Has been successfully removed");
                    }

                }
                else
                    MessageBox.Show("Select the edificies please", "Classrooms", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Mostrar();
                IsNuevo = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Write the name of the installation ");
                ErrorIcon.SetError(txtNombre, "Here");
            }
            else
            {
                if (this.IsNuevo)
                {
                    N_Visitas.InsertarEdificio(this.txtNombre.Text);
                    MessageBox.Show("Has been added successfully");
                }
                this.Mostrar();
                IsNuevo = false;

            }
        }

        private void frmEdificio_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }
    }
    
}

