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
    public partial class FrmCambiarContrasenia2 : Form
    {
        private MySqlCommand command;
        private String correo;
        public FrmCambiarContrasenia2(String pCorreo)
        {
            InitializeComponent();
            command = new MySqlCommand();
            command.Connection = FrmCargaApp.conexion;
            correo = pCorreo;
        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            if (comprobarCampos())
            {
                if (JTB_Contras2.TextName.Equals(JTB_Contras1.TextName))
                {
                    MessageBox.Show("Contraseñas correctas", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string query = "UPDATE `usuarios` SET `Contraseña`=" + JTB_Contras2.TextName + " WHERE `Correo` = '" + correo + "'";


                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    string query1 = "UPDATE `usuarios` SET `CodRecContr`=" + 0 + " WHERE `Correo` = '" + correo + "'";


                    command.CommandText = query1;
                    command.ExecuteNonQuery();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Contraseñas incorrectas", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmCambiarContrasenia2_Load(object sender, EventArgs e)
        {

        }
        private bool comprobarCampos()
        {
            //-----------------COMPROBACION DE LOS TXT------------------------
            bool correcto = true;
            foreach (Control c in this.Controls)
            {
                if (c is JMetroTextBox.JMetroTextBox)
                {
                    if (((JMetroTextBox.JMetroTextBox)c).TextName.Equals("") || ((JMetroTextBox.JMetroTextBox)c).TextName.Equals("Contraseña") || ((JMetroTextBox.JMetroTextBox)c).TextName.Equals("Repetir Contraseña"))
                    {
                        errorProvider1.SetError(c, "Falta por introducir los datos de este campo");
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

        private void JTB_Contras1_Leave(object sender, EventArgs e)
        {
            if (JTB_Contras1.TextName.Equals(""))
            {
                JTB_Contras1.TextName = "Contraseña";
            }
        }

        private void JTB_Contras1_Enter(object sender, EventArgs e)
        {

            if (JTB_Contras1.TextName.Equals("Contraseña"))
            {
                JTB_Contras1.TextName = "";
            }
        }

        private void JTB_Contras2_Leave(object sender, EventArgs e)
        {
            if (JTB_Contras2.TextName.Equals(""))
            {
                JTB_Contras2.TextName = "Repetir Contraseña";
            }
        }

        private void JTB_Contras2_Enter(object sender, EventArgs e)
        {
            if (JTB_Contras2.TextName.Equals("Repetir Contraseña"))
            {
                JTB_Contras2.TextName = "";
            }
        }
    }
}
