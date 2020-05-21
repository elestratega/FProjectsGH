using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjects
{
    public class Usuario
    {
        private int idUsuario;
        private String nombre;
        private String correo;
        private String contrasenia;
        private int codRecContr;
        private String tipoUsario;
        private Image fotoUsuario;
        private DateTime fechaCodRecContr;

        public Usuario(int idUsuario, string nombre, string correo, string contrasenia, int codRecContr, string tipoUsario, Image fotoUsuario, DateTime fechaCodRecContr)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.correo = correo;
            this.contrasenia = contrasenia;
            this.codRecContr = codRecContr;
            this.tipoUsario = tipoUsario;
            this.fotoUsuario = fotoUsuario;
            this.fechaCodRecContr = fechaCodRecContr;
        }

        public Usuario()
        {
            this.idUsuario = 0;
            this.nombre = "";
            this.correo = "";
            this.contrasenia = "";
            this.codRecContr = 0;
            this.tipoUsario = "";
            
            this.fechaCodRecContr = new DateTime();
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public int CodRecContr { get => codRecContr; set => codRecContr = value; }
        public string TipoUsario { get => tipoUsario; set => tipoUsario = value; }
        public Image FotoUsuario { get => fotoUsuario; set => fotoUsuario = value; }
        public DateTime FechaCodRecContr { get => fechaCodRecContr; set => fechaCodRecContr = value; }

        public override bool Equals(object obj)
        {
            return obj is Usuario usuario &&
                   idUsuario == usuario.idUsuario &&
                   nombre == usuario.nombre &&
                   correo == usuario.correo &&
                   contrasenia == usuario.contrasenia &&
                   codRecContr == usuario.codRecContr &&
                   tipoUsario == usuario.tipoUsario &&
                   EqualityComparer<Image>.Default.Equals(fotoUsuario, usuario.fotoUsuario) &&
                   fechaCodRecContr == usuario.fechaCodRecContr;
        }

        public override int GetHashCode()
        {
            var hashCode = -1895202683;
            hashCode = hashCode * -1521134295 + idUsuario.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(correo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(contrasenia);
            hashCode = hashCode * -1521134295 + codRecContr.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(tipoUsario);
            hashCode = hashCode * -1521134295 + EqualityComparer<Image>.Default.GetHashCode(fotoUsuario);
            hashCode = hashCode * -1521134295 + fechaCodRecContr.GetHashCode();
            return hashCode;
        }
    }
}

