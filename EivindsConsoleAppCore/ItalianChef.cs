using System;
using System.Collections.Generic;
using System.Text;

namespace EivindsConsoleAppCore
{
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
    }
}
