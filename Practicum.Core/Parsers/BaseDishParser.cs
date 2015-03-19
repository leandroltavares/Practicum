using Practicum.Core.Helpers;
using Practicum.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Core.Parsers
{
    /// <summary>
    /// Base class implementation for dish parsers
    /// </summary>
    public abstract class BaseDishParser
    {
        #region Attributes

        /// <summary>
        /// Arguments
        /// </summary>
        protected List<string> arguments;

        protected List<Dish> dishes;

        #endregion

        #region Constructors
        /// <summary>
        /// Default Contructor
        /// </summary>
        /// <param name="arguments">List of spplited arguments</param>
        public BaseDishParser(List<string> arguments)
        {
            dishes = new List<Dish>();

            this.arguments = arguments;

            SanitizeArguments();
        } 

        #endregion

        #region Main Method

        /// <summary>
        /// Parse implementation
        /// </summary>
        /// <returns></returns>
        public virtual string Parse()
        {
            bool isValid = true;

            Dictionary<Dish, int> dishesCounter = new Dictionary<Dish, int>();

            foreach (var currentArgument in arguments)
            {
                int dishType = Convert.ToInt32(currentArgument);

                var currentDish = dishes.FirstOrDefault(dish => (int)dish.Type == dishType);

                if (currentDish != null)
                {
                    if (!dishesCounter.ContainsKey(currentDish))
                    {
                        dishesCounter.Add(currentDish, 0);
                    }

                    if (currentDish.CanRepeat)
                    {
                        dishesCounter[currentDish]++;
                    }
                    else
                    {
                        if (dishesCounter[currentDish] == 0)
                        {
                            dishesCounter[currentDish]++;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                else
                {
                    isValid = false;
                    break;
                }
            }

            string output = ProduceOutput(dishesCounter);

            if (!isValid)
            {
                output += "error";
            }

            return StringHelper.SanitizeCommas(output);
        } 
        #endregion

        #region Auxiliar Methods

        /// <summary>
        /// Method for producing the output
        /// </summary>
        /// <param name="dishCounter"></param>
        /// <returns></returns>
        protected virtual string ProduceOutput(Dictionary<Dish, int> dishCounter)
        {
            string output = string.Empty;

            foreach (KeyValuePair<Dish, int> dish in dishCounter)
            {
                if (dish.Value == 1)
                {
                    output += dish.Key.Name + ", ";
                }
                else if (dish.Value > 1)
                {
                    output += string.Format("{0}(x{1}), ", dish.Key.Name, dish.Value);
                }
            }

            return output;
        }

        /// <summary>
        /// Method for sanitizing the input arguments
        /// </summary>
        protected void SanitizeArguments()
        {
            arguments.RemoveAt(0);

            for (int i = 0; i < arguments.Count; i++)
            {
                arguments[i] = arguments[i].Trim();
            }

            arguments.Sort();
        } 
        #endregion
    }
}
