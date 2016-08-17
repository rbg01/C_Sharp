using System;

namespace Tabla_multiplicar
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int multiplica, resultado;
			int contador;


			/*	1- Pedir dato de entrada */
			Console.WriteLine("Introduce un número para ver su tabla de multiplicar");
			multiplica = Convert.ToInt32(Console.ReadLine());

			for (contador = 1; contador <= 10; contador++)
			{
				resultado = multiplica * contador;
				Console.WriteLine("{0} X {1} = {2} \n", multiplica, contador, resultado);
			}
		}
	}
}
