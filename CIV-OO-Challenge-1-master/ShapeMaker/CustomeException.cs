using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeGenerator
{
    class LengthLessThanOneException : Exception



    {
        public LengthLessThanOneException(string message) : base(message) { }


    }
}
