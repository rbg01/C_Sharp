


/*	 Crear un programa que pida una letra al usuario y diga si se trata de una
vocal.
*/

using System;

namespace Tipo_char
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			char letra;
			bool es_vocal;

			Console.WriteLine("Introduce una letra \n");
			letra = Convert.ToChar(Console.ReadLine());

			Console.WriteLine("La letra es {0}", letra);

			es_vocal = (letra == 'a') || (letra == 'e') || (letra == 'i') || (letra == 'o') || (letra == 'u');

			if (es_vocal)
				Console.WriteLine("Es una vocal");
			else
				Console.WriteLine("Es una consonante u otro simbolo");


		/*	if (letra == 'a')
				if (letra == 'e')
					if (letra == 'i')
						if (letra == 'o')
							if (letra == 'u')
								Console.WriteLine("Es una vocal");
							else
								Console.WriteLine("Es una consonante");

		*/
		}
	}
}


