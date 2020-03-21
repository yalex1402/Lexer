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

        public string GetReservedWords(object key) => _reservedWords[key].ToString();
        public string GetOperators(object key) => _operators[key].ToString();
        public string GetSymbols(object key) => _symbols[key].ToString();

        public LexerController()
        {
            _reservedWords = AddReservedWords();
            _operators = AddOperators();
            _symbols = AddSymbols();
        }

        public IEnumerable<TokenViewModel> FindToken(ToValidateViewModel toValidate)
        {
            List<TokenViewModel> tokenList = null;
            toValidate.StringPosition = FirstCharacterPosition(toValidate.Text);

            for (int i = toValidate.StringPosition; i < toValidate.Text.Length; i++)
            {
                toValidate.CharToValidate = toValidate.Text[i];

                if (char.IsWhiteSpace(toValidate.CharToValidate))
                {
                    tokenList.Add(ToToken(toValidate.TextToValidate));
                }

                toValidate.TextToValidate += toValidate.CharToValidate;
            }
            
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
            if (IsReservedWord(textToValidate))
            {
                token.TypeToken = Token.RESERVED;
            }
            else if (IsOperator(textToValidate))
            {
                token.TypeToken = Token.OPERATOR;
            }
            else if (IsSymbol(textToValidate))
            {
                token.TypeToken = Token.SYMBOL;
            }
            else if (IsIdentifier(textToValidate))
            {
                token.TypeToken = Token.IDENTIFIER;
            }
            else
            {
                token.TypeToken = Token.NOT_FOUND;
            }
            token.Text = textToValidate;
            return token;
        }

        private bool IsReservedWord (string text)
        {
            return true;
        }

        private bool IsOperator(string text)
        {
            return true;
        }

        private bool IsSymbol(string text)
        {
            return true;
        }

        private bool IsIdentifier(string text)
        {
            return true;
        }

        private Hashtable AddReservedWords()
        {
            Hashtable reservedWords = null;
            reservedWords.Add("if", "Reserved_if");
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
