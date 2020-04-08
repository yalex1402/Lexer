using Lexer.Controller;
using Lexer.Forms.Models;
using System.Collections.Generic;

namespace Lexer.Forms.Controllers
{
    public class SintaxController
    {
        private List<SintaxResponseViewModel> _result;

        public SintaxController()
        {
            LexerController lexer = new LexerController();
            _result = new List<SintaxResponseViewModel>();
        }




    }
}
