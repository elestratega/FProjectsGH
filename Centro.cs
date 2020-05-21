using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjects
{
    public class Centro : Usuario
    {
        private int idCentro;
        private String nombreCentro;
        private String direccion;
        private String telefono;
        private int idUsuario;
        private String contraseniaCentro;



        public Centro(int idUsuario, string nombre, string correo, string contrasenia, int codRecContr, string tipoUsario, Image fotoUsuario, DateTime fechaCodRecContr, int idCentro, string nombreCentro, string direccion, string telefono, string contraseniaCentro) : base(idUsuario, nombre, correo, contrasenia, codRecContr, tipoUsario, fotoUsuario, fechaCodRecContr)
        {
            this.idCentro = idCentro;
            this.nombreCentro = nombreCentro;
            this.direccion = direccion;
            this.telefono = telefono;
            this.idUsuario = idUsuario;
            this.contraseniaCentro = contraseniaCentro;
        }

        public Centro()
        {
            this.idCentro = 0;
            this.nombreCentro = "";
            this.direccion = "";
            this.telefono = "";
            this.idUsuario = 0;
            this.contraseniaCentro = "";
        }

        public int IdCentro { get => idCentro; set => idCentro = value; }
        public string NombreCentro { get => nombreCentro; set => nombreCentro = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int IdUsuario1 { get => idUsuario; set => idUsuario = value; }
        public string ContraseniaCentro { get => contraseniaCentro; set => contraseniaCentro = value; }

        public override bool Equals(object obj)
        {
            return obj is Centro centro &&
                   base.Equals(obj) &&
                   idCentro == centro.idCentro &&
                   nombreCentro == centro.nombreCentro &&
                   direccion == centro.direccion &&
                   telefono == centro.telefono &&
                   idUsuario == centro.idUsuario &&
                   contraseniaCentro == centro.contraseniaCentro;
        }

        public override int GetHashCode()
        {
            var hashCode = 634492291;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + idCentro.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombreCentro);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(direccion);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(telefono);
            hashCode = hashCode * -1521134295 + idUsuario.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(contraseniaCentro);
            return hashCode;
        }
    }
}
