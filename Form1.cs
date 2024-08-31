using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combat_thing
{
    public partial class Form1 : Form
    {
        

        Player PyrInt = new(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Atkbtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btn was Clicked");
            //PyrInt.Attack();
        }

    
    }
}
