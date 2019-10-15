using System;
using NUnit.Framework;
using Shapes;

namespace Quadrilateral_Tests
{
	[TestFixture]


	public class Tests
	{
		Square sq1 { get; set; }
		Rectangle rec1 { get; set; }
		Equilateral equ1 { get; set; }
		RightAngleTriangle rat1 { get; set; }
		Circle Cir1 { get; set; }

		Square sq2 { get; set; }
		Rectangle rec2 { get; set; }
		Equilateral equ2 { get; set; }
		RightAngleTriangle rat2 { get; set; }
		Circle Cir2 { get; set; }


		Square sq3 { get; set; }
		Rectangle rec3 { get; set; }
		Equilateral equ3 { get; set; }
		RightAngleTriangle rat3 { get; set; }
		Circle Cir3 { get; set; }

		[SetUp]
		public void Init()
		{
			sq1 = new Square("Blue", 5);
			rec1 = new Rectangle("Red", 5, 10);
			equ1 = new Equilateral("Blue", 5);
			rat1 = new RightAngleTriangle("Orange", 4, 6);
			Cir1 = new Circle("Red", 5);

			sq2 = new Square("Blue", 15);
			rec2 = new Rectangle("Red", 4, 6);
			equ2 = new Equilateral("Blue", 15);
			rat2 = new RightAngleTriangle("Orange", 5, 10);
			Cir2 = new Circle("Red", 15);

			sq3 = new Square("Blue", 7);
			rec3 = new Rectangle("Red", 9, 7);
			equ3 = new Equilateral("Blue", 7);
			rat3 = new RightAngleTriangle("Orange", 9, 7);
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
		[TestCase(5, 25)]
		[TestCase(7, 49)]
		[TestCase(15, 225)]
		public void Square_GetArea_ValidInput_CorrectResult(int input, int expected)
		{
			// arrange
			var sq = new Square("blue", input);

			// act
			var result = sq.GetArea();

			// assert
			Assert.AreEqual(expected, result);
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
			int area = 10.83;
			int perimeter = 15;

			Assert.AreEqual(area, equ1.GetArea()));
			Assert.AreEqual(area, equ1.GetPerimeter()));

			int area = 97.43;
			int perimeter = 45;

			Assert.AreEqual(area, equ2.GetArea()));
			Assert.AreEqual(area, equ2.GetPerimeter()));

			int area = 21.22;
			int perimeter = 21;

			Assert.AreEqual(area, equ3.GetArea()));
			Assert.AreEqual(area, equ3.GetPerimeter()));

		}

		[Test]
		public void RightAngleTriangleTest()
		{
			int area = 25;
			int perimeter = 26.18;

			Assert.AreEqual(area, rat1.GetArea()));
			Assert.AreEqual(perimeter, rat1.GetPerimeter()));

			int area = 12;
			int perimeter = 17.21;

			Assert.AreEqual(area, rat2.GetArea()));
			Assert.AreEqual(perimeter, rat2.GetPerimeter()));

			int area = 31.5;
			int perimeter = 27.4;

			Assert.AreEqual(area, rat3.GetArea()));
			Assert.AreEqual(perimeter, rat3.GetPerimeter()));
		}

		[Test]
		public void CircleTest()
		{
			int area = 78.55;
			int perimeter = 31.42;

			Assert.AreEqual(area, Cir1.GetArea()));
			Assert.AreEqual(perimeter, Cir1.GetPerimeter()));

			int area = 706.95;
			int perimeter = 94.26;

			Assert.AreEqual(area, Cir2.GetArea()));
			Assert.AreEqual(perimeter, Cir2.GetPerimeter()));

			int area = 153.96;
			int perimeter = 43.99;

			Assert.AreEqual(area, Cir3.GetArea()));
			Assert.AreEqual(perimeter, Cir3.GetPerimeter()));
		}


	}
}