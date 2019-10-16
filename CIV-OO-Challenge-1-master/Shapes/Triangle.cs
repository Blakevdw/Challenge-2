using System;
using System.Collections.Generic;
using System.Text;
using Shapes;

namespace ShapesInterface
{
	public abstract class Triangle : Shape
	{

		public Triangle(string pColour) : base(pColour) { }

		public double Side1Length { get; set; }
		public double Side2Length { get; set; }
		public double Side3Length { get; set; }
	}


	public class RightAngle : Triangle, IShapeData
	{
		public RightAngle(string pColour, double pSide1Length, double pSide2Length) : base(pColour)
		{
			Side1Length = pSide1Length;
			Side2Length = pSide2Length;
		}

		public double GetArea()
		{
			return 1 / 2 * Side1Length * Side2Length;
		}

		public double GetPerimeter()
		{
			return Side1Length + Side2Length + Side1Length;
		}

	}

	public class Equilateral : Triangle, IShapeData2
	{
		public Equilateral(string pColour, double pSide1Length) : base(pColour)
		{
			Side1Length = pSide1Length;
		}

		public double GetArea()
		{
			return (Math.Sqrt(3) / 4 * Side1Length * Side1Length);
		}

		public double GetPerimeter()
		{
			return Side1Length * 3;
		}

		public double GetHypotenuse()
		{
			return Side1Length * Side1Length + Side2Length * Side2Length;
		}
	}
}


