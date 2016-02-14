namespace HanHW4_1
{
    partial class Form1
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
            this.playCountLabel = new System.Windows.Forms.Label();
            this.playCountTextBox = new System.Windows.Forms.TextBox();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.guessLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.startNewButton = new System.Windows.Forms.Button();
            this.randomNumberTextBox = new System.Windows.Forms.TextBox();
            this.randomNumberLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.guessNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playCountLabel
            // 
            this.playCountLabel.AutoSize = true;
            this.playCountLabel.Location = new System.Drawing.Point(12, 67);
            this.playCountLabel.Name = "playCountLabel";
            this.playCountLabel.Size = new System.Drawing.Size(72, 17);
            this.playCountLabel.TabIndex = 0;
            this.playCountLabel.Text = "Play Count:";
            // 
            // playCountTextBox
            // 
            this.playCountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playCountTextBox.Location = new System.Drawing.Point(86, 67);
            this.playCountTextBox.Name = "playCountTextBox";
            this.playCountTextBox.ReadOnly = true;
            this.playCountTextBox.Size = new System.Drawing.Size(100, 18);
            this.playCountTextBox.TabIndex = 1;
            this.playCountTextBox.TabStop = false;
            // 
            // guessTextBox
            // 
            this.guessTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessTextBox.Location = new System.Drawing.Point(240, 115);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(61, 35);
            this.guessTextBox.TabIndex = 1;
            this.guessTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guessTextBox_KeyDown);
            // 
            // guessLabel
            // 
            this.guessLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessLabel.Location = new System.Drawing.Point(12, 10);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(389, 45);
            this.guessLabel.TabIndex = 3;
            this.guessLabel.Text = "Random number has been generated between 1 and 100. Please enter your guess numbe" +
    "r in the text box and press Enter key.";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(313, 244);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 26);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // startNewButton
            // 
            this.startNewButton.Location = new System.Drawing.Point(23, 244);
            this.startNewButton.Name = "startNewButton";
            this.startNewButton.Size = new System.Drawing.Size(75, 26);
            this.startNewButton.TabIndex = 2;
            this.startNewButton.Text = "Start New";
            this.startNewButton.UseVisualStyleBackColor = true;
            this.startNewButton.Click += new System.EventHandler(this.startNewButton_Click);
            // 
            // randomNumberTextBox
            // 
            this.randomNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomNumberTextBox.Location = new System.Drawing.Point(100, 115);
            this.randomNumberTextBox.Name = "randomNumberTextBox";
            this.randomNumberTextBox.ReadOnly = true;
            this.randomNumberTextBox.Size = new System.Drawing.Size(61, 35);
            this.randomNumberTextBox.TabIndex = 7;
            this.randomNumberTextBox.TabStop = false;
            this.randomNumberTextBox.Visible = false;
            // 
            // randomNumberLabel
            // 
            this.randomNumberLabel.AutoSize = true;
            this.randomNumberLabel.Location = new System.Drawing.Point(63, 94);
            this.randomNumberLabel.Name = "randomNumberLabel";
            this.randomNumberLabel.Size = new System.Drawing.Size(112, 17);
            this.randomNumberLabel.TabIndex = 9;
            this.randomNumberLabel.Text = "Random Number:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(107, 164);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 17);
            this.resultLabel.TabIndex = 12;
            // 
            // guessNumberLabel
            // 
            this.guessNumberLabel.AutoSize = true;
            this.guessNumberLabel.Location = new System.Drawing.Point(219, 94);
            this.guessNumberLabel.Name = "guessNumberLabel";
            this.guessNumberLabel.Size = new System.Drawing.Size(98, 17);
            this.guessNumberLabel.TabIndex = 13;
            this.guessNumberLabel.Text = "Guess Number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 294);
            this.Controls.Add(this.guessNumberLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.randomNumberLabel);
            this.Controls.Add(this.randomNumberTextBox);
            this.Controls.Add(this.startNewButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.playCountTextBox);
            this.Controls.Add(this.playCountLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Guessing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playCountLabel;
        private System.Windows.Forms.TextBox playCountTextBox;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button startNewButton;
        private System.Windows.Forms.TextBox randomNumberTextBox;
        private System.Windows.Forms.Label randomNumberLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label guessNumberLabel;
    }
}

