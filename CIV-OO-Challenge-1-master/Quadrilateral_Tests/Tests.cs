using System;
using NUnit.Framework;
using Shapes;
using ShapesInterface;



namespace Quadrilateral_Tests
{
	[TestFixture]


	public class Tests
	{
		Square sq1 { get; set; }
		Rectangle rec1 { get; set; }
		Equilateral equ1 { get; set; }
		RightAngle rat1 { get; set; }
		Circle Cir1 { get; set; }

		Square sq2 { get; set; }
		Rectangle rec2 { get; set; }
		Equilateral equ2 { get; set; }
		RightAngle rat2 { get; set; }
		Circle Cir2 { get; set; }


		Square sq3 { get; set; }
		Rectangle rec3 { get; set; }
		Equilateral equ3 { get; set; }
		RightAngle rat3 { get; set; }
		Circle Cir3 { get; set; }

		[SetUp]
		public void Init()
		{
			sq1 = new Square("Blue", 5);
			rec1 = new Rectangle("Red", 5, 10);
			equ1 = new Equilateral("Blue", 5);
			rat1 = new RightAngle("Orange", 4, 6);
			Cir1 = new Circle("Red", 5);

			sq2 = new Square("Blue", 15);
			rec2 = new Rectangle("Red", 4, 6);
			equ2 = new Equilateral("Blue", 15);
			rat2 = new RightAngle("Orange", 5, 10);
			Cir2 = new Circle("Red", 15);

			sq3 = new Square("Blue", 7);
			rec3 = new Rectangle("Red", 9, 7);
			equ3 = new Equilateral("Blue", 7);
			rat3 = new RightAngle("Orange", 9, 7);
			Cir3 = new Circle("Red", 7);

		}

		[Test]
		public void SquareTests()
		{
			int area = 25;
			int perimeter = 20;

			Assert.AreEqual(area, sq1.GetArea());
			Assert.AreEqual(perimeter, sq1.GetPerimeter());

			area = 225;
			perimeter = 60;

			Assert.AreEqual(area, sq2.GetArea());
			Assert.AreEqual(perimeter, sq2.GetPerimeter());

			area = 49;
			perimeter = 28;

			Assert.AreEqual(area, sq3.GetArea());
			Assert.AreEqual(perimeter, sq3.GetPerimeter());

		}

		[Test]
		public void RectangleTests()
		{
			int area = 50;
			int perimeter = 30;

			Assert.AreEqual(area, rec1.GetArea());
			Assert.AreEqual(perimeter, rec1.GetPerimeter());

			area = 24;
			perimeter = 20;

			Assert.AreEqual(area, rec2.GetArea());
			Assert.AreEqual(perimeter, rec2.GetPerimeter());

			area = 63;
			perimeter = 32;

			Assert.AreEqual(area, rec3.GetArea());
			Assert.AreEqual(perimeter, rec3.GetPerimeter());

		}

		[Test]
		public void EquilateralTest()
		{
			double area = 10.83;
			int perimeter = 15;

			Assert.AreEqual((decimal)area, (decimal)Math.Round(equ1.GetArea(), 2));
			Assert.AreEqual(perimeter, equ1.GetPerimeter());

			area = 97.43;
			perimeter = 45;

			Assert.AreEqual((decimal)area, (decimal)Math.Round(equ2.GetArea(), 2));
			Assert.AreEqual(perimeter, equ2.GetPerimeter());

			area = 21.22;
			perimeter = 21;

			Assert.AreEqual((decimal)area, (decimal)Math.Round(equ3.GetArea(), 2));
			Assert.AreEqual(perimeter, equ3.GetPerimeter());

		}

		[Test]
		public void RightAngleTriangleTest()
		{
			double area = 25;
			double perimeter = 26.18;

			Assert.AreEqual(area, rat1.GetArea());
			Assert.AreEqual((decimal)perimeter, (decimal)Math.Round(rat1.GetPerimeter(), 2));

			area = 12;
			perimeter = 17.21;

			Assert.AreEqual(area, rat2.GetArea());
			Assert.AreEqual((decimal)perimeter, (decimal)Math.Round(rat2.GetPerimeter(), 2));

			area = 31.5;
			perimeter = 27.4;

			Assert.AreEqual((decimal)area, (decimal)Math.Round(rat3.GetArea(), 2));
			Assert.AreEqual((decimal)perimeter, (decimal)Math.Round(rat3.GetPerimeter(), 2));
		}

		[Test]
		public void CircleTest()
		{

			double area = 78.55;
			double perimeter = 31.42;

			Assert.AreEqual((decimal)area, (decimal)Math.Round(Cir1.GetArea(), 2));
			Assert.AreEqual((decimal)perimeter, (decimal)Math.Round(Cir1.GetPerimeter(), 2));

			area = 706.95;
			perimeter = 94.26;

			Assert.AreEqual((decimal)area, (decimal)Math.Round(Cir2.GetArea(), 2));
			Assert.AreEqual((decimal)perimeter, (decimal)Math.Round(Cir2.GetPerimeter(), 2));

			area = 153.96;
			perimeter = 43.99;

			Assert.AreEqual((decimal)area, (decimal)Math.Round(Cir3.GetArea(), 2));
			Assert.AreEqual((decimal)perimeter, (decimal)Math.Round(Cir3.GetPerimeter(), 2));
		}


	}
}