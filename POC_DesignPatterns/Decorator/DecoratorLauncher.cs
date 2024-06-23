using POC_DesignPatterns.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_DesignPatterns.Decorator
{
    public class DecoratorLauncher : Launcher
    {
        public override void Launch()
        {
            var green = new GreenColor();
            Console.WriteLine($"Launching green... {GetColor.Result(green)}");

            var red = new RedDecorator(green);
            Console.WriteLine($"Launching red... {GetColor.Result(red)}");

            var blue = new BlueDecorator(red);
            Console.WriteLine($"Launching blue... {GetColor.Result(blue)}");
        }
    }
}
