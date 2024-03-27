using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace choose_your_own_adventure
{

    public partial class Form1 : Form
    {
        int page = 1;
        Random randgen1 = new Random();
        Random randgen2 = new Random();
        public Form1()
        {
            InitializeComponent();
            backButton.Enabled = false;
                    readerLabel.Text = "A dragon has took over the castle and now you must defeat them";
            choose1Label.Text = "Continue";
            choose2Label.Text = "";

        }

        private void chooseButton1_Click(object sender, EventArgs e)
        {
            backButton.Enabled = true;
            readerLabel.Text = "";
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                int rand = randgen1.Next(1, 101);
                if (rand <= 30)
                {
                    page = 4;
                }
                else
                {
                    page = 3;
                }
            }
            else if (page == 3)
            {
                page = 6;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 5)
            {
                page = 4;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 12;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 7;
            }
            else if (page == 10)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 26;
            }
            else if (page == 12)
            {
                page = 14;
            }
            else if (page == 13)
            {
                page = 18;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                page = 20;
            }
            else if (page == 19)
            {
                page = 1;
            }
            else if (page == 20)
            {
                page = 22;
            }
            else if (page == 21)
            {
                page = 1;
            }
            else if (page == 22)
            {
                page = 1;
            }
            else if (page == 23)
            {
                page = 24;
            }
            else if (page == 24)
            {
                page = 1;
            }
            else if (page == 25)
            {
                page = 1;
            }
            else if (page == 26)
            {
                page = 1;
            }
            else if (page == 27)
            {
                page = 28;
            }
            else if (page == 28)
            {
                page = 1;
            }
            else if (page == 29)
            {
                page = 1;
            }
            else if (page == 30)
            {
                page = 31;
            }
            else if (page == 31)
            {
                page = 1;
            }
            else if (page == 32)
            {
                int rand2 = randgen2.Next(1, 101);

                if (rand2 >= 50)
                {
                    page = 34;
                }
                else
                {
                    page = 35;
                }
            }

            else if (page == 33)
            {
                page = 1;
            }
            else if (page == 34)
            {
                page = 1;
            }
            else if (page == 35)
            {
                page = 1;
            }
            SoundPlayer player = new SoundPlayer(Properties.Resources.Ambiance);
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.Dies);
            SoundPlayer player3 = new SoundPlayer(Properties.Resources.Fire_sound);
            SoundPlayer player4 = new SoundPlayer(Properties.Resources.Monster);
            switch (page)
            {
                case 1:

                    player.Play();
                    readerLabel.Text = "A dragon has took over the castle and now you must defeat them";
                    choose1Label.Text = "Continue";
                    choose2Label.Text = "";
                    break;
                case 2:

                    player.Play();
                    pictureBox.Image = Properties.Resources.Town;
                    readerLabel.Text = "Where do you want to go?";
                    choose1Label.Text = "Castle";
                    choose2Label.Text = "Outside of Town";
                    break;
                case 3:
                    player4.Play();
                    pictureBox.Image = Properties.Resources.Skeleton;
                    readerLabel.Text = "A Skeleton appears blocking your way, you can only run. " +
                        "\nWhich way do you go?";
                    choose1Label.Text = "Left";
                    choose2Label.Text = "Right";
                    break;
                case 4:
                    pictureBox.Image = Properties.Resources.DragonSleeping;
                    readerLabel.Text = "You have enter a large room, the dragon sleeping, you can either attack or try to find a better solution up the stairs on the side." +
                        "\nWhich way do you go";
                    choose1Label.Text = "To Battle!!!";
                    choose2Label.Text = "Up the stairs";
                    break;
                case 5:
                    pictureBox.Image = Properties.Resources.Skeleton;
                    readerLabel.Text = "The Skeleton is still behind you. " +
                        "\nWhich way do you go?";
                    choose1Label.Text = "Left";
                    choose2Label.Text = "Right";
                    break;
                case 6:
                    player2.Play();
                    pictureBox.Image = Properties.Resources.Grave;
 
                    player2.Play();
                    readerLabel.Text = "The Skeleton catches you after you enter a dead end." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 7:
                    pictureBox.Image = Properties.Resources.Dragon;
                    readerLabel.Text = "The Dragon awakes, beginning to attack." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Charge!!!";
                    choose2Label.Text = "dodge it's attack";
                    break;
                case 8:
                    pictureBox.Image = Properties.Resources.TowerStair;
                    readerLabel.Text = "You sneak up the stairs finding a small chest on the side and forwards, more stairs." +
                        "\nWhat do you do";
                    choose1Label.Text = "Up the stairs";
                    choose2Label.Text = "Open the chest";
                    break;
                case 9:
                    pictureBox.Image = Properties.Resources.Wall;
                    readerLabel.Text = "You find a dead end with another chest on the side." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Go back";
                    choose2Label.Text = "Open the chest";
                    break;
                case 10:
                    pictureBox.Image = Properties.Resources.Teeth;
                    readerLabel.Text = "You open the chest before seeing the mass of teeth, its tongue quickly grabs you before you relise it's a mimic." +
                        "\nTry Again";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 11:
                    pictureBox.Image = Properties.Resources.Balcony;
                    readerLabel.Text = "You find a magical artifact that reveals illusions, looking back you find the wall is now a balcony looking over the dragon with a boulder." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Shoot the dragon";
                    choose2Label.Text = "push the boulder";
                    break;
                case 12:
                    pictureBox.Image = Properties.Resources.Dragon;
                    readerLabel.Text = "Charging past it's attack, you get face to face with the beast." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Duck below the beast";
                    choose2Label.Text = "Jump Stirke!!!";
                    break;
                case 13:
                    pictureBox.Image = Properties.Resources.Dragon;
                    readerLabel.Text = "you dodge it's attack it's tail now trapping you in the corner, a strange look on it's face." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Grab it's tail";
                    choose2Label.Text = "Shoot it";
                    break;
                case 14:
                    player2.Play();
                    pictureBox.Image = Properties.Resources.Grave;
                    readerLabel.Text = "you duck under but then witness the dragon sitting down crushing you instantly." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 15:
                    pictureBox.Image = Properties.Resources.Dragon;
                    readerLabel.Text = "Your sword pierces the dragon, the monster rears it's head back." +
                        "\nWhat do you do?";
                    choose1Label.Text = "shoot it's eye";
                    choose2Label.Text = "Axe Smash!!!";
                    break;
                case 16:
                    pictureBox.Image = Properties.Resources.Trophy;
                    readerLabel.Text = "The arrow goes through the eye piercing it's head. You have won the Quest!" +
                        "\nDo you want to try again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 17:
                    pictureBox.Image = Properties.Resources.Trophy;
                    readerLabel.Text = "The axe goes through the stomach, the dragon body collaspes with it's last breaths. You have won the Quest!" +
                        "\nDo you want to try again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 18:
                    pictureBox.Image = Properties.Resources.Dragon;
                    readerLabel.Text = "You grab the tail as it get brought back to it's body, you are now next to it's head." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Let go";
                    choose2Label.Text = "Attack the eye";
                    break;
                case 19:
                    player3.Play();
                    pictureBox.Image = Properties.Resources.Fire;
                    readerLabel.Text = "The dragons flames burst out of it's mouth burning you alive in an instant" +
                        "\nTry Again";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 20:
                    pictureBox.Image = Properties.Resources.Dragon;
                    readerLabel.Text = "You are not at the bottom of the beast it's claws getting ready to crush." +
                        "\nWhat do you do?";
                    choose1Label.Text = "JumpStrike!!!";
                    choose2Label.Text = "Go below";
                    break;
                case 21:
                    player2.Play();
                    pictureBox.Image = Properties.Resources.Grave;
                    readerLabel.Text = "Your attack misses the mark and a second later, the dragons teeth are upon you." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 22:
                    player2.Play();
                    pictureBox.Image = Properties.Resources.Grave;
                    readerLabel.Text = "The dragons claws tear through your flesh before you even get close." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 23:
                    pictureBox.Image = Properties.Resources.Dragon;
                    readerLabel.Text = "You duck the Dragon then land a strike at it's back, it finds itself to big to turn." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Contiue to attck it";
                    choose2Label.Text = "Climb the beast";
                    break;
                case 24:
                    player2.Play();
                    pictureBox.Image = Properties.Resources.Grave;
                    readerLabel.Text = "You forgot about the tail, striking at you the last thing you see is the dragons malicious grin." +
                        "\nTry Again";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 25:
                    pictureBox.Image = Properties.Resources.Trophy;
                    readerLabel.Text = "You succefully climb the beast and then repeatily stabbing it, after a while the dragon succumbs to it's wounds. You have won the Quest." +
                        "\nDo you want to try again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 26:
                    player2.Play();
                    pictureBox.Image = Properties.Resources.Grave;
                    readerLabel.Text = "The arrow bounce off it's hide and it a shockingly quick move it flies up and eats you in one bite." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 27:
                    pictureBox.Image = Properties.Resources.Dragon;
                    readerLabel.Text = "The dragon is trapped by the boulder and is now struggling." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Shoot it";
                    choose2Label.Text = "get into close range";
                    break;
                case 28:
                    pictureBox.Image = Properties.Resources.Trophy;
                    readerLabel.Text = "Your arrows rain down on the beast and after a while the dragon lays dead. You have won the Quest." +
                        "\nDo you want to try again";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 29:
                    player2.Play();
                    pictureBox.Image = Properties.Resources.Grave;
                    readerLabel.Text = "you jump onto the monster but end up tripping, as the dragon struggles against the bouder you get crushed in the crossfire." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 30:
                    pictureBox.Image = Properties.Resources.OutsideTown;
                    readerLabel.Text = "You leave town and find yourself with only a small farm." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Leave Town";
                    choose2Label.Text = "Go to the Farm";
                    break;
                case 31:
                    pictureBox.Image = Properties.Resources.wild;
                    readerLabel.Text = "You decide that screw your quest, you arn't fighting a dragon and get out of town." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 32:
                    pictureBox.Image = Properties.Resources.Farm;
                    readerLabel.Text = "You go to the farm and meet a man named Farmer Robins who tells you that he's looking for some help, you also notice a bag of gold on his waist." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Yoink";
                    choose2Label.Text = "Work for him";
                    break;
                case 33:
                    pictureBox.Image = Properties.Resources.Farm;
                    readerLabel.Text = "You find yourself enjoying the farmwork and decide to retire from adventuring." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 34:
                    pictureBox.Image = Properties.Resources.Jail;
                    readerLabel.Text = "You are arrested and thrown in jail." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 35:
                    pictureBox.Image = Properties.Resources.wild;
                    readerLabel.Text = "You escape as an outlaw, banished from the town." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;

            }

        }

        private void chooseButton2_Click(object sender, EventArgs e)
        {
            backButton.Enabled = true;
            if (page == 2)
            {
                page = 30;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 4)
            {
                page = 8;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 99;
            }
            else if (page == 7)
            {
                page = 13;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 9)
            {
                page = 11;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 27;
            }
            else if (page == 12)
            {
                page = 15;
            }
            else if (page == 13)
            {
                page = 19;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 16)
            {
                page = 99;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 18)
            {
                page = 21;
            }
            else if (page == 19)
            {
                page = 99;
            }
            else if (page == 20)
            {
                page = 23;
            }
            else if (page == 21)
            {
                page = 99;
            }
            else if (page == 22)
            {
                page = 99;
            }
            else if (page == 23)
            {
                page = 25;
            }
            else if (page == 24)
            {
                page = 99;
            }
            else if (page == 25)
            {
                page = 99;
            }
            else if (page == 26)
            {
                page = 99;
            }
            else if (page == 27)
            {
                page = 29;
            }
            else if (page == 28)
            {
                page = 99;
            }
            else if (page == 29)
            {
                page = 99;
            }
            else if (page == 30)
            {
                page = 32;
            }
            else if (page == 31)
            {
                page = 99;
            }
            else if (page == 32)
            {
                page = 33;
            }
            else if (page == 33)
            {
                page = 99;
            }
            else if (page == 34)
            {
                page = 99;
            }
            else if (page == 35)
            {
                page = 99;
            }
            SoundPlayer player = new SoundPlayer(Properties.Resources.Ambiance);
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.Dies);
            SoundPlayer player3 = new SoundPlayer(Properties.Resources.Fire_sound);
            SoundPlayer player4 = new SoundPlayer(Properties.Resources.Monster);
            switch (page)
            {
                case 1:

                    player.Play();
                    readerLabel.Text = "A dragon has took over the castle and now you must defeat them";
                    choose1Label.Text = "Continue";
                    choose2Label.Text = "";
                    break;
                case 2:

                    player.Play();
                    pictureBox.Image = Properties.Resources.Town;
                    readerLabel.Text = "Where do you want to go?";
                    choose1Label.Text = "Castle";
                    choose2Label.Text = "Outside of Town";
                    break;
                case 3:
                    player4.Play();
                    pictureBox.Image = Properties.Resources.Skeleton;
                    readerLabel.Text = "A Skeleton appears blocking your way, you can only run. " +
                        "\nWhich way do you go?";
                    choose1Label.Text = "Left";
                    choose2Label.Text = "Right";
                    break;
                case 4:
                    pictureBox.Image = Properties.Resources.DragonSleeping;
                    readerLabel.Text = "You have enter a large room, the dragon sleeping, you can either attack or try to find a better solution up the stairs on the side." +
                        "\nWhich way do you go";
                    choose1Label.Text = "To Battle!!!";
                    choose2Label.Text = "Up the stairs";
                    break;
                case 5:
                    pictureBox.Image = Properties.Resources.Skeleton;
                    readerLabel.Text = "The Skeleton is still behind you. " +
                        "\nWhich way do you go?";
                    choose1Label.Text = "Left";
                    choose2Label.Text = "Right";
                    break;
                case 6:
                    player2.Play();
                    pictureBox.Image = Properties.Resources.Grave;

                    player2.Play();
                    readerLabel.Text = "The Skeleton catches you after you enter a dead end." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 7:
                    pictureBox.Image = Properties.Resources.Dragon;
                    readerLabel.Text = "The Dragon awakes, beginning to attack." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Charge!!!";
                    choose2Label.Text = "dodge it's attack";
                    break;
                case 8:
                    pictureBox.Image = Properties.Resources.TowerStair;
                    readerLabel.Text = "You sneak up the stairs finding a small chest on the side and forwards, more stairs." +
                        "\nWhat do you do";
                    choose1Label.Text = "Up the stairs";
                    choose2Label.Text = "Open the chest";
                    break;
                case 9:
                    pictureBox.Image = Properties.Resources.Wall;
                    readerLabel.Text = "You find a dead end with another chest on the side." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Go back";
                    choose2Label.Text = "Open the chest";
                    break;
                case 10:
                    pictureBox.Image = Properties.Resources.Teeth;
                    readerLabel.Text = "You open the chest before seeing the mass of teeth, its tongue quickly grabs you before you relise it's a mimic." +
                        "\nTry Again";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 11:
                    pictureBox.Image = Properties.Resources.Balcony;
                    readerLabel.Text = "You find a magical artifact that reveals illusions, looking back you find the wall is now a balcony looking over the dragon with a boulder." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Shoot the dragon";
                    choose2Label.Text = "push the boulder";
                    break;
                case 12:
                    pictureBox.Image = Properties.Resources.Dragon;
                    readerLabel.Text = "Charging past it's attack, you get face to face with the beast." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Duck below the beast";
                    choose2Label.Text = "Jump Stirke!!!";
                    break;
                case 13:
                    pictureBox.Image = Properties.Resources.Dragon;
                    readerLabel.Text = "you dodge it's attack it's tail now trapping you in the corner, a strange look on it's face." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Grab it's tail";
                    choose2Label.Text = "Shoot it";
                    break;
                case 14:
                    player2.Play();
                    pictureBox.Image = Properties.Resources.Grave;
                    readerLabel.Text = "you duck under but then witness the dragon sitting down crushing you instantly." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 15:
                    pictureBox.Image = Properties.Resources.Dragon;
                    readerLabel.Text = "Your sword pierces the dragon, the monster rears it's head back." +
                        "\nWhat do you do?";
                    choose1Label.Text = "shoot it's eye";
                    choose2Label.Text = "Axe Smash!!!";
                    break;
                case 16:
                    pictureBox.Image = Properties.Resources.Trophy;
                    readerLabel.Text = "The arrow goes through the eye piercing it's head. You have won the Quest!" +
                        "\nDo you want to try again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 17:
                    pictureBox.Image = Properties.Resources.Trophy;
                    readerLabel.Text = "The axe goes through the stomach, the dragon body collaspes with it's last breaths. You have won the Quest!" +
                        "\nDo you want to try again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 18:
                    pictureBox.Image = Properties.Resources.Dragon;
                    readerLabel.Text = "You grab the tail as it get brought back to it's body, you are now next to it's head." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Let go";
                    choose2Label.Text = "Attack the eye";
                    break;
                case 19:
                    player3.Play();
                    pictureBox.Image = Properties.Resources.Fire;
                    readerLabel.Text = "The dragons flames burst out of it's mouth burning you alive in an instant" +
                        "\nTry Again";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 20:
                    pictureBox.Image = Properties.Resources.Dragon;
                    readerLabel.Text = "You are not at the bottom of the beast it's claws getting ready to crush." +
                        "\nWhat do you do?";
                    choose1Label.Text = "JumpStrike!!!";
                    choose2Label.Text = "Go below";
                    break;
                case 21:
                    player2.Play();
                    pictureBox.Image = Properties.Resources.Grave;
                    readerLabel.Text = "Your attack misses the mark and a second later, the dragons teeth are upon you." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 22:
                    player2.Play();
                    pictureBox.Image = Properties.Resources.Grave;
                    readerLabel.Text = "The dragons claws tear through your flesh before you even get close." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 23:
                    pictureBox.Image = Properties.Resources.Dragon;
                    readerLabel.Text = "You duck the Dragon then land a strike at it's back, it finds itself to big to turn." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Contiue to attck it";
                    choose2Label.Text = "Climb the beast";
                    break;
                case 24:
                    player2.Play();
                    pictureBox.Image = Properties.Resources.Grave;
                    readerLabel.Text = "You forgot about the tail, striking at you the last thing you see is the dragons malicious grin." +
                        "\nTry Again";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 25:
                    pictureBox.Image = Properties.Resources.Trophy;
                    readerLabel.Text = "You succefully climb the beast and then repeatily stabbing it, after a while the dragon succumbs to it's wounds. You have won the Quest." +
                        "\nDo you want to try again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 26:
                    player2.Play();
                    pictureBox.Image = Properties.Resources.Grave;
                    readerLabel.Text = "The arrow bounce off it's hide and it a shockingly quick move it flies up and eats you in one bite." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 27:
                    pictureBox.Image = Properties.Resources.Dragon;
                    readerLabel.Text = "The dragon is trapped by the boulder and is now struggling." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Shoot it";
                    choose2Label.Text = "get into close range";
                    break;
                case 28:
                    pictureBox.Image = Properties.Resources.Trophy;
                    readerLabel.Text = "Your arrows rain down on the beast and after a while the dragon lays dead. You have won the Quest." +
                        "\nDo you want to try again";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 29:
                    player2.Play();
                    pictureBox.Image = Properties.Resources.Grave;
                    readerLabel.Text = "you jump onto the monster but end up tripping, as the dragon struggles against the bouder you get crushed in the crossfire." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 30:
                    pictureBox.Image = Properties.Resources.OutsideTown;
                    readerLabel.Text = "You leave town and find yourself with only a small farm." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Leave Town";
                    choose2Label.Text = "Go to the Farm";
                    break;
                case 31:
                    pictureBox.Image = Properties.Resources.wild;
                    readerLabel.Text = "You decide that screw your quest, you arn't fighting a dragon and get out of town." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 32:
                    pictureBox.Image = Properties.Resources.Farm;
                    readerLabel.Text = "You go to the farm and meet a man named Farmer Robins who tells you that he's looking for some help, you also notice a bag of gold on his waist." +
                        "\nWhat do you do?";
                    choose1Label.Text = "Yoink";
                    choose2Label.Text = "Work for him";
                    break;
                case 33:
                    pictureBox.Image = Properties.Resources.Farm;
                    readerLabel.Text = "You find yourself enjoying the farmwork and decide to retire from adventuring." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 34:
                    pictureBox.Image = Properties.Resources.Jail;
                    readerLabel.Text = "You are arrested and thrown in jail." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;
                case 35:
                    pictureBox.Image = Properties.Resources.wild;
                    readerLabel.Text = "You escape as an outlaw, banished from the town." +
                        "\nTry Again?";
                    choose1Label.Text = "Yes";
                    choose2Label.Text = "No";
                    break;



                case 99:
                    Application.Exit();
                    break;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            {

                if (page == 3)
                {
                    page = 6;
                }
                else if (page == 4)
                {
                    page = 2;
                }
                else if (page == 5)
                {
                    page = 6;
                }
                else if (page == 7)
                {
                    page = 19;
                }
                else if (page == 8)
                {
                    page = 7;
                }
                else if (page == 9)
                {
                    page = 8;
                }
                else if (page == 11)
                {
                    page = 27;
                }
                else if (page == 12)
                {
                    page = 15;
                }
                else if (page == 13)
                {
                    page = 19;
                }
                else if (page == 15)
                {
                    page = 22;
                }

                else if (page == 18)
                {
                    page = 21;
                }
                else if (page == 20)
                {
                    page = 22;
                }
                else if (page == 23)
                {
                    page = 24;
                }
                else if (page == 27)
                {
                    page = 26;
                }
                else if (page == 30)
                {
                    page = 2;
                }
                else if (page == 32)
                {
                    page = 30;
                }
                else
                {
                    backButton.Enabled = false;
                }
                SoundPlayer player = new SoundPlayer(Properties.Resources.Ambiance);
                SoundPlayer player2 = new SoundPlayer(Properties.Resources.Dies);
                SoundPlayer player3 = new SoundPlayer(Properties.Resources.Fire_sound);
                SoundPlayer player4 = new SoundPlayer(Properties.Resources.Monster);
                switch (page)
                {
                    case 1:

                        player.Play();
                        readerLabel.Text = "A dragon has took over the castle and now you must defeat them";
                        choose1Label.Text = "Continue";
                        choose2Label.Text = "";
                        break;
                    case 2:

                        player.Play();
                        pictureBox.Image = Properties.Resources.Town;
                        readerLabel.Text = "Where do you want to go?";
                        choose1Label.Text = "Castle";
                        choose2Label.Text = "Outside of Town";
                        break;
                    case 3:
                        player4.Play();
                        pictureBox.Image = Properties.Resources.Skeleton;
                        readerLabel.Text = "A Skeleton appears blocking your way, you can only run. " +
                            "\nWhich way do you go?";
                        choose1Label.Text = "Left";
                        choose2Label.Text = "Right";
                        break;
                    case 4:
                        pictureBox.Image = Properties.Resources.DragonSleeping;
                        readerLabel.Text = "You have enter a large room, the dragon sleeping, you can either attack or try to find a better solution up the stairs on the side." +
                            "\nWhich way do you go";
                        choose1Label.Text = "To Battle!!!";
                        choose2Label.Text = "Up the stairs";
                        break;
                    case 5:
                        pictureBox.Image = Properties.Resources.Skeleton;
                        readerLabel.Text = "The Skeleton is still behind you. " +
                            "\nWhich way do you go?";
                        choose1Label.Text = "Left";
                        choose2Label.Text = "Right";
                        break;
                    case 6:
                        player2.Play();
                        pictureBox.Image = Properties.Resources.Grave;

                        player2.Play();
                        readerLabel.Text = "The Skeleton catches you after you enter a dead end." +
                            "\nTry Again?";
                        choose1Label.Text = "Yes";
                        choose2Label.Text = "No";
                        break;
                    case 7:
                        pictureBox.Image = Properties.Resources.Dragon;
                        readerLabel.Text = "The Dragon awakes, beginning to attack." +
                            "\nWhat do you do?";
                        choose1Label.Text = "Charge!!!";
                        choose2Label.Text = "dodge it's attack";
                        break;
                    case 8:
                        pictureBox.Image = Properties.Resources.TowerStair;
                        readerLabel.Text = "You sneak up the stairs finding a small chest on the side and forwards, more stairs." +
                            "\nWhat do you do";
                        choose1Label.Text = "Up the stairs";
                        choose2Label.Text = "Open the chest";
                        break;
                    case 9:
                        pictureBox.Image = Properties.Resources.Wall;
                        readerLabel.Text = "You find a dead end with another chest on the side." +
                            "\nWhat do you do?";
                        choose1Label.Text = "Go back";
                        choose2Label.Text = "Open the chest";
                        break;
                    case 10:
                        pictureBox.Image = Properties.Resources.Teeth;
                        readerLabel.Text = "You open the chest before seeing the mass of teeth, its tongue quickly grabs you before you relise it's a mimic." +
                            "\nTry Again";
                        choose1Label.Text = "Yes";
                        choose2Label.Text = "No";
                        break;
                    case 11:
                        pictureBox.Image = Properties.Resources.Balcony;
                        readerLabel.Text = "You find a magical artifact that reveals illusions, looking back you find the wall is now a balcony looking over the dragon with a boulder." +
                            "\nWhat do you do?";
                        choose1Label.Text = "Shoot the dragon";
                        choose2Label.Text = "push the boulder";
                        break;
                    case 12:
                        pictureBox.Image = Properties.Resources.Dragon;
                        readerLabel.Text = "Charging past it's attack, you get face to face with the beast." +
                            "\nWhat do you do?";
                        choose1Label.Text = "Duck below the beast";
                        choose2Label.Text = "Jump Stirke!!!";
                        break;
                    case 13:
                        pictureBox.Image = Properties.Resources.Dragon;
                        readerLabel.Text = "you dodge it's attack it's tail now trapping you in the corner, a strange look on it's face." +
                            "\nWhat do you do?";
                        choose1Label.Text = "Grab it's tail";
                        choose2Label.Text = "Shoot it";
                        break;
                    case 14:
                        player2.Play();
                        pictureBox.Image = Properties.Resources.Grave;
                        readerLabel.Text = "you duck under but then witness the dragon sitting down crushing you instantly." +
                            "\nTry Again?";
                        choose1Label.Text = "Yes";
                        choose2Label.Text = "No";
                        break;
                    case 15:
                        pictureBox.Image = Properties.Resources.Dragon;
                        readerLabel.Text = "Your sword pierces the dragon, the monster rears it's head back." +
                            "\nWhat do you do?";
                        choose1Label.Text = "shoot it's eye";
                        choose2Label.Text = "Axe Smash!!!";
                        break;
                    case 16:
                        pictureBox.Image = Properties.Resources.Trophy;
                        readerLabel.Text = "The arrow goes through the eye piercing it's head. You have won the Quest!" +
                            "\nDo you want to try again?";
                        choose1Label.Text = "Yes";
                        choose2Label.Text = "No";
                        break;
                    case 17:
                        pictureBox.Image = Properties.Resources.Trophy;
                        readerLabel.Text = "The axe goes through the stomach, the dragon body collaspes with it's last breaths. You have won the Quest!" +
                            "\nDo you want to try again?";
                        choose1Label.Text = "Yes";
                        choose2Label.Text = "No";
                        break;
                    case 18:
                        pictureBox.Image = Properties.Resources.Dragon;
                        readerLabel.Text = "You grab the tail as it get brought back to it's body, you are now next to it's head." +
                            "\nWhat do you do?";
                        choose1Label.Text = "Let go";
                        choose2Label.Text = "Attack the eye";
                        break;
                    case 19:
                        player3.Play();
                        pictureBox.Image = Properties.Resources.Fire;
                        readerLabel.Text = "The dragons flames burst out of it's mouth burning you alive in an instant" +
                            "\nTry Again";
                        choose1Label.Text = "Yes";
                        choose2Label.Text = "No";
                        break;
                    case 20:
                        pictureBox.Image = Properties.Resources.Dragon;
                        readerLabel.Text = "You are not at the bottom of the beast it's claws getting ready to crush." +
                            "\nWhat do you do?";
                        choose1Label.Text = "JumpStrike!!!";
                        choose2Label.Text = "Go below";
                        break;
                    case 21:
                        player2.Play();
                        pictureBox.Image = Properties.Resources.Grave;
                        readerLabel.Text = "Your attack misses the mark and a second later, the dragons teeth are upon you." +
                            "\nTry Again?";
                        choose1Label.Text = "Yes";
                        choose2Label.Text = "No";
                        break;
                    case 22:
                        player2.Play();
                        pictureBox.Image = Properties.Resources.Grave;
                        readerLabel.Text = "The dragons claws tear through your flesh before you even get close." +
                            "\nTry Again?";
                        choose1Label.Text = "Yes";
                        choose2Label.Text = "No";
                        break;
                    case 23:
                        pictureBox.Image = Properties.Resources.Dragon;
                        readerLabel.Text = "You duck the Dragon then land a strike at it's back, it finds itself to big to turn." +
                            "\nWhat do you do?";
                        choose1Label.Text = "Contiue to attck it";
                        choose2Label.Text = "Climb the beast";
                        break;
                    case 24:
                        player2.Play();
                        pictureBox.Image = Properties.Resources.Grave;
                        readerLabel.Text = "You forgot about the tail, striking at you the last thing you see is the dragons malicious grin." +
                            "\nTry Again";
                        choose1Label.Text = "Yes";
                        choose2Label.Text = "No";
                        break;
                    case 25:
                        pictureBox.Image = Properties.Resources.Trophy;
                        readerLabel.Text = "You succefully climb the beast and then repeatily stabbing it, after a while the dragon succumbs to it's wounds. You have won the Quest." +
                            "\nDo you want to try again?";
                        choose1Label.Text = "Yes";
                        choose2Label.Text = "No";
                        break;
                    case 26:
                        player2.Play();
                        pictureBox.Image = Properties.Resources.Grave;
                        readerLabel.Text = "The arrow bounce off it's hide and it a shockingly quick move it flies up and eats you in one bite." +
                            "\nTry Again?";
                        choose1Label.Text = "Yes";
                        choose2Label.Text = "No";
                        break;
                    case 27:
                        pictureBox.Image = Properties.Resources.Dragon;
                        readerLabel.Text = "The dragon is trapped by the boulder and is now struggling." +
                            "\nWhat do you do?";
                        choose1Label.Text = "Shoot it";
                        choose2Label.Text = "get into close range";
                        break;
                    case 28:
                        pictureBox.Image = Properties.Resources.Trophy;
                        readerLabel.Text = "Your arrows rain down on the beast and after a while the dragon lays dead. You have won the Quest." +
                            "\nDo you want to try again";
                        choose1Label.Text = "Yes";
                        choose2Label.Text = "No";
                        break;
                    case 29:
                        player2.Play();
                        pictureBox.Image = Properties.Resources.Grave;
                        readerLabel.Text = "you jump onto the monster but end up tripping, as the dragon struggles against the bouder you get crushed in the crossfire." +
                            "\nTry Again?";
                        choose1Label.Text = "Yes";
                        choose2Label.Text = "No";
                        break;
                    case 30:
                        pictureBox.Image = Properties.Resources.OutsideTown;
                        readerLabel.Text = "You leave town and find yourself with only a small farm." +
                            "\nWhat do you do?";
                        choose1Label.Text = "Leave Town";
                        choose2Label.Text = "Go to the Farm";
                        break;
                    case 31:
                        pictureBox.Image = Properties.Resources.wild;
                        readerLabel.Text = "You decide that screw your quest, you arn't fighting a dragon and get out of town." +
                            "\nTry Again?";
                        choose1Label.Text = "Yes";
                        choose2Label.Text = "No";
                        break;
                    case 32:
                        pictureBox.Image = Properties.Resources.Farm;
                        readerLabel.Text = "You go to the farm and meet a man named Farmer Robins who tells you that he's looking for some help, you also notice a bag of gold on his waist." +
                            "\nWhat do you do?";
                        choose1Label.Text = "Yoink";
                        choose2Label.Text = "Work for him";
                        break;
                    case 33:
                        pictureBox.Image = Properties.Resources.Farm;
                        readerLabel.Text = "You find yourself enjoying the farmwork and decide to retire from adventuring." +
                            "\nTry Again?";
                        choose1Label.Text = "Yes";
                        choose2Label.Text = "No";
                        break;
                    case 34:
                        pictureBox.Image = Properties.Resources.Jail;
                        readerLabel.Text = "You are arrested and thrown in jail." +
                            "\nTry Again?";
                        choose1Label.Text = "Yes";
                        choose2Label.Text = "No";
                        break;
                    case 35:
                        pictureBox.Image = Properties.Resources.wild;
                        readerLabel.Text = "You escape as an outlaw, banished from the town." +
                            "\nTry Again?";
                        choose1Label.Text = "Yes";
                        choose2Label.Text = "No";
                        break;

                }
            }
        }
    }
}


