using Practicum.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Core.Parsers
{
    public class NightDishParser : BaseDishParser
    {
        public NightDishParser(List<string> arguments)
            :base(arguments)
        {
            dishes.Add(new Dish() { Name = "steak", Type = DishType.Entree, CanRepeat = false });
            dishes.Add(new Dish() { Name = "potato", Type = DishType.Side, CanRepeat = true });
            dishes.Add(new Dish() { Name = "wine", Type = DishType.Drink, CanRepeat = false });
            dishes.Add(new Dish() { Name = "cake", Type = DishType.Desert, CanRepeat = true });
        }
    }
}
