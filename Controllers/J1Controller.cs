using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    /// <summary>
    /// Output the cupcake left at the cupcake party
    /// </summary>
    /// The goal is to determine how many cupcakes will be left over if each student gets one cupcake
    /// <param name="regular">The number of box that's been input</param>
    /// <param name="small">The number of box that's been input</param>
    /// <param name="regularCupcake">The total of cupcakes of the regular boxes that is input</param>
    /// <param name="smallCupcake">The total of cupcakes of the small boxes that is input</param>
    /// <param name="cupcakeTotal">The total number of cupcake(regular + small)</param>
    /// <param name="remainder">cupcake left</param>
    /// <returns>
    /// The cupcake left after each student have had one cupcake
    /// </returns>
    /// <example>
    /// http://localhost:50446/api/j1/cupcake/5/2 -> 18
    /// http://localhost:50446/api/j1/cupcake/9/4 -> 56
    /// </example>
    public class J1Controller : ApiController
    {
        [HttpGet]
        [Route("api/j1/Cupcake/{regular}/{small}")]
        public int Cupcake(int regular, int small)
        {
            int regularCupcake = regular * 8;
            int smallCupcake = small * 3;
            int cupcakeTotal = regularCupcake + smallCupcake;
            int remainder = cupcakeTotal - 28;
            return remainder;
        }
    }
}
