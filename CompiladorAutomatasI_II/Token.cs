using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorAutomatasI_II
{
    public enum TipoToken
    {
        NUM,
        PUNTO_Y_COMA,
        INICIO,
        FIN,
        SUMAR,
        RESTAR,
        MULTIPLICAR,
        DIVIDIR,
        Y,
        ERROR
    }

    public class Token
    {
        public TipoToken Tipo { get; set; }
        public string Lexema { get; set; }
        public string Patron { get; set; }

        public Token(TipoToken tipo, string lexema, string patron)
        {
            Tipo = tipo;
            Lexema = lexema;
            Patron = patron;

        }

        public override string ToString()
        {
            return $"Tipo: {Tipo},Lexema: '{Lexema}', Patrón: '{Patron}'";
        }
    }
}
