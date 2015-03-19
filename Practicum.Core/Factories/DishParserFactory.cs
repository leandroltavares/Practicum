using Practicum.Core.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Core.Factories
{
    public class DishParserFactory
    {
        public static BaseDishParser GetDishParser(string input)
        {
            BaseDishParser parser = null;

            var arguments = input.ToLower().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (arguments.Count < 2)
            {
                throw new ArgumentException("The input must have a time of the day and at least one dish", input);
            }
            else
            {
                string periodOfDayArgument = arguments[0];

                switch (periodOfDayArgument)
                {
                    case "morning":
                        parser = new MorningDishParser(arguments);
                        break;

                    case "night":
                        parser = new NightDishParser(arguments);
                        break;

                    default:
                        throw new ArgumentException("The first argument must be 'morning' or 'night'", input);
                }

                return parser;
            }
        }
    }
}
