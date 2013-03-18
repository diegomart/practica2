
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System;

namespace practica2
{
	class principal
	{
		public void muestraMenu(){
			Console.WriteLine("***Menu***");
			Console.WriteLine("1.-Reloj");
			Console.WriteLine("2.-Cronometro");
		}


		public void leerEntrada(){
			int opcion = int.Parse(Console.ReadLine());
			if(opcion == 1){
				reloj Reloj = new reloj();
				Reloj.iniciarReloj();
			}else{
				cronometro Cronometro = new cronometro();
                Cronometro.iniciarCronometro();
			}
		}

		public static void Main (string[] args)
		{

			principal programa = new principal();
			programa.muestraMenu();
			programa.leerEntrada();
		}
	}
}
