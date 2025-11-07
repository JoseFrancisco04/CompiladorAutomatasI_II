using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorAutomatasI_II
{
    public class ManejadorTokens
    {

        public List<Token> separarTokens(string codigo)
        {

            List<Token> lexemas = new List<Token>();
            if (string.IsNullOrEmpty(codigo))
            {
                return lexemas;

            }
            string tokenActual = "";
            for (int i = 0; i < codigo.Length; i++)
            {
                char c = codigo[i];
                //si hay un espacio, tabulador o salto de linea
                if (char.IsWhiteSpace(c))
                {
                    if (!string.IsNullOrEmpty(tokenActual))
                    {
                        lexemas.Add(new Token(tokenActual, false));
                        tokenActual = "";

                    }

                }
                else if (c == ';')//si es ;
                {
                    if (!string.IsNullOrEmpty(tokenActual))
                    {
                        lexemas.Add(new Token(tokenActual, false));
                        tokenActual = "";

                    }
                    lexemas.Add(new Token(";", false));
                }
                else
                {
                    tokenActual += c;
                }
            }

            //procesar el ultimo token si existe
            if (!string.IsNullOrEmpty(tokenActual))
            {
                lexemas.Add(new Token(tokenActual, false));

            }
            return lexemas;

        }
    }
}
