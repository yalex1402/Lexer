using Lexer.Controller;
using Lexer.Forms.Helpers;
using Lexer.Forms.Models;
using Lexer.Model;
using System.Collections.Generic;

namespace Lexer.Forms.Controllers
{
    public class SintaxController
    {
        private readonly ISymbolsHelper _symbolsHelper;
        private List<SintaxResponseViewModel> _result;
        private ToValidateViewModel _toValidate;
        private SintaxResponseViewModel _sintaxResponse;

        public SintaxController(ISymbolsHelper symbolsHelper)
        {
            _result = new List<SintaxResponseViewModel>();
            _toValidate = new ToValidateViewModel();
            _symbolsHelper = symbolsHelper;
            _sintaxResponse = new SintaxResponseViewModel();
        }

        public List<SintaxResponseViewModel> GetSintaxAnalisis(string text)
        {
            LexerController lexer = new LexerController(_symbolsHelper);
            _toValidate.Text = text;
            _toValidate.StringPosition = lexer.FirstCharacterPosition(_toValidate.Text);
            for (int i = _toValidate.StringPosition; i < _toValidate.Text.Length; i++)
            {
                _toValidate.CharToValidate = _toValidate.Text[i];

                if (!_symbolsHelper.IsSemiColon(_toValidate.CharToValidate) 
                    && !_symbolsHelper.IsBracket(_toValidate.CharToValidate))
                {
                    _toValidate.TextToValidate += _toValidate.CharToValidate;
                }

                if (_symbolsHelper.IsSemiColon(_toValidate.CharToValidate)
                    || _symbolsHelper.IsBracket(_toValidate.CharToValidate))
                {
                    _sintaxResponse.Tokens = lexer.FindToken(_toValidate.TextToValidate);
                    _result.Add(_sintaxResponse);
                    _toValidate.TextToValidate = "";
                }
            }
            return _result;
        }


    }
}
