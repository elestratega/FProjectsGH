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
    public partial class FrmMisProyectosAlumno : Form
    {
        public FrmMisProyectosAlumno()
        {
            InitializeComponent();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LbSubirProyecto_Click(object sender, EventArgs e)
        {
            FrmSubirProyectoAlumno f = new FrmSubirProyectoAlumno();
            f.Show();
        }
    }
}
