using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexer.Forms.Helpers
{
    public class SymbolsHelper : ISymbolsHelper
    {
        public bool IsParen(char textToValidate)
        {
            if (textToValidate.ToString() == "(" || textToValidate.ToString() == ")")
            {
                return true;
            }
            return false;
        }

        public bool IsQuote(char textToValidate)
        {
            if (textToValidate.ToString() == "'")
            {
                return true;
            }
            return false;
        }

        public bool IsComma(char textToValidate)
        {
            if (textToValidate.ToString() == ",")
            {
                return true;
            }
            return false;
        }

        public bool IsSemiColon(char textToValidate)
        {
            if (textToValidate.ToString() == ";")
            {
                return true;
            }
            return false;
        }

        public bool IsBracket(char textToValidate)
        {
            if (textToValidate.ToString() == "{" || textToValidate.ToString() == "}")
            {
                return true;
            }
            return false;
        }
    }
}
