using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PunchOut
{
    public partial class Form1 : Form
    {
        //Tell the game that the player is not blocking
        bool playerBlock = false;
        //Tell the game that the enemy is not blocking
        bool enemyBlock = false;
        Random random = new Random();
        int enemySpeed = 5;
        int index = 0;
        int playerHealth = 100;
        int enemyHealth = 100;
        //Here are a list of moves
        List<string> enemyAttack = new List<string> {"left", "right", "block" };

        public Form1()
        {
            InitializeComponent();
            ResetGame();
            //When the game starts reset game
        }

        //This is how the boxer thinks
        private void BoxerAttackTimerEvent(object sender, EventArgs e)
        {
            //Choose a random number from 0 through 2
            index = random.Next(0, enemyAttack.Count);
            //convert that to a string
            switch (enemyAttack[index].ToString()) 
            {
                //if left is chosen then do this
                case "left":
                    Boxer.Image = Properties.Resources.enemy_punch1;
                    enemyBlock= false;
                    if (Boxer.Bounds.IntersectsWith(Player.Bounds) && playerBlock == false)
                    { 
                    playerHealth -= 5;
                    }
                    break;
                //if right is chosen then do this
                case "right":
                    Boxer.Image = Properties.Resources.enemy_punch2;
                    enemyBlock = false;
                    if (Boxer.Bounds.IntersectsWith(Player.Bounds) && playerBlock == false)
                    {
                        playerHealth -= 5;
                    }
                    break;
                //if block is chosen then do this
                case "block":
                    Boxer.Image = Properties.Resources.enemy_block;
                    enemyBlock = true;
                break;
            }

        }

        private void BoxerMoveTimerEvent(object sender, EventArgs e)
        {
            //set up both heath bars here
            //I think this is only done to avoid errors
            if (playerHealth > 1)
            {
            PlayerHealthBar.Value = playerHealth;

            }
            if (enemyHealth > 1)
            {
                BoxerHealthBar.Value = enemyHealth;

            }

            //move the boxer
            //if the boxers left coordinate is greater than 430 than change the direction 
            Boxer.Left += enemySpeed;
                if (Boxer.Left > 430)
            { 
                enemySpeed = -5;
            }
            //if the boxers left coordinate is less than 220 than change the direction 
            if (Boxer.Left < 220)
            {
                enemySpeed = 5;
            }

            //check for the end of game scenario You Win
            if (enemyHealth < 1)
            {
                BoxerAttackTimer.Stop();
                BoxerMoveTimer.Stop();
                //Change this to label
                MessageBox.Show("You win, Click ok to continue");
                ResetGame();
            }
            //check for the end of game scenario You Lose
            if (playerHealth < 1)
            {
                BoxerAttackTimer.Stop();
                BoxerMoveTimer.Stop();
                //Change this to label
                MessageBox.Show("You lost, Click ok to continue");
                ResetGame();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            //Left Right and Down Keys
            if (e.KeyCode == Keys.Left)
            {
                Player.Image = Properties.Resources.boxer_left_punch;
                playerBlock = false;

                if (Player.Bounds.IntersectsWith(Boxer.Bounds) && enemyBlock == false)
                {
                enemyHealth -= 10;
                }
             }
            if (e.KeyCode == Keys.Right)
            {
                Player.Image = Properties.Resources.boxer_right_punch;
                playerBlock = false;
                if (Player.Bounds.IntersectsWith(Boxer.Bounds) && enemyBlock == false)
                {
                    enemyHealth -= 10;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                Player.Image = Properties.Resources.boxer_block;
                playerBlock = true;
            }

        }
        //when no keys are pressed
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            Player.Image = Properties.Resources.boxer_stand;
            playerBlock = false;
        }
        private void ResetGame()
        {
            BoxerAttackTimer.Start();
            BoxerMoveTimer.Start();
            playerHealth= 100;    
            enemyHealth= 100;
            Boxer.Left = 400;
            Boxer.Top = 325;
        }

      
    }
}
