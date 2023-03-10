using DomainModel.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entity
{
    public class Tienda : ALogistica
    {
        public Guid Identificador { get ; set ; }
        public string Nombre { get ; set ; }
        public string Provincia { get ; set ; }
        public string Localidad { get ; set ; }
    }
}
