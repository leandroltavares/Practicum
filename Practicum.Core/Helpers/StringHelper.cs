using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Core.Helpers
{
    /// <summary>
    /// Helper class for strings
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// Method for sanitizing the output
        /// </summary>
        /// <param name="input">string to be sanitized</param>
        /// <returns></returns>
        public static string SanitizeCommas(string input)
        {
            string sanitizedString = input.Trim();

            if (sanitizedString.Last() == ',')
                return sanitizedString.Substring(0, sanitizedString.Length - 1).Trim();

            return sanitizedString;
        }
    }
}
