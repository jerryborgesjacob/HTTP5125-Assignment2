using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125_Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        // CCC-2022 J1
        /// <summary>
        /// Calculates the Number of cupcakes left over, if there are 28 students in a class and each takes one cupcake.
        /// </summary>
        /// <param name="regular">Number of Regular sized boxes (based on input by user)</param>
        /// <param name="small">Number of Small sized boxes (based on input by user)</param>
        /// <returns0>Returns a string that displays the number of cupcakes left over.</returns>
        /// <example> GET : localhost.xx/api/J1/Cupcakes/4/2 => "There are 10 cupcakes leftover.
        /// </example>
        [HttpGet]
        [Route("api/J1/Cupcakes/{regular}/{small}")]
        public string Cupcakes(int regular, int small)
        {
            string result;
            int totalCupcakes = (regular * 8) + (small * 3); // regular box holds 8 cupcakes , while the small box holds 3. 
            int leftOver = totalCupcakes - 28;

            if (leftOver < 0) // validating input
            {
                result = "Please ensure that there are atleast 28 cupcakes.";
            }
            else if (leftOver == 1) 
            { 
                result = "There is " + leftOver + " cupcake leftover.";
            }
            else 
            {
                result = "There are " + leftOver + " cupcakes leftover.";
            }

            return result;
        }
    }
}
