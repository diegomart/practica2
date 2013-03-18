using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace principal
{
    public class reloj
    {

        private void iniciarReloj()
        {

            Console.WriteLine("Reloj iniciciado");


            for (; ; )
            {
                Console.Clear();
                Console.WriteLine(DateTime.Now);
                Thread.Sleep(1000);
            }
        }
    }
}