using System;
using System.Collections.Generic;
using System.Text;

namespace ExamModule1
{
    class InserisciNumero
    {
        public static int LeggiNumeroDaConsole(int minVal, int maxVal)
        {
          
            string valString;
            int valInt = 0;

            bool isInt = false;
            bool InRange = false;

            do
            {
                try
                {
                    
                    valString = Console.ReadLine();

                    valInt = int.Parse(valString);
                    isInt = true;

                    if (valInt >= minVal && valInt <= maxVal)
                    {
                        
                        InRange = true;
                    }
                    else
                    {
                        
                        Console.WriteLine("Attenzione!Il valore immesso non è nell'intervallo indicato");

                        
                        valInt = 0;
                        isInt = false;
                        InRange = false;
                    }
                }
                catch (Exception exc)
                {
                    
                    Console.WriteLine("Attenzione!Il valore immesso non è un numero!");

                    valInt = 0;
                    isInt = false;
                    InRange = false;
                }
            }
            while (isInt == false || InRange == false);

            
            return valInt;
        }

        public static void Uscita()
        {
            Console.Write("Premi un pulsante per uscire");
            Console.ReadKey();
        }
    }
}
