using BLL.Contract;
using DomainModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public sealed class ProductoService : IGenericBLLRepository<Producto>
    {
        private readonly static ProductoService _instance = new ProductoService();

        public static ProductoService Current
        {
            get
            {
                return _instance;
            }
        }


        public void Add(Producto obj)
        {
            try
            {

                DAL.Factory.Fabricacion.Current.GetProductoRepository().Add(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Update(Producto obj)
        {
            try
            {

                DAL.Factory.Fabricacion.Current.GetProductoRepository().Update(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Delete(Guid id)
        {
            try
            {

                DAL.Factory.Fabricacion.Current.GetProductoRepository().Delete(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Producto GetById(Guid id)
        {
            try
            {

                return DAL.Factory.Fabricacion.Current.GetProductoRepository().GetById(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<Producto> GetAll()
        {
            try
            {

                return DAL.Factory.Fabricacion.Current.GetProductoRepository().GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
