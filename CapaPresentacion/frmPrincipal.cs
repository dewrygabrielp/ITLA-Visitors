using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public string IdUsuario = null;
        public string Nombre = null;
        public string Apellido = null;
        public string Usuario = null;
        public string Password = null;
        public string Acceso = null;
        public frmPrincipal()
        {
            InitializeComponent();
            this.propertypanel();
            lblHour.Text = DateTime.Now.ToLongDateString();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.GestionAcceso();


        }

        #region Panel, Timer, btnConf, btnCerrar,AbrirForm()
        private void propertypanel()
        {
            this.pnlMenu.Visible = false;
            this.pnlConfM.Visible = false;
        }
        private void ocultarpanel()
        {
            if (pnlMenu.Visible == true || pnlConfM.Visible == true)
            {
                this.pnlMenu.Visible = false;
                this.pnlConfM.Visible = false;
            }
                
        }
        private void mostrarpanelMenu()
        {
            if (pnlMenu.Visible == false)
            {
                this.pnlMenu.Visible = true;
                
            }
            else  this.pnlMenu.Visible = false;
            
        }
        private void mostrarpanelAdmin()
        {
            if (pnlConfM.Visible == false)
            {
                this.pnlConfM.Visible = true;

            }
            else this.pnlConfM.Visible = false;

        }



        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHour.Text = DateTime.Now.ToLongDateString();

        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Realmente desea salir de la aplicación?", "Visitantes ITLA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void AbrirForm(object formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }
        #endregion


        private void GestionAcceso()
        {
            if (Acceso == "ADMINISTRATOR")
            {
                btnUser.Enabled = true;
              
            }

            else
            {
                btnUser.Enabled = false;
                
            }


        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            frmConfiguration conf = new frmConfiguration();
            conf.Show();
            this.ocultarpanel();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.mostrarpanelMenu();
        }

        private void btnVisitas_Click(object sender, EventArgs e)
        {
            frmConsultarVisitas cv = new frmConsultarVisitas();
            cv.Show();
            this.ocultarpanel();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmVisitas v = new frmVisitas();
            v.Show();
            this.ocultarpanel();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmConfiguration cv = new frmConfiguration();
            cv.Show();
            this.ocultarpanel();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if(WindowState == FormWindowState.Minimized)
            
                WindowState = FormWindowState.Normal;
            

        }

        private void btnEdificio_Click(object sender, EventArgs e)
        {
            frmEdificio cv = new frmEdificio();
            cv.Show();
            this.ocultarpanel();
        }

        private void btnCarreras_Click(object sender, EventArgs e) { /*this.AbrirForm(new frmCarreras());*/ }
        

        private void btnAulas_Click(object sender, EventArgs e)
        {
            frmAula cv = new frmAula();
            cv.Show();
            this.ocultarpanel();
        }

       
        private void btnManager_Click_1(object sender, EventArgs e)
        {
            this.mostrarpanelAdmin();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Do you really want to exit the application?", "Controls visitors", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes) Application.Exit();
        }
    }
}
