using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Taskbar.Core;

namespace FProjects
{
    public partial class FrmMiPerfil : Form
    {
        public FrmMiPerfil()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMiPerfil_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath btnPath = new GraphicsPath();
            Rectangle btnRectangulo = btnCerrarSesion.ClientRectangle;
            btnRectangulo.Inflate(0, 35);
            btnPath.AddEllipse(btnRectangulo);
            btnCerrarSesion.Region = new Region(btnPath);
        }

        private void btnEditarMiPerfil_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath btnPath = new GraphicsPath();
            Rectangle btnRectangulo = btnEditarMiPerfil.ClientRectangle;
            btnRectangulo.Inflate(0, 35);
            btnPath.AddEllipse(btnRectangulo);
            btnEditarMiPerfil.Region = new Region(btnPath);
        }
    }
}
