using BLL.Contract;
using DomainModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public sealed class DepositoService : IGenericBLLRepository<Deposito>
    {
        private readonly static DepositoService _instance = new DepositoService();

        public static DepositoService Current
        {
            get
            {
                return _instance;
            }
        }


        public void Add(Deposito obj)
        {
            try
            {

                DAL.Factory.Fabricacion.Current.GetDepositoRepository().Add(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Update(Deposito obj)
        {
            try
            {

                DAL.Factory.Fabricacion.Current.GetDepositoRepository().Update(obj);
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

                DAL.Factory.Fabricacion.Current.GetDepositoRepository().Delete(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Deposito GetById(Guid id)
        {
            try
            {

                return DAL.Factory.Fabricacion.Current.GetDepositoRepository().GetById(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<Deposito> GetAll()
        {
            try
            {

                return DAL.Factory.Fabricacion.Current.GetDepositoRepository().GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
