using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_Parcial_ADO
{
    public class Socio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni {  get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int NumeroSocio { get; set; }
        public bool CuotaAlDia {  get; set; }
    }
}
