using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorAutomatasI_II
{

    public class Token
    {
        public String value { get; set; }
        public bool bandera {  get; set; }
        public bool banderaLexico { get; set; }
        public bool banderaSemantico { get; set; }


        public Token(String value)
        {
            this.value = value;
        
        }

        public string ObtenerErrorSintactico()
        {
        
            if (!bandera)
                return "Error sintáctico";
            return "SUCCESSFUL";
        }

        public string ObtenerErrorLexico()
        {
            if (!banderaLexico)
                return "Error léxico";
            return "SUCCESSFUL";
        }

        public string ObtenerErrorSemantico()
        {
            if (!banderaSemantico)
                return "Error semántico";
            return "SUCCESSFUL";
        }
    }
}
