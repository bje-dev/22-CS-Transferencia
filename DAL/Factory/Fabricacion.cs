using DAL.Contract;
using DomainModel.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factory
{
    public class Fabricacion
    {
        #region Singleton
        private readonly static Fabricacion _instance = new Fabricacion();

        public static Fabricacion Current
        {
            get
            {
                return _instance;
            }
        }

        #endregion

        private string dataSource = ConfigurationManager.AppSettings["base"];
        public IRepositorioGenerico<Deposito> GetDepositoRepository()
        {
            if (dataSource == "memory")
                return new DAL.Implementations.Memoria.DepositoRepository();

            return null;
        }
        public IRepositorioGenerico<Producto> GetProductoRepository()
        {
            if (dataSource == "memory")
                return new DAL.Implementations.Memoria.ProductoRepository();

            return null;
        }
        public IRepositorioGenerico<Tienda> GetTiendaRepository()
        {
            if (dataSource == "memory")
                return new DAL.Implementations.Memoria.TiendaRepository();

            return null;
        }
        public IRepositorioTransferencias<OperacionHistoricaCab> GetTransferenciaRepository()
        {
            if (dataSource == "memory")
                return new DAL.Implementations.Memoria.TrasferenciaRepository();

            return null;
        }

  
    }
}
