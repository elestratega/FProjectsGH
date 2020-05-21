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
    public partial class FrmCargaApp : Form
    {
        public static MySqlConnection conexion = null;

        private void FrmCargaApp_Load(object sender, EventArgs e)
        {
            lbCargando.Visible = true;
            this.Opacity = 0.0;
            panelCargaI.Width = 10;
            timerAparecer.Start();
        }

        public FrmCargaApp()
        {
            InitializeComponent();
        }

        private void timerAparecer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }

            panelCargaI.Width += 1;
            panelCargaD.Left -= 1;
            panelCargaD.Width += 2;

            if (panelCargaI.Width == 150)
            {
                conectar();
               // MessageBox.Show("Conexion + " + conexion.State.ToString());
            }

            if (panelCargaI.Width == 460)
            {
                timerAparecer.Stop();
                timerDesvanecer.Start();
            }

            if (panelCargaI.Width == 100)
            {
                lbCargando.Visible = false;
                lbConectando.Visible = true;
            }

            if (panelCargaI.Width == 400)
            {
                lbCargando.Visible = false;
                lbConectando.Visible = false;
                lbIniciando.Visible = true;
            }

            if (panelCargaI.Width == 170)
            {
                lbCargando.Visible = true;
                lbConectando.Visible = false;
                lbIniciando.Visible = false;
            }

        }

        private void timerDesvanecer_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;

            if (this.Opacity == 0)
            {
                timerDesvanecer.Stop();
                this.Close();
            }
        }

        public void conectar()
        {
            try
            {
                conexion = new MySqlConnection("Server = db4free.net ; Database = conexion; Uid = admin899_9; Pwd = Admin89@Admin; Port = 3306; old guids=true");
                conexion.Open();

            }
            catch (Exception)
            {
                timerReintentarConex.Start();
            }

        }
        private void timerReintentarConex_Tick(object sender, EventArgs e)
        {
            if (conexion.State != ConnectionState.Open)
            {
                try
                {
                    MessageBox.Show("Intentado reconectar espere un momento");
                    conexion.Open();

                }
                catch (Exception)
                {

                }
            }
            else
            {
                timerReintentarConex.Stop();
            }
        }
    }
}

