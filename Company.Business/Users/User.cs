using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Business.Base;
using DevSturdy.Toolkit.Cryptography;

namespace Company.Business
{
    public class User :BaseEntity
    {
        public User() : base() { }

        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
