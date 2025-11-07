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
        
        public Token(String value, bool bandera)
        {
            this.value = value;
            this.bandera = bandera;
        }
    }
}
