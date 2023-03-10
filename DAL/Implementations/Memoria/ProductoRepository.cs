using DAL.Contract;
using DomainModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.Memoria
{
    internal class ProductoRepository : IRepositorioGenerico<Producto>
    {
        private List<Producto> producto = new List<Producto>();
        public ProductoRepository()
        {
            producto.Add(new Producto { Identificador = new Guid("9D2B0228-4D0D-4C23-8B49-01A698857720"), Nombre = "Teclado", Descripcion = "Teclado Gamer", Precio = 1009.85 });
            producto.Add(new Producto { Identificador = new Guid("9D2B0228-4D0D-4C23-8B49-01A698857721"), Nombre = "Mouse", Descripcion = "Mouse Genius", Precio = 2030 });
            producto.Add(new Producto { Identificador = new Guid("9D2B0228-4D0D-4C23-8B49-01A698857722"), Nombre = "Monitor", Descripcion = "LED de 24 pulgadas", Precio = 10009 });
            producto.Add(new Producto { Identificador = new Guid("9D2B0228-4D0D-4C23-8B49-01A698857723"), Nombre = "Disco", Descripcion = "SSD 500GB", Precio = 5326 });
            producto.Add(new Producto { Identificador = new Guid("9D2B0228-4D0D-4C23-8B49-01A698857724"), Nombre = "Impresora", Descripcion = "Impresora Laser", Precio = 7054 });
            producto.Add(new Producto { Identificador = new Guid("9D2B0228-4D0D-4C23-8B49-01A698857725"), Nombre = "NotePad", Descripcion = "Superficie para mouse", Precio = 352 });
            producto.Add(new Producto { Identificador = new Guid("9D2B0228-4D0D-4C23-8B49-01A698857726"), Nombre = "Parlante", Descripcion = "Parlante Generico Genius", Precio = 3800 });
        }
        public void Add(Producto obj)
        {
            producto.Add(obj);
        }

        public void Delete(Guid id)
        {
            var mov = producto.Where(o => o.Identificador == id).FirstOrDefault();
            if (mov != null)
                producto.Remove(mov);
        }

        public IEnumerable<Producto> GetAll()
        {
            return producto;
        }

        public Producto GetById(Guid id)
        {
            return producto.FirstOrDefault(o => o.Identificador == id);
        }

        public void Update(Producto obj)
        {
            var mov = producto.Where(o => o.Identificador == obj.Identificador).FirstOrDefault();
            if (mov != null)
                producto.Remove(mov);
            producto.Add(obj);
        }
    }
}
