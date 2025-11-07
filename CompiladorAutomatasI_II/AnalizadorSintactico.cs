using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorAutomatasI_II
{
    internal class AnalizadorSintactico
    {
        public static List<Token> analizadorSintactico(String codigo)
        {
            AnalizadorLexico al = new AnalizadorLexico();
            List<Token> tokens = al.analizadorLexico(codigo);
            if (tokens == null)
                return null;
            foreach (Token token in tokens)
            {
                char[] caracteres = token.value.ToUpper().ToCharArray();
                switch (caracteres[0])// Se compara el primer caracter
                {
                    case 'I':
                        //Se compara primero la longitud para evitar una IndexOutOfRangeException
                        if (caracteres.Length == 6 && caracteres[1] == 'N')
                        {
                            if (caracteres[2] == 'I')
                            {
                                if (caracteres[3] == 'C')
                                {
                                    if (caracteres[4] == 'I')
                                    {
                                        if (caracteres[5] == 'O')
                                        {
                                            token.bandera = true;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 'F':// Grafo de "FIN"
                        if (caracteres.Length == 3 && caracteres[1] == 'I')// La palabra debe tener 3 letras
                        {// y la segunda letra debe ser "I"
                            if (caracteres[2] == 'N')
                            {
                                token.bandera = true;
                            }
                        }
                        break;
                    case 'Y':// Grafo de la "Y"
                        if (caracteres.Length == 1)// Solo debe ser una "Y"
                            token.bandera = true;
                        break;
                    case ';':// Grafo del ";"
                        if (caracteres.Length == 1)// Solo debe ser un ";"
                            token.bandera = true;
                        break;
                    default: // Grafo de números
                        if (caracteres.Length <= 4)// Verificar que solo sean 4 dígitos o menos.
                        {
                            token.bandera = true;// Al ser un número menor que 9999 es valido.
                            if (caracteres[0] == '0' && caracteres.Length > 1)
                            {
                                token.bandera = false;// Un numero de 2 dígitos o más no puede iniciar con 0.
                            }
                        }
                        break;
                }
            }
            return tokens;
        }
    }
}
