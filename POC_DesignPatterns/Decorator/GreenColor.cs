using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_DesignPatterns.Decorator
{
    public class GreenColor : Color
    {
        public override string GetColorName()
        {
            return "Green";
        }
    }
}
