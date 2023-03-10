using BLL.Contract;
using DomainModel.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public sealed class TransferenciaService : IGenericBLLRepository<OperacionHistoricaCab>
    {
        private readonly static TransferenciaService _instance = new TransferenciaService();

        public static TransferenciaService Current
        {
            get
            {
                return _instance;
            }
        }


        public void Add(OperacionHistoricaCab obj)
        {
            try
            {

                DAL.Factory.Fabricacion.Current.GetTransferenciaRepository().Add(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Update(OperacionHistoricaCab obj)
        {
            try
            {

                DAL.Factory.Fabricacion.Current.GetTransferenciaRepository().Update(obj);
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

                DAL.Factory.Fabricacion.Current.GetTransferenciaRepository().Delete(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public OperacionHistoricaCab GetById(Guid id)
        {
            try
            {

                return DAL.Factory.Fabricacion.Current.GetTransferenciaRepository().GetById(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<OperacionHistoricaCab> GetAll()
        {
            try
            {

                return DAL.Factory.Fabricacion.Current.GetTransferenciaRepository().GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTable GetByDestino(Guid identificador)
        {
            try
            {

                return DAL.Factory.Fabricacion.Current.GetTransferenciaRepository().GetByDestino(identificador);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTable GetMayorTresOperaciones(Guid identificador)
        {
            try
            {

                return DAL.Factory.Fabricacion.Current.GetTransferenciaRepository().GetMayorTresOperaciones(identificador);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
