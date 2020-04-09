using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexer.Forms.Helpers
{
    public interface ISymbolsHelper
    {
        bool IsParen(char text);

        bool IsQuote(char text);

        bool IsComma(char text);

        bool IsSemiColon(char text);

        bool IsBracket(char text);
    }
}
