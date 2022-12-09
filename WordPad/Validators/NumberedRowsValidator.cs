using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordPad.Validators
{
    public static class NumberedRowsValidator
    {
        private static Regex _validationRegex = new Regex(
            @"^[1-9]+\.", 
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public static bool Validate(string input) => !_validationRegex.IsMatch(input);
    }
}
