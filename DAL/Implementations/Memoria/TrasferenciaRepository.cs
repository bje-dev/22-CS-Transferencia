using DAL.Contract;
using DomainModel.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.Memoria
{
    internal class TrasferenciaRepository : IRepositorioTransferencias<OperacionHistoricaCab>
    {
        private static List<OperacionHistoricaCab> Movimientos = new List<OperacionHistoricaCab>();
        public void Add(OperacionHistoricaCab obj)
        {
            Movimientos.Add(obj);
        }

        public void Delete(Guid id)
        {
            var mov = Movimientos.Where(o => o.Identificador == id).FirstOrDefault();
            if (mov != null)
                Movimientos.Remove(mov);
        }

        public IEnumerable<OperacionHistoricaCab> GetAll()
        {
            return Movimientos;
        }

        public OperacionHistoricaCab GetById(Guid id)
        {
            return Movimientos.Where(o => o.Identificador == id).FirstOrDefault();
        }

        public void Update(OperacionHistoricaCab obj)
        {
            var mov = Movimientos.Where(o => o.Identificador == obj.Identificador).FirstOrDefault();
            if (mov != null)
                Movimientos.Remove(mov);
            Movimientos.Add(obj);
        }

        public DataTable GetByDestino(Guid _identificador)
        {
            DataTable dataTable = new DataTable();
            DataColumn identificador = new DataColumn();
            identificador.ColumnName = "Identificador";
            dataTable.Columns.Add(identificador);
            DataColumn Origen = new DataColumn();
            Origen.ColumnName = "Origen";
            dataTable.Columns.Add(Origen);
            DataColumn Usuario = new DataColumn();
            Usuario.ColumnName = "Usuario";
            dataTable.Columns.Add(Usuario);
            DataColumn fecha = new DataColumn();
            fecha.ColumnName = "Fecha";
            dataTable.Columns.Add(fecha);

            foreach (OperacionHistoricaCab item in Movimientos)
            {
                if (item.Destino is Deposito)
                {
                    var deposito = ((Deposito)item.Destino);
                    if (deposito.Identificador == _identificador)
                    {
                        DataRow dr = dataTable.NewRow();
                        dr[0] = item.Identificador.ToString();
                        dr[1] = deposito.Nombre;
                        dr[2] = item.Usuario;
                        dr[3] = item.Fecha;

                        dataTable.Rows.Add(dr);
                    }
                }
                else
                {
                    var tienda = ((Tienda)item.Destino);
                    if (tienda.Identificador == _identificador)
                    {
                        DataRow dr = dataTable.NewRow();
                        dr[0] = item.Identificador.ToString();
                        dr[1] = tienda.Nombre;
                        dr[2] = item.Usuario;
                        dr[3] = item.Fecha;
                        dataTable.Rows.Add(dr);
                    }
                }


            }
            return dataTable;
        }

        public DataTable GetMayorTresOperaciones(Guid _identificador)
        {
            DataTable dataTable = new DataTable();
            DataColumn identificador = new DataColumn();
            identificador.ColumnName = "Identificador";
            dataTable.Columns.Add(identificador);
            DataColumn Origen = new DataColumn();
            Origen.ColumnName = "Origen";
            dataTable.Columns.Add(Origen);
            DataColumn Destino = new DataColumn();
            Destino.ColumnName = "Destino";
            dataTable.Columns.Add(Destino);
            DataColumn Usuario = new DataColumn();
            Usuario.ColumnName = "Usuario";
            dataTable.Columns.Add(Usuario);
            DataColumn fecha = new DataColumn();
            fecha.ColumnName = "Fecha";
            dataTable.Columns.Add(fecha);
            //(c.Destino is Deposito ? ((Deposito)c.Destino).Identificador: ((Tienda)c.Destino).Identificador)
          var mayoresTres =  Movimientos
            .GroupBy(c => new { Identificador = (c.Destino is Deposito) ? ((Deposito)c.Destino).Identificador : ((Tienda)c.Destino).Identificador,Fecha= c.Fecha.Date})
            .Where(grp => grp.Count() > 3)
            .Select(grp =>new { grp.Key.Identificador,Fecha= grp.Key.Fecha.Date })
            .OrderBy(x=>x.Fecha);

            foreach (var item in mayoresTres)
            {
                var movimientoPorFecha = Movimientos.Where(x => (x.Destino is Deposito ? ((Deposito)x.Destino).Identificador : ((Tienda)x.Destino).Identificador) == item.Identificador && x.Fecha.Date == item.Fecha).ToList();
                
                foreach (var itemMov in movimientoPorFecha)
                {

                    if (itemMov.Destino is Deposito)
                    {
                        var deposito = ((Deposito)itemMov.Destino);
                      
                            DataRow dr = dataTable.NewRow();
                            dr[0] = itemMov.Identificador.ToString();
                            dr[1] = ((Deposito)itemMov.Origen).Nombre;
                            dr[2] = deposito.Nombre;                            
                            dr[3] = itemMov.Usuario;
                            dr[4] = itemMov.Fecha;

                            dataTable.Rows.Add(dr);
                    }
                    else
                    {
                        var tienda = ((Tienda)itemMov.Destino);
                            DataRow dr = dataTable.NewRow();
                            dr[0] = itemMov.Identificador.ToString();
                            dr[1] = ((Deposito)itemMov.Origen).Nombre;
                            dr[2] = tienda.Nombre;
                            dr[3] = itemMov.Usuario;
                            dr[4] = itemMov.Fecha;
                            dataTable.Rows.Add(dr);
                    }
                }
               


            }
            return dataTable;
        }
    }
}
