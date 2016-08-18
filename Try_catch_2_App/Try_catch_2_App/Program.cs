using System;

namespace Try_catch_2_App
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int num_1, num_2, resultado;

			try
			{
				Console.WriteLine("Introduzca el primer número: ");
				num_1 = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Introduzca el segundo número: ");
				num_2 = Convert.ToInt32(Console.ReadLine());

				resultado = num_1 / num_2;
				Console.WriteLine("{0} / {1} = {2}", num_1, num_2, resultado);
			}
			catch (FormatException)
			{
				Console.WriteLine("No es un número valido");
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("No se puede dividir por cero");
			}
	}
	}
}
