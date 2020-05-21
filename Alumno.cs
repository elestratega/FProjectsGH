using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjects
{
    public class Alumno : Usuario
    {
        private int idAlumno;
        private String nombreAlumno;
        private String telefono;
        private Ciclo ciclo;
        private Centro centro;
        

        public Alumno(int idUsuario, string nombre, string correo, string contrasenia, int codRecContr, string tipoUsario, Image fotoUsuario, DateTime fechaCodRecContr,int idAlumno, string nombreAlumno, string telefono, Ciclo ciclo, Centro centro) : base(idUsuario,nombre, correo,contrasenia, codRecContr,tipoUsario,fotoUsuario,fechaCodRecContr)
        {
            this.idAlumno = idAlumno;
            this.nombreAlumno = nombreAlumno;
            this.telefono = telefono;
            this.ciclo = ciclo;
            this.centro = centro;
            
        }

        public Alumno()
        {
            this.idAlumno = 0;
            this.nombreAlumno = "";
            this.telefono = "";
            this.ciclo = new Ciclo();
            this.centro = new Centro();
            
        }

        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string Telefono { get => telefono; set => telefono = value; }      
        public Centro Centro { get => centro; set => centro = value; }
       
        public Ciclo Ciclo { get => ciclo; set => ciclo = value; }

        public override bool Equals(object obj)
        {
            return obj is Alumno alumno &&
                   base.Equals(obj) &&
                   idAlumno == alumno.idAlumno &&
                   nombreAlumno == alumno.nombreAlumno &&
                   telefono == alumno.telefono &&
                   EqualityComparer<Ciclo>.Default.Equals(ciclo, alumno.ciclo) &&
                   centro == alumno.centro;
        }

        public override int GetHashCode()
        {
            var hashCode = -1993539621;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + idAlumno.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombreAlumno);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(telefono);
            hashCode = hashCode * -1521134295 + EqualityComparer<Ciclo>.Default.GetHashCode(ciclo);
            hashCode = hashCode * -1521134295 + centro.GetHashCode();
 
            return hashCode;
        }
    }
}
