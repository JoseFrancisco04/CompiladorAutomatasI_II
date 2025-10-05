﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorAutomatasI_II
{
    internal class AnalizadorLexico
    {
        private List<string> alfabeto = [
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            ";",
            "A",
            "C",
            "D",
            "E",
            "F",
            "I",
            "L",
            "M",
            "N",
            "O",
            "P",
            "R",
            "S",
            "T",
            "U",
            "V",
            "Y"
        ];
        public bool analizadorLexico(String codigoFuente)
        {
            ManejadorTokens mt = new ManejadorTokens();
            List<String> tokens = mt.separarTokens(codigoFuente);
            foreach (String token in tokens)
            {
                char[] caracteres = token.ToUpper().ToCharArray();
                for (short i = 0; i < caracteres.Length; i++)
                {
                    if (!alfabeto.Contains(caracteres[i].ToString()))
                        return false;
                }
            }
            return true;
        }
    }
}
