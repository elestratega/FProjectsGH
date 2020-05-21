using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FProjects
{
    public partial class FrmRegistrarse : Form
    {
        public FrmRegistrarse()
        {
            InitializeComponent();
        }

        //-----------BTN HACIA FRM DE INICIO || CAMBIA (INICIO DE SESION X MI PERFIL)--------------------------------
        //private void BtnConfirmar_Click(object sender, EventArgs e)
        //{
        //    if (comprobarCampos())
        //    {
        //        MessageBox.Show("Conexion + " + FrmCargaApp.conexion.State.ToString());
        //        MySqlCommand command = new MySqlCommand();
        //        command.Connection = FrmCargaApp.conexion;
        //        String tipoUsuario = "";
        //        string sql = "";

        //        //si el usuario es estandar se añade
        //        if (!rbAlumno.Checked)
        //        {
        //            tipoUsuario = "Estandar";

        //            sql = "INSERT into usuarios (Nombre,Correo,Contraseña,CodRecContr,TipoUsuario) values('" + txtNombreUsuario.Text + "','" + txtCorreo.Text + "','" + txtContraseñaMostrar.Text + "'," + 0 + ",'" + tipoUsuario + "')";

        //            command.CommandText = sql;
        //            if (command.ExecuteNonQuery() == 1)
        //            {
        //                MessageBox.Show("Usuario agregado correctamente");
        //            }

        //        }
        //        else
        //        {
        //            //si el usuario es un usuario se miran todos los centros por si coincide la contraseña
        //            tipoUsuario = "Alumno";
        //            String sqlValido = "Select NombreCentro from centros where ContraseñaCentro = '" + txtContraCentro.Text + "'";
        //            MySqlDataReader reader;
        //            try
        //            {
        //                MySqlCommand command2 = new MySqlCommand(sqlValido,FrmCargaApp.conexion);
        //                command2.CommandText = sqlValido;
        //                reader = command2.ExecuteReader();
        //                reader.Close();

        //                sql = "INSERT into usuarios (Nombre,Correo,Contraseña,CodRecContr,TipoUsuario) values('" + txtNombreUsuario.Text + "','" + txtCorreo.Text + "','" + txtContraseñaMostrar.Text + "'," + 0 + ",'" + tipoUsuario + "')";

        //                //sql = "INSERT into usuarios (NombreAlumno,Telefono,Contraseña,CodRecContr,TipoUsuario) values('" + txtNombreUsuario.Text + "','" + txtCorreo.Text + "','" + txtContraseñaMostrar.Text + "'," + 0 + ",'" + tipoUsuario + "')";

        //                command.CommandText = sql;
        //                    if (command.ExecuteNonQuery() == 1)
        //                    {
        //                        MessageBox.Show("Usuario agregado correctamente");
        //                    }
                        
        //            }
        //            catch (Exception)
        //            {
        //                MessageBox.Show("El centro no existe");
        //            }

        //        }
        //    }
        //}

        private bool comprobarCampos()
        {
            //-----------------COMPROBACION DE LOS TXT------------------------
            bool correcto = true;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text.Equals("") || c.Text.Equals("Contraseña") || c.Text.Equals("Correo electrónico"))
                    {
                        errorProvider1.SetError(c, "Falta por introducir alguno de los campos");
                        correcto = false;
                    }
                    else
                    {
                        errorProvider1.SetError(c, "");
                    }
                }
            }
            return correcto;
        }

        //--------- TXT NOMBRE DE USUARIO ------------------------ 
        private void JMT_Nombre_Enter(object sender, EventArgs e)
        {
            if (JMT_Nombre.TextName.Equals("Nombre de Usuario"))
            {
                JMT_Nombre.TextName = "";
            }
        }

        private void JMT_Nombre_Leave(object sender, EventArgs e)
        {
            if (JMT_Nombre.TextName.Equals(""))
            {
                JMT_Nombre.TextName = "Nombre de Usuario";
            }
        }

        //--------- TXT CORREO ELECTRÓNICO ------------------------ 

        private void JMT_Correo_Enter(object sender, EventArgs e)
        {
            if (JMT_Correo.TextName.Equals("Correo Electrónico"))
            {
                JMT_Correo.TextName = "";
            }
        }

        private void JMT_Correo_Leave(object sender, EventArgs e)
        {
            if (JMT_Correo.TextName.Equals(""))
            {
                JMT_Correo.TextName = "Correo Electrónico";
            }
        }

        //--------- TXT CONTRASEÑA ------------------------
        private void JMT_Contra_Enter(object sender, EventArgs e)
        {

        }

        private void JMT_Contra_Leave(object sender, EventArgs e)
        {

        }

        //----------------BTN MOSTRAR------------------------------

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        //--------- TXT REPETIR CONTRASEÑA ------------------------

        private void JMT_RepetirContra_Enter(object sender, EventArgs e)
        {

        }

        private void JMT_RepetirContra_Leave(object sender, EventArgs e)
        {

        }
        private void FrmRegistrarse_Load(object sender, EventArgs e)
        {

        }

        private void lbInicioSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
