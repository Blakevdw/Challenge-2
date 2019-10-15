using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesInterface
{
	public abstract class Quadrilateral : Shape
	{

		public Quadrilateral(string pColour) : base(pColour) { }

		public double Side1Length { get; set; }
		public double Side2Length { get; set; }
		public double Side3Length { get; set; }
		public double Side4Length { get; set; }
	}

	public class Square : Quadrilateral, IShapeData
	{
		public Square(string pColour, double pSide1Length) : base(pColour)
		{
			Side1Length = pSide1Length;
		}

		public double GetArea()
		{
			return Side1Length * Side1Length;
		}

		public double GetPerimeter()
		{
			return Side1Length * 4;
		}
	}


	public class Rectangle : Quadrilateral, IShapeData
	{
		public Rectangle(string pColour, double pSide1Length, double pSide2Length) : base(pColour)
		{
			Side1Length = pSide1Length;
			Side1Length = pSide1Length;
			Side2Length = pSide2Length;
			Side2Length = pSide2Length;
		}

		public double GetArea()
		{
			return Side1Length * Side2Length;
		}

		public double GetPerimeter()
		{
			return Side1Length + Side1Length + Side2Length + Side2Length;
		}

	}


}
