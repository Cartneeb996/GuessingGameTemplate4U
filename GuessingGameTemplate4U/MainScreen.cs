using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GuessingGameTemplate4U
{
    public partial class MainScreen : UserControl
    {

        //creates a random number between 1 and 100 and stores it in a global 
        //variable that can be used throughout the program 
        public static Random randNum = new Random();
        int rand;

        public MainScreen()
        {
            InitializeComponent();
            rand = randNum.Next(1, 101);
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            
            int guess = Convert.ToInt16(inputBox.Text);

            Form1.userGuesses.Add(guess);


            if (guess < rand)
            {
                outputLabel.Text = "Too Low!";
            }
            else if (guess > rand)
            {
                outputLabel.Text = "Too High!";
            }
            else
            {
                outputLabel.Text = "You Got it!";
                Refresh();
                Thread.Sleep(1000);
                Form1 f = (Form1)this.FindForm();
                f.switchScreen(this, "RS");
                

            }

            inputBox.Text = "";
            inputBox.Focus();
        }

    }
}
