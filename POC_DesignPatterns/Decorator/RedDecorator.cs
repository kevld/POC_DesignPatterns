using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_DesignPatterns.Decorator
{
    public class RedDecorator : Decorator
    {
        public RedDecorator(Color color) : base(color)
        {
        }

        public override string GetColorName()
        {
            return $"From red : {base.GetColorName()}";
        }
    }
}
