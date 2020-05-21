using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjects
{
    public class Ciclo
    {
        private int idCiclo;
        private String nombreCiclo;
        private Centro centro;



        public Ciclo(int idCiclo, string nombreCiclo, Centro centro)
        {
            this.idCiclo = idCiclo;
            this.nombreCiclo = nombreCiclo;
            this.centro = centro;
        }

        public Ciclo()
        {
            this.idCiclo = 0;
            this.nombreCiclo = "";
            this.centro = new Centro();
        }
        public int IdCiclo { get => idCiclo; set => idCiclo = value; }
        public string NombreCiclo { get => nombreCiclo; set => nombreCiclo = value; }
        public Centro Centro { get => centro; set => centro = value; }

        public override bool Equals(object obj)
        {
            return obj is Ciclo ciclo &&
                   idCiclo == ciclo.idCiclo &&
                   nombreCiclo == ciclo.nombreCiclo &&
                   EqualityComparer<Centro>.Default.Equals(centro, ciclo.centro) &&
                   IdCiclo == ciclo.IdCiclo &&
                   NombreCiclo == ciclo.NombreCiclo &&
                   EqualityComparer<Centro>.Default.Equals(Centro, ciclo.Centro);
        }

        public override int GetHashCode()
        {
            var hashCode = 1952208;
            hashCode = hashCode * -1521134295 + idCiclo.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombreCiclo);
            hashCode = hashCode * -1521134295 + EqualityComparer<Centro>.Default.GetHashCode(centro);
            hashCode = hashCode * -1521134295 + IdCiclo.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NombreCiclo);
            hashCode = hashCode * -1521134295 + EqualityComparer<Centro>.Default.GetHashCode(Centro);
            return hashCode;
        }
    }
}
