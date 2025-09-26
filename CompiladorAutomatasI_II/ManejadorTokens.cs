using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorAutomatasI_II
{
    public class ManejadorTokens
    {
        private List<string> tokens;

        public ManejadorTokens()
        {
            tokens = new List<string>();
        }

        public List <string> separarTokens(string codigo)
        {
           List<string> lexemas = new List<string>();
            if (string.IsNullOrEmpty(codigo))
            {
                return lexemas;

            }
            string tokenActual = "";
            for (int i = 0; i <codigo.Length; i++)
            {
                char c = codigo[i];
                //si hay un espacio, tabulador o salto de linea
                if (char.IsWhiteSpace(c))
                {
                    if (!string.IsNullOrEmpty(tokenActual))
                    {
                        lexemas.Add(tokenActual);
                        tokenActual = "";

                    }

                }
                else if (c == ';')//si es ;
                {
                    if (!string.IsNullOrEmpty(tokenActual))
                    {
                        lexemas.Add(tokenActual);
                        tokenActual = "";

                    }
                    lexemas.Add(";");

                }
                else
                {
                    tokenActual += c;
                }
            }

            //procesar el ultimo token si existe
            if (!string.IsNullOrEmpty(tokenActual))
            {
                lexemas.Add(tokenActual);

            }
            return lexemas;

        }
        public void GuardarTokens(List<string> lexemas)
        {
            tokens.Clear();
            tokens.AddRange(lexemas);

        }

        //metodo para limpiar la lista de tokens
        public void LimpiarTokens()
        {
            tokens.Clear();
        }
    }
}
