using DevExpress.XtraEditors.Filtering.Templates;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FProjects
{
    public partial class FrmCambiarContrasenia : Form
    {
        private MySqlCommand command;
        private String correo;
        public FrmCambiarContrasenia()
        {
            InitializeComponent();
            command = new MySqlCommand();
            command.Connection = FrmCargaApp.conexion;
            correo = "";
        }

        private void FrmCambiarContrasenia_Load(object sender, EventArgs e)
        {

          


        }

        private void JTButton_Enviar_Click(object sender, EventArgs e)
        {
            //Comprabacion contra la base de datos
            if (comprobarCampos())
            {

                MessageBox.Show(JMT_Correo.TextName);
                String sql = "Select Correo from usuarios where Correo = '" + JMT_Correo.TextName + "'";
                MySqlCommand command = new MySqlCommand(sql, FrmCargaApp.conexion);


                //try
                //{
              
                    command.ExecuteNonQuery();

                    if (tiempoSpamCumplido(JMT_Correo.TextName))
                    {
                        mandarCorreo(JMT_Correo.TextName);
                        correo = JMT_Correo.TextName;
                        JTB_Pin.Visible = true;
                        btnConfirmar.Visible = true;
                    }

                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("El correo no existe");
                //}

            }
        }

        private bool comprobarCampos()
        {
            //-----------------COMPROBACION DE LOS TXT------------------------
            bool correcto = true;
            foreach (Control c in this.Controls)
            {
                if (c is JMetroTextBox.JMetroTextBox)
                {
                    if (((JMetroTextBox.JMetroTextBox)c).TextName.Equals("") || ((JMetroTextBox.JMetroTextBox)c).TextName.Equals("Dirección de correo electrónico"))
                    {
                        errorProvider1.SetError(c, "Falta por introducir el correo electronico");
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

        private int generarCodRec()
        {
            String numeroRec = "";
            Random r = new Random();
            for (int i = 0; i < 4; i++)
            {
                numeroRec += Convert.ToString(r.Next(0, 9));
            }

            return Convert.ToInt32(numeroRec);
        }

        //metodo para saber si el cCodRecContr se ha cambiado hace mas de 3 min
        private Boolean tiempoSpamCumplido(String correo)
        {
            //sacamos la fecha del correo
            String sql = "Select FechaCodRecContr from usuarios where Correo = '" + correo + "'";
            DateTime fechaRecuperacion = DateTime.Now.AddDays(7);
               
            MySqlCommand command = new MySqlCommand(sql, FrmCargaApp.conexion);
            MySqlDataReader reader = command.ExecuteReader();

            try
            {
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if(reader.GetValue(0) != null)
                    {
                        fechaRecuperacion = reader.GetDateTime(0);
                    }
                    
                }
            }
            reader.Close(); 
            

                if(fechaRecuperacion != DateTime.Now.AddDays(7))
                {
                //si la fecha actual - 3 minutos es < que la del codigo de recuperacion
                MessageBox.Show("Fecha de la base de datos: " + fechaRecuperacion.ToString());
                MessageBox.Show("Fecha actual - 3 min: " + DateTime.Now.AddMinutes(-3).ToString());



                if (DateTime.Now.AddMinutes(-3) < fechaRecuperacion)
                    {
                        MessageBox.Show("No se puede cambiar la contraseña en 3 min");
                        return false;
                    }
                    else
                    {

                        return true;
                    }
                }
                else
                {
                    return true;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("No se puede cambiar la contraseña en 3 min excepcion");
                return false;
            }




        }

        private void mandarCorreo(String pCorreo)
        {
            MessageBox.Show("Se ha enviado el correo. Espere unos minutos para que le llegue", "Correo en camino", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int numeroRec = generarCodRec();
            string emailOrigen = "fprojectsFP@gmail.com";
            string pwd = "fprojects090200";
            string msg = "Hola, se ha solicitado el codigo de recuperacion de tu cuenta: " + numeroRec + " . Si tu no lo has solicitado ponte en contacto con nosotros a traves del correo de " + emailOrigen;

            MailMessage oMailMessage = new MailMessage(emailOrigen, pCorreo, "Codigo de recuperacion de la contraseña de Fprojects", msg);

            oMailMessage.IsBodyHtml = true;

            SmtpClient oSmtpClient = new SmtpClient("smtp.gmail.com", 587);

            oSmtpClient.EnableSsl = true;
            oSmtpClient.UseDefaultCredentials = false;
            oSmtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            oSmtpClient.Credentials = new System.Net.NetworkCredential(emailOrigen, pwd);

            oSmtpClient.Send(oMailMessage);
            oSmtpClient.Dispose();

            string query = "UPDATE usuarios SET CodRecContr =" + numeroRec + ", FechaCodRecContr = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE Correo = '" + pCorreo + "'";


            command.CommandText = query;
            command.ExecuteNonQuery();


        }

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

        private void JTB_Pin_Enter(object sender, EventArgs e)
        {
            if (JTB_Pin.TextName.Equals("PIN"))
            {
                JTB_Pin.TextName = "";
            }
        }

        private void JTB_Pin_Leave(object sender, EventArgs e)
        {
            if (JTB_Pin.TextName.Equals(""))
            {
                JTB_Pin.TextName = "PIN";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (JTB_Pin.TextName.Equals("") || JTB_Pin.TextName.Equals("PIN"))
            {
                errorProvider1.SetError(JTB_Pin, "Falta por introducir el PIN");

            }
            else
            {
                errorProvider1.SetError(JTB_Pin, "");

                command.CommandText = "Select CodRecContr from usuarios where Correo = '" + correo + "'";
                MySqlDataReader reader = null;
                int numero = 0;
                try
                {
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        numero = reader.GetInt32(0);
                        
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("No se ha solicitado el pin");
                }
                reader.Close();
                if (JTB_Pin.TextName.Equals(Convert.ToString(numero)))
                {
                    MessageBox.Show("PIN correcto", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmCambiarContrasenia2 frmCambiarContrasenia2 = new FrmCambiarContrasenia2(correo);
                    frmCambiarContrasenia2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("PIN incorrecto", "Inorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {
            FrmRegistrarse f = new FrmRegistrarse();
            f.ShowDialog();
        }

        private void lbInicioSesion_Click(object sender, EventArgs e)
        {
            FrmInicioSesion frmInicioSesion = new FrmInicioSesion();
            frmInicioSesion.ShowDialog(); 
        }
    }
}
