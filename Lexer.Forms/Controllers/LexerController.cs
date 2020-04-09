using Lexer.Forms.Enums;
using Lexer.Forms.Helpers;
using Lexer.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lexer.Controller
{
    public class LexerController
    {

        private Hashtable _reservedWords;
        private Hashtable _operators;
        private Hashtable _symbols;
        private readonly ISymbolsHelper _symbolsHelper;

        public string GetReservedWords(string key) => _reservedWords[key].ToString();
        public string GetOperators(string key) => _operators[key].ToString();
        public string GetSymbols(string key) => _symbols[key].ToString();

        public LexerController(ISymbolsHelper symbolsHelper)
        {
            _reservedWords = new Hashtable();
            _operators = new Hashtable();
            _symbols = new Hashtable();
            _symbolsHelper = symbolsHelper;
        }

        public List<TokenViewModel> FindToken(string text)
        {
            bool ban;
            bool IsQuote = false;

            AddLanguage();

            ToValidateViewModel toValidate = new ToValidateViewModel
            {
                Text = text
            };

            List<TokenViewModel> tokenList = new List<TokenViewModel>();
            toValidate.StringPosition = FirstCharacterPosition(toValidate.Text);

            for (int i = toValidate.StringPosition; i < toValidate.Text.Length; i++)
            {
                ban = false;

                toValidate.CharToValidate = toValidate.Text[i];

                if (_symbolsHelper.IsQuote(toValidate.CharToValidate))
                {
                    IsQuote = !IsQuote;
                }

                if ((char.IsWhiteSpace(toValidate.CharToValidate) || _symbolsHelper.IsParen(toValidate.CharToValidate)
                        || _symbolsHelper.IsComma(toValidate.CharToValidate)) && (!IsQuote) && toValidate.TextToValidate != "")
                {
                    tokenList.Add(ToToken(toValidate.TextToValidate));
                    toValidate.TextToValidate = "";
                    ban = true;
                }

                if (!ban && !char.IsWhiteSpace(toValidate.CharToValidate))
                {
                    toValidate.TextToValidate += toValidate.CharToValidate;
                }

            }

            return tokenList;
        }

        public List<TokenViewModel> FindToken(ToValidateViewModel toValidate)
        {
            bool ban;
            bool IsQuote = false;

            AddLanguage();

            List<TokenViewModel> tokenList = new List<TokenViewModel>();
            toValidate.StringPosition = FirstCharacterPosition(toValidate.Text);

            for (int i = toValidate.StringPosition; i < toValidate.Text.Length; i++)
            {
                ban = false;
                
                toValidate.CharToValidate = toValidate.Text[i];

                if (_symbolsHelper.IsQuote(toValidate.CharToValidate))
                {
                    IsQuote = !IsQuote;
                }

                if ((char.IsWhiteSpace(toValidate.CharToValidate) || _symbolsHelper.IsParen(toValidate.CharToValidate) 
                        || _symbolsHelper.IsComma(toValidate.CharToValidate)) && (!IsQuote) && toValidate.TextToValidate != "" )
                {
                    tokenList.Add(ToToken(toValidate.TextToValidate));
                    toValidate.TextToValidate = "";
                    ban = true;
                }

                if (!ban && !char.IsWhiteSpace(toValidate.CharToValidate))
                {
                    toValidate.TextToValidate += toValidate.CharToValidate;
                }
                
            }
            
            return tokenList;
        }

        public int FirstCharacterPosition(string text)
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
            TokenViewModel token = new TokenViewModel();
            if (IsReservedWord(textToValidate))
            {
                token.TypeToken = Token.RESERVED;
                token.TextToIdentifier = GetReservedWords(textToValidate);
            }
            else if (IsOperator(textToValidate))
            {
                token.TypeToken = Token.OPERATOR;
                token.TextToIdentifier = GetOperators(textToValidate);
            }
            else if (IsSymbol(textToValidate))
            {
                token.TypeToken = Token.SYMBOL;
                token.TextToIdentifier = GetSymbols(textToValidate);
            }
            else if (IsIdentifier(textToValidate))
            {
                if (IsNumericIdentifier(textToValidate))
                {
                    token.TypeToken = Token.NUM_IDENTIFIER;
                    token.TextToIdentifier = "Integer";
                }
                else if (IsStringIdentifier(textToValidate))
                {
                    token.TypeToken = Token.STRING;
                    token.TextToIdentifier = "String";
                }
                else
                {
                    token.TypeToken = Token.IDENTIFIER;
                    token.TextToIdentifier = "Identifier";
                }
            }
            else
            {
                token.TypeToken = Token.NOT_FOUND;
                token.TextToIdentifier = "";
            }
            token.Text = textToValidate;
            return token;
        }

        private bool IsReservedWord (string text)
        {
            if (_reservedWords.ContainsKey(text))
            {
                return true;
            }
            return false;
        }

        private bool IsOperator(string text)
        {
            if (_operators.ContainsKey(text))
            {
                return true;
            }
            return false;
        }

        private bool IsSymbol(string text)
        {
            if (_symbols.ContainsKey(text))
            {
                return true;
            }
            return false;
        }

        private bool IsIdentifier(string text)
        {
            if (IsNumericIdentifier(text) || IsStringIdentifier(text) || IsVariableIdentifier(text))
            {
                return true;
            }            
            return false;
        }

        private bool IsNumericIdentifier(string text)
        {
            var regexNumeric = @"^[0-9]*$";
            Match match = Regex.Match(text, regexNumeric);
            if (match.Success)
            {
                return true;
            }
            return false;
        }

        private bool IsVariableIdentifier(string text)
        {
            var regexVariable = @"[_a-zA-Z]{1}[_a-zA-Z0-9]";
            Match match = Regex.Match(text, regexVariable);
            if (match.Success)
            {
                return true;
            }
            return false;
        }

        public bool IsStringIdentifier(string text)
        {
            var regexString = "^'[A-Za-z ]*'$";
            Match match = Regex.Match(text, regexString);
            if (match.Success)
            {
                return true;
            }
            return false;
        }

        private void AddReservedWords()
        {
            _reservedWords.Add("if", "Reserved_if");
            _reservedWords.Add("else", "Reserved_else");
            _reservedWords.Add("while", "Reserved_while");
            _reservedWords.Add("for", "Reserved_for");
            _reservedWords.Add("next", "Reserved_next");
            _reservedWords.Add("case", "Reserved_case");
            _reservedWords.Add("print", "Reserved_print");
        }

        private void AddOperators()
        {
            _operators.Add("+", "op_add");
            _operators.Add("-", "op_substract");
            _operators.Add("*", "op_multiply");
            _operators.Add("/", "op_divide");
            _operators.Add("%", "op_mod");
            _operators.Add("<", "op_less");
            _operators.Add("<=", "op_lessequal");
            _operators.Add(">", "op_greater");
            _operators.Add(">=", "op_greaterequal");
            _operators.Add("==", "op_equal");
            _operators.Add("!=", "op_notequal");
            _operators.Add("!", "op_not");
            _operators.Add("=", "op_assigment");
            _operators.Add("&&", "op_and");
            _operators.Add("||", "op_or");
        }

        private void AddSymbols()
        {
            _symbols.Add("(", "LeftParen");
            _symbols.Add(")", "RightParen");
            _symbols.Add("{", "LeftBrace");
            _symbols.Add("}", "RightBrace");
            _symbols.Add(";", "Semi-Colon");
            _symbols.Add(",", "Comma");
        }

        private void AddLanguage()
        {
            AddReservedWords();
            AddOperators();
            AddSymbols();
        }

    }
}
