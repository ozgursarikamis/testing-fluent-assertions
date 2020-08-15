using System;
using System.Collections.Generic;
using System.Text;
using Loans.Domain;

namespace Loans
{
    class Class1 : ValueObject
    {
        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
