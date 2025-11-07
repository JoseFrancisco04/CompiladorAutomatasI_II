using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompiladorAutomatasI_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            List<Token> tokens = AnalizadorSintactico.analizadorSintactico(tbCode.Text);
            if (tokens != null)
            {
                String text = "";
                foreach (Token token in tokens)
                {
                    text += token.value + " syntax= " + token.bandera.ToString() + "\n";
                }
                tbConsole.Text = text;
            }
            else
            {
                tbConsole.Text = "Lexical Error";
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            tbConsole.Clear();
            tbCode.Clear();
            tbCode.Focus();
        }
    }
}
