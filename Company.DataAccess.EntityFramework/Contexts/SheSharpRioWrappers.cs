using Company.DataAccess.Contexts;
using DevSturdy.Toolkit.DataAccess.EntityFramework.Contexts.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevSturdy.Toolkit.DataAccess.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Company.DataAccess.EntityFramework.Mapping;
using Company.Business;

namespace Company.DataAccess.EntityFramework.Contexts
{
    public class SheSharpRioWrappers : DbContextBase , IDbContextSheSharp 
    {
        public SheSharpRioWrappers(string nameOrConnectionString)
            :base(nameOrConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new UserMapConfig());

        }

        public IDbSet<User> User { get; private set; }

        protected override void SetDbEntities()
        {
            this.User = base.Set<User>();
        }
    }
}
