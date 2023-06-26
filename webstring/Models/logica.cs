using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webstring.Models
{
    public class logica
    {
        /*ejercicio 1*/
        public string contar(string valor1)
        {
            int dato = valor1.Count();
            string resultado1 = $"{valor1} tiene {dato} caracteres";
            return resultado1;
        }

        /*ejercicio 2*/
        public string mayuscula(string valor2)
        {
            string resultado2 = valor2.ToUpper();
            return resultado2;
        }

        /*ejercicio 3*/
        public string minuscula(string valor3)
        {
            string resultado3 = valor3.ToLower();
            return resultado3;
        }  
        
        /*ejercicio 4*/
        public string cajas(string valor4, string valor5, string valor6)
        {
            string resultado4 = $"{valor4} {valor5} {valor6}";
            return resultado4;            
        }

        /*ejercicio 5*/
        public string validar(string valor7, string valor8)
        {
            if (valor7.StartsWith(valor8))
            {

            }
            else if(valor8.StartsWith(valor7))
            {
                    
            }
            string resultado5 = valor7;
            return resultado5;
        }

        /*ejercicio 6*/
        public string cadena(string valor9)
        {
            string resultado6 = valor9.Replace(',', ' ').Replace('/', ' ');            
            return resultado6;
        }

        /*ejercicio 7*/
        public string coma(string valor10)
        {
            string resultado7 = valor10.TrimEnd(',', ' ');
            return resultado7;
        }

        /*ejercicio 8*/
        public string espacio(string valor11)
        {
            string resultado8 = valor11.Trim();
            return resultado8;
        }

        /*ejercicio 9*/
        public string ti(string valor12)
        {
            string resultado9 = valor12;
            if (valor12.StartsWith("ti"))
            {
                resultado9 = $"El enunciado {valor12} SI empieza con la palabra TI";
            }
            else
            {
                resultado9 = $"El enunciado {valor12} NO empieza con la palabra TI";
            }           
            return resultado9;
        }

        /*ejercicio10*/
        public string ejercicio10(string valor13)
        {
            string resultado10 = valor13.PadLeft(5, '0');
            return resultado10;
        }      
    }
}