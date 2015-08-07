using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class RiskRoller1 : Form
    {
        //Need to pass pair of ints into and out of the function, make a struct to hold them.
        public struct AttackersDefenders
        {
            public int attackers;
            public int defenders;
            public AttackersDefenders(int att, int def)
            {
                this.attackers = att;
                this.defenders = def;
            }
        }

        Random rnd;
        public RiskRoller1()
        {
            InitializeComponent();
            for (int i = 0; i <= 30; i++)
            {
                comboDefenders.Items.Add(i);
                comboAttackers.Items.Add(i);
            }
            rnd = new Random();
            Output.Text = "";
        }

        #region "Single Rolls"
        private void Attack1on1_Click(object sender, EventArgs e)
        {
            Output.Text = "";
            Attack(new AttackersDefenders(1, 1));
        }

        private void Attack2on1_Click(object sender, EventArgs e)
        {
            Output.Text = "";
            Attack(new AttackersDefenders(2, 1));
        }

        private void Attack3on1_Click(object sender, EventArgs e)
        {
            Output.Text = "";
            Attack(new AttackersDefenders(3, 1));
        }

        private void Attack1on2_Click(object sender, EventArgs e)
        {
            Output.Text = "";
            Attack(new AttackersDefenders(1, 2));
        }

        private void Attack2on2_Click(object sender, EventArgs e)
        {
            Output.Text = "";
            Attack(new AttackersDefenders(2, 2));
        }

        private void Attack3on2_Click(object sender, EventArgs e)
        {
            Output.Text = "";
            Attack(new AttackersDefenders(3, 2));
        }
        #endregion 


        private void clearAll_click(object sender, EventArgs e)
        {
            Output.Text = "";
            comboDefenders.Text = "";
            comboAttackers.Text = "";
        }


                        
        private AttackersDefenders Attack(AttackersDefenders men)
        {
            int attackNo = men.attackers; 
            int defenderNo = men.defenders;

            List<int> DefendersRolls = new List<int>(defenderNo);
            for (int i = 0; i < defenderNo; i++)
            {
                DefendersRolls.Add(DiceRoll());
            }
            DefendersRolls.Sort();
            DefendersRolls.Reverse();
            AddOutput("Defenders: " + WriteList(DefendersRolls));

            //Get List of Attack Rolls
            List<int> AttackRolls = new List<int>(attackNo);
            for (int i = 0; i < attackNo; i++)
            {
                AttackRolls.Add(DiceRoll());
            }
            AttackRolls.Sort();
            AttackRolls.Reverse();
            AddOutput("Attackers: " + WriteList(AttackRolls));

            AddOutput("");

            while (AttackRolls.Count > 0 && DefendersRolls.Count > 0)
            {
                if (AttackRolls[0] > DefendersRolls[0])
                {
                    defenderNo--;
                    AddOutput("Defender Lost");
                }
                else
                {
                    attackNo--;
                    AddOutput("Attacker Lost");
                }
                AttackRolls.RemoveAt(0);
                DefendersRolls.RemoveAt(0);
            }

           
            men.attackers = attackNo;
            men.defenders = defenderNo;
            return men;
        }

        private string WriteList(List<int> list)
        {
            StringBuilder output = new StringBuilder();
            output.Append("(");
            string comma = "";
            // Loop through List with foreach.
            foreach (int number in list) 
            {
                output.Append(comma+number);
                comma = ",";
            }
            output.Append(")");

            return output.ToString();
        }

        private int DiceRoll()
        {
            return rnd.Next(1,7);
        }

        private void AddOutput(string addedtext)
        {
            Output.Text += addedtext + "\r\n";
        }



        private void RollingAttack_Click(object sender, EventArgs e)
        {
            bool finished = false;
            bool firstrun = true;
            Output.Text = "";
            do
            {

                if (comboDefenders.Text == "")
                {
                    AddOutput("No Defenders Selected");
                    finished = true;
                    return;
                }

                if (comboAttackers.Text == "")
                {
                    AddOutput("No Attackers Selected");
                    finished = true;
                    return;
                }

                int defendersNo = Int32.Parse(comboDefenders.Text);
                if (defendersNo == 0)
                {
                    AddOutput("No-one left to defend with");
                    finished = true;
                    return;
                }

                int attackersNo = Int32.Parse(comboAttackers.Text);
                if (attackersNo == 0)
                {
                    AddOutput("No-one left to attack with");
                    finished = true;
                    return;
                }

                AttackersDefenders TotalArmies = new AttackersDefenders(attackersNo, defendersNo);
                if (firstrun)
                {
                    AddOutput("Attackers: " + TotalArmies.attackers);
                    AddOutput("Defenders: " + TotalArmies.defenders);
                    AddOutput("");
                    firstrun = false;
                }
                TotalArmies = rollingAttack(TotalArmies);

                if (TotalArmies.attackers == 0)
                {
                    AddOutput("No Attackers Left");
                    finished = true;
                }
                else if (TotalArmies.defenders == 0)
                {
                    AddOutput("No Defenders Left");
                    finished = true;
                }
                else if (toTheBloodyEnd.Checked)
                {
                    AddOutput("###########");
                    AddOutput("");
                }

                comboDefenders.Text = TotalArmies.defenders.ToString();
                comboAttackers.Text = TotalArmies.attackers.ToString();
            } while ((toTheBloodyEnd.Checked) && (finished == false));
            finished = true;
        }

        private AttackersDefenders rollingAttack(AttackersDefenders TotalArmies)
        {
            AttackersDefenders BattleArmies = new AttackersDefenders();

            //Setting Attackers.
            if (TotalArmies.attackers > 3)
            {
                BattleArmies.attackers = 3;
                TotalArmies.attackers -= 3;
            }
            else
            {
                BattleArmies.attackers = TotalArmies.attackers;
                TotalArmies.attackers = 0;
            }

            //Setting Defenders.
            if (TotalArmies.defenders > 2)
            {
                BattleArmies.defenders = 2;
                TotalArmies.defenders -= 2;
            }
            else
            {
                BattleArmies.defenders = TotalArmies.defenders;
                TotalArmies.defenders = 0;
            }

            //Attack with Armies
            BattleArmies = Attack(BattleArmies);

            //Update Combo Boxes
            TotalArmies.attackers += BattleArmies.attackers;
            TotalArmies.defenders += BattleArmies.defenders;
            
            AddOutput("");
            AddOutput("Attackers: " + TotalArmies.attackers);
            AddOutput("Defenders: " + TotalArmies.defenders);
            AddOutput("");
            
            return TotalArmies;
        }

        //Streach Goal 1 = Rolling Battle (DONE)
        //Streach Goal 2 = Stat Tracking.
        //Streach Goal 3 = Different Dice Settings.
    }
}
