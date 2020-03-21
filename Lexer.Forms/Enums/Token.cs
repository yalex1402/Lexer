using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexer.Forms.Enums
{
    public enum Token
    {
        RESERVED,
        OPERATOR,
        SYMBOL,
        IDENTIFIER,
        NUM_IDENTIFIER,
        STRING,
        NOT_FOUND
    }
}
