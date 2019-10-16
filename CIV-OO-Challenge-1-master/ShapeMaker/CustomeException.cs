using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeGenerator
{
	class InvalidInput : Exception
	{
		public InvalidInput(string message) : base(message) { }
	}

	class DecimalInputInvalid : Exception
	{
		public DecimalInputInvalid(string message) : base(message) { }
	}


}
