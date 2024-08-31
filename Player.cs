using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combat_thing
{
    public class Player
    {




        // Body stats

        //Defalt stats
        public double Health = 10;

        // Strength 
        public double TotalSth = 10;
        // Endurance
        public double TotalEnd = 10;
        // felxibility
        public double TotalFex = 10;
        // balance
        public double TotalBal = 10;

        
        


        public void Attack()
        {
            Console.WriteLine("Attacking");
            Health = Health--;
            Console.WriteLine("Attack was finished");
        }






    }
}
