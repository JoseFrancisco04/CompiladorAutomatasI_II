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
            
            ManejadorTokens mt = new ManejadorTokens();
            List<String> tokens = mt.separarTokens(tbCode.Text);
            String output = "";
            for (int i = 0; i < tokens.Count; i++) { 
                output += tokens[i].ToString() + "-";
            }
            tbConsole.Text = output;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            tbConsole.Clear();
            tbCode.Clear();
            tbCode.Focus();
        }
    }
}
