using System;

namespace Try_Catch_App
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int num_1, num_2, resultado;

			try
			{
				Console.WriteLine("Introduzca el primer número");
				num_1 = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Introduzca el segundo número");
				num_2 = Convert.ToInt32(Console.ReadLine());

				resultado = num_1 / num_2;

				Console.WriteLine("Su división es {0}", resultado);
			}
			catch (Exception error_encontrado)
			{
				Console.WriteLine("Ha habído un error {0}", error_encontrado.Message);

			}
		}
	}
}
