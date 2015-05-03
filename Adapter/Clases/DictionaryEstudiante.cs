using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Clases
{
    class DictionaryEstudiante
    {
        Dictionary<String, Estudiante> dictionary = new Dictionary<String, Estudiante>();

        internal Dictionary<String, Estudiante> Dictionary
        {
            get { return dictionary; }
            set { dictionary = value; }
        }


    }
}
