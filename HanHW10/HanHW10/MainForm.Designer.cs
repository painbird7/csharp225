namespace HanHW10
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
            this.mainAddButton = new System.Windows.Forms.Button();
            this.mainDeleteButton = new System.Windows.Forms.Button();
            this.mainExitButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.highestTextBox = new System.Windows.Forms.TextBox();
            this.lowestTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainAddButton
            // 
            this.mainAddButton.Location = new System.Drawing.Point(23, 473);
            this.mainAddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainAddButton.Name = "mainAddButton";
            this.mainAddButton.Size = new System.Drawing.Size(87, 30);
            this.mainAddButton.TabIndex = 0;
            this.mainAddButton.Text = "Add New";
            this.mainAddButton.UseVisualStyleBackColor = true;
            this.mainAddButton.Click += new System.EventHandler(this.mainAddButton_Click);
            // 
            // mainDeleteButton
            // 
            this.mainDeleteButton.Location = new System.Drawing.Point(192, 473);
            this.mainDeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainDeleteButton.Name = "mainDeleteButton";
            this.mainDeleteButton.Size = new System.Drawing.Size(87, 30);
            this.mainDeleteButton.TabIndex = 1;
            this.mainDeleteButton.Text = "Delete";
            this.mainDeleteButton.UseVisualStyleBackColor = true;
            // 
            // mainExitButton
            // 
            this.mainExitButton.Location = new System.Drawing.Point(361, 473);
            this.mainExitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainExitButton.Name = "mainExitButton";
            this.mainExitButton.Size = new System.Drawing.Size(87, 30);
            this.mainExitButton.TabIndex = 2;
            this.mainExitButton.Text = "Exit";
            this.mainExitButton.UseVisualStyleBackColor = true;
            this.mainExitButton.Click += new System.EventHandler(this.mainExitButton_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.Location = new System.Drawing.Point(23, 25);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(426, 235);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "City";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Population";
            this.columnHeader2.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "The total population of all the cities:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Highest population:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "The average population of all the cities:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lowest population:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(270, 288);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(179, 25);
            this.totalTextBox.TabIndex = 8;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // averageTextBox
            // 
            this.averageTextBox.Location = new System.Drawing.Point(270, 329);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.Size = new System.Drawing.Size(179, 25);
            this.averageTextBox.TabIndex = 9;
            this.averageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // highestTextBox
            // 
            this.highestTextBox.Location = new System.Drawing.Point(270, 370);
            this.highestTextBox.Name = "highestTextBox";
            this.highestTextBox.Size = new System.Drawing.Size(179, 25);
            this.highestTextBox.TabIndex = 10;
            this.highestTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lowestTextBox
            // 
            this.lowestTextBox.Location = new System.Drawing.Point(270, 410);
            this.lowestTextBox.Name = "lowestTextBox";
            this.lowestTextBox.Size = new System.Drawing.Size(179, 25);
            this.lowestTextBox.TabIndex = 11;
            this.lowestTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 528);
            this.Controls.Add(this.lowestTextBox);
            this.Controls.Add(this.highestTextBox);
            this.Controls.Add(this.averageTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.mainExitButton);
            this.Controls.Add(this.mainDeleteButton);
            this.Controls.Add(this.mainAddButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Populations";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainAddButton;
        private System.Windows.Forms.Button mainDeleteButton;
        private System.Windows.Forms.Button mainExitButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.TextBox highestTextBox;
        private System.Windows.Forms.TextBox lowestTextBox;
    }
}

