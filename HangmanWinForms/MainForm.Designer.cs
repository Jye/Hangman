namespace HangmanWinForms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newGameButton = new System.Windows.Forms.Button();
            this.remainingGuessesCaption = new System.Windows.Forms.Label();
            this.remainingGuessesLabel = new System.Windows.Forms.Label();
            this.scoreCaption = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.revealedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(197, 11);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(75, 23);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // remainingGuessesCaption
            // 
            this.remainingGuessesCaption.AutoSize = true;
            this.remainingGuessesCaption.Location = new System.Drawing.Point(12, 22);
            this.remainingGuessesCaption.Name = "remainingGuessesCaption";
            this.remainingGuessesCaption.Size = new System.Drawing.Size(51, 13);
            this.remainingGuessesCaption.TabIndex = 1;
            this.remainingGuessesCaption.Text = "Guesses:";
            // 
            // remainingGuessesLabel
            // 
            this.remainingGuessesLabel.AutoSize = true;
            this.remainingGuessesLabel.Location = new System.Drawing.Point(64, 21);
            this.remainingGuessesLabel.Name = "remainingGuessesLabel";
            this.remainingGuessesLabel.Size = new System.Drawing.Size(0, 13);
            this.remainingGuessesLabel.TabIndex = 2;
            // 
            // scoreCaption
            // 
            this.scoreCaption.AutoSize = true;
            this.scoreCaption.Location = new System.Drawing.Point(25, 9);
            this.scoreCaption.Name = "scoreCaption";
            this.scoreCaption.Size = new System.Drawing.Size(38, 13);
            this.scoreCaption.TabIndex = 3;
            this.scoreCaption.Text = "Score:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(63, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 13);
            this.scoreLabel.TabIndex = 4;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(12, 96);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 5;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // guessTextBox
            // 
            this.guessTextBox.Location = new System.Drawing.Point(93, 99);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(179, 20);
            this.guessTextBox.TabIndex = 6;
            // 
            // revealedLabel
            // 
            this.revealedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.revealedLabel.AutoSize = true;
            this.revealedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revealedLabel.Location = new System.Drawing.Point(88, 51);
            this.revealedLabel.Name = "revealedLabel";
            this.revealedLabel.Size = new System.Drawing.Size(0, 25);
            this.revealedLabel.TabIndex = 7;
            this.revealedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.revealedLabel);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.scoreCaption);
            this.Controls.Add(this.remainingGuessesLabel);
            this.Controls.Add(this.remainingGuessesCaption);
            this.Controls.Add(this.newGameButton);
            this.Name = "MainForm";
            this.Text = "Hangman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label remainingGuessesCaption;
        private System.Windows.Forms.Label remainingGuessesLabel;
        private System.Windows.Forms.Label scoreCaption;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Label revealedLabel;
    }
}

