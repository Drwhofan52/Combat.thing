using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace combat_thing
{
    public class Player
    {

        //player stats
        public double Health;
        public double MHealth;
        public int HBH;
        public double Power;
        public double Powermin;
        public double Powermax;
        public double DmgTkn;
        public bool Missed;
        public string Target;

        //constructer
        public Player(double Health, double MHealth, double Power, double PowerMin, double PowerMax, string Target)
        {

            this.Health = Health;
            this.Power = Power;
            this.Powermin = PowerMin;
            this.Powermax = PowerMax;
            this.Target = Target;
            this.MHealth = MHealth;

        }

        //method for checking health
        public void CheckHlh()
        {

            //text output for health
            Debug.WriteLine("Player Health IS : " + Health);
            Debug.WriteLine(" ");

        }

        //hit processing
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
