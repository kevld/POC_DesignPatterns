using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_DesignPatterns.Adapter
{
    public class Color
    {
        private string Name { get; set; }

        public Color(string name)
        {
            Name = name;
        }

        public string GetColorName() => Name;
    }
}
