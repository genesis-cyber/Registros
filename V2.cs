using System;
using System. IO;

namespace V2
{
	class program 
	{
		static void Main(string []args)
		{
			static void Main(string[] args)
		{
			string filePath = args[0];
			int opcion2;

			Console.WriteLine("¿Que desea realizar?");
			Console.WriteLine("1. agregar");
			Console.WriteLine("2. listado");
			Console.WriteLine("3. Buscar");
			opcion2 = Convert.ToInt32(Console.ReadLine());

			switch (opcion2)
			{
				case 1:
					string nombre;
					string apellido;
					string opcion;
					string cedula;
					string edad;

				datos:
					Console.WriteLine("por favor inserte su nombre");
					nombre = Console.ReadLine();
					Console.WriteLine("por favor inserte su apellido");
					apellido = Console.ReadLine();
					Console.WriteLine("por favor inserte su cedula");
					cedula = Console.ReadLine();
					Console.WriteLine("por favor inserte su edad");
					edad = Console.ReadLine();

				informacion:
					Console.WriteLine("desea guardar la informacion? SI O NO");
					opcion = (Console.ReadLine().ToUpper());

					if (opcion == "SI")
					{
						Stream x = new FileStream(filePath, FileMode.Append, FileAccess.Write);
						StreamWriter Writer = new StreamWriter(x);
						Writer.WriteLine(cedula + ", " + nombre + ", " + apellido + ", " +edad );
					}
					else if (opcion == "NO")
					{
						goto datos;
					}
					else 
			        {
						goto informacion;
					}

					break;

				case 2:
					Stream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
					StreamReader sr = new StreamReader(fs);
					System.Console.WriteLine(sr.ReadToEnd());

					break;

				case 3:
					StreamReader lectura;
					string lista, cedula2;
					bool encontrado = false;
					string[] campo = new string[4];
					char[] comas = { ',' };

					lectura = File.OpenText("Registro.txt");
					System.Console.WriteLine("ingrese el numero de cedula que desea encontrar");
					cedula2 = System.Console.ReadLine();
					lista = lectura.ReadLine();

					while (lista != null && encontrado == false)
					{
						campo = lista.Split(comas);

						if (campo[0].Trim().Equals(comas))
						{
							System.Console.WriteLine("cedula: " + campo[0].Trim());
							System.Console.WriteLine("Nombre: " + campo[1].Trim());
							System.Console.WriteLine("apellido: " + campo[2].Trim());
							System.Console.WriteLine("edad: " + campo[3].Trim());
							encontrado = true;
						}
						else
						{
							lista = lectura.ReadLine();
						}
					}
					if (encontrado == false)
					{
						System.Console.WriteLine("la cedula no se ha encontrado");
					}
					lectura.Close();

			
		    }
		}
	}
}