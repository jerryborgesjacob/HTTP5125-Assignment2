using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125_Assignment2.Controllers
{
    public class J2Controller : ApiController
    {

        //CCC-2012 J2
        /// <summary>
        /// Takes 4 inputs from the user, and displays the result for the fish finder device.
        /// </summary>
        /// <param name="reading1">Integer input by user for Depth Reading 1</param>
        /// <param name="reading2">Integer input by user for Depth Reading 2</param>
        /// <param name="reading3">Integer input by user for Depth Reading 3</param>
        /// <param name="reading4">Integer input by user for Depth Reading 4</param>
        /// <returns>String that contains the status, based on depth reading sequence</returns>
        /// <example> GET : localhost.xx/api/J2/FishFinder/1/2/3/4 => "Fish Rising"
        /// </example>
        [HttpGet]
        [Route("api/J2/FishFinder/{reading1}/{reading2}/{reading3}/{reading4}")]
        public string FishFinder(int reading1, int reading2, int reading3, int reading4)
        {
            string alert;
            if (reading1 < reading2 && reading2 < reading3 && reading3 < reading4) // depth readings in increasing sequence
            {
                alert = "Fish Rising";
            } else if (reading4 < reading3 && reading3 < reading2 && reading2 < reading1) // depth readings in decreasing sequence
            {
                alert = "Fish Diving";
            }else if (reading1 == reading2 && reading2 == reading3 && reading3 == reading4) // depth readings are all equal
            {
                alert = "Fish At Constant Depth";
            }
            else
            {
                alert = "No Fish"; // depth readings in random sequence
            }
            return alert;
        }
    }
}
