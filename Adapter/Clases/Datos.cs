using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Clases
{
    class Datos
    {

        List<Estudiante> ArregloEstudiante = new List<Estudiante>();
      
        public List<Estudiante>  GetArregloEstudiante()
        {
            return ArregloEstudiante;
        }

        public void SetarregloEstudiante(List<Estudiante>  arregloEstudiante)
        {
            this.ArregloEstudiante = arregloEstudiante;
        }





        internal static IEnumerable<Estudiante> getArregloEstudiante()
        {
            throw new NotImplementedException();
        }
    }
}
