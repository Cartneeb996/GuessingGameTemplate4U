namespace GuessingGameTemplate4U
{
    partial class resultScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.promptLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.sortedGuesses = new System.Windows.Forms.Label();
            this.guessesNoSort = new System.Windows.Forms.Label();
            this.sortedGuessesOut = new System.Windows.Forms.Label();
            this.guessesOut = new System.Windows.Forms.Label();
            this.numGuesses = new System.Windows.Forms.Label();
            this.numGuesssesOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.ForeColor = System.Drawing.Color.White;
            this.promptLabel.Location = new System.Drawing.Point(216, 124);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(70, 21);
            this.promptLabel.TabIndex = 11;
            this.promptLabel.Text = "You win!";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(149, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(207, 37);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Guessing Game";
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(211, 173);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(75, 23);
            this.playAgainButton.TabIndex = 15;
            this.playAgainButton.Text = "Play again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // sortedGuesses
            // 
            this.sortedGuesses.AutoSize = true;
            this.sortedGuesses.ForeColor = System.Drawing.Color.White;
            this.sortedGuesses.Location = new System.Drawing.Point(319, 79);
            this.sortedGuesses.Name = "sortedGuesses";
            this.sortedGuesses.Size = new System.Drawing.Size(82, 13);
            this.sortedGuesses.TabIndex = 16;
            this.sortedGuesses.Text = "Sorted Guesses";
            // 
            // guessesNoSort
            // 
            this.guessesNoSort.AutoSize = true;
            this.guessesNoSort.ForeColor = System.Drawing.Color.White;
            this.guessesNoSort.Location = new System.Drawing.Point(46, 79);
            this.guessesNoSort.Name = "guessesNoSort";
            this.guessesNoSort.Size = new System.Drawing.Size(77, 13);
            this.guessesNoSort.TabIndex = 17;
            this.guessesNoSort.Text = "Guesses made";
            // 
            // sortedGuessesOut
            // 
            this.sortedGuessesOut.AutoSize = true;
            this.sortedGuessesOut.ForeColor = System.Drawing.Color.White;
            this.sortedGuessesOut.Location = new System.Drawing.Point(342, 97);
            this.sortedGuessesOut.Name = "sortedGuessesOut";
            this.sortedGuessesOut.Size = new System.Drawing.Size(0, 13);
            this.sortedGuessesOut.TabIndex = 18;
            // 
            // guessesOut
            // 
            this.guessesOut.AutoSize = true;
            this.guessesOut.ForeColor = System.Drawing.Color.White;
            this.guessesOut.Location = new System.Drawing.Point(66, 97);
            this.guessesOut.Name = "guessesOut";
            this.guessesOut.Size = new System.Drawing.Size(0, 13);
            this.guessesOut.TabIndex = 19;
            // 
            // numGuesses
            // 
            this.numGuesses.AutoSize = true;
            this.numGuesses.ForeColor = System.Drawing.Color.White;
            this.numGuesses.Location = new System.Drawing.Point(198, 79);
            this.numGuesses.Name = "numGuesses";
            this.numGuesses.Size = new System.Drawing.Size(88, 13);
            this.numGuesses.TabIndex = 20;
            this.numGuesses.Text = "Number Guesses";
            // 
            // numGuesssesOut
            // 
            this.numGuesssesOut.AutoSize = true;
            this.numGuesssesOut.ForeColor = System.Drawing.Color.White;
            this.numGuesssesOut.Location = new System.Drawing.Point(208, 106);
            this.numGuesssesOut.Name = "numGuesssesOut";
            this.numGuesssesOut.Size = new System.Drawing.Size(0, 13);
            this.numGuesssesOut.TabIndex = 21;
            // 
            // resultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.numGuesssesOut);
            this.Controls.Add(this.numGuesses);
            this.Controls.Add(this.guessesOut);
            this.Controls.Add(this.sortedGuessesOut);
            this.Controls.Add(this.guessesNoSort);
            this.Controls.Add(this.sortedGuesses);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "resultScreen";
            this.Size = new System.Drawing.Size(500, 272);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Label sortedGuesses;
        private System.Windows.Forms.Label guessesNoSort;
        private System.Windows.Forms.Label sortedGuessesOut;
        private System.Windows.Forms.Label guessesOut;
        private System.Windows.Forms.Label numGuesses;
        private System.Windows.Forms.Label numGuesssesOut;
    }
}
