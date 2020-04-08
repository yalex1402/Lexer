using Lexer.Controller;
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
        public frmLexer()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            ToValidateViewModel view = new ToValidateViewModel
            {
                Text = txtCode.Text + " "
            };
            LexerController lexer = new LexerController();
            List<TokenViewModel> result = lexer.FindToken(view);
            foreach (var item in result)
            {
                txtResult.Text += $"Token for {item.Text} is {item.TypeToken.ToString()} and {item.TextToIdentifier}\n"; 
            }
        }
    }
}
