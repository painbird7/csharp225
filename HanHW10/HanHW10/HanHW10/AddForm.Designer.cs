namespace HanHW10
{
    partial class AddForm
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
            this.addFormSaveButton = new System.Windows.Forms.Button();
            this.addFormExitButton = new System.Windows.Forms.Button();
            this.cityLabel = new System.Windows.Forms.Label();
            this.populationLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.addFormClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addFormSaveButton
            // 
            this.addFormSaveButton.Location = new System.Drawing.Point(35, 178);
            this.addFormSaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addFormSaveButton.Name = "addFormSaveButton";
            this.addFormSaveButton.Size = new System.Drawing.Size(87, 30);
            this.addFormSaveButton.TabIndex = 2;
            this.addFormSaveButton.Text = "Save";
            this.addFormSaveButton.UseVisualStyleBackColor = true;
            this.addFormSaveButton.Click += new System.EventHandler(this.addFormSaveButton_Click);
            // 
            // addFormExitButton
            // 
            this.addFormExitButton.Location = new System.Drawing.Point(272, 178);
            this.addFormExitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addFormExitButton.Name = "addFormExitButton";
            this.addFormExitButton.Size = new System.Drawing.Size(87, 30);
            this.addFormExitButton.TabIndex = 4;
            this.addFormExitButton.Text = "Exit";
            this.addFormExitButton.UseVisualStyleBackColor = true;
            this.addFormExitButton.Click += new System.EventHandler(this.addFormExitButton_Click);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(32, 35);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(32, 17);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "City:";
            // 
            // populationLabel
            // 
            this.populationLabel.AutoSize = true;
            this.populationLabel.Location = new System.Drawing.Point(32, 90);
            this.populationLabel.Name = "populationLabel";
            this.populationLabel.Size = new System.Drawing.Size(73, 17);
            this.populationLabel.TabIndex = 6;
            this.populationLabel.Text = "Population:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(142, 32);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(217, 25);
            this.cityTextBox.TabIndex = 0;
            // 
            // populationTextBox
            // 
            this.populationTextBox.Location = new System.Drawing.Point(142, 87);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(217, 25);
            this.populationTextBox.TabIndex = 1;
            // 
            // addFormClearButton
            // 
            this.addFormClearButton.Location = new System.Drawing.Point(156, 178);
            this.addFormClearButton.Name = "addFormClearButton";
            this.addFormClearButton.Size = new System.Drawing.Size(87, 30);
            this.addFormClearButton.TabIndex = 3;
            this.addFormClearButton.Text = "Clear";
            this.addFormClearButton.UseVisualStyleBackColor = true;
            this.addFormClearButton.Click += new System.EventHandler(this.addFormClearButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 243);
            this.Controls.Add(this.addFormClearButton);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.populationLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addFormExitButton);
            this.Controls.Add(this.addFormSaveButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFormSaveButton;
        private System.Windows.Forms.Button addFormExitButton;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label populationLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.Button addFormClearButton;
    }
}