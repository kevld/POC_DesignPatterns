using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_DesignPatterns.Adapter
{
    public class Adapter : IColor
    {
        private readonly Color _color;

        public Adapter(Color color)
        {
            _color = color;
        }

        public string GetColorName() => _color.GetColorName();
       
    }
}
