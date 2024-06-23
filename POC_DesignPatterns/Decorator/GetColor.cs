using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_DesignPatterns.Decorator
{
    public static class GetColor
    {
        public static string Result(Color color)
        {
            return $"Result : {color.GetColorName()}";
        }
    }
}
