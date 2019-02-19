using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class resultScreen : UserControl
    {
        public resultScreen()
        {
            InitializeComponent();
            numGuesssesOut.Text = Form1.userGuesses.Count.ToString();
            for(int x = 0; x< Form1.userGuesses.Count; x++)
            {
                guessesOut.Text += Form1.userGuesses[x] + "\n";
            }
            Form1.userGuesses.Sort();
            for (int x = 0; x < Form1.userGuesses.Count; x++)
            {
                sortedGuessesOut.Text += Form1.userGuesses[x] + "\n";
            }
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            Form1 f = (Form1)this.FindForm();
            f.switchScreen(this, "MS");

        }
    }
}
