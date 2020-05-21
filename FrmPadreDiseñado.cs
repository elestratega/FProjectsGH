using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FProjects
{
    public partial class FrmPadreDiseñado : Form
    {

        private IconButton botonSeleccionado;
        private Panel bordeIzquierdo;
        
        int posY = 0;
        int posX = 0;

        private Object usuarioLogeado;
        public FrmPadreDiseñado()
        {
            InitializeComponent();

            FrmCargaApp carga = new FrmCargaApp();
            carga.ShowDialog();

            bordeIzquierdo = new Panel();
            bordeIzquierdo.Size = new Size(9, 53);
            panelMenu.Controls.Add(bordeIzquierdo);

            iconMaximizar.Visible = true;
            iconTamanoNormal.Visible = false;
            usuarioLogeado = new Usuario();
        }

        private void FrmPadreDiseñado_Load(object sender, EventArgs e)
        {
            BotonActivado(btnInicio);
        }

        private void BotonActivado(object senderBtn)
        {
            if (senderBtn != null)
            {
                DesactivarBoton();
                botonSeleccionado = (IconButton)senderBtn;
                botonSeleccionado.BackColor = Color.FromArgb(19, 137, 255);
                botonSeleccionado.TextAlign = ContentAlignment.MiddleCenter;
                botonSeleccionado.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonSeleccionado.ImageAlign = ContentAlignment.MiddleRight;
                botonSeleccionado.FlatAppearance.BorderColor = Color.MidnightBlue;

                bordeIzquierdo.BackColor = Color.MidnightBlue;
                bordeIzquierdo.Location = new Point(0, botonSeleccionado.Location.Y);
                bordeIzquierdo.Visible = true;
                bordeIzquierdo.BringToFront();
            }
        }

        private void DesactivarBoton()
        {
            if (botonSeleccionado != null)
            {
                botonSeleccionado.BackColor = Color.FromArgb(0, 120, 215);
                botonSeleccionado.ForeColor = Color.MidnightBlue;
                botonSeleccionado.TextAlign = ContentAlignment.MiddleLeft;
                botonSeleccionado.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonSeleccionado.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            BotonActivado(sender);
            panelInicio.Visible = true;
            panelInicio.Dock = DockStyle.Fill;
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelFondo.Visible = false;
            BotonActivado(sender);
            bool encontrado = false;
            foreach (Form fForm in MdiChildren)
            {
                if (fForm.GetType() == typeof(FrmMisProyectosAlumno))
                {
                    encontrado = true;

                    fForm.BringToFront();
                    break;
                }
            }
            if (!encontrado)
            {
                FrmMisProyectosAlumno fProyectos = new FrmMisProyectosAlumno();
                fProyectos.MdiParent = this;
                fProyectos.Dock = DockStyle.Fill;
                fProyectos.Show();
            }
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            BotonActivado(sender);
            bool encontrado = false;
            foreach (Form fForm in Application.OpenForms)
            {
                if (fForm.GetType() == typeof(FrmInicioSesion))
                {
                    encontrado = true;

                    fForm.BringToFront();
                    break;
                }
            }
            if (!encontrado)
            {
                FrmInicioSesion frmInicioSesion = new FrmInicioSesion(usuarioLogeado);
                frmInicioSesion.ShowDialog();
            }
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.iconTamanoNormal.Visible = true;
            this.iconMaximizar.Visible = false;
        }

        private void iconTamanoNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.iconMaximizar.Visible = true;
            this.iconTamanoNormal.Visible = false;
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelBotones_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY); 
            }
        }

        private void lbMiperfil_Click(object sender, EventArgs e)
        {
            FrmMiPerfil p = new FrmMiPerfil();
            p.Show();
        }
    }
}
