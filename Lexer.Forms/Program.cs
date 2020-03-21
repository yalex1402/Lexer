using Lexer.Forms.Views;
using System;
using System.Windows.Forms;

namespace Lexer.Forms
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLexer());
        }
    }
}
