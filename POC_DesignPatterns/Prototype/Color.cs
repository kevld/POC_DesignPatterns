using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_DesignPatterns.Prototype
{
    public class Color : ICloneable
    {
        public Guid ColorGuid { get; set; }

        public string Name { get; set; }

        public Color(Guid colorGuid, string name)
        {
            ColorGuid = colorGuid;
            Name = name;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
