using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FProjects
{
    public partial class FrmInicioSesion : Form
    {
        public static String correoGuardado;
        private Object usuarioLogeado;
        public FrmInicioSesion(Object p_usuarioLogeado)
        {
            InitializeComponent();
            usuarioLogeado = p_usuarioLogeado;
        }
        public FrmInicioSesion()
        {
            InitializeComponent();
            
        }
        //------------BTN HACIA FRM DE INICIO---------------------------------
        private void JTButton_Login_Click(object sender, EventArgs e)
        {
            //Comprabacion contra la base de datos
            if (comprobarCampos())
            {

              
                String sql = "Select TipoUsuario from usuarios where Correo = '" + JMT_txtCorreo.TextName + "' AND " +
                        "Contraseña = '" + JMT_ContraEsconder.TextName + "'";
                
                    
                try
                {

                    MySqlCommand command = new MySqlCommand(sql,FrmCargaApp.conexion);
                   
                    //this.Hide();
                    correoGuardado = JMT_txtCorreo.TextName;
                    //FrmBienvenida welcome = new FrmBienvenida();
                    //welcome.ShowDialog();
                    
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        switch (reader.GetString(0))
                        {
                            case "Usuario":
                                MessageBox.Show("USUARIO");
                                reader.Close();
                                crearUsuario("Usuario");
                                break;
                            case "Alumno":
                                MessageBox.Show("Alumno");
                                reader.Close();
                                crearUsuario("Alumno");

                                break;
                            case "Centro":
                                reader.Close();
                                crearUsuario("Centro");
                                break;
                        }

                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        //Metodo que crea el obj del tipo que se le pase
        public void crearUsuario(String pTipoUsuario)
        {

            int idUsuario = 0;
            String sql = "Select idUsuario from usuarios where Correo = '" + JMT_txtCorreo.TextName + "' AND " +
           "Contraseña = '" + JMT_ContraEsconder.TextName + "'";

            MySqlCommand command = new MySqlCommand(sql, FrmCargaApp.conexion);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                idUsuario = reader.GetInt32(0);
            }
            reader.Close();

            switch (pTipoUsuario)
            {
                case "Usuario":
                   // MessageBox.Show("USUARIO");

                    Usuario usua = new Usuario();
                    sql = "SELECT `Nombre`, `Correo`, `Contraseña`, `CodRecContr`, `TipoUsuario`, `FechaCodRecContr` FROM `usuarios` WHERE `idUsuario`="+ idUsuario;

                    command = new MySqlCommand(sql, FrmCargaApp.conexion);

                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        usua.IdUsuario = idUsuario;
                        usua.Nombre = reader.GetString(0);
                        usua.Correo = reader.GetString(1);
                        usua.Contrasenia = reader.GetString(2);
                        usua.CodRecContr = reader.GetInt32(3);
                        usua.TipoUsario = reader.GetString(4);
                        usua.FechaCodRecContr = reader.GetDateTime(5);

                    }
                    reader.Close();

                    sql = "SELECT FotoUsuario  FROM `usuarios` WHERE `idUsuario`=" + idUsuario;

                    command = new MySqlCommand(sql, FrmCargaApp.conexion);

                    byte[] foto = (byte[])command.ExecuteScalar();
                    if (foto.Length!=0)
                    {
                        MemoryStream ms = new MemoryStream(foto);
                        usua.FotoUsuario = Image.FromStream(ms);
                        ms.Close();
                    }

                    MessageBox.Show(usua.ToString());
                    break;
                case "Alumno":
                    MessageBox.Show("Alumno");

                    break;
                case "Centro":
                    MessageBox.Show("Centro");
                    break;
            }
        }
        //------------BTN HACIA FRM DE REGISTRARSE---------------------------------
        private void lbRegistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistrarse f = new FrmRegistrarse();
            f.ShowDialog();
        }
        //-----------BTN HACIA FRM DE CAMBIAR_CONTRASEÑA---------------------------------
        private void lbCambioContra_Click(object sender, EventArgs e)
        {
            FrmCambiarContrasenia f = new FrmCambiarContrasenia();
            f.ShowDialog();
        }
        //Comprobaciones 
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
                        errorProvider1.SetError(c,"");
                    }
                }
            }
            return correcto;
        }

        //--------- TXT CONTRASEÑA ------------------------
        private void JMT_ContraEsconder_Click(object sender, EventArgs e)
        {
            if (JMT_ContraEsconder.TextName.Equals("Contraseña"))
            {
                JMT_ContraEsconder.TextName = "";
                JMT_ContraEsconder.IsPassword = true;

            }
        }

        private void JMT_ContraEsconder_Enter(object sender, EventArgs e)
        {
            if (JMT_ContraEsconder.TextName.Equals("Contraseña"))
            {
                JMT_ContraEsconder.TextName = "";
                JMT_ContraEsconder.IsPassword = true;

            }
        }

        private void JMT_ContraEsconder_Leave(object sender, EventArgs e)
        {
            if (JMT_ContraEsconder.TextName.Equals(""))
            {
                JMT_ContraEsconder.TextName = "Contraseña";
                JMT_ContraEsconder.IsPassword = false;

            }
        }
        //----------------BTN MOSTRAR------------------------------
        private void btnMostrarContra_MouseDown(object sender, MouseEventArgs e)
        {
            JMT_ContraEsconder.Visible = false;
            JMT_ContraMostrar.Visible = true;
        }

        private void btnMostrarContra_MouseUp(object sender, MouseEventArgs e)
        {
            JMT_ContraMostrar.Visible = false;
            JMT_ContraEsconder.Visible = true;
            JMT_ContraEsconder.Font = new Font("Sitka Heading", 12, FontStyle.Regular);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            JMT_ContraMostrar.TextName = JMT_ContraEsconder.TextName;
        }
        //--------- TXT CORREO ELECTRÓNICO ------------------------ 

        private void JMT_txtCorreo_Leave(object sender, EventArgs e)
        {
            
            if (JMT_txtCorreo.TextName.Equals(""))
            {
                JMT_txtCorreo.TextName = "Correo Electrónico";
            }
        }
        private void JMT_txtCorreo_Enter(object sender, EventArgs e)
        {
            if (JMT_txtCorreo.TextName.Equals("Correo Electrónico"))
            {
                JMT_txtCorreo.TextName = "";
            }
        }


        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
