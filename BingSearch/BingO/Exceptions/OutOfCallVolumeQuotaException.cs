using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingOWebSearchResults.Exceptions
{
    public class OutOfCallVolumeQuotaException : Exception
    {
        public OutOfCallVolumeQuotaException(string message) : base(message)
        {

        }
        
    }
}
