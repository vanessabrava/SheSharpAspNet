using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Business;
using DevSturdy.Toolkit.DataAccess.EntityFramework.Contexts.Abstract;

namespace Company.DataAccess.Contexts
{
    public interface IDbContextSheSharp : IDbContext
    {
        IDbSet<User> User { get; }
    }
}
