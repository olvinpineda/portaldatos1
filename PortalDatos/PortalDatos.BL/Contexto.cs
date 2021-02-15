using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalDatos.BL
{
    public class Contexto : DbContext
    {
        public Contexto(): base("PortalDatosDB")
        {

        }
        public DbSet<Producto> Productos { get; set; }
    }
}
