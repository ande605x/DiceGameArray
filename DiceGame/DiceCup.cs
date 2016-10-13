using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceGame
{
    class DiceCup
    {
         private Die[] dieMany;

        public DiceCup()
        {
            // VERY IMPORTANT! When we have instance fields of a class type,
            // we MUST remember to create actual objects in the constructor,
            // that the instance fields can then point to.
           
            dieMany = new Die[5] { new Die(6), new Die(6), new Die(10), new Die(10), new Die(10) };

        }
        /// <summary>
        /// Ruller alle terningerne i bægeret
        /// </summary>
        public void RollAllDiceInCup()
        {
            for(int index=0;index<dieMany.Length; index++)
                dieMany[index].RollDie();
        }

       


        // You must create a method with the below header:
        /// <summary>
        /// returnerer værdierer fra alle terninger
        /// </summary>
        /// <returns></returns>
         public int GetTotalValue()
        {
            int total = 0;
            for (int index = 0; index < dieMany.Length; index++)
                total = dieMany[index].GetValue();
            return total;
        }

        // You must create a method with the below header:
         public bool IsTotalValueLargerThan(int value)
        {
            int terningeværdi;
            bool checker;
            terningeværdi = GetTotalValue();

            checker = terningeværdi > value;

            return checker;

        }

        public void ShowValues()
        {
            
            for (int index = 0; index < dieMany.Length; index++)
            {
                Console.WriteLine("Terning {0} har værdien {1}",index,dieMany[index]);
            }
        }


    }
}
