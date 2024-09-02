using System.Diagnostics;

namespace combat_thing
{
    public partial class Form1 : Form
    {

        //temp objects
        public Player player = new Player(10, 1, "TR");
        public Enemy enemy = new Enemy(10, 1, "TR");






        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }






}
