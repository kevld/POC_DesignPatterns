using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_DesignPatterns.Decorator
{
    public class Decorator : Color
    {
        protected Color? _color;

        public Decorator(Color color)
        {
            _color = color;
        }

        public override string GetColorName()
        {
            return _color?.GetColorName() ?? "No color";
        }

        public void SetColor(Color color)
        {
            _color = color;
        }
    }
}
