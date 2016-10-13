using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceGame
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            
          
            
            DiceCup diceCup = new DiceCup();
            diceCup.RollAllDiceInCup();
            Console.WriteLine($"Samlet værdi {diceCup.GetTotalValue()}");
            diceCup.ShowValues();



            Console.ReadLine();

            // The LAST line of code should be ABOVE this line
        }
    }
}
