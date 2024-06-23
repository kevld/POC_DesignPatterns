using POC_DesignPatterns.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_DesignPatterns.Adapter
{
    public class AdapterLauncher : Launcher
    {
        public override void Launch()
        {
            Color color = new Color("Green");
            IColor adaptedColor = new Adapter(color);

            Console.WriteLine($"Original color : {color.GetColorName()}");
            Console.WriteLine($"Adapted color : {adaptedColor.GetColorName()}");
        }
    }
}
