using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combat_thing
{
    public class Enemy
    {

        //enemy stats
        public double Health;
        public double Power;
        public double DmgTkn;
        public bool Missed;
        public string Target = "TR";

        //constructer
        public Enemy(double health, double power)
        {

            //constructed stats
            this.Health = health;
            this.Power = power;
        
        }

        //method for checking the health
        public void CheckHlh()
        {

            //text output for health
            Debug.WriteLine("Enemy Health IS : " + Health);
            Debug.WriteLine(" ");

        }

        public void WasHit()
        {

            //hit comp
            Debug.WriteLine("was hit");

            //health change
            Health = Health - DmgTkn;

            //for comp 
            Debug.WriteLine("Hit was processed");

        }


    }
}
