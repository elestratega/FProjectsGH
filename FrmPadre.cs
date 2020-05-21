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
    public partial class FrmPadre : Form
    {
        //public static MySqlConnection conexion=null;
        public FrmPadre()
        {
            InitializeComponent();

            FrmCargaApp carga = new FrmCargaApp();
            carga.ShowDialog();

            //conexion = new MySqlConnection("Server = db4free.net ; Database = conexion; Uid = admin899_9; Pwd = Admin89@Admin; Port = 3306; old guids=true");
            //conexion.Open();
            //MessageBox.Show("Conexion + " + conexion.State.ToString());
        }

        //--------------------------INICIO---------------------------------
        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            //foreach (Form fForm in MdiChildren)
            //{
            //    fForm.Close();
            //}

        }

        //--------------------------OTROS PROYECTOS---------------------------------
        private void OtrosProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //en obras
        }

        //--------------------------MIS PROYECTOS---------------------------------
        private void MisProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        //--------------------------INICIO DE SESION---------------------------------
        private void InicioDeSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInicioSesion f = new FrmInicioSesion();
            f.ShowDialog();
        }


    }
}
