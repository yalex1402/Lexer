using Lexer.Controller;
using Lexer.Forms.Controllers;
using Lexer.Forms.Helpers;
using Lexer.Forms.Models;
using Lexer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lexer.Forms.Views
{
    public partial class frmLexer : Form
    {
        private readonly ISymbolsHelper _symbolsHelper;

        public frmLexer(ISymbolsHelper symbolsHelper)
        {
            InitializeComponent();
            _symbolsHelper = symbolsHelper;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            ToValidateViewModel view = new ToValidateViewModel
            {
                Text = txtCode.Text + " "
            };
            SintaxController sintax = new SintaxController(_symbolsHelper);
            List<SintaxResponseViewModel> result2 = sintax.GetSintaxAnalisis(txtCode.Text);
            LexerController lexer = new LexerController(_symbolsHelper);
            List<TokenViewModel> result = lexer.FindToken(view);
            foreach (var item in result)
            {
                txtResult.Text += $"Token for {item.Text} is {item.TypeToken.ToString()} and {item.TextToIdentifier}\n"; 
            }
        }
    }
}
