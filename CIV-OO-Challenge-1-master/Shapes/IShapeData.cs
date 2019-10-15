using System;
using System.Collections.Generic;
using System.Text;


namespace ShapesInterface
{
	interface IShapeData
	{
		double GetPerimeter();

		double GetArea();

	}

	interface IShapeData2
	{
		double GetPerimeter();

		double GetArea();

		double GetHypotenuse();
	}
}
