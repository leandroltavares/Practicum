using Practicum.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Core.Parsers
{
    public class MorningDishParser : BaseDishParser
    {
        public MorningDishParser(List<string> arguments)
            :base(arguments)
        {
            dishes.Add(new Dish() { Name = "eggs", Type = DishType.Entree, CanRepeat = false });
            dishes.Add(new Dish() { Name = "toast", Type = DishType.Side, CanRepeat = false });
            dishes.Add(new Dish() { Name = "coffee", Type = DishType.Drink, CanRepeat = true });

        }
    }
}
