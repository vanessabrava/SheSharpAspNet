using Company.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DataAccess.EntityFramework.Contexts
{
    public class DbContextFactory :IDbContextFactory, IDbContextFactory<SheSharpRioWrappers>
    {
        public IDbContextSheSharp GetContext()
        {
            return new SheSharpRioWrappers("DB_SHESHARP");
        }

        public SheSharpRioWrappers Create()
        {
            return new SheSharpRioWrappers("DB_SHESHARP");
        }
    }
}
