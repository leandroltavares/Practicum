using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Core.Models
{
    /// <summary>
    /// Class for representing a dish
    /// </summary>
    public class Dish
    {
        /// <summary>
        /// Name of the dish
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type of the dish
        /// </summary>
        public DishType Type { get; set; }

        /// <summary>
        /// Flag for determing whether the dish can be repeated or not
        /// </summary>
        public bool CanRepeat { get; set; }
    }
}
