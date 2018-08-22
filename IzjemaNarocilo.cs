using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja_test
{
    class IzjemaNarocilo : Exception
    {
        public IzjemaNarocilo(string error) : base (error)
        {
                
        }
    }
}
