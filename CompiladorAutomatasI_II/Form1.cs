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
        private bool isUpdating = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            List<Token> tokens = AnalizadorSemantico.analizadorSemantico(tbCode.Text);
            
            if (tokens != null)
            {
                tbConsole.Clear();
                foreach (Token token in tokens)
                {
                    tbConsole.SelectionColor = Color.White;
                    tbConsole.AppendText(token.value +  "  ");

                    tbConsole.AppendText("Lexicon= ");
                    string lexiconResult = token.ObtenerErrorLexico();
                    tbConsole.SelectionColor = lexiconResult == "SUCCESSFUL" ? Color.Green : Color.Red;
                    tbConsole.AppendText(lexiconResult);

                    tbConsole.SelectionColor = Color.White;
                    tbConsole.AppendText(" Syntax= ");
                    string syntaxResult = token.ObtenerErrorSintactico();
                    tbConsole.SelectionColor = syntaxResult == "SUCCESSFUL" ? Color.Green : Color.Red;
                    tbConsole.AppendText(syntaxResult);

                    tbConsole.SelectionColor = Color.White;
                    tbConsole.AppendText(" Semantic= ");
                    string semanticoResultado = token.ObtenerErrorSemantico();
                    tbConsole.SelectionColor = semanticoResultado == "SUCCESSFUL" ? Color.Green : Color.Red;
                    tbConsole.AppendText(semanticoResultado);

                    tbConsole.SelectionColor = Color.White;
                    tbConsole.AppendText(" \n");

                }
            }
            else
            {
                tbConsole.Clear();
                tbConsole.SelectionColor = Color.Red;
                tbConsole.Text = "Error";
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            tbConsole.Clear();
            tbCode.Clear();
            tbCode.Focus();
        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {
            if (!isUpdating)
            {
                ColorearCodigo();

            }

        }

        private void tbCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BeginInvoke(new Action(()=> ColorearCodigo()));

            }
        }

        private void ColorearCodigo()
        {
            if (string.IsNullOrWhiteSpace(tbCode.Text))
                return;
            isUpdating = true;

            int posicionCursor = tbCode.SelectionStart;

            List<Token> tokens = AnalizadorSemantico.analizadorSemantico(tbCode.Text);
            if (tokens != null)
            {
                tbCode.SelectAll();
                tbCode.SelectionColor = Color.White;
                tbCode.DeselectAll();

                int posicionActual = 0;

                foreach (Token token in tokens)
                {
                    int inicio = tbCode.Text.IndexOf(token.value, posicionActual, StringComparison.OrdinalIgnoreCase);

                    if (inicio >=0)
                    {
                        tbCode.Select(inicio, token.value.Length);

                        bool tieneError = !token.banderaLexico || !token.bandera || !token.banderaSemantico;

                        if(tieneError)
                        {
                            tbCode.SelectionColor = Color.Red;
                        }
                        else
                        {
                            string valorUpper = token.value.ToUpper();
                            if (valorUpper == "INICIO" || valorUpper == "FIN" || valorUpper == "Y" || valorUpper == ";")
                            {
                                tbCode.SelectionColor = Color.Green;
                            }
                            else if (valorUpper == "SUMAR" || valorUpper == "RESTAR" || valorUpper == "MULTIPLICAR" || valorUpper == "DIVIDIR")
                            {
                                tbCode.SelectionColor = Color.Orange;
                            }
                            else
                            {
                                tbCode.SelectionColor = Color.Blue;
                            }
                            
                        }

                        posicionActual = inicio + token.value.Length;
                    }
                }
                tbCode.Select(posicionCursor, 0);
                tbCode.SelectionColor = Color.White;
            }
            isUpdating = false;

        }
    }
}
