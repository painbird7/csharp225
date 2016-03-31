namespace HanHW6
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
            this.components = new System.ComponentModel.Container();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.annualChangeTextBox = new System.Windows.Forms.TextBox();
            this.greatestTextBox = new System.Windows.Forms.TextBox();
            this.leastTextBox = new System.Windows.Forms.TextBox();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listView = new System.Windows.Forms.ListView();
            this.yearCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.popCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.increaseCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 391);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(87, 27);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(151, 391);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 27);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(299, 391);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 27);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filePathTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathTextBox.Location = new System.Drawing.Point(12, 27);
            this.filePathTextBox.Multiline = true;
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(374, 27);
            this.filePathTextBox.TabIndex = 5;
            this.filePathTextBox.TabStop = false;
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathLabel.Location = new System.Drawing.Point(12, 9);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(0, 13);
            this.filePathLabel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Average Annual Change:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "The Year with The Greatest Increase:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "The Year with The Least Increase:";
            // 
            // annualChangeTextBox
            // 
            this.annualChangeTextBox.Location = new System.Drawing.Point(286, 264);
            this.annualChangeTextBox.Name = "annualChangeTextBox";
            this.annualChangeTextBox.Size = new System.Drawing.Size(100, 23);
            this.annualChangeTextBox.TabIndex = 10;
            // 
            // greatestTextBox
            // 
            this.greatestTextBox.Location = new System.Drawing.Point(286, 305);
            this.greatestTextBox.Name = "greatestTextBox";
            this.greatestTextBox.Size = new System.Drawing.Size(100, 23);
            this.greatestTextBox.TabIndex = 11;
            // 
            // leastTextBox
            // 
            this.leastTextBox.Location = new System.Drawing.Point(286, 348);
            this.leastTextBox.Name = "leastTextBox";
            this.leastTextBox.Size = new System.Drawing.Size(100, 23);
            this.leastTextBox.TabIndex = 12;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(HanHW6.Form1);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.yearCH,
            this.popCH,
            this.increaseCH});
            this.listView.Location = new System.Drawing.Point(28, 75);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(358, 145);
            this.listView.TabIndex = 13;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // yearCH
            // 
            this.yearCH.Text = "Year";
            // 
            // popCH
            // 
            this.popCH.Text = "Populations";
            this.popCH.Width = 80;
            // 
            // increaseCH
            // 
            this.increaseCH.Text = "Increase";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 435);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.leastTextBox);
            this.Controls.Add(this.greatestTextBox);
            this.Controls.Add(this.annualChangeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "US Populations 1950-1990";
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox annualChangeTextBox;
        private System.Windows.Forms.TextBox greatestTextBox;
        private System.Windows.Forms.TextBox leastTextBox;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader increaseCH;
        private System.Windows.Forms.ColumnHeader popCH;
        private System.Windows.Forms.ColumnHeader yearCH;
    }
}

