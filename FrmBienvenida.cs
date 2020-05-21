using MySql.Data.MySqlClient;
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
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }

        private void timerAparecer_Tick(object sender, EventArgs e)
        {
            if(this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }

            circuloProgreso.Value += 1;
            circuloProgreso.Text = circuloProgreso.Value.ToString();

            if(circuloProgreso.Value == 100)
            {
                timerAparecer.Stop();
                timerDesvanecer.Start();
            }
        }

        private void timerDesvanecer_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;

            if(this.Opacity == 0)
            {
                timerDesvanecer.Stop();
                this.Close();
            }
        }

        private void FrmBienvenida_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = FrmCargaApp.conexion;
            command.CommandText = "Select Nombre from usuarios where Correo='" + FrmInicioSesion.correoGuardado + "'";

            lbUsuario.Text = command.ExecuteScalar().ToString();
            this.Opacity = 0.0;
            circuloProgreso.Value = 0;
            circuloProgreso.Minimum = 0;
            circuloProgreso.Maximum = 100;
            timerAparecer.Start();

        }
    }
}
