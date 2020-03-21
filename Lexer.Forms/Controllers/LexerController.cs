using Lexer.Forms.Enums;
using Lexer.Model;
using System.Collections;
using System.Collections.Generic;

namespace Lexer.Controller
{
    public class LexerController
    {

        private static Hashtable _reservedWords;
        private static Hashtable _operators;
        private static Hashtable _symbols;

        public LexerController()
        {
            _reservedWords = AddReservedWords();
            _operators = AddOperators();
            _symbols = AddSymbols();
        }

        public IEnumerable<TokenViewModel> FindToken(ToValidateViewModel toValidate)
        {
            List<TokenViewModel> tokenList = null;
            return tokenList;
        }

        private int FirstCharacterPosition(string text)
        {
            int position = 0;
            while (char.IsWhiteSpace(text[position]))
            {
                position++;
            }
            return position;
        }

        private TokenViewModel ToToken(string textToValidate)
        {
            TokenViewModel token = null;
            token.TypeToken = Token.IDENTIFIER;
            token.Text = textToValidate;
            return token;
        }

        private Hashtable AddReservedWords()
        {
            Hashtable reservedWords = null;
            reservedWords.Add("if","Reserved_if");
            reservedWords.Add("else", "Reserved_else");
            reservedWords.Add("while", "Reserved_while");
            reservedWords.Add("for", "Reserved_for");
            reservedWords.Add("next", "Reserved_next");
            reservedWords.Add("case", "Reserved_case");
            reservedWords.Add("print", "Reserved_print");
            return reservedWords;
        }

        private Hashtable AddOperators()
        {
            Hashtable reservedWords = null;
            reservedWords.Add("+", "op_add");
            reservedWords.Add("-", "op_substract");
            reservedWords.Add("*", "op_multiply");
            reservedWords.Add("/", "op_divide");
            reservedWords.Add("%", "op_mod");
            reservedWords.Add("<", "op_less");
            reservedWords.Add("<=", "op_lessequal");
            reservedWords.Add(">", "op_greater");
            reservedWords.Add(">=", "op_greaterequal");
            reservedWords.Add("==", "op_equal");
            reservedWords.Add("!=", "op_notequal");
            reservedWords.Add("!", "op_not");
            reservedWords.Add("=", "op_assigment");
            reservedWords.Add("&&", "op_and");
            reservedWords.Add("||", "op_or");
            return reservedWords;
        }

        private Hashtable AddSymbols()
        {
            Hashtable reservedWords = null;
            reservedWords.Add("(", "LeftParen");
            reservedWords.Add(")", "RightParen");
            reservedWords.Add("{", "LeftBrace");
            reservedWords.Add("}", "RightBrace");
            reservedWords.Add(";", "Semi-Colon");
            reservedWords.Add(",", "Comma");
            return reservedWords;
        }

    }
}
