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
            ToValidateViewModel view = new ToValidateViewModel
            {
                Text = txtCode.Text + " "
            };
            LexerController lexer = new LexerController();
            lexer.FindToken(view);
        }
    }
}
