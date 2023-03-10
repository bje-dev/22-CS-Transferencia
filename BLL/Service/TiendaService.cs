using BLL.Contract;
using DomainModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public sealed class TiendaService : IGenericBLLRepository<Tienda>
    {
        private readonly static TiendaService _instance = new TiendaService();

        public static TiendaService Current
        {
            get
            {
                return _instance;
            }
        }


        public void Add(Tienda obj)
        {
            try
            {
              
                DAL.Factory.Fabricacion.Current.GetTiendaRepository().Add(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Update(Tienda obj)
        {
            try
            {

                DAL.Factory.Fabricacion.Current.GetTiendaRepository().Update(obj);
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

                DAL.Factory.Fabricacion.Current.GetTiendaRepository().Delete(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Tienda GetById(Guid id)
        {
            try
            {

               return DAL.Factory.Fabricacion.Current.GetTiendaRepository().GetById(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<Tienda> GetAll()
        {
            try
            {

                return DAL.Factory.Fabricacion.Current.GetTiendaRepository().GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
