using System.Diagnostics;

namespace combat_thing
{
    public partial class Form1 : Form
    {




        //temp objects
        public Player player = new Player(10, 10, 1, 1, 10, "TR");
        public Enemy enemy = new Enemy(10, 10, 1, "TR");
        public int HBH;






        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateHealth();
        }


        // for the interaction
        public void Battle()
        {
            //sets the dmg amount
            player.DmgTkn = enemy.Power;
            enemy.DmgTkn = player.Power;

            if (player.Target == enemy.Target)
            {

                player.Missed = true;
                enemy.Missed = true;

            }
            else
            {

                player.Missed = false;
                enemy.Missed = false;

            }

            //handils if player was hit
            if (enemy.Missed == false)
            {
                //aplies dmg
                player.WasHit();

            }


            //handils if enemy was hit
            if (player.Missed == false)
            {
                //aplies dmg
                enemy.WasHit();

            }

            //sets dmg to 0 
            player.DmgTkn = 0;
            enemy.DmgTkn = 0;

            //does health check
            player.CheckHlh();
            enemy.CheckHlh();

        }

        private void BattleBtn_Click(object sender, EventArgs e)
        {

            //the start confremation
            Debug.WriteLine("Interacting");
            Debug.WriteLine(" ");

            // for calling battle
            Battle();

            //the end confremation
            Debug.WriteLine("the interaction has finished");
            Debug.WriteLine(" ");

            UpdateHealth();
            CallTheReaper();
            UpdateHealth();
        }

        private void TRTBtn_Click(object sender, EventArgs e)
        {
            player.Target = "TR";

        }

        private void TLTBtn_Click(object sender, EventArgs e)
        {
            player.Target = "TL";
        }

        private void BLTbtn_Click(object sender, EventArgs e)
        {
            player.Target = "BL";
        }

        private void BRTBtn_Click(object sender, EventArgs e)
        {
            player.Target = "BR";
        }


        public void UpdateHealth()
        {

            player.Health = Math.Round(player.Health);
            HBH = Convert.ToInt32(player.Health);
            HealthBar.Value = HBH;
            HthLbl2.Text = "=  " + Convert.ToString(player.Health);

        }

        public void CallTheReaper()
        {
            if (player.Health == 0)
            {
                Debug.WriteLine("player is dead   restarting");
                enemy.Health = enemy.MHealth;
                player.Health = player.MHealth;
            }
            else if (enemy.Health == 0)
            {
                Debug.WriteLine("enmey is dead   restarting");
                enemy.Health = enemy.MHealth;
                player.Health = player.MHealth;
            }
            else
            {

                Debug.WriteLine("no one is dead");
                UpdateHealth();
            }



        }

        private void UpPwrbtn_Click(object sender, EventArgs e)
        {

            if (player.Power < player.Powermax)
            {
                player.Power = player.Power + player.Powermin;
                Debug.WriteLine("power is :" + player.Power);
            }
            else
            {
                Debug.WriteLine("power Max has been reached");
            }
            
        }

        private void DnPwrbtn_Click(object sender, EventArgs e)
        {
            if (player.Power > player.Powermin)
            {
                player.Power = player.Power - player.Powermin;
                Debug.WriteLine("power is :" + player.Power);
            }
            else
            {
                Debug.WriteLine("power Min has been reached");
            }
            
        }
    }






}
