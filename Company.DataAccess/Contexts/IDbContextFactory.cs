using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DataAccess.Contexts
{
    public interface IDbContextFactory
    {
        IDbContextSheSharp GetContext();
    }
}
