using DAL.Contract;
using DomainModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.Memoria
{
    internal class DepositoRepository : IRepositorioGenerico<Deposito>
    {
        private List<Deposito> deposito = new List<Deposito>();
        public DepositoRepository()
        {
            deposito.Add(new Deposito { Identificador = new Guid("9D2B0228-4D0D-4C23-8B49-01A698857700"), Nombre = "Deposito D1", Provincia = "Bs As", Localidad = "Boulogne" });
            deposito.Add(new Deposito { Identificador = new Guid("9D2B0228-4D0D-4C23-8B49-01A698857701"), Nombre = "Deposito D2", Provincia = "Bs As", Localidad = "Don torcuato" });
            deposito.Add(new Deposito { Identificador = new Guid("9D2B0228-4D0D-4C23-8B49-01A698857702"), Nombre = "Deposito D3", Provincia = "Bs As", Localidad = "Bancalary" });
            deposito.Add(new Deposito { Identificador = new Guid("9D2B0228-4D0D-4C23-8B49-01A698857703"), Nombre = "Deposito D4", Provincia = "Bs As", Localidad = "Pacheco" });
        }
        public void Add(Deposito obj)
        {
            deposito.Add(obj);
        }

        public void Delete(Guid id)
        {
            var mov = deposito.Where(o => o.Identificador == id).FirstOrDefault();
            if (mov != null)
                deposito.Remove(mov);
        }

        public IEnumerable<Deposito> GetAll()
        {
            return deposito;
        }

        public Deposito GetById(Guid id)
        {
            return deposito.FirstOrDefault(x => x.Identificador == id);
        }

        public void Update(Deposito obj)
        {
            var mov = deposito.Where(o => o.Identificador == obj.Identificador).FirstOrDefault();
            if (mov != null)
                deposito.Remove(mov);
            deposito.Add(obj);
        }
    }
}
