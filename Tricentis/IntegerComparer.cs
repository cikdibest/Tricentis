using System;
using System.Collections.Generic;
using System.Text;

namespace Tricentis
{
    public class IntegerComparer
    {
        private readonly int expectedNumber;
        public IntegerComparer(int expectedNumber)
        {
            this.expectedNumber = expectedNumber;
        }
        public string CompareTheIntegers(int enteredInteger)
        {
            if (enteredInteger > expectedNumber)
            {
                return "higher";
            }

            else if (enteredInteger < expectedNumber)
            {
                return "lower";
            }
            else
            {
                return "equal";
            }
        }
    }
}
