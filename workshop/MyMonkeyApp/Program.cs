
using MyMonkeyApp;

namespace MyMonkeyAppApp;

class Program
{
	private static readonly string[] asciiArt = new[]
	{
		@"  (o\_/o)",
		@" (='.'=)",
		@" (")_(")",
		@"  (o.o)",
		@"  ( : )",
		@"  (" + '"' + @". ." + '"' + @")",
		@"  (\__/)",
		@"  (='.'=)",
		@"  (")_(")"
	};

	static void Main()
	{
		var exit = false;
		var rand = new Random();
		while (!exit)
		{
			Console.Clear();
			// Mostrar arte ASCII aleatorio
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(asciiArt[rand.Next(asciiArt.Length)]);
			Console.ResetColor();
			Console.WriteLine("\n=== Menú de Monos ===");
			Console.WriteLine("1. Listar todos los monos");
			Console.WriteLine("2. Obtener detalles de un mono específico por nombre");
			Console.WriteLine("3. Obtener un mono aleatorio");
			Console.WriteLine("4. Salir de la aplicación");
			Console.Write("Seleccione una opción: ");
			var input = Console.ReadLine();
			Console.WriteLine();
			switch (input)
			{
				case "1":
					ListarTodosLosMonos();
					break;
				case "2":
					ObtenerMonoPorNombre();
					break;
				case "3":
					ObtenerMonoAleatorio();
					break;
				case "4":
					exit = true;
					break;
				default:
					Console.WriteLine("Opción no válida. Presione una tecla para continuar...");
					Console.ReadKey();
					break;
			}
		}
	}

	static void ListarTodosLosMonos()
	{
		var monos = MonkeyHelper.GetMonkeys();
		Console.WriteLine("\nNombre                      | Ubicación         | Población");
		Console.WriteLine("----------------------------------------------------------");
		foreach (var mono in monos)
		{
			Console.WriteLine($"{mono.Name,-26} | {mono.Location,-16} | {mono.Population,9}");
		}
		Console.WriteLine("\nPresione una tecla para volver al menú...");
		Console.ReadKey();
	}

	static void ObtenerMonoPorNombre()
	{
		Console.Write("Ingrese el nombre del mono: ");
		var nombre = Console.ReadLine();
		var mono = MonkeyHelper.GetMonkeyByName(nombre ?? "");
		if (mono != null)
		{
			Console.WriteLine($"\nNombre: {mono.Name}\nUbicación: {mono.Location}\nPoblación: {mono.Population}");
		}
		else
		{
			Console.WriteLine("Mono no encontrado.");
		}
		Console.WriteLine("\nPresione una tecla para volver al menú...");
		Console.ReadKey();
	}

	static void ObtenerMonoAleatorio()
	{
		var mono = MonkeyHelper.GetRandomMonkey();
		Console.WriteLine($"\n¡Mono aleatorio seleccionado!\nNombre: {mono.Name}\nUbicación: {mono.Location}\nPoblación: {mono.Population}");
		Console.WriteLine("\nPresione una tecla para volver al menú...");
		Console.ReadKey();
	}
}
