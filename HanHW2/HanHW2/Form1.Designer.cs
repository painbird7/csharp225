namespace HanHW2
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
            this.permitGroupBox = new System.Windows.Forms.GroupBox();
            this.permitSCTextBox = new System.Windows.Forms.TextBox();
            this.permitECTextBox = new System.Windows.Forms.TextBox();
            this.permitWCTextBox = new System.Windows.Forms.TextBox();
            this.permitSCLabel = new System.Windows.Forms.Label();
            this.permitECLabel = new System.Windows.Forms.Label();
            this.permitWCLabel = new System.Windows.Forms.Label();
            this.permitInstructionLabel = new System.Windows.Forms.Label();
            this.revenueGroupBox = new System.Windows.Forms.GroupBox();
            this.trTotalTextBox = new System.Windows.Forms.TextBox();
            this.scTotalTextBox = new System.Windows.Forms.TextBox();
            this.ecTotalTextBox = new System.Windows.Forms.TextBox();
            this.wcTotalTextBox = new System.Windows.Forms.TextBox();
            this.revenueTRTextbox = new System.Windows.Forms.TextBox();
            this.revenueSCTextBox = new System.Windows.Forms.TextBox();
            this.revenueECTextBox = new System.Windows.Forms.TextBox();
            this.revenueWCTextBox = new System.Windows.Forms.TextBox();
            this.revenueTRLabel = new System.Windows.Forms.Label();
            this.revenueSCLabel = new System.Windows.Forms.Label();
            this.revenueECLabel = new System.Windows.Forms.Label();
            this.revenueWCLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.permitGroupBox.SuspendLayout();
            this.revenueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // permitGroupBox
            // 
            this.permitGroupBox.Controls.Add(this.permitSCTextBox);
            this.permitGroupBox.Controls.Add(this.permitECTextBox);
            this.permitGroupBox.Controls.Add(this.permitWCTextBox);
            this.permitGroupBox.Controls.Add(this.permitSCLabel);
            this.permitGroupBox.Controls.Add(this.permitECLabel);
            this.permitGroupBox.Controls.Add(this.permitWCLabel);
            this.permitGroupBox.Controls.Add(this.permitInstructionLabel);
            this.permitGroupBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permitGroupBox.Location = new System.Drawing.Point(16, 18);
            this.permitGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.permitGroupBox.Name = "permitGroupBox";
            this.permitGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.permitGroupBox.Size = new System.Drawing.Size(342, 247);
            this.permitGroupBox.TabIndex = 0;
            this.permitGroupBox.TabStop = false;
            this.permitGroupBox.Text = "Permits Sold";
            // 
            // permitSCTextBox
            // 
            this.permitSCTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permitSCTextBox.Location = new System.Drawing.Point(133, 161);
            this.permitSCTextBox.Name = "permitSCTextBox";
            this.permitSCTextBox.Size = new System.Drawing.Size(125, 25);
            this.permitSCTextBox.TabIndex = 3;
            // 
            // permitECTextBox
            // 
            this.permitECTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permitECTextBox.Location = new System.Drawing.Point(133, 119);
            this.permitECTextBox.Name = "permitECTextBox";
            this.permitECTextBox.Size = new System.Drawing.Size(125, 25);
            this.permitECTextBox.TabIndex = 2;
            // 
            // permitWCTextBox
            // 
            this.permitWCTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permitWCTextBox.Location = new System.Drawing.Point(133, 77);
            this.permitWCTextBox.Name = "permitWCTextBox";
            this.permitWCTextBox.Size = new System.Drawing.Size(125, 25);
            this.permitWCTextBox.TabIndex = 1;
            // 
            // permitSCLabel
            // 
            this.permitSCLabel.AutoSize = true;
            this.permitSCLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permitSCLabel.Location = new System.Drawing.Point(8, 164);
            this.permitSCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.permitSCLabel.Name = "permitSCLabel";
            this.permitSCLabel.Size = new System.Drawing.Size(109, 17);
            this.permitSCLabel.TabIndex = 3;
            this.permitSCLabel.Text = "South Commuter:";
            // 
            // permitECLabel
            // 
            this.permitECLabel.AutoSize = true;
            this.permitECLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permitECLabel.Location = new System.Drawing.Point(8, 122);
            this.permitECLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.permitECLabel.Name = "permitECLabel";
            this.permitECLabel.Size = new System.Drawing.Size(100, 17);
            this.permitECLabel.TabIndex = 2;
            this.permitECLabel.Text = "East Commuter:";
            // 
            // permitWCLabel
            // 
            this.permitWCLabel.AutoSize = true;
            this.permitWCLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permitWCLabel.Location = new System.Drawing.Point(8, 80);
            this.permitWCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.permitWCLabel.Name = "permitWCLabel";
            this.permitWCLabel.Size = new System.Drawing.Size(105, 17);
            this.permitWCLabel.TabIndex = 1;
            this.permitWCLabel.Text = "West Commuter:";
            // 
            // permitInstructionLabel
            // 
            this.permitInstructionLabel.AutoSize = true;
            this.permitInstructionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permitInstructionLabel.Location = new System.Drawing.Point(8, 38);
            this.permitInstructionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.permitInstructionLabel.Name = "permitInstructionLabel";
            this.permitInstructionLabel.Size = new System.Drawing.Size(325, 17);
            this.permitInstructionLabel.TabIndex = 0;
            this.permitInstructionLabel.Text = "Enter the number of permits sold for each type of permit.";
            // 
            // revenueGroupBox
            // 
            this.revenueGroupBox.AutoSize = true;
            this.revenueGroupBox.Controls.Add(this.trTotalTextBox);
            this.revenueGroupBox.Controls.Add(this.scTotalTextBox);
            this.revenueGroupBox.Controls.Add(this.ecTotalTextBox);
            this.revenueGroupBox.Controls.Add(this.wcTotalTextBox);
            this.revenueGroupBox.Controls.Add(this.revenueTRTextbox);
            this.revenueGroupBox.Controls.Add(this.revenueSCTextBox);
            this.revenueGroupBox.Controls.Add(this.revenueECTextBox);
            this.revenueGroupBox.Controls.Add(this.revenueWCTextBox);
            this.revenueGroupBox.Controls.Add(this.revenueTRLabel);
            this.revenueGroupBox.Controls.Add(this.revenueSCLabel);
            this.revenueGroupBox.Controls.Add(this.revenueECLabel);
            this.revenueGroupBox.Controls.Add(this.revenueWCLabel);
            this.revenueGroupBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueGroupBox.Location = new System.Drawing.Point(375, 18);
            this.revenueGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.revenueGroupBox.Name = "revenueGroupBox";
            this.revenueGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.revenueGroupBox.Size = new System.Drawing.Size(469, 247);
            this.revenueGroupBox.TabIndex = 1;
            this.revenueGroupBox.TabStop = false;
            this.revenueGroupBox.Text = "Revenue Generated";
            // 
            // trTotalTextBox
            // 
            this.trTotalTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trTotalTextBox.Location = new System.Drawing.Point(120, 192);
            this.trTotalTextBox.Name = "trTotalTextBox";
            this.trTotalTextBox.ReadOnly = true;
            this.trTotalTextBox.Size = new System.Drawing.Size(335, 27);
            this.trTotalTextBox.TabIndex = 15;
            this.trTotalTextBox.TabStop = false;
            // 
            // scTotalTextBox
            // 
            this.scTotalTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scTotalTextBox.Location = new System.Drawing.Point(340, 122);
            this.scTotalTextBox.Name = "scTotalTextBox";
            this.scTotalTextBox.ReadOnly = true;
            this.scTotalTextBox.Size = new System.Drawing.Size(115, 25);
            this.scTotalTextBox.TabIndex = 14;
            this.scTotalTextBox.TabStop = false;
            // 
            // ecTotalTextBox
            // 
            this.ecTotalTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecTotalTextBox.Location = new System.Drawing.Point(340, 80);
            this.ecTotalTextBox.Name = "ecTotalTextBox";
            this.ecTotalTextBox.ReadOnly = true;
            this.ecTotalTextBox.Size = new System.Drawing.Size(115, 25);
            this.ecTotalTextBox.TabIndex = 13;
            this.ecTotalTextBox.TabStop = false;
            // 
            // wcTotalTextBox
            // 
            this.wcTotalTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wcTotalTextBox.Location = new System.Drawing.Point(340, 38);
            this.wcTotalTextBox.Name = "wcTotalTextBox";
            this.wcTotalTextBox.ReadOnly = true;
            this.wcTotalTextBox.Size = new System.Drawing.Size(115, 25);
            this.wcTotalTextBox.TabIndex = 12;
            this.wcTotalTextBox.TabStop = false;
            // 
            // revenueTRTextbox
            // 
            this.revenueTRTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueTRTextbox.Location = new System.Drawing.Point(120, 162);
            this.revenueTRTextbox.Multiline = true;
            this.revenueTRTextbox.Name = "revenueTRTextbox";
            this.revenueTRTextbox.ReadOnly = true;
            this.revenueTRTextbox.Size = new System.Drawing.Size(335, 24);
            this.revenueTRTextbox.TabIndex = 11;
            this.revenueTRTextbox.TabStop = false;
            // 
            // revenueSCTextBox
            // 
            this.revenueSCTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueSCTextBox.Location = new System.Drawing.Point(120, 122);
            this.revenueSCTextBox.Name = "revenueSCTextBox";
            this.revenueSCTextBox.ReadOnly = true;
            this.revenueSCTextBox.Size = new System.Drawing.Size(214, 25);
            this.revenueSCTextBox.TabIndex = 10;
            this.revenueSCTextBox.TabStop = false;
            // 
            // revenueECTextBox
            // 
            this.revenueECTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueECTextBox.Location = new System.Drawing.Point(120, 80);
            this.revenueECTextBox.Name = "revenueECTextBox";
            this.revenueECTextBox.ReadOnly = true;
            this.revenueECTextBox.Size = new System.Drawing.Size(214, 25);
            this.revenueECTextBox.TabIndex = 9;
            this.revenueECTextBox.TabStop = false;
            // 
            // revenueWCTextBox
            // 
            this.revenueWCTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueWCTextBox.Location = new System.Drawing.Point(120, 38);
            this.revenueWCTextBox.Name = "revenueWCTextBox";
            this.revenueWCTextBox.ReadOnly = true;
            this.revenueWCTextBox.Size = new System.Drawing.Size(214, 25);
            this.revenueWCTextBox.TabIndex = 8;
            this.revenueWCTextBox.TabStop = false;
            // 
            // revenueTRLabel
            // 
            this.revenueTRLabel.AutoSize = true;
            this.revenueTRLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueTRLabel.Location = new System.Drawing.Point(8, 165);
            this.revenueTRLabel.Name = "revenueTRLabel";
            this.revenueTRLabel.Size = new System.Drawing.Size(93, 17);
            this.revenueTRLabel.TabIndex = 7;
            this.revenueTRLabel.Text = "Total Revenue:";
            // 
            // revenueSCLabel
            // 
            this.revenueSCLabel.AutoSize = true;
            this.revenueSCLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueSCLabel.Location = new System.Drawing.Point(8, 122);
            this.revenueSCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.revenueSCLabel.Name = "revenueSCLabel";
            this.revenueSCLabel.Size = new System.Drawing.Size(109, 17);
            this.revenueSCLabel.TabIndex = 6;
            this.revenueSCLabel.Text = "South Commuter:";
            // 
            // revenueECLabel
            // 
            this.revenueECLabel.AutoSize = true;
            this.revenueECLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueECLabel.Location = new System.Drawing.Point(8, 80);
            this.revenueECLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.revenueECLabel.Name = "revenueECLabel";
            this.revenueECLabel.Size = new System.Drawing.Size(100, 17);
            this.revenueECLabel.TabIndex = 5;
            this.revenueECLabel.Text = "East Commuter:";
            // 
            // revenueWCLabel
            // 
            this.revenueWCLabel.AutoSize = true;
            this.revenueWCLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueWCLabel.Location = new System.Drawing.Point(8, 38);
            this.revenueWCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.revenueWCLabel.Name = "revenueWCLabel";
            this.revenueWCLabel.Size = new System.Drawing.Size(105, 17);
            this.revenueWCLabel.TabIndex = 4;
            this.revenueWCLabel.Text = "West Commuter:";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(176, 285);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(98, 52);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "&Calculate Revenue";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(375, 285);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(98, 52);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(574, 285);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 52);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 349);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.revenueGroupBox);
            this.Controls.Add(this.permitGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parking Revenue";
            this.permitGroupBox.ResumeLayout(false);
            this.permitGroupBox.PerformLayout();
            this.revenueGroupBox.ResumeLayout(false);
            this.revenueGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox permitGroupBox;
        private System.Windows.Forms.Label permitECLabel;
        private System.Windows.Forms.Label permitWCLabel;
        private System.Windows.Forms.Label permitInstructionLabel;
        private System.Windows.Forms.GroupBox revenueGroupBox;
        private System.Windows.Forms.TextBox revenueTRTextbox;
        private System.Windows.Forms.TextBox revenueSCTextBox;
        private System.Windows.Forms.TextBox revenueECTextBox;
        private System.Windows.Forms.TextBox revenueWCTextBox;
        private System.Windows.Forms.Label revenueTRLabel;
        private System.Windows.Forms.Label revenueSCLabel;
        private System.Windows.Forms.Label revenueECLabel;
        private System.Windows.Forms.Label revenueWCLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label permitSCLabel;
        private System.Windows.Forms.TextBox trTotalTextBox;
        private System.Windows.Forms.TextBox scTotalTextBox;
        private System.Windows.Forms.TextBox ecTotalTextBox;
        private System.Windows.Forms.TextBox wcTotalTextBox;
        private System.Windows.Forms.TextBox permitSCTextBox;
        private System.Windows.Forms.TextBox permitECTextBox;
        private System.Windows.Forms.TextBox permitWCTextBox;
    }
}

