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
    public partial class frmAula : Form
    {
        private bool IsNuevo = false;
       
        private string ID;
        public frmAula()
        {
            InitializeComponent();
            ttmensaje.SetToolTip(txtNombre, "Write the name of the installation");
            ttmensaje.SetToolTip(btnGuardar, "Press to save");
            ttmensaje.SetToolTip(btnEliminar, "Press to delete");

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            if(txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Write the name of the installation ");
                ErrorIcon.SetError(txtNombre, "Here");
            }
            else
            {
                if (this.IsNuevo)
                {
                    N_Visitas.InsertarAula(this.txtNombre.Text);
                    MessageBox.Show("Has been added successfully");
                }
                this.Mostrar();
                IsNuevo = false;
               
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgvAulas.Rows.Count > 0)
                {
                    DialogResult dialog;
                   
                    dialog= MessageBox.Show("are you sure you want to delete the classroom?", "Classrooms Controls",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(dialog == DialogResult.Yes)
                    {
                        ID = Convert.ToString(dgvAulas.CurrentRow.Cells["IdAula"].Value);
                        N_Visitas.EliminarAula(Convert.ToInt32(ID));
                        MessageBox.Show("Has been successfully removed");
                    }
                   
                }
                else
                    MessageBox.Show("Select the classroom please", "Classrooms", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Mostrar();
                IsNuevo = false;
            } 
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void Mostrar()
        {
            this.dgvAulas.DataSource = N_Visitas.MostrarAula();
            this.dgvAulas.Columns[0].Visible = false;
            lblTotal.Text = "Total classrooms: " + Convert.ToString(dgvAulas.Rows.Count);
        }

        private void frmAula_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void btnfrmPrincipal_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
