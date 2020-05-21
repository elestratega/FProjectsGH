using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjects
{
    public class Proyecto
    {
        private int idProyecto;
        private String nombreProyecto;
        private String descripcion;
        private String archivos;
        private bool estado;
        private int valoracion;
        private Ciclo ciclo;
        private Alumno alumno;
        private DateTime fecha;


        public Proyecto(int idProyecto, string nombreProyecto, string descripcion, string archivos, bool estado, int valoracion, Ciclo ciclo, Alumno alumno, DateTime fecha)
        {
            this.idProyecto = idProyecto;
            this.nombreProyecto = nombreProyecto;
            this.descripcion = descripcion;
            this.archivos = archivos;
            this.estado = estado;
            this.valoracion = valoracion;
            this.ciclo = ciclo;
            this.alumno = alumno;
            this.fecha = fecha;
        }

        public Proyecto()
        {
            this.idProyecto = 0;
            this.nombreProyecto = "";
            this.descripcion = "";
            this.archivos = "";
            this.estado = false;
            this.valoracion = 0;
            this.ciclo = new Ciclo();
            this.alumno = new Alumno();
            this.fecha = new DateTime();
        }

        public int IdProyecto { get => idProyecto; set => idProyecto = value; }
        public string NombreProyecto { get => nombreProyecto; set => nombreProyecto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Archivos { get => archivos; set => archivos = value; }
        public bool Estado { get => estado; set => estado = value; }
        public int Valoracion { get => valoracion; set => valoracion = value; }
        public Ciclo Ciclo { get => ciclo; set => ciclo = value; }
        public Alumno Alumno { get => alumno; set => alumno = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public override bool Equals(object obj)
        {
            return obj is Proyecto proyecto &&
                   idProyecto == proyecto.idProyecto &&
                   nombreProyecto == proyecto.nombreProyecto &&
                   descripcion == proyecto.descripcion &&
                   archivos == proyecto.archivos &&
                   estado == proyecto.estado &&
                   valoracion == proyecto.valoracion &&
                   EqualityComparer<Ciclo>.Default.Equals(ciclo, proyecto.ciclo) &&
                   EqualityComparer<Alumno>.Default.Equals(alumno, proyecto.alumno) &&
                   fecha == proyecto.fecha;
        }

        public override int GetHashCode()
        {
            var hashCode = 702782718;
            hashCode = hashCode * -1521134295 + idProyecto.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombreProyecto);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(descripcion);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(archivos);
            hashCode = hashCode * -1521134295 + estado.GetHashCode();
            hashCode = hashCode * -1521134295 + valoracion.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Ciclo>.Default.GetHashCode(ciclo);
            hashCode = hashCode * -1521134295 + EqualityComparer<Alumno>.Default.GetHashCode(alumno);
            hashCode = hashCode * -1521134295 + fecha.GetHashCode();
            return hashCode;
        }
    }
}
