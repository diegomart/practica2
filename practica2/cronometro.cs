using System;

using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Practica2
{

    public class cronometro
    {

        private void iniciarCronometro()
        {


            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    for (int k = 0; k < 60; k++)
                    {
                        for (int l = 0; l < 100; l++)
                        {

                            Thread.Sleep(1 / 999999999);

                            Console.WriteLine(i+":"+j+":"+k+":"+l);
                            

                        }
                    }
                }
            }
        }
    }
}

    
