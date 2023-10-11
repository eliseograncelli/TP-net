using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using BusinessEntities;

namespace DataAccess
{
    public class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Data Source=DESKTOP-JPRR102; Initial Catalog=dbSistema; Integrated Security =True; TrustServerCertificate=true");
            //optionsBuilder.UseSqlServer($"Data Source=PC-Fili; Initial Catalog=dbSistema; Integrated Security =True; TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<ProductoBE> Producto { get;set; }    
        public DbSet<UsuarioBE> Usuarios { get;set; }
    }
}
