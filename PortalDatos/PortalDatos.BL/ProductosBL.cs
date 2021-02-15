using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalDatos.BL
{
    public class ProductosBL
    {
       public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Equipo de servidores";
            producto1.Precio = 1500;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Switches";
            producto2.Precio = 1000;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Equipo de servidores";
            producto3.Precio = 500;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);

            return listadeProductos;

        }
    }
}
