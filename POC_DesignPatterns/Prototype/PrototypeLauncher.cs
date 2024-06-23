using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_DesignPatterns.Prototype
{
    public class PrototypeLauncher
    {
        public void Launch() 
        {
            var p1 = new Color(Guid.NewGuid(), "Green");
            var p2 = (Color) p1.Clone() ;

            Console.WriteLine($"P1 : {p1.Name}, {p1.ColorGuid}");
            Console.WriteLine($"P2 : {p2.Name}, {p2.ColorGuid}");

            Console.WriteLine("Editing P1");
            p1.Name = "Blue";
            p1.ColorGuid = Guid.NewGuid();

            Console.WriteLine($"P1 : {p1.Name}, {p1.ColorGuid}");
            Console.WriteLine($"P2 : {p2.Name}, {p2.ColorGuid}");
        }
    }
}
