using System;

namespace ShapeGenerator
{
	class ProgramMenu
	{
		static ShapeList myShapeList = new ShapeList();
		static void Main(string[] args)
		{
			Console.WriteLine("Shape Generator");


			while (true)
			{

				Console.WriteLine(" (1) Generate Square");

				Console.WriteLine(" (2) Generate Rectangle");

				Console.WriteLine(" (3) Generate Circle");

				Console.WriteLine(" (4) Display Squares");

				Console.WriteLine(" (5) Display Rectangles");

				Console.WriteLine(" (6) Display Circle");

				Console.WriteLine(" (7) Exit");



				var key = Console.ReadKey(true);

				if (key.Key == ConsoleKey.D1)
				{
					myShapeList.AddSquare();
				}

				else if (key.Key == ConsoleKey.D2)
				{
					myShapeList.AddRectangle();
				}

				else if (key.Key == ConsoleKey.D3)
				{
					myShapeList.AddCircle();
				}

				else if (key.Key == ConsoleKey.D4)
				{
					myShapeList.DisplaySInput();
				}

				else if (key.Key == ConsoleKey.D5)
				{
					myShapeList.DisplayRInput();
				}

				else if (key.Key == ConsoleKey.D6)
				{
					myShapeList.DisplayCInput();
				}

				else if (key.Key == ConsoleKey.D7)
				{
					break;
				}

				else
				{
					Console.WriteLine("Invalid Input");
					Console.ReadKey(true);
				}

			}

		}
	}
}
