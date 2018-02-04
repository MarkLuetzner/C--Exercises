using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theQuest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        PictureBox equipControl;
        bool bluePotionUsed;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new theQuest.Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }
        
        public void UpdateCharacters()
        {
            //Change player location
            playerImage.Location = game.PlayerLocation;

            // Toggle hitpoints of Player
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            //Toggle visibility of enemy Image
            int enemiesShown = 0;

                batImage.Visible = false;
                batHitPoints.Text = "0";

                ghostImage.Visible = false;
                ghostHitPoints.Text = "0";


            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    batImage.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        batImage.Visible = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghost)
                {
                    ghostImage.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        ghostImage.Visible = true;
                        enemiesShown++;
                    }
                }
            }

            //Toggle visibility of weapon on playingfield
            swordImage.Visible = false;
            bluePotionImage.Visible = false;

            Control weaponControl = null;

            if (!game.WeaponInRoom.PickedUp)
            {
                switch (game.WeaponInRoom.Name)
                {
                    case "Sword":
                        weaponControl = swordImage;
                        break;
                    case "Blue Potion":
                        weaponControl = bluePotionImage;
                        break;
                    default:
                        break;
                }
                weaponControl.Visible = true;
                weaponControl.Location = game.WeaponInRoom.Location;
            }

            //Toggle visibility of inventory items

            swordImageBar.Visible = false;
            bowImageBar.Visible = false;
            maceImageBar.Visible = false;
            bluePotionImageBar.Visible = false;
            redPotionImageBar.Visible = false;

            if (game.CheckPlayerInventory("Sword"))
                swordImageBar.Visible = true;
            if (game.CheckPlayerInventory("Bow"))
                bowImageBar.Visible = true;
            if (game.CheckPlayerInventory("Mace"))
                maceImageBar.Visible = true;
            if (game.CheckPlayerInventory("Blue Potion") && game.WeaponUsed==false && bluePotionUsed==false)
                bluePotionImageBar.Visible = true;
            if (game.CheckPlayerInventory("Red Potion") && game.WeaponUsed==false)
                redPotionImageBar.Visible = true;

            // Toggle equipped weapon

            swordImageBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            bowImageBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            maceImageBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            bluePotionImageBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            redPotionImageBar.BorderStyle = System.Windows.Forms.BorderStyle.None;

            groupBox2.Text = "Attack";
            attackDownButton.Visible = true;
            attackLeftButton.Visible = true; 
            attackRightButton.Visible = true;

            equipControl = null;

            switch (game.WeaponEquipped)
            {
                case "Sword":
                    equipControl = swordImageBar;
                    break;
                case "Blue Potion":
                    equipControl = bluePotionImageBar;
                    groupBox2.Text = "Drink";
                    attackDownButton.Visible = false;
                    attackLeftButton.Visible = false;
                    attackRightButton.Visible = false;

                    break;
                default:          
                    break;
            }
            if (equipControl != null)
            equipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            //Check if player died

            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }

            //Check if advance to next level

            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(random);
                UpdateCharacters();
            }

        }

        private void swordImageBar_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");
            }
            UpdateCharacters();
        }

        private void bowImageBar_Click(object sender, EventArgs e)
        {

        }

        private void maceImageBar_Click(object sender, EventArgs e)
        {

        }

        private void bluePotionImageBar_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                game.Equip("Blue Potion");
            }
            UpdateCharacters();
        }

        private void redPotionImageBar_Click(object sender, EventArgs e)
        {

        }

        private void moveLeftButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void moveRightButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void attackLeftButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void attackUpButton_Click(object sender, EventArgs e)
        {
            if (game.WeaponUsed == false)
            game.Attack(Direction.Up, random);
            else
            {
                game.Attack(Direction.Up, random);
                game.Equip("Sword");
                bluePotionUsed = true;
            }

            UpdateCharacters();
        }

        private void attackRightButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void attackDownButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ghostHitPoints_Click(object sender, EventArgs e)
        {

        }

        private void ghostImage_Click(object sender, EventArgs e)
        {

        }
    }
}
