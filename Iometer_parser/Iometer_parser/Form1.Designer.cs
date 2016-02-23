namespace Iometer_parser
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
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.parseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nultipleItemsRadioButton = new System.Windows.Forms.RadioButton();
            this.oneItemRadioButton = new System.Windows.Forms.RadioButton();
            this.openButton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(458, 455);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 27);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(667, 455);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 27);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // parseButton
            // 
            this.parseButton.Location = new System.Drawing.Point(307, 455);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(87, 27);
            this.parseButton.TabIndex = 2;
            this.parseButton.Text = "&Parse";
            this.parseButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nultipleItemsRadioButton);
            this.groupBox1.Controls.Add(this.oneItemRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(66, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 105);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // nultipleItemsRadioButton
            // 
            this.nultipleItemsRadioButton.AutoSize = true;
            this.nultipleItemsRadioButton.Location = new System.Drawing.Point(29, 59);
            this.nultipleItemsRadioButton.Name = "nultipleItemsRadioButton";
            this.nultipleItemsRadioButton.Size = new System.Drawing.Size(101, 19);
            this.nultipleItemsRadioButton.TabIndex = 1;
            this.nultipleItemsRadioButton.TabStop = true;
            this.nultipleItemsRadioButton.Text = "Multiple items";
            this.nultipleItemsRadioButton.UseVisualStyleBackColor = true;
            // 
            // oneItemRadioButton
            // 
            this.oneItemRadioButton.AutoSize = true;
            this.oneItemRadioButton.Location = new System.Drawing.Point(29, 33);
            this.oneItemRadioButton.Name = "oneItemRadioButton";
            this.oneItemRadioButton.Size = new System.Drawing.Size(74, 19);
            this.oneItemRadioButton.TabIndex = 0;
            this.oneItemRadioButton.TabStop = true;
            this.oneItemRadioButton.Text = "One item";
            this.oneItemRadioButton.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(294, 65);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "&Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(54, 180);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(859, 225);
            this.dataGrid.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 595);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.parseButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton nultipleItemsRadioButton;
        private System.Windows.Forms.RadioButton oneItemRadioButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}

