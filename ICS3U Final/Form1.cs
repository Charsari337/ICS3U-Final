using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICS3U_Final
{
    public partial class Form1 : Form
    {
        //player1
        bool aDown = false;
        bool wDown = false;
        bool dDown = false;
        bool sDown = false;
        //interact
        bool qDown = false;

        int player1X = 600;
        int player1Y = 50;

        //player2
        bool rightArrow = false;
        bool upArrow = false;
        bool downArrow = false;
        bool leftArrow = false;
        //interact
        bool leftShiftDown = false;

        int player2X = 600;
        int player2Y = 50;

        //player3
        bool num4 = false;
        bool num8 = false;
        bool num6 = false;
        bool num5 = false;
        //interact
        bool num7 = false;

        int player3X = 600;
        int player3Y = 50;

        //player4
        bool uDown = false;
        bool hDOwn = false;
        bool jDown = false;
        bool kDown = false;
        //interact
        bool yDown = false;

        int player4X = 600;
        int player4Y = 50;

        //Player(s)
        int playerWidth = 15;
        int playerHeight = 15;
        int playerSpeed = 4;

        int playerCount;

        //interface
        bool space = false;
        bool escape = false;

        //Components
        string gameState = "waiting";
        int scene = 0;

        SolidBrush wallBrush = new SolidBrush(Color.DimGray);
        SolidBrush p1Brush = new SolidBrush(Color.Maroon);
        SolidBrush p2Brush = new SolidBrush(Color.MidnightBlue);
        SolidBrush p3Brush = new SolidBrush(Color.DarkGoldenrod);
        SolidBrush p4Brush = new SolidBrush(Color.DarkGreen);

        SolidBrush dodgeballbrush = new SolidBrush(Color.Red);
        SolidBrush basketballbrush = new SolidBrush(Color.Orange);

        public Form1()
        {
            InitializeComponent();

            titleLabel.Show();
            subTitleLabel.Show();
            titleLabel.Text = "Spooky School Legends";
            subTitleLabel.Text = "Press Space to Start or Escape to Exit";

            pOp1Butt.Hide();
            pOp2Butt.Hide();
            pOp3Butt.Hide();
            pOp4Butt.Hide();

            choiceMicon.Hide();
            choiceNicon.Hide();
            choiceMlabel.Hide();
            choiceNlabel.Hide();

            dialoguePictureBox.Hide();
            dialogueTextBox.Hide();

            gameState = "waiting";
        }
        public void GameInitialize()
        {
            titleLabel.Hide();
            subTitleLabel.Hide();

            gameTimer.Enabled = false;
            gameState = "initial";
        }

        public void DialogueEvent()
        {
            pOp1Butt.Hide();
            pOp2Butt.Hide();
            pOp3Butt.Hide();
            pOp4Butt.Hide();

            subTitleLabel.Hide();

            choiceMicon.Show();
            choiceNicon.Show();
            choiceMlabel.Show();
            choiceNlabel.Show();

            dialoguePictureBox.Show();
            dialogueTextBox.Show();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (gameState == "initial")
            {
                subTitleLabel.Text = "How many player are playing?";
                subTitleLabel.Text += "\n\nUse the mouse to select.";
                subTitleLabel.Text += "\n\nRecommended to play with others.";
                subTitleLabel.Show();

                pOp1Butt.Show();
                pOp2Butt.Show();
                pOp3Butt.Show();
                pOp4Butt.Show();
            }
            if (gameState == "dialogue")
            {
                DialogueEvent();
            }
            if (gameState == "entrance")
            {
                gameTimer.Enabled = true;
                choiceMicon.Hide();
                choiceNicon.Hide();
                choiceMlabel.Hide();
                choiceNlabel.Hide();

                dialoguePictureBox.Hide();
                dialogueTextBox.Hide();
                //Top entrance
                e.Graphics.FillRectangle(wallBrush, 0, 0, 500, 50);
                e.Graphics.FillRectangle(wallBrush, 700, 0, 500, 50);
                //left side
                e.Graphics.FillRectangle(wallBrush, 0, 0, 50, 800);
                //right side
                e.Graphics.FillRectangle(wallBrush, 1140, 0, 50, 300);
                e.Graphics.FillRectangle(wallBrush, 1140, 500, 50, 300);
                //Bottom
                e.Graphics.FillRectangle(wallBrush, 0, 720, 1200, 50);
                
                //player 1
                e.Graphics.FillRectangle(p1Brush, player1X, player1Y, playerWidth, playerHeight);
                Rectangle player1Box = new Rectangle(player1X, player1Y, playerWidth, playerHeight);

                //player 2
                e.Graphics.FillRectangle(p2Brush, player2X, player2Y, playerWidth, playerHeight);
                Rectangle player2Box = new Rectangle(player2X, player2Y, playerWidth, playerHeight);
                //player 3
                e.Graphics.FillRectangle(p3Brush, player3X, player3Y, playerWidth, playerHeight);
                Rectangle player3Box = new Rectangle(player3X, player3Y, playerWidth, playerHeight);
                //player 4
                e.Graphics.FillRectangle(p4Brush, player4X, player4Y, playerWidth, playerHeight);
                Rectangle player4Box = new Rectangle(player4X, player4Y, playerWidth, playerHeight);

                //Gym entrance
                //e.Graphics.FillRectangle(p4Brush, 1150, 300, 50, 200);
                Rectangle gymEntranceBox = new Rectangle(1150, 300, 50, 200);
                if(player1Box.IntersectsWith(gymEntranceBox) || player2Box.IntersectsWith(gymEntranceBox) || player3Box.IntersectsWith(gymEntranceBox) || player4Box.IntersectsWith(gymEntranceBox))
                {
                    gameTimer.Enabled = false;
                    scene = 3;
                    DialogueEvent();
                    gameState = "gymEntrance";
                }
            }
            if(gameState == "gym")
            {
                gameTimer.Enabled = true;
                choiceMicon.Hide();
                choiceNicon.Hide();
                choiceMlabel.Hide();
                choiceNlabel.Hide();

                dialoguePictureBox.Hide();
                dialogueTextBox.Hide();
                //Top
                e.Graphics.FillRectangle(wallBrush, 0, 0, 1200, 50);
                //Bottom
                e.Graphics.FillRectangle(wallBrush, 0, 720, 1200, 50);
                //Centre
                e.Graphics.FillEllipse(dodgeballbrush, 550, 350, 50, 50);
                e.Graphics.FillEllipse(basketballbrush, 550, 400, 50, 50);

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //Player 1
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Q:
                    qDown = true;
                    break;
                //Player 2
                case Keys.Right:
                    rightArrow = true;
                    break;
                case Keys.Left:
                    leftArrow = true;
                    break;
                case Keys.Up:
                    upArrow = true;
                    break;
                case Keys.Down:
                    downArrow = true;
                    break;
                case Keys.RShiftKey:
                    leftShiftDown = true;
                    break;
                //Player 3
                case Keys.NumPad4:
                    num4 = true;
                    break;
                case Keys.NumPad8:
                    num8 = true;
                    break;
                case Keys.NumPad5:
                    num5 = true;
                    break;
                case Keys.NumPad6:
                    num6 = true;
                    break;
                case Keys.NumPad7:
                    num7 = true;
                    break;
                //Player4
                case Keys.U:
                    uDown = true;
                    break;
                case Keys.H:
                    hDOwn = true;
                    break;
                case Keys.J:
                    jDown = true;
                    break;
                case Keys.K:
                    kDown = true;
                    break;
                case Keys.Y:
                    yDown = true;
                    break;
                //Interface
                case Keys.Space:
                    if(gameState == "waiting")
                    {
                        GameInitialize();
                    }
                    break;

                case Keys.Escape:
                    if(gameState == "waiting")
                    {
                        Application.Exit();
                    }
                    break;
                
            }
            //Dialogue
            if (e.KeyCode == Keys.M)
            {
                if(scene == 0)
                {
                    scene = 1;
                }
                else if(scene == 1)
                {
                    scene = 2;
                }
                else if(scene == 2)
                {
                    gameState = "entrance";
                }
                else if(scene == 3)
                {
                    gameState = "gym";
                }
            }
            switch (scene)
            {
                case 0:
                    dialoguePictureBox.BackgroundImage = Properties.Resources.OpeningScene;
                    dialogueTextBox.Text = "You and your friends are running around your school at night in hopes of finding the rumored urban legends.";
                    choiceMlabel.Text = "Continue";
                    choiceNlabel.Text = "";
                    break;
                case 1:
                    dialoguePictureBox.BackgroundImage = Properties.Resources.OpeningScene2;
                    dialogueTextBox.Text = "It is rumored that there are two urban legends. One of them on each floor of your school.";
                    choiceMlabel.Text = "Continue";
                    choiceNlabel.Text = "";
                    break;
                case 2:
                    dialoguePictureBox.BackgroundImage = Properties.Resources.OpeningScene3;
                    dialogueTextBox.Text = "You all come to your school late at night seeking a thrill or proving your skepticism. Will you find something or waste your night here at your school.";
                    choiceMlabel.Text = "Continue";
                    choiceNlabel.Text = "";
                    break;
                case 3:
                    dialoguePictureBox.BackgroundImage = Properties.Resources.GymEntrance;
                    dialogueTextBox.Text = "For some reason the whole school has been warped. From the entrance you can only find the halls leading to the gym.";
                    choiceMlabel.Text = "Enter";
                    choiceNlabel.Text = "";
                    break;
                case 4:
                    dialoguePictureBox.BackgroundImage = Properties.Resources.Balls;
                    dialogueTextBox.Text = "You approach 2 balls at the center of the gym, a dodge ball and a basket ball. You decide to pick up one of them.";
                    choiceMlabel.Text = "Dodgeball";
                    choiceNlabel.Text = "Basket ball";
                    break;
                case 5:
                    dialoguePictureBox.BackgroundImage = Properties.Resources.ghosts;
                    dialogueTextBox.Text = "You pick up the dodge ball. As you do you are immediately faced by the three athlete ghosts.";
                    choiceMlabel.Text = "Continue";
                    choiceNlabel.Text = "";
                    break;
                case 6:
                    dialoguePictureBox.BackgroundImage = Properties.Resources.ghosts;
                    dialogueTextBox.Text = "The ball flies out of your hand and onto one of the ghosts. They appear to wind up for a throw!";
                    choiceMlabel.Text = "Continue";
                    choiceNlabel.Text = "";
                    break;
                case 7:
                    dialoguePictureBox.BackgroundImage = Properties.Resources.end;
                    dialogueTextBox.Text = "After a gruesome game of dodgeball the balls stop flying. You quickly make it out of your school, never to do something like this again.";
                    choiceMlabel.Text = "End";
                    choiceNlabel.Text = "";
                    break;
                case 8:
                    dialoguePictureBox.BackgroundImage = Properties.Resources.end;
                    dialogueTextBox.Text = "You pick up the basket ball and hear the gym closet open. Right after you hear footsteps rush to you. This frightens you to leave the school and never return at night.";
                    choiceMlabel.Text = "End";
                    choiceNlabel.Text = "";
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //Player 1
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Q:
                    qDown = false;
                    break;
                //Player 2
                case Keys.Right:
                    rightArrow = false;
                    break;
                case Keys.Left:
                    leftArrow = false;
                    break;
                case Keys.Up:
                    upArrow = false;
                    break;
                case Keys.Down:
                    downArrow = false;
                    break;
                case Keys.RShiftKey:
                    leftShiftDown = false;
                    break;
                //Player 3
                case Keys.NumPad4:
                    num4 = false;
                    break;
                case Keys.NumPad8:
                    num8 = false;
                    break;
                case Keys.NumPad5:
                    num5 = false;
                    break;
                case Keys.NumPad6:
                    num6 = false;
                    break;
                case Keys.NumPad7:
                    num7 = false;
                    break;
                //Player4
                case Keys.U:
                    uDown = false;
                    break;
                case Keys.H:
                    hDOwn = false;
                    break;
                case Keys.J:
                    jDown = false;
                    break;
                case Keys.K:
                    kDown = false;
                    break;
                case Keys.Y:
                    yDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //Player 1 movement and collision
            //Entrance
            /*player1Y = 50;
            player1X = 600;*/
            if (wDown == true && player1Y > 0)
            {
                player1Y -= playerSpeed;
            }
            if (sDown == true && player1Y < this.Height - playerHeight)
            {
                player1Y += playerSpeed;
            }
            if (aDown == true && player1X > 0)
            {
                player1X -= playerSpeed;
            }
            if(dDown == true && player1X < this.Width - playerWidth)
            {
                player1X += playerSpeed;
            }

            Refresh();
        }

        private void pOp1Butt_Click(object sender, EventArgs e)
        {
            playerCount = 1;
            gameState = "dialogue";
        }

        private void pOp2Butt_Click(object sender, EventArgs e)
        {
            playerCount = 2;
            gameState = "dialogue";
        }

        private void pOp3Butt_Click(object sender, EventArgs e)
        {
            playerCount = 3;
            gameState = "dialogue";
        }

        private void pOp4Butt_Click(object sender, EventArgs e)
        {
            playerCount = 4;
            gameState = "dialogue";
        }
    }

    /*Game Notes:
     -
     -
    Librarian game(RUN). Idea: Librarian runs after players.
    
    */
}
