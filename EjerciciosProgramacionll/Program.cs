using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

class EjerciosProgramacionll
{
	public static void Main()
	
	{
		#region Ejercicio 073
		//primer dato que entra , primero en salir//

		//	Queue<string> cola = new Queue<string>();

		//	while (true)
		//	{

		//		Console.WriteLine("introduzca el texto");
		//		Console.WriteLine("");

		//		string DatoCola = Console.ReadLine();

		//		Console.WriteLine("");

		//		if (DatoCola == "")
		//		{
		//			MostrarQueue(cola);
		//			break;
		//		}
		//		else
		//		{
		//			cola.Enqueue(DatoCola);
		//		}
		//	}

		//static void MostrarQueue(Queue<string> cola)
		//	{
		//		while (cola.Count > 0)
		//		{
		//			string DatoCola = (string)cola.Dequeue();
		//			Console.WriteLine(DatoCola);
		//		}
		//	}

		#endregion

		#region Ejercicio 074

		//Stack<string> Pila = new Stack<string>();

		//while (true)
		//{
		//	Console.WriteLine("introduzca el texto");
		//	Console.WriteLine("");

		//	string DatoPila = Console.ReadLine();

		//	Console.WriteLine("");

		//	if (DatoPila =="")
		//	{
		//		MostrarDatoPila(Pila);
		//		break;
		//	}
		//	else
		//	{
		//		Pila.Push(DatoPila);
		//	}
		//}

		//static void MostrarDatoPila(Stack<string> Pila)
		//{
		//	while (Pila.Count > 0)
		//	{
		//		string datocola = Pila.Pop();
		//		Console.WriteLine(datocola);
		//	}
		//}

		#endregion

		#region Ejercicio 075

		//ArrayList arrayList = new ArrayList();

		//while (true)
		//{
		//	Console.WriteLine("introduzca el texto");
		//	Console.WriteLine("");

		//	string DatoArray = Console.ReadLine();

		//	Console.WriteLine("");

		//	if (DatoArray == "")
		//	{
		//		while (true)
		//		{
		//			Console.WriteLine("Consultar lista ingresando un numero o introduzca el numero 0 para finalizar");
		//			Console.WriteLine("");

		//			int Lista = Convert.ToInt32(Console.ReadLine());

		//			if ( Lista == 0)
		//			{
		//				Environment.Exit(0);
		//			}
		//			else
		//			{
		//				Console.WriteLine("En posicion " + Lista + " se encuentra:" + "{0}", arrayList[Lista - 1]);
		//			}
		//		}
		//	}
		//	else
		//	{
		//		arrayList.Add(DatoArray);
		//	}
		//}

		#endregion

		#region Ejercicio 077
		//SortedList<string, string> dicci = new SortedList<string, string>();
		//dicci.Add("living room", "sala de estar");
		//dicci.Add("bathroom", "baño");
		//dicci.Add("kitchen", "cocina");
		//dicci.Add("study", "sala de estudio");
		//dicci.Add("bedroom", "dormitorio");
		//dicci.Add("laudryroom", "lavadero");
		//dicci.Add("garden", "jardin");

		//Console.WriteLine("Ingrese el nombre de la sala de la casa que desea traducir al español");
		//Console.WriteLine("");
		//string palabra = Console.ReadLine().ToLower();

		//if (dicci.ContainsKey(palabra))
		//{
		//	string traducir = dicci[palabra];
		//	Console.WriteLine($"{palabra} su tradiccion es {traducir}");
		//}
		//else
		//{
		//	Console.WriteLine($"la palabra {palabra} no se encuentra");
		//}

		#endregion

		#region Ejercicio 078

		//Dictionary<string, string> dicci = new Dictionary<string, string>();
		//dicci.Add("living room", "sala de estar");
		//dicci.Add("bathroom", "baño");
		//dicci.Add("kitchen", "cocina");
		//dicci.Add("study", "sala de estudio");
		//dicci.Add("bedroom", "dormitorio");
		//dicci.Add("laudryroom", "lavadero");
		//dicci.Add("garden", "jardin");

		//Console.WriteLine("nombre de salas");
		//Console.WriteLine("");

		//string palabra = Console.ReadLine().ToLower();


		//string[] points = palabra.Split(',');

		//foreach (var point in points)
		//{
		//	if (dicci.ContainsKey(point))
		//	{
		//		Console.WriteLine(point + " es " + dicci[point]);
		//	}
		//}
		//Console.ReadLine();

		#endregion

		SortedSet<string> dicci = new SortedSet<string>();

		while (true)
		{
			Console.WriteLine(" Introduci cosas para comprar ");
			Console.WriteLine("");

			string palabra = Console.ReadLine();
			Console.WriteLine("");

			if (palabra == "")
			{
				break;
			}
			if (!dicci.Contains(palabra))
			{
				dicci.Add(palabra);
				Console.WriteLine("se agrego a la lista ");
			}
			else
			{
				Console.WriteLine("[" + palabra + "]" + "ya esta ");
			}


		}

	}
}


