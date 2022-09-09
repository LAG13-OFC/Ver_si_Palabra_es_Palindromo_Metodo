using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Palindromo_Metodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;                                                                     //v para palabra
            Write("Ingrese palabra: ");
            palabra = ReadLine();                                           
            palabra = palabra.ToLower();
            if(Polidromo(palabra) > 0)                                                          //si el metodo Polidromo() devuelve un N° mayor que 0
            {   
                WriteLine($"La palabra '{palabra}' ES Polidromo");                              //es polidromo
            }
            else if(Polidromo(palabra) < 0)                                                     //o si es menor a 0 no es Polimedro
            {
                WriteLine($"La palabra '{palabra}' NO es Polidromo");
            }
            ReadKey();
        }
        static int Polidromo(string pal)                                                        //metodo que resibe un string y devulve un entero
        {
            int i, cont=0;                                                                      //v i para decrementar en el for y v cont para incrementar

            for (i = pal.Length - 1; i >= 0; i--)                                               // for de decremento, empieza en la ultima letra de la palabra
            {
                if (pal[i] != pal[cont])                                                        //if para ver si la letra en la posicion i es distinta a letra en posicion cont
                {   
                    return -1;                                                                  //Si se cumple devuelve -1
                }
                cont++;                                                                         //v cont que incrementa
            }
            return 1;                                                                           //Si nunca pasa por dentro del if va a retornar un 1
        }
    }
}
