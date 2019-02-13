using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShotgunSpel
{
    public partial class Form1 : Form
    {
        int playerChoice;
        int AiChoice;
        int playerAmmo = 0;
        int AiAmmo = 0;
        int AiWins = 0;
        int playerWins;
        Random random = new Random();

        enum PlayerMove
        {
            Load,
            Shoot,
            Block,
            ShutGun
        };

        public Form1()
        {
            InitializeComponent();
        }
        //
        //   Help
        //
        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();

        }
        //
        //   Load
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            btnPlay_Click(sender, e);
        }
        //
        //   Play Again 
        //
        private void btnPlay_Click(object sender, EventArgs e)
        {
            playerAmmo = 0;
            lblPlayerAmmoCount.Text = playerAmmo.ToString();
            playerWins = 0;
            lblPlayerWinsCount.Text = playerWins.ToString();

            AiAmmo = 0;
            lblAIAmmoCount.Text = AiAmmo.ToString();
            AiWins = 0;
            lblAIWinsCount.Text = AiWins.ToString();

            Image myImage4 = Image.FromFile(@"C:\Users\eashi\source\repos\ShotgunSpel\Images\letsPlay.jpg");
            picBoxPlayerAction.Image = myImage4;
            Image myImage5 = Image.FromFile(@"C:\Users\eashi\source\repos\ShotgunSpel\Images\Why.png");
            picBoxComputerAction.Image = myImage5;
            btnSkjuta.Visible = false;
            btnShotgun.Visible = false;
        }
        //
        //   Method for Ai choice
        //
        public int AiComputerChoice()
        {

            if (AiAmmo == 0)
            {
                AiChoice = 0; //  AiChoice = PlayerMove.Load; from Enum
            }
            if (AiAmmo > 0 && AiAmmo < 3)
            {
                AiChoice = random.Next(0, 3); // Read 

            }
            if (AiAmmo == 3)
            {
                AiChoice = 3;

            }

            switch (AiChoice)
            {
                case 0:
                    Image myImage = Image.FromFile(@"C:\Users\eashi\source\repos\ShotgunSpel\Images\7ooX.gif");
                    picBoxComputerAction.Image = myImage;
                    AiAmmo++;
                    lblAIAmmoCount.Text = AiAmmo.ToString();
                    break;

                case 1:
                    Image myImage1 = Image.FromFile(@"C:\Users\eashi\source\repos\ShotgunSpel\Images\Shoot.jpg");
                    picBoxComputerAction.Image = myImage1;
                    AiAmmo--;
                    lblAIAmmoCount.Text = AiAmmo.ToString();
                    break;

                case 2:
                    Image myImage2 = Image.FromFile(@"C:\Users\eashi\source\repos\ShotgunSpel\Images\shield.jpg");
                    picBoxComputerAction.Image = myImage2;
                    break;
                case 3:
                    Image myImage3 = Image.FromFile(@"C:\Users\eashi\source\repos\ShotgunSpel\Images\BigS_gun_U.png");
                    picBoxComputerAction.Image = myImage3;
                    AiAmmo = 0;
                    lblAIAmmoCount.Text = AiAmmo.ToString();
                    break;
            }
            return AiChoice;
        }
        //   Method for Player choice
        /* PlayerChoice ... 0 = Ladda , 1 = Skuta , 2 = Blocka , 3 = Shotgun 
           AiChoice     ... 0 = Ladda , 1 = Skuta , 2 = Blocka , 3 = Shotgun */
        public void Choice()
        {


            if (playerChoice == 0 && AiChoice == 1)
            {
                AiWins++;
                lblAIWinsCount.Text = AiWins.ToString();
            }
            else if (playerChoice == 1 && AiChoice == 0)
            {
                playerWins++;
                lblPlayerWinsCount.Text = playerWins.ToString();
            }
            else if (playerChoice == 3 && (AiChoice == 0 || AiChoice == 1 || AiChoice == 2))
            {
                playerWins++;
                lblPlayerWinsCount.Text = playerWins.ToString();
            }
            else if (AiChoice == 3 && (playerChoice == 0 || playerChoice == 1 || playerChoice == 2))
            {
                AiWins++;
                lblAIWinsCount.Text = AiWins.ToString();
            }
            else if (playerChoice == 3 && AiChoice == 3)
            {
                playerWins++;
                lblPlayerWinsCount.Text = playerWins.ToString();
                AiWins++;
                lblAIWinsCount.Text = AiWins.ToString();
            }

            else if (playerAmmo == 0)
            {
                btnSkjuta.Visible = false;
                btnShotgun.Visible = false;
            }
        }
        //
        //   Method for Ammo Check
        //
        private void CheckAmmo()
        {
            if (playerAmmo == 3)
            {
                btnLadda.Visible = false;
                btnSkjuta.Visible = false;
                btnShotgun.Visible = true;
            }
            else if (playerAmmo == 0)
            {
                btnShotgun.Visible = false;
                btnSkjuta.Visible = false;
            }
        }
        //
        //    Shoot
        //
        private void btnSkjuta_Click(object sender, EventArgs e)
        {
            Image myImage = Image.FromFile(@"C:\Users\eashi\source\repos\ShotgunSpel\Images\Shoot_U.png");
            picBoxPlayerAction.Image = myImage;
            AiComputerChoice();
            if (playerAmmo > 0)
            {
                btnSkjuta.Visible = true;
                playerChoice = 1;
                playerAmmo--;
                lblPlayerAmmoCount.Text = playerAmmo.ToString();
                CheckAmmo();
                Choice();
            }
        }
        //
        //   Load
        //
        private void btnLadda_Click(object sender, EventArgs e) // Load
        {
            Image myImage = Image.FromFile(@"C:\Users\eashi\source\repos\ShotgunSpel\Images\7ooX.gif");
            picBoxPlayerAction.Image = myImage;

            AiComputerChoice();
            if (playerAmmo < 3)
            {
                btnSkjuta.Visible = true;
                playerChoice = 0;
                playerAmmo++;
                lblPlayerAmmoCount.Text = playerAmmo.ToString();
                CheckAmmo();
                Choice();
            }
        }
        //
        //   Block
        //
        private void btnBlocka_Click(object sender, EventArgs e)   // Block
        {
            Image myImage = Image.FromFile(@"C:\Users\eashi\source\repos\ShotgunSpel\Images\shield.jpg");
            picBoxPlayerAction.Image = myImage;
            btnSkjuta.Visible = true;
            playerChoice = 2;
            AiComputerChoice();
            CheckAmmo();
            Choice();

        }
        //
        //   Shotgun
        //
        private void btnShotgun_Click(object sender, EventArgs e)
        {
            AiComputerChoice();
            if (playerAmmo == 3)
            {
                btnShotgun.Visible = true;
                playerChoice = 3;
                Image myImage = Image.FromFile(@"C:\Users\eashi\source\repos\ShotgunSpel\Images\BigS_gun.jpg");
                picBoxPlayerAction.Image = myImage;
                playerAmmo = 0;
                lblPlayerAmmoCount.Text = playerAmmo.ToString();
                btnShotgun.Visible = false;
                btnSkjuta.Visible = false;
                btnLadda.Visible = true;
            }
            else
            {
                btnShotgun.Visible = false;
            }
            Choice();

        }
        //
        //    Exit
        //
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
