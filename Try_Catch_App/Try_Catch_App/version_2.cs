using System;
namespace Try_Catch_App
{
	public class version_2
	{
		public version_2()
		{
			int numero1, numero2, resultado;
			try
			{
				Console.WriteLine("Introduzca el primer numero");
				numero1 = Convert.ToInt32(Console.ReadLine());
				numero2 = Convert.ToInt32(Console.ReadLine());
				resultado = numero1 / numero2;
				Console.WriteLine("Su división es: {0}", resultado);

			}
			catch (FormatException)

			{
				Console.WriteLine("No es un número válido");

			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("No se puede dividir entre cero");

			}
		}
	}
}
