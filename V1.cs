using system;
using system. IO;

namespace V1
{
	class program 
	{
		static void Main(string[] args);
		{
			string nombre;
			string apellido;
			string opcion;
			string cedula;
			int edad; 
			
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
			
			if(opcion == "SI")
			{
				Stream x= new FileStream ("./registro.txt", FileMode.Append, FileAccess.Write);
				StreamWriter Writer = new StreamWriter(x);
				writer.WriteLine(cedula + ", " + nombre+ ", " + )
			}
			else if (opcion == "NO")
			{
				goto datos;
			}
			else()
			{
				goto informacion;
			}
			
			
		}
	}
}