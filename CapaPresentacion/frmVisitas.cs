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
    public partial class frmVisitas : Form
    {
        private bool IsEditar = false;
        private bool IsNuevo = false;
        public frmVisitas()
        {
            InitializeComponent();
            MostrarEdificio();
            MostrarAula();
            MostrarCarreras();
            ttmensaje.SetToolTip(txtNombre, "Enter your name");
            ttmensaje.SetToolTip(txtApellido, "Enter your Last Name");
            ttmensaje.SetToolTip(txtReason, "Enter the reason for your visit");
            ttmensaje.SetToolTip(maskedTextBox1, "Enter your email");
            ttmensaje.SetToolTip(cbxCarrera, "Choose your university degree or technologist");
            ttmensaje.SetToolTip(cbxEdificio, "Select the building you are going to");
            ttmensaje.SetToolTip(cbxAula, "Select the site or classroom you are going to");
            ttmensaje.SetToolTip(txtNombre, "Select the building or classroom you are going to");
            ttmensaje.SetToolTip(pcbPhoto,"Choose your image (optional)");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Do you really want to exit the application?", "Visitors Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBack_MouseClick(object sender, MouseEventArgs e) { this.Close(); }
        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Minimized)

                WindowState = FormWindowState.Normal;

        }

        private void pictureBox2_Click(object sender, EventArgs e) { this.Close(); }

        private void pictureBox3_Click(object sender, EventArgs e) { this.Close(); }
  
        private void mensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Record of visits", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Record of visits", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MostrarEdificio()
        {
            cbxEdificio.DataSource = N_Visitas.MostrarEdificio();
            cbxEdificio.DisplayMember = "Edificio";
            cbxEdificio.ValueMember = "IdEdificio";
        }
        private void MostrarAula()
        {
            cbxAula.DataSource = N_Visitas.MostrarAula();
            cbxAula.DisplayMember = "Aula";
            cbxAula.ValueMember = "IdAula";
        }
        private void MostrarCarreras()
        {
            cbxCarrera.DataSource = N_Visitas.MostrarCarreras();
            cbxCarrera.DisplayMember = "Carrera";
            cbxCarrera.ValueMember = "IdCarrera";
        }
       
        private void limpiar()
        {
            this.pcbPhoto.Image = global::CapaPresentacion.Properties.Resources.file;
            this.txtNombre.text  = string.Empty;
            this.txtApellido.text = string.Empty;
            this.txtReason.Text = string.Empty;
            this.maskedTextBox1.Text = string.Empty;
        }
        private void habilitar(bool valor)
        {
            txtNombre.Enabled = valor;
            txtApellido.Enabled = valor;
            txtReason.ReadOnly = !valor;
            cbxAula.Enabled = valor;
            cbxCarrera.Enabled = valor;
            cbxEdificio.Enabled = valor;
            maskedTextBox1.ReadOnly = !valor;
        }
        private void registrar()
        {

            this.IsNuevo = true;
            this.IsEditar = false;
            this.botones();
            this.limpiar();
            this.habilitar(true);
            txtNombre.Focus();
        }
        private void botones()
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
        private void cancelar()
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.botones();
            this.limpiar();
            this.habilitar(false);
        }
        private void editar()
        {
            if (!this.txtIdVisita.Text.Equals(""))
            {
                this.IsEditar = true;
                this.botones();
                this.habilitar(true);
            }
            else this.mensajeError("you must first select the record by id");
        }
        private void guardar()
        {
           string respuesta = "";
            try
            {
                if(txtNombre.text == string.Empty || txtApellido.text == string.Empty)
                {
                    this.mensajeError("Enter all fields");
                    ErrorIcon.SetError(txtNombre, "Enter your name");
                    ErrorIcon.SetError(txtApellido, "Enter your Last name");
                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    pcbPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    byte[] imagen = ms.GetBuffer();
                    
                    if (this.IsNuevo)
                    {
                        respuesta = N_Visitas.Insertar(Convert.ToInt32(cbxEdificio.SelectedValue), Convert.ToInt32(cbxAula.SelectedValue),this.txtNombre.text,this.txtApellido.text,
                            Convert.ToInt32(cbxCarrera.SelectedValue),this.txtReason.Text,this.maskedTextBox1.Text,dtpEntryTime.Value,dtpDepartureTime.Value, imagen);
                    }
                    else
                    {
                        respuesta = N_Visitas.Editar(Convert.ToInt32(this.txtIdVisita.Text),Convert.ToInt32(cbxEdificio.SelectedValue), Convert.ToInt32(cbxAula.SelectedValue), this.txtNombre.text, this.txtApellido.text,
                            Convert.ToInt32(cbxCarrera.SelectedValue), this.txtReason.Text, this.maskedTextBox1.Text, dtpEntryTime.Value, dtpDepartureTime.Value, imagen);
                    }
                    
                    if (respuesta.Equals("OK"))
                    {
                        if (this.IsNuevo) this.mensajeOk("Was successfully saved");

                        else this.mensajeOk("Edited successfully, you can open the query window to confirm");          
                    }
                    else
                    {
                        this.mensajeError(respuesta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.botones();
                    this.limpiar();
                   
                }
                
            }catch(Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
        }

        private void btnCargarImagen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.pcbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pcbPhoto.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnLimpiarImagen_Click_1(object sender, EventArgs e)
        {
            this.pcbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pcbPhoto.Image = Properties.Resources.file;
        }
        private void btnGuardar_Click(object sender, EventArgs e) { this.guardar(); }
        private void btnRegistrar_Click(object sender, EventArgs e) { this.registrar(); }
        private void btnEditar_Click(object sender, EventArgs e) { this.editar(); }
        private void btnCancelar_Click(object sender, EventArgs e) { this.cancelar(); }

        private void frmVisitas_Load(object sender, EventArgs e)
        {
            this.habilitar(false);
            //masktextbox("","","");
        }

        private void mkbMail_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
       /* private void masktextbox(string correo, string dom, string region)
        {
            maskedTextBox1.Mask = $"{correo} @ {dom}  {region}";
            maskedTextBox1.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected);
        }*/

        
        void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Invalid Input";
            toolTip1.Show("We're sorry, but only mail valid.", maskedTextBox1);
        }
    }
    
}
