using DomainModel.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entity
{
    public class OperacionHistoricaCab
    {
        public Guid Identificador { get; set; }
        public ALogistica Origen{ get; set; }
        public ALogistica Destino { get; set; }
        public DateTime Fecha { get; set; }
        public String Usuario { get; set; }
        public List<OperacionHistoricaDet> Movimientos { get; set; } = new List<OperacionHistoricaDet>();
    }
}
