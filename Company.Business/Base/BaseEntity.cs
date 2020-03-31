using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevSturdy.Validations.Interface;

namespace Company.Business.Base
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            this.DataEntry = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime DataEntry { get; set; }
        public IValidation Validation { get; private set; }

        protected virtual void Validate (IAssertion assetion)
        {
            this.Validation = assetion.Validate();
        }
    }
}
