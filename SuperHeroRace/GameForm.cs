using SuperHeroRace.RaceModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetGame2
{ 
    public partial class GameForm : Form
    {

        Hero[] hero = new Hero[5]; // 5 Heros
        Punter[] punters = new Punter[3]; // 3 punters
        Hero winnerHero;

        Timer timer1,timer2,timer3,timer4, timer5;


        public GameForm()
        {
            InitializeComponent();
            GetSuperHeroData();  // method call here for SuperHero 
            btnAction.Enabled = false; // disable Race button on form load
        }

        // SuperHero initialization Details
        private void GetSuperHeroData()
        {
            hero[0] = new Hero() { HeroName = "Batman", RaceTrackLength = 1030, MyPictureBox = pictureHero1 };
            hero[1] = new Hero() { HeroName = "Superman", RaceTrackLength = 1030, MyPictureBox = pictureHero2 };
            hero[2] = new Hero() { HeroName = "Wonder Woman", RaceTrackLength = 1030, MyPictureBox = pictureHero3 };
            hero[3] = new Hero() { HeroName = "Caption Marvel", RaceTrackLength = 1030, MyPictureBox = pictureHero4 };
            hero[4] = new Hero() { HeroName = "Ironman", RaceTrackLength = 1030, MyPictureBox = pictureHero5 };

            //3 Punters
            punters[0] = Factory.GetPunter("Noah");
            punters[1] = Factory.GetPunter("William");
            punters[2] = Factory.GetPunter("George");
            
            punters[0].MyLabel = labelBet;
            punters[0].MyRadioButton = punter1Radio;
            punters[0].MyText = label2Punter1;
            punters[0].MyRadioButton.Text = punters[0].Name;

            
            punters[1].MyLabel = labelBet;
            punters[1].MyRadioButton = punter2Radio;
            punters[1].MyText = label3Punter2;
            punters[1].MyRadioButton.Text = punters[1].Name;

            
            punters[2].MyLabel = labelBet;
            punters[2].MyRadioButton = punter3Radio;
            punters[2].MyText = label4Punter3;
            punters[2].MyRadioButton.Text = punters[2].Name;

            chooseSuperHero.Minimum = 1;
            chooseSuperHero.Maximum = 5;
            chooseSuperHero.Value = 1;
        }

        //Place your Bet for Punters
        private void buttonPlaceBet_Click(object sender, EventArgs e)
        {
            if (buttonPlaceBet.Text.Contains("Place"))
            {
                int count = 0;
                int total_active = 0;
                foreach (Punter punter in punters)
                {
                    if (punter.Busted)
                    {
                        // nothing happend!
                    }
                    else
                    {
                        total_active++;
                        if (punter.MyRadioButton.Checked)
                        {
                            if (punter.MyBet == null)
                            {
                                int number = (int)chooseSuperHero.Value;
                                int amount = (int)SelectBetAmount.Value;
                                bool alreadyPlaced = false;
                                foreach (Punter pun in punters)
                                {
                                    if (pun.MyBet != null && pun.MyBet.urHero == hero[number - 1])
                                    {
                                        alreadyPlaced = true;
                                        break;
                                    }
                                }
                                if (alreadyPlaced)
                                {
                                    MessageBox.Show("This Super Hero is Already Selected By Another Better!","Info");
                                }
                                else
                                {
                                    punter.MyBet = new Bet() { Amount = amount, urHero = hero[number - 1] };
                                }

                            }
                            else
                            {
                                MessageBox.Show("You already placed a Bet for " + punter.Name,"Info");
                            }
                        }
                        if (punter.MyBet != null)
                        {
                            count++;
                        }
                    }
                }
                ConfigBet(); // method calling
                if (count == total_active)
                {
                    btnAction.Text = "START RACE";
                    panelBet.Enabled = false;
                    btnAction.Enabled = true;
                }
            }
        }

        private void labelCycleNo_Click(object sender, EventArgs e)
        {

        }

        private void puntersRadio_CheckedChanged(object sender, EventArgs e)
        {
            ConfigBet(); // method calling to set the BET
        }

        
        //setup bet Panel
        private void ConfigBet()
        {
            foreach (Punter punter in punters)
            {
                if (punter.Busted)
                {
                    punter.MyText.Text = "BUSTED";
                }
                else
                {
                    if (punter.MyBet == null)
                    {
                        punter.MyText.Text = punter.Name + " has not placed any bet";
                    }
                    else
                    {
                        punter.MyText.Text = punter.Name + " bets $" + punter.MyBet.Amount + " on " + punter.MyBet.urHero.HeroName;
                    }
                    if (punter.MyRadioButton.Checked)
                    {
                        labelMax.Text = "Max Bet Amount is $" + punter.Cash.ToString();
                        //btnAction.Text = "Place Bet for " + punter.Name;
                        punter.MyLabel.Text = punter.Name + " Bets Amount $";
                        SelectBetAmount.Minimum = 1;
                        SelectBetAmount.Maximum = punter.Cash;
                        SelectBetAmount.Value = 1;
                    }
                }
            }
        }

        //Start Race now
        private void btnAction_Click(object sender, EventArgs e)
        {
           
            if (btnAction.Text.Contains("START"))
            {
                timer1 = new Timer();
                timer1.Interval = 15;
                timer1.Tick += Cycling_Tick;

                timer2 = new Timer();
                timer2.Interval = 15;
                timer2.Tick += Cycling_Tick;

                timer3 = new Timer();
                timer3.Interval = 15;
                timer3.Tick += Cycling_Tick;

                timer4 = new Timer();
                timer4.Interval = 15;
                timer4.Tick += Cycling_Tick;

                timer5 = new Timer();
                timer5.Interval = 15;
                timer5.Tick += Cycling_Tick;

                timer1.Start();
                timer2.Start();
                timer3.Start();
                timer4.Start();
                timer5.Start();
                btnAction.Enabled = false;

            }
            else if (btnAction.Text.Contains("GAME"))
            {
                MessageBox.Show("GAME OVER!","Message");
                Application.Exit();
            }
        }


        private void Cycling_Tick(object sender, EventArgs e)
        {
            if(sender is Timer)
            {
                int index = -1;
                Timer timer = sender as Timer;
                if( timer == timer1)
                {
                    index = 0;
                }
                else if (timer == timer2)
                {
                    index = 1;
                }
                else if (timer == timer3)
                {
                    index = 2;
                }
                else if (timer == timer4)
                {
                    index = 3;
                }
                else if (timer == timer5)
                {
                    index = 4;
                }

                if ( index != -1 )
                {
                    PictureBox pbox = hero[index].MyPictureBox;
                    if (pbox.Location.X + pbox.Width > hero[index].RaceTrackLength)
                    {  
                        if (winnerHero == null)
                        {
                            winnerHero = hero[index];
                        }
                        timer1.Stop();
                        timer2.Stop();
                        timer3.Stop();
                        timer4.Stop();
                        timer5.Stop();
                    }
                    else
                    {
                        int jump = new Random().Next(1, 15);
                        pbox.Location = new Point(pbox.Location.X + jump, pbox.Location.Y);
                    }
                }
            }
            if(winnerHero != null)
            {
                MessageBox.Show("Splended!! " + winnerHero.HeroName + " is Won...");
                ConfigBet();
                foreach (Punter punter in punters)
                {
                    if (punter.MyBet != null)
                    {
                        if (punter.MyBet.urHero == winnerHero)
                        {
                            punter.Cash += punter.MyBet.Amount;
                            punter.MyText.Text = punter.Name + " Won and now has $" + punter.Cash;
                            punter.Winner = true;
                        }
                        else
                        {
                            punter.Cash -= punter.MyBet.Amount;
                            if (punter.Cash == 0)
                            {
                                punter.MyText.Text = "BUSTED";
                                punter.Busted = true;
                                punter.MyRadioButton.Enabled = false;
                            }
                            else
                            {
                                punter.MyText.Text = punter.Name + " Lost and now has $" + punter.Cash;
                            }
                        }                        
                    }
                }
                winnerHero = null;
                timer1 = timer2 = timer3 = timer4 = timer5 = null;
                int count = 0;
                foreach (Punter punter in punters)
                {
                    if (punter.Busted)
                    {
                        count++;
                    }
                    if (punter.MyRadioButton.Enabled && punter.MyRadioButton.Checked)
                    {
                        labelMax.Text = "Max Bet is $" + punter.Cash;
                        SelectBetAmount.Maximum = punter.Cash;
                        SelectBetAmount.Minimum = 1;
                    }
                    punter.MyBet = null;
                    punter.Winner = false;
                }
                if (count == punters.Length)
                {
                    btnAction.Text = "GAME OVER";

                }
                else
                {
                    panelBet.Enabled = true;
                }
                foreach (Hero h in hero)
                {
                    h.MyPictureBox.Location = new Point(12, h.MyPictureBox.Location.Y);
                }
            }
        }
    }
}
