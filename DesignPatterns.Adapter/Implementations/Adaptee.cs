using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Implementations
{
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "specific request";
        }
    }
}
