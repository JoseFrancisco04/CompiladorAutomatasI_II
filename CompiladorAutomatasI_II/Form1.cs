using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            List<Token> tokens = AnalizadorSemantico.analizadorSemantico(tbCode.Text);
            
            if (tokens != null)
            {
                String text = "";
                foreach (Token token in tokens)
                {
                    text += token.value + " lexicon= " + token.ObtenerErrorLexico() + " syntax= " + token.ObtenerErrorSintactico() + " semantic= " + token.ObtenerErrorSemantico() + "\n";
                }
                tbConsole.Text = text;
            }
            else
            {
                tbConsole.Text = "Error";
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            tbConsole.Clear();
            tbCode.Clear();
            tbCode.Focus();
        }

        private void tbCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            System.Drawing.Color errorColor = Color.Red;

            List<Token> tokens = AnalizadorSemantico.analizadorSemantico(tbCode.Text);
            List<String> errorStrings = new List<String>();
            List<int> errorIndex = new List<int>();
            int indexes = 0;

            foreach (Token token in tokens)
            {
                if (!token.bandera || !token.banderaLexico || !token.banderaSemantico)
                {
                    errorStrings.Add(token.value);
                    errorIndex.Add(indexes);
                }
                indexes += token.value.Length;
            }

            for (int i = 0; i < errorStrings.Count; i++)
            {
                tbCode.SelectionStart = errorIndex[i];
                tbCode.SelectionLength = errorStrings[i].Length;

                tbCode.SelectionColor = errorColor;
                tbCode.SelectionLength = 0;
            }
             */


        }
    }
}
