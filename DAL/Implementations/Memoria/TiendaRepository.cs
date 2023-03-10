using DAL.Contract;
using DomainModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.Memoria
{
    internal class TiendaRepository : IRepositorioGenerico<Tienda>
    {
        private List<Tienda> tienda = new List<Tienda>();
        public TiendaRepository()
        {
            tienda.Add(new Tienda { Identificador = new Guid("9D2B0228-4D0D-4C23-8B49-01A698857710"), Nombre = "Tienda T1", Provincia = "Bs As", Localidad = "Boulogne" });
            tienda.Add(new Tienda { Identificador = new Guid("9D2B0228-4D0D-4C23-8B49-01A698857711"), Nombre = "Tienda T2", Provincia = "Bs As", Localidad = "Don torcuato" });
            tienda.Add(new Tienda { Identificador = new Guid("9D2B0228-4D0D-4C23-8B49-01A698857712"), Nombre = "Tienda T3", Provincia = "Bs As", Localidad = "Bancalary" });
            tienda.Add(new Tienda { Identificador = new Guid("9D2B0228-4D0D-4C23-8B49-01A698857713"), Nombre = "Tienda T4", Provincia = "Bs As", Localidad = "Pacheco" });
        }
        public void Add(Tienda obj)
        {
            tienda.Add(obj);
        }

        public void Delete(Guid id)
        {
            var mov = tienda.Where(o => o.Identificador == id).FirstOrDefault();
            if (mov != null)
                tienda.Remove(mov);
        }

        public IEnumerable<Tienda> GetAll()
        {
            return tienda;
        }

        public Tienda GetById(Guid id)
        {
            return tienda.FirstOrDefault(x=>x.Identificador==id);
        }

        public void Update(Tienda obj)
        {
            var mov = tienda.Where(o => o.Identificador == obj.Identificador).FirstOrDefault();
            if (mov != null)
                tienda.Remove(mov);
            tienda.Add(obj);
        }
    }
}
