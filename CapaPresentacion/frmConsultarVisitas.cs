using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class frmConsultarVisitas : Form
    {
        
        public frmConsultarVisitas()
        {
            InitializeComponent();
            CbxEdificio();
        }
        private void MostrarVisitas()
        {
            this.dgvVisitantes.DataSource = N_Visitas.MostrarVisitas();
            this.columns();
            //dgvVisitantes.Columns[0].Visible = false;
           // dgvVisitantes.Columns[10].Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Do you really want to exit the application?", "Records query", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes) Application.Exit();
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Minimized)

                WindowState = FormWindowState.Normal;
        }
        private void btnBack_MouseClick(object sender, MouseEventArgs e) { this.Close(); }
        private void pictureBox2_Click(object sender, EventArgs e) { this.Close(); }
        private void pictureBox1_Click(object sender, EventArgs e) { this.Close(); }

        private void frmConsultarVisitas_Load(object sender, EventArgs e)
        {
            this.MostrarVisitas();
            this.btnEliminar.Enabled = false;
        }
        private void columns() 
        {   this.lblTotal.Text = "Visitors found: " + Convert.ToString(dgvVisitantes.Rows.Count);
            this.dgvVisitantes.Columns[0].Visible = false;
                dgvVisitantes.Columns[4].Visible = false;
                dgvVisitantes.Columns[5].Visible = false;
                dgvVisitantes.Columns[6].Visible = false;
                dgvVisitantes.Columns[13].Visible = false;
                dgvVisitantes.Columns[14].Visible = false;
                dgvVisitantes.Columns[15].Visible = false;
                dgvVisitantes.Columns[16].Visible = false;
                dgvVisitantes.Columns[17].Visible = false;
                dgvVisitantes.Columns[18].Visible = false;
                dgvVisitantes.Columns[19].Visible = false;
                dgvVisitantes.Columns[20].Visible = false;

                dgvVisitantes.Columns[11].Width = 60;
                dgvVisitantes.Columns[12].Width = 63;


        }

        /* private void BuscarNombre()
         {
             N_Visitas visitas = new N_Visitas();
             this.dgvVisitantes.DataSource = visitas.BuscarNombre(txtNombre.text);
             this.columns();
         }*/
        private void BuscarEdificio()
        {
            N_Visitas visitas = new N_Visitas();
            this.dgvVisitantes.DataSource = visitas.BuscarEdificio(Convert.ToInt32(cbxEdificio.SelectedValue));
            this.columns();
        }
        private void CbxEdificio()
        {
            cbxEdificio.DataSource = N_Visitas.MostrarEdificio();
            cbxEdificio.DisplayMember = "Edificio";
            cbxEdificio.ValueMember = "IdEdificio";
        }

       /* private void txtNombre_OnTextChange(object sender, EventArgs e)
        {
                this.BuscarNombre();
        }*/
        private void cbxEdificio_Click(object sender, EventArgs e) { this.BuscarEdificio(); }
        private MemoryStream ByteImage()
        {
            byte [] img = (byte[])dgvVisitantes.CurrentRow.Cells[13].Value;
            MemoryStream ms = new MemoryStream(img);
            return ms;
        }
        private void dgvVisitantes_Click(object sender, EventArgs e)
        {
            pcbPhoto.Image = Image.FromStream(ByteImage());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Do you really want to delete the Records?", "Query visitors", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (opcion == DialogResult.Yes)
                {
                    string codigo;
                    string respuesta = "";

                    foreach (DataGridViewRow row in dgvVisitantes.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[4].Value);
                            respuesta = N_Visitas.Eliminar(Convert.ToInt32(codigo));

                            if (respuesta.Equals("OK"))
                            {
                                MessageBox.Show("Registry was successfully deleted", "Query Visitors", MessageBoxButtons.OK);
                                
                            }
                            else
                            {
                                MessageBox.Show(respuesta);
                            }
                        }
                    }
                    this.MostrarVisitas();
                    this.chkEliminar.Checked = false;
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
                this.dgvVisitantes.Columns[0].Visible = true;
                this.btnEliminar.Enabled = true;

            }
            else
            {
                this.dgvVisitantes.Columns[0].Visible = false;
                this.btnEliminar.Enabled = false;
            }
        }

        private void dgvVisitantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvVisitantes.Columns[0].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvVisitantes.Rows[e.RowIndex].Cells[0];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);

            }
        }
    } 
      
       
     
}
