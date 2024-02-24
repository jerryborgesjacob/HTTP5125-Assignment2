using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125_Assignment2.Controllers
{
    public class J3Controller : ApiController
    {

        //CCC-2011 J3
        /// <summary>
        /// Takes two integers from the user, 
        /// and displays the length of Sumac Sequence starting with the two integers.
        /// </summary>
        /// <param name="a">First Integer input by the user</param>
        /// <param name="b">Second Integer input by the user</param>
        /// <returns> A string that contains the length of the Sumac Sequence (or a string that displays the error message).</returns>
        /// <example> GET : localhost.xx/api/J3/Sumac/120/71 => "There are 5 numbers in the sequence."
        /// </example>
        [HttpGet]
        [Route("api/J3/Sumac/{a}/{b}")]

        public string Sumac(int a, int b)
        {
            string result;
            int temp; // variable used to temporarily hold result of (a - b)
            int counter = 2; // initialized to '2' as there will always be at least 2 numbers in the Sumac Sequence.

            if (a <= b) // b cannot be greater than a, as it will lead to a negative number.
            {
                result = "First Integer must be greater than the second integer.";
            }
            else if (a < 1 || b < 1) // all integers in Sumac Sequence must be greater than or equal to one.
            {
                result = "Both values must be greater than or equal to 1";            
            }
            else if (a > 10000) // maximum limit set by the question.
            {
                result = "Maximum allowed is 10000.";
            }
            else        
            {
                while (a > b)
                {
                    temp = a - b;
                    a = b;
                    b = temp;
                    counter++;
                }

                result = "There are " + counter + " numbers in the sequence.";
            }

            return result;
        }
    }
}
