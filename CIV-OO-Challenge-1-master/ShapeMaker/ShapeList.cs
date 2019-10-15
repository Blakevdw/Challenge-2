using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Shapes;

namespace ShapeGenerator
{
    class ShapeList
    {
        List<Square> squares;
        List<Rectangle> rectangles;

        public ShapeList() {
            squares = new List<Square>();
            rectangles = new List<Rectangle>();
        }
     
		public void DisplayRectangles()
		{
			DisplaySeperator();
			try
			{
				if (rectangles.Count < 1)
				{
					throw (new LengthLessThanOneException("Length of rectangle list less than one"));
				}
				else
				{
					Console.WriteLine("Current Rectangles");
					for (int i = 0; i < squares.Count; i++)
					{
						Console.WriteLine("Square " + i + ": Colour = " + rectangles[i].Colour + " 1st length = " + rectangles[i].Side1Length + " 2nd length = " + rectangles[i].Side2Length);
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}


		public void DisplaySquares() {
            DisplaySeperator();
            try
            {
                if (squares.Count < 1)
                {
                    throw (new LengthLessThanOneException("Currently the length of the square list at present is less than one"));
                }
                else
                {
                    Console.WriteLine("Current Squares");
                    for (int i = 0; i < squares.Count; i++)
                    {
                        Console.WriteLine("Square " + i + ": Colour = " + squares[i].Colour + " length = " + squares[i].Side1Length);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

        }

      

        public void DisplaySeperator() {
           Console.WriteLine(string.Concat(Enumerable.Repeat("-", Console.BufferWidth)));
        }

        public int AddLength(string message) {
            Console.WriteLine(message);
            int x = 0;
            
            try
            {
                x = int.Parse(Console.ReadLine());

                if (x < 1)
                {
                    throw (new LengthLessThanOneException("Currently the side list is less than one exception at present"));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return 0;
            }

            return x;

        }

        public string AddColour(string message) {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public void AddSquare(){
            Console.Clear();
            int x = AddLength("Chosen Square Length?");
            if (x < 1) {
                return;
            }
            squares.Add(new Square(AddColour("Chosen Square Colour?"), x));
        }

        public void AddRectangle() {
            Console.Clear();
            int x = AddLength("Length of first side?");
            if (x < 1)
            {
                return;
            }
            int y = AddLength("Length of second side?");
            if (y < 1)
            {
                return;
            }
            rectangles.Add(new Rectangle(AddColour("Chosen Rectangle colour?"), x, y));
        }

        public void DisplaySInput() {
            Console.Clear();
            DisplaySquares();
            Console.ReadLine();
        }

        public void DisplayRInput() {
            Console.Clear();
            DisplayRectangles();
            Console.ReadLine();
        }
    }
}
