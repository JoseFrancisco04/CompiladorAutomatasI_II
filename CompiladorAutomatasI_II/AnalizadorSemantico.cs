using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorAutomatasI_II
{
    internal class AnalizadorSemantico
    {




        public static List<Token> analizadorSemantico(String codigo)
        {
            AnalizadorSintactico asin = new AnalizadorSintactico();
            List<Token> tokens = asin.analizadorSintactico(codigo);

            int contadorInicio = 0;
            int contadorFinal = 0;
            bool validarInicio = false;

            for (int i = 0; i < tokens.Count; i++)
            {
                Token token = tokens[i];
                //Primera regla semantica en el if (INICIO) que es escribir la palabra INICIO al inicio del codigo junto con ; ademas se verifica que solo exista una sola palabra INICIO con la variable auxiliar contadorInicio
                //Tambian hay una variable auxiliar que es validarInicio que se pone en true si se cumple la regla semantica del INICIO para despues validar la regla semantica del FIN
                if (token.value == "INICIO")
                {


                    contadorInicio++;
                    token.banderaSemantico = false;

                    if (contadorInicio == 1 && i + 1 < tokens.Count && tokens[i + 1].value == ";")
                    {
                        validarInicio = true;
                        token.banderaSemantico = true;

                    }


                }
                //Este if verifica las operaciones aritmeticas SUMAR, RESTAR, MULTIPLICAR y DIVIDIR, te toca acompletarlo gei, solo falta esto pa:
                //1.Marcar que la instrucccion de la operacion aritmetica sea valida en su estructura
                //2.Checar que la instruccion aritmetica este dentro del bloque INICIO y FIN
                //3.Que al dividir entre 0 marque error semantico
                //y pues creo que es todo...si hace falta algo ahi lo agregas
                //ver si se puede agregar mas de una operacion aritmetica entre INICIO y FIN o solo una operacion aritmetica...ahi le checas
                else if (token.value == "SUMAR" || token.value == "RESTAR" || token.value == "MULTIPLICAR" || token.value == "DIVIDIR")
                {
                    if (i + 4 < tokens.Count)
                    {
                        if (esNumero(tokens[i + 1].value) && tokens[i+2].value == "Y" && esNumero(tokens[i + 3].value) && tokens[i + 4].value == ";")
                        {

                        }

                    }
                    else
                    {
                        token.banderaSemantico = false;
                    }


                }
                //Esta regla semantica del if (FIN) verifica que la palabra FIN este al final del codigo junto con ; ademas de que solo exista una sola palabra FIN con la variable auxiliar contadorFinal
                //Aqui tambien se verifica que haya una palabra INICIO valida antes de la palabra FIN
                else if (token.value == "FIN")
                {
                    contadorFinal++;
                    

                    if (validarInicio == false)
                    {
                        token.banderaSemantico = false;
                    }
                    else
                    {
                        if (contadorFinal == 1 && i + 1 < tokens.Count && tokens[i + 1].value == ";")
                        {
                            token.banderaSemantico = true;
                        }
                    }

                }
                //Esta regla semantica del if (;) verifica que haya un ; en las palabras reservada INICIO, FIN y en la instruccion de operaciones aritmeticas
                else if (token.value == ";")
                {
                    if (i > 0)
                    {

                        if (tokens[i - 1].value == "INICIO" || tokens[i - 1].value == "FIN" || esNumero(tokens[i - 1].value))
                        {
                            token.banderaSemantico = true;
                        }
                        else
                        {
                            token.banderaSemantico = false;
                        }

                    }

                }
                else
                {
                    return null; 
                }

            }

            return tokens;
        }


        //Este metodo verfica que el valor sea un numero
        private static bool esNumero(string valor)
        {
            int numero = int.Parse(valor);
            return true;
        }

    }
}
