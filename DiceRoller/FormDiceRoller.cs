using DiceRoller.Properties;
using System.Reflection;
using Timer = System.Windows.Forms.Timer;

namespace DiceRoller
{
    public partial class FormDiceRoller : Form
    {
        public FormDiceRoller()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer2.Tick += Timer_Tick2;
        }
        private readonly Random random = new Random();
        private readonly Random random2 = new Random();

        private readonly Timer timer = new Timer();
        private readonly Timer timer2 = new Timer();

        private int number;
        public int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
            
        }
        public int RandomNumber2(int min, int max)
        {
            return random2.Next(min, max);

        }


        private void picClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
           
            PicDice.Image = Resources.imagees; 
            PicDice.SizeMode = PictureBoxSizeMode.Zoom;
            PicDice2.Image = Resources.imagees;
            PicDice2.SizeMode = PictureBoxSizeMode.Zoom;

            timer.Interval = random.Next(2000, 4000);
            timer2.Interval = random.Next(2000, 4000);

            timer.Start();
            timer2.Start();
        }

    
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop(); 

         
            number = RandomNumber(1, 7);

            if (number == 1)
                PicDice.Image = Resources.dice_1;
            else if (number == 2)
                PicDice.Image = Resources.dice_2;
            else if (number == 3)
                PicDice.Image = Resources.dice_3;
            else if (number == 4)
                PicDice.Image = Resources.dice_4;
            else if (number == 5)
                PicDice.Image = Resources.dice_5;
            else
                PicDice.Image = Resources.dice_6;

            PicDice.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Timer_Tick2(object sender, EventArgs e)
        {
            timer2.Stop();


            number = RandomNumber2(1, 7);

            if (number == 1)
                PicDice2.Image = Resources.dice_1;
            else if (number == 2)
                PicDice2.Image = Resources.dice_2;
            else if (number == 3)
                PicDice2.Image = Resources.dice_3;
            else if (number == 4)
                PicDice2.Image = Resources.dice_4;
            else if (number == 5)
                PicDice2.Image = Resources.dice_5;
            else
                PicDice2.Image = Resources.dice_6;

            PicDice2.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}