using System.Data.Entity;

namespace OperationForecasting
{
    class ApplicationContext:DbContext
    {
        public DbSet<Log> Logs { get; set; }
        public DbSet<Material> Materials { get; set; }

        public ApplicationContext() : base("DefaultConnection") 
        {
            Database.SetInitializer<ApplicationContext>(null);
        }
    }
}
