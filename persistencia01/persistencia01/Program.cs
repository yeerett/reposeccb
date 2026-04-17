/*
 * Creado por SharpDevelop.
 * Usuario: Querím Pineda
 * Fecha: 17/4/2026
 * Hora: 2:16 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;

namespace persistencia01
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("===== TALLER SECCION B =====");
			
			// Directorio
			
			string rutaraiz = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"DatosIujo");
			string rutareportes = Path.Combine(rutaraiz, "Reportes");
			
			Console.WriteLine(rutaraiz);
			Console.WriteLine(rutareportes);
			if (!Directory.Exists(rutareportes)) {
			    	Directory.CreateDirectory(rutareportes);
			    	Console.WriteLine("Directorio creado correctamente");
			    }
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}