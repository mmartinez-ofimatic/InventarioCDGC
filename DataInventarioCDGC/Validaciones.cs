using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DataInventarioCDGC
{
   public class Validaciones
    {

       public bool ValidateCedula(string cedula)
       {
           bool isCorrect = false;

           int n, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, verificador, suma, contador = 0;

           char caracter = '\0';



           if (ValidateNumeric(cedula) == false)
           {
               return isCorrect;
           }
           else
           {

               for (n = 0; n < cedula.Length; n++)
               {
                   if (cedula[n] == caracter)
                   {
                       contador = contador + 1;
                   }
               }

               if (n != 11)
               {
                   return isCorrect;
               }
               else
               {
                   n1 = int.Parse(cedula.Substring(0, 1));
                   n2 = int.Parse(cedula.Substring(1, 1)) * 2;
                   n3 = int.Parse(cedula.Substring(2, 1));
                   n4 = int.Parse(cedula.Substring(3, 1)) * 2;
                   n5 = int.Parse(cedula.Substring(4, 1));
                   n6 = int.Parse(cedula.Substring(5, 1)) * 2;
                   n7 = int.Parse(cedula.Substring(6, 1));
                   n8 = int.Parse(cedula.Substring(7, 1)) * 2;
                   n9 = int.Parse(cedula.Substring(8, 1));
                   n10 = int.Parse(cedula.Substring(9, 1)) * 2;
                   verificador = int.Parse(cedula.Substring(10, 1));
                   if (n1 > 9)
                   {
                       n1 = n1 - 9;
                   }
                   if (n2 > 9)
                   {
                       n2 = n2 - 9;
                   }
                   if (n3 > 9)
                   {
                       n3 = n3 - 9;
                   }
                   if (n4 > 9)
                   {
                       n4 = n4 - 9;
                   }
                   if (n5 > 9)
                   {
                       n5 = n5 - 9;
                   }
                   if (n6 > 9)
                   {
                       n6 = n6 - 9;
                   }
                   if (n7 > 9)
                   {
                       n7 = n7 - 9;
                   }
                   if (n8 > 9)
                   {
                       n8 = n8 - 9;
                   }
                   if (n9 > 9)
                   {
                       n9 = n9 - 9;
                   }
                   if (n1 > 9)
                   {
                       n1 = n1 - 9;
                   }
                   if (n10 > 9)
                   {
                       n10 = n10 - 9;
                   }

                   suma = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10;

                   if (suma % 10 == 0 && verificador == 0)
                   {
                       return isCorrect = true;
                   }
                   else
                   {
                       if ((suma) % 10 != 0 && (suma + verificador) % 10 == 0)
                       {
                           return isCorrect = true;
                       }
                       else
                       {
                           return isCorrect;
                       }
                   }

               }
           }
         //  return isCorrect;
       }

        public bool ValidateNumeric(string numericText)
        {
            bool isCorrect = false;

            Match numeric = Regex.Match(numericText, @"^[0-9]*$");
            
            if (numeric.Success)
                return isCorrect = true;
            else
                return isCorrect;
        }

        public bool ValidateDecimal(string numericText)
        {
            bool isCorrect = false;
            //^\d*(.\d\d)?$
            Match numeric = Regex.Match(numericText, @"^\d*(.\d\d)?$");

            if (numeric.Success)
                return isCorrect = true;
            else
                return isCorrect;
        }
    }
}
