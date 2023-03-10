using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.POCO
{
    public abstract class ALogistica
    {
       public Guid Identificador { get; set; }
        public String Nombre { get; set; }
        public String Provincia { get; set; }
        public String Localidad { get; set; }
    }
}
