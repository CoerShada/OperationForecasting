using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OperationForecasting
{
    class ApplicationContext:DbContext
    {
        public DbSet<Log> Logs { get; set; }

        public ApplicationContext() : base("DefaultConnection") 
        {
            Database.SetInitializer<ApplicationContext>(null);
        }
    }
}
