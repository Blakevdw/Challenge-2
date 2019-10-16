using System;
using System.Collections.Generic;
using System.Text;
using Shapes;

namespace ShapesInterface
{
	public class Circle : Shape, IShapeData
	{
		public double Radius { get; set; }

		public Circle(string pColour, double pRadius) : base(pColour)
		{
			Radius = pRadius;
		}

		public double GetArea()
		{
			return Math.PI * (Radius * Radius);
		}

		public double GetPerimeter()
		{
			return 2 * Math.PI * Radius;
		}
	}
}
