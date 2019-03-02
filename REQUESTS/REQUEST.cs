using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTS
{
    public abstract class REQUEST
    {
        public DateTime DATA1 { get; set; }
        public DateTime DATA2 { get; set; }
        public abstract void getRequest();
    }
}
