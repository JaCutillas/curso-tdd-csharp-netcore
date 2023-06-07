using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzz
    {
         public static List<string> GenerarLista()
        {
            var listaResultado = new List<string>();            
            for (int i = 1; i <= 100; i++)
            {
                string valor = null;
                if (i%3 == 0 || i.ToString().Contains("3"))
                {
                    valor = "Fizz";
                }
                if(i%5 == 0 || i.ToString().Contains("5"))
                {
                    valor += "Buzz";
                }
                
                listaResultado.Add(valor ?? (i).ToString());
            }

            return listaResultado;
        }
    }
}