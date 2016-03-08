namespace HanHW5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.presentValueLabel = new System.Windows.Forms.Label();
            this.futureValueLabel = new System.Windows.Forms.Label();
            this.annualInterestRateLabel = new System.Windows.Forms.Label();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.futureValueTextBox = new System.Windows.Forms.TextBox();
            this.annualInterestRateTextBox = new System.Windows.Forms.TextBox();
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            this.presentValueTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // presentValueLabel
            // 
            this.presentValueLabel.AutoSize = true;
            this.presentValueLabel.Location = new System.Drawing.Point(27, 190);
            this.presentValueLabel.Name = "presentValueLabel";
            this.presentValueLabel.Size = new System.Drawing.Size(144, 17);
            this.presentValueLabel.TabIndex = 0;
            this.presentValueLabel.Text = "The amount to deposit:";
            // 
            // futureValueLabel
            // 
            this.futureValueLabel.AutoSize = true;
            this.futureValueLabel.Location = new System.Drawing.Point(27, 22);
            this.futureValueLabel.Name = "futureValueLabel";
            this.futureValueLabel.Size = new System.Drawing.Size(81, 17);
            this.futureValueLabel.TabIndex = 1;
            this.futureValueLabel.Text = "Future value:";
            // 
            // annualInterestRateLabel
            // 
            this.annualInterestRateLabel.AutoSize = true;
            this.annualInterestRateLabel.Location = new System.Drawing.Point(27, 78);
            this.annualInterestRateLabel.Name = "annualInterestRateLabel";
            this.annualInterestRateLabel.Size = new System.Drawing.Size(124, 17);
            this.annualInterestRateLabel.TabIndex = 2;
            this.annualInterestRateLabel.Text = "Annual interest rate:";
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(27, 134);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(110, 17);
            this.yearsLabel.TabIndex = 3;
            this.yearsLabel.Text = "Number of years:";
            // 
            // futureValueTextBox
            // 
            this.futureValueTextBox.Location = new System.Drawing.Point(185, 19);
            this.futureValueTextBox.Name = "futureValueTextBox";
            this.futureValueTextBox.Size = new System.Drawing.Size(140, 25);
            this.futureValueTextBox.TabIndex = 4;
            // 
            // annualInterestRateTextBox
            // 
            this.annualInterestRateTextBox.Location = new System.Drawing.Point(185, 75);
            this.annualInterestRateTextBox.Name = "annualInterestRateTextBox";
            this.annualInterestRateTextBox.Size = new System.Drawing.Size(140, 25);
            this.annualInterestRateTextBox.TabIndex = 5;
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.Location = new System.Drawing.Point(185, 131);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(140, 25);
            this.yearsTextBox.TabIndex = 6;
            // 
            // presentValueTextBox
            // 
            this.presentValueTextBox.Location = new System.Drawing.Point(185, 187);
            this.presentValueTextBox.Name = "presentValueTextBox";
            this.presentValueTextBox.ReadOnly = true;
            this.presentValueTextBox.Size = new System.Drawing.Size(140, 25);
            this.presentValueTextBox.TabIndex = 7;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(250, 250);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(33, 250);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(467, 250);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(382, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 123);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 381);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.presentValueTextBox);
            this.Controls.Add(this.yearsTextBox);
            this.Controls.Add(this.annualInterestRateTextBox);
            this.Controls.Add(this.futureValueTextBox);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.annualInterestRateLabel);
            this.Controls.Add(this.futureValueLabel);
            this.Controls.Add(this.presentValueLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Present Value Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label presentValueLabel;
        private System.Windows.Forms.Label futureValueLabel;
        private System.Windows.Forms.Label annualInterestRateLabel;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.TextBox futureValueTextBox;
        private System.Windows.Forms.TextBox annualInterestRateTextBox;
        private System.Windows.Forms.TextBox yearsTextBox;
        private System.Windows.Forms.TextBox presentValueTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

