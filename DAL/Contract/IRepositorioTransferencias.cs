using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contract
{
    public interface IRepositorioTransferencias<T>:IRepositorioGenerico<T>
    {
        void Add(T obj);

        void Update(T obj);

        void Delete(Guid id);

        T GetById(Guid id);

        IEnumerable<T> GetAll();
        DataTable GetByDestino(Guid identificador);
        DataTable GetMayorTresOperaciones(Guid identificador);
    }
}
