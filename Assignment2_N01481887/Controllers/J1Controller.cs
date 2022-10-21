using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01481887.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Calculate the total calories of the meal base on user choice.
        /// </summary>
        /// <param name="burger"> Three type of burger choice</param>
        /// <param name="drink">Three type of drink choice</param>
        /// <param name="side">Three type of side order choice</param>
        /// <param name="dessert">Three type of dessert choice.</param>
        /// <returns>Total calories of the meal</returns>
        /// <example>
        /// GET:/api/J1/Menu/4/4/4/4 -> 0
        /// GET:/api/J1/Menu/1/2/3/4 -> 691
        /// </example>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public int Menu(int burger, int drink, int side, int dessert)
        {
            return getBurgerCalories(burger) + getDrinkCalories(drink) + getSideCalories(side) + getDessertCalories(dessert);
        }
        public int getBurgerCalories(int burger)
        {
            if (burger == 1)
            {
                return 461;
            }
            else if (burger == 2)
            {
                return 431;
            }
            else if (burger == 3)
            {
                return 420;
            }
            else
            {
                return 0;
            }
        }
        public int getDrinkCalories(int drink)
        {
            if (drink == 1)
            {
                return 130;
            }
            else if (drink == 2)
            {
                return 160;
            }
            else if (drink == 3)
            {
                return 118;
            }
            else
            {
                return 0;
            }
        }
        public int getSideCalories(int side)
        {
            if (side == 1)
            {
                return 100;
            }
            else if (side == 2)
            {
                return 57;
            }
            else if (side == 3)
            {
                return 70;
            }
            else
            {
                return 0;
            }
        }
        public int getDessertCalories(int dessert)
        {
            if (dessert == 1)
            {
                return 167;
            }
            else if (dessert == 2)
            {
                return 266;
            }
            else if (dessert == 3)
            {
                return 75;
            }
            else
            {
                return 0;
            }
        }


    }
}
