using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Ejem_pre_hito
{
    class metodos
    {
        //metodo para identificar si el numero es primo
        public static string NumeroPrimo(int numero_verificar) {

            if (numero_verificar == 1) {
                return "el numero 1 no es primo ni compuesto";
            }
            else if (numero_verificar <= 0)
            {
                return "Introduzca un numero mayor a 0";
            }
            int contador = 0;
            for (int j = 1; j <= numero_verificar; j++)
            {
                if (numero_verificar % j == 0)
                {
                    contador = contador + 1;
                }
            }
            if (contador == 2)
            {
                return "Es primo";
            }
            else
            {
                return "No es primo";
            }
        }

        //metodo para numero random
        public static int NumeroRandom() {
            Random numero_random = new Random();
            int x = 1; int y = 100;
            int numero = numero_random.Next(x,y);
            return numero;
        }

        public static int Operacion(string condicional, int x, int y ) {
            if (condicional == "Es primo")
            {
                int respuesta_pim = (x * y) + x;
                return respuesta_pim;
            }
            else if (condicional == "No es primo")
            {
                int respuesta_alt = (x * y);
                return respuesta_alt;
            }
            else {
                return x;
            }
        
        }
       //metodo para obtener multiplos
       public static List<int> Multiplos(int numero){
           List<int> Res_mult = new List<int>();
           int desde = 0; int hasta = 1000;
           for (int i = desde; i <= hasta; i++) {
               if (i % numero == 0) {
                   Res_mult.Add(i);
               }
           }
               return Res_mult;
        }
    //verificar si los numeros son primos
       public static List<int> MultiplosPrimos(int numero) {
           List<int> Res_multp = new List<int>();
           int desde = 0; int hasta = 1000;
           for (int i = desde; i <= hasta; i++)
           {
               if (i % numero == 0)
               {
                   int contador = 0;
                   for (int j = 1; j <= i; j++)
                   {
                       if (i % j == 0)
                       {
                           contador = contador + 1;
                       }
                   }
                   if (contador == 2)
                   {
                       Res_multp.Add(i);
                   }
                   
               }
           }
           return Res_multp;
       }
    //verificar los numeros compuestos
       public static List<int> MultiplosCompuestos(int numero)
       {
           List<int> Res_comp = new List<int>();
           int desde = 0; int hasta = 1000;
           for (int i = desde; i <= hasta; i++)
           {
               if (i % numero == 0)
               {
                   int contador = 0;
                   for (int j = 1; j <= i; j++)
                   {
                       if (i % j == 0)
                       {
                           contador = contador + 1;
                       }
                   }
                   if (contador == 2)
                   {
                       
                   }
                   else {
                       Res_comp.Add(i);
                   }

               }
           }
           return Res_comp;
       }
    //metodo para factorial
       public static int Factorial(int fact)
       {
           int resultado = 1;
           for (int i = 1; i <= fact; i++)
           {
               resultado *= i; 
           }
           return resultado; 
       }



      
    }
}
