using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoRelacionesEntreClases.Ejercicio1
{
    public class Chofer
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string  Apellido { get; set; }
        public string Documento { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public string TipoLibretaConducir { get; set; }
    }
}
