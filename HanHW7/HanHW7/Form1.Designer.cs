﻿namespace HanHW7
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
            this.colaPictureBox = new System.Windows.Forms.PictureBox();
            this.lemonLimePictureBox = new System.Windows.Forms.PictureBox();
            this.rootBeerPictureBox = new System.Windows.Forms.PictureBox();
            this.creamSodaPictureBox = new System.Windows.Forms.PictureBox();
            this.grapeSodaPictureBox = new System.Windows.Forms.PictureBox();
            this.colaPanel = new System.Windows.Forms.Panel();
            this.colaPriceTextBox = new System.Windows.Forms.TextBox();
            this.colaQtyTextBox = new System.Windows.Forms.TextBox();
            this.colaQtyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lemonLimePanel = new System.Windows.Forms.Panel();
            this.lemonLimePriceTextBox = new System.Windows.Forms.TextBox();
            this.lemonLimeQtyTextBox = new System.Windows.Forms.TextBox();
            this.lemonLimeQtyLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rootBeerPanel = new System.Windows.Forms.Panel();
            this.rootBeerPriceTextBox = new System.Windows.Forms.TextBox();
            this.rootBeerQtyTextBox = new System.Windows.Forms.TextBox();
            this.rootBeerQtyLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grapeSodaPanel = new System.Windows.Forms.Panel();
            this.grapeSodaPriceTextBox = new System.Windows.Forms.TextBox();
            this.grapeSodaQtyTextBox = new System.Windows.Forms.TextBox();
            this.grapeSodaQtyLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.creamSodaPanel = new System.Windows.Forms.Panel();
            this.creamSodaPriceTextBox = new System.Windows.Forms.TextBox();
            this.creamSodaQtyTextBox = new System.Windows.Forms.TextBox();
            this.creamSodaQtyLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalPanel = new System.Windows.Forms.Panel();
            this.totalQuantityTextBox = new System.Windows.Forms.TextBox();
            this.totalSalesTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.outOfStockListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.colaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lemonLimePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootBeerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creamSodaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grapeSodaPictureBox)).BeginInit();
            this.colaPanel.SuspendLayout();
            this.lemonLimePanel.SuspendLayout();
            this.rootBeerPanel.SuspendLayout();
            this.grapeSodaPanel.SuspendLayout();
            this.creamSodaPanel.SuspendLayout();
            this.totalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // colaPictureBox
            // 
            this.colaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("colaPictureBox.Image")));
            this.colaPictureBox.Location = new System.Drawing.Point(18, 12);
            this.colaPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colaPictureBox.Name = "colaPictureBox";
            this.colaPictureBox.Size = new System.Drawing.Size(64, 64);
            this.colaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.colaPictureBox.TabIndex = 0;
            this.colaPictureBox.TabStop = false;
            this.colaPictureBox.Click += new System.EventHandler(this.PictureBoxClick);
            this.colaPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeBorderFixed3D);
            this.colaPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChangeBorderNone);
            // 
            // lemonLimePictureBox
            // 
            this.lemonLimePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("lemonLimePictureBox.Image")));
            this.lemonLimePictureBox.Location = new System.Drawing.Point(18, 12);
            this.lemonLimePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lemonLimePictureBox.Name = "lemonLimePictureBox";
            this.lemonLimePictureBox.Size = new System.Drawing.Size(62, 64);
            this.lemonLimePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lemonLimePictureBox.TabIndex = 1;
            this.lemonLimePictureBox.TabStop = false;
            this.lemonLimePictureBox.Click += new System.EventHandler(this.PictureBoxClick);
            this.lemonLimePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeBorderFixed3D);
            this.lemonLimePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChangeBorderNone);
            // 
            // rootBeerPictureBox
            // 
            this.rootBeerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("rootBeerPictureBox.Image")));
            this.rootBeerPictureBox.Location = new System.Drawing.Point(16, 12);
            this.rootBeerPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rootBeerPictureBox.Name = "rootBeerPictureBox";
            this.rootBeerPictureBox.Size = new System.Drawing.Size(64, 64);
            this.rootBeerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rootBeerPictureBox.TabIndex = 2;
            this.rootBeerPictureBox.TabStop = false;
            this.rootBeerPictureBox.Click += new System.EventHandler(this.PictureBoxClick);
            this.rootBeerPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeBorderFixed3D);
            this.rootBeerPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChangeBorderNone);
            // 
            // creamSodaPictureBox
            // 
            this.creamSodaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("creamSodaPictureBox.Image")));
            this.creamSodaPictureBox.Location = new System.Drawing.Point(16, 12);
            this.creamSodaPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.creamSodaPictureBox.Name = "creamSodaPictureBox";
            this.creamSodaPictureBox.Size = new System.Drawing.Size(62, 64);
            this.creamSodaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.creamSodaPictureBox.TabIndex = 3;
            this.creamSodaPictureBox.TabStop = false;
            this.creamSodaPictureBox.Click += new System.EventHandler(this.PictureBoxClick);
            this.creamSodaPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeBorderFixed3D);
            this.creamSodaPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChangeBorderNone);
            // 
            // grapeSodaPictureBox
            // 
            this.grapeSodaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("grapeSodaPictureBox.Image")));
            this.grapeSodaPictureBox.Location = new System.Drawing.Point(16, 12);
            this.grapeSodaPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grapeSodaPictureBox.Name = "grapeSodaPictureBox";
            this.grapeSodaPictureBox.Size = new System.Drawing.Size(62, 64);
            this.grapeSodaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.grapeSodaPictureBox.TabIndex = 4;
            this.grapeSodaPictureBox.TabStop = false;
            this.grapeSodaPictureBox.Click += new System.EventHandler(this.PictureBoxClick);
            this.grapeSodaPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeBorderFixed3D);
            this.grapeSodaPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChangeBorderNone);
            // 
            // colaPanel
            // 
            this.colaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colaPanel.Controls.Add(this.colaPriceTextBox);
            this.colaPanel.Controls.Add(this.colaQtyTextBox);
            this.colaPanel.Controls.Add(this.colaQtyLabel);
            this.colaPanel.Controls.Add(this.label1);
            this.colaPanel.Controls.Add(this.colaPictureBox);
            this.colaPanel.Location = new System.Drawing.Point(12, 11);
            this.colaPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colaPanel.Name = "colaPanel";
            this.colaPanel.Size = new System.Drawing.Size(101, 139);
            this.colaPanel.TabIndex = 5;
            // 
            // colaPriceTextBox
            // 
            this.colaPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colaPriceTextBox.Location = new System.Drawing.Point(55, 88);
            this.colaPriceTextBox.Name = "colaPriceTextBox";
            this.colaPriceTextBox.ReadOnly = true;
            this.colaPriceTextBox.Size = new System.Drawing.Size(37, 16);
            this.colaPriceTextBox.TabIndex = 4;
            this.colaPriceTextBox.TabStop = false;
            // 
            // colaQtyTextBox
            // 
            this.colaQtyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colaQtyTextBox.Location = new System.Drawing.Point(79, 111);
            this.colaQtyTextBox.Name = "colaQtyTextBox";
            this.colaQtyTextBox.ReadOnly = true;
            this.colaQtyTextBox.Size = new System.Drawing.Size(18, 16);
            this.colaQtyTextBox.TabIndex = 3;
            this.colaQtyTextBox.TabStop = false;
            // 
            // colaQtyLabel
            // 
            this.colaQtyLabel.AutoSize = true;
            this.colaQtyLabel.Location = new System.Drawing.Point(3, 111);
            this.colaQtyLabel.Name = "colaQtyLabel";
            this.colaQtyLabel.Size = new System.Drawing.Size(74, 15);
            this.colaQtyLabel.TabIndex = 2;
            this.colaQtyLabel.Text = "Qty in Stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price:";
            // 
            // lemonLimePanel
            // 
            this.lemonLimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lemonLimePanel.Controls.Add(this.lemonLimePriceTextBox);
            this.lemonLimePanel.Controls.Add(this.lemonLimeQtyTextBox);
            this.lemonLimePanel.Controls.Add(this.lemonLimeQtyLabel);
            this.lemonLimePanel.Controls.Add(this.label4);
            this.lemonLimePanel.Controls.Add(this.lemonLimePictureBox);
            this.lemonLimePanel.Location = new System.Drawing.Point(128, 11);
            this.lemonLimePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lemonLimePanel.Name = "lemonLimePanel";
            this.lemonLimePanel.Size = new System.Drawing.Size(101, 139);
            this.lemonLimePanel.TabIndex = 6;
            // 
            // lemonLimePriceTextBox
            // 
            this.lemonLimePriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lemonLimePriceTextBox.Location = new System.Drawing.Point(55, 87);
            this.lemonLimePriceTextBox.Name = "lemonLimePriceTextBox";
            this.lemonLimePriceTextBox.ReadOnly = true;
            this.lemonLimePriceTextBox.Size = new System.Drawing.Size(37, 16);
            this.lemonLimePriceTextBox.TabIndex = 5;
            this.lemonLimePriceTextBox.TabStop = false;
            // 
            // lemonLimeQtyTextBox
            // 
            this.lemonLimeQtyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lemonLimeQtyTextBox.Location = new System.Drawing.Point(78, 111);
            this.lemonLimeQtyTextBox.Name = "lemonLimeQtyTextBox";
            this.lemonLimeQtyTextBox.ReadOnly = true;
            this.lemonLimeQtyTextBox.Size = new System.Drawing.Size(20, 16);
            this.lemonLimeQtyTextBox.TabIndex = 3;
            this.lemonLimeQtyTextBox.TabStop = false;
            // 
            // lemonLimeQtyLabel
            // 
            this.lemonLimeQtyLabel.AutoSize = true;
            this.lemonLimeQtyLabel.Location = new System.Drawing.Point(3, 111);
            this.lemonLimeQtyLabel.Name = "lemonLimeQtyLabel";
            this.lemonLimeQtyLabel.Size = new System.Drawing.Size(74, 15);
            this.lemonLimeQtyLabel.TabIndex = 2;
            this.lemonLimeQtyLabel.Text = "Qty in Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Price:";
            // 
            // rootBeerPanel
            // 
            this.rootBeerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rootBeerPanel.Controls.Add(this.rootBeerPriceTextBox);
            this.rootBeerPanel.Controls.Add(this.rootBeerQtyTextBox);
            this.rootBeerPanel.Controls.Add(this.rootBeerQtyLabel);
            this.rootBeerPanel.Controls.Add(this.label6);
            this.rootBeerPanel.Controls.Add(this.rootBeerPictureBox);
            this.rootBeerPanel.Location = new System.Drawing.Point(245, 11);
            this.rootBeerPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rootBeerPanel.Name = "rootBeerPanel";
            this.rootBeerPanel.Size = new System.Drawing.Size(100, 139);
            this.rootBeerPanel.TabIndex = 6;
            // 
            // rootBeerPriceTextBox
            // 
            this.rootBeerPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rootBeerPriceTextBox.Location = new System.Drawing.Point(55, 87);
            this.rootBeerPriceTextBox.Name = "rootBeerPriceTextBox";
            this.rootBeerPriceTextBox.ReadOnly = true;
            this.rootBeerPriceTextBox.Size = new System.Drawing.Size(37, 16);
            this.rootBeerPriceTextBox.TabIndex = 5;
            this.rootBeerPriceTextBox.TabStop = false;
            // 
            // rootBeerQtyTextBox
            // 
            this.rootBeerQtyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rootBeerQtyTextBox.Location = new System.Drawing.Point(79, 111);
            this.rootBeerQtyTextBox.Name = "rootBeerQtyTextBox";
            this.rootBeerQtyTextBox.ReadOnly = true;
            this.rootBeerQtyTextBox.Size = new System.Drawing.Size(18, 16);
            this.rootBeerQtyTextBox.TabIndex = 3;
            this.rootBeerQtyTextBox.TabStop = false;
            // 
            // rootBeerQtyLabel
            // 
            this.rootBeerQtyLabel.AutoSize = true;
            this.rootBeerQtyLabel.Location = new System.Drawing.Point(3, 111);
            this.rootBeerQtyLabel.Name = "rootBeerQtyLabel";
            this.rootBeerQtyLabel.Size = new System.Drawing.Size(74, 15);
            this.rootBeerQtyLabel.TabIndex = 2;
            this.rootBeerQtyLabel.Text = "Qty in Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Price:";
            // 
            // grapeSodaPanel
            // 
            this.grapeSodaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grapeSodaPanel.Controls.Add(this.grapeSodaPriceTextBox);
            this.grapeSodaPanel.Controls.Add(this.grapeSodaQtyTextBox);
            this.grapeSodaPanel.Controls.Add(this.grapeSodaQtyLabel);
            this.grapeSodaPanel.Controls.Add(this.label8);
            this.grapeSodaPanel.Controls.Add(this.grapeSodaPictureBox);
            this.grapeSodaPanel.Location = new System.Drawing.Point(12, 158);
            this.grapeSodaPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grapeSodaPanel.Name = "grapeSodaPanel";
            this.grapeSodaPanel.Size = new System.Drawing.Size(101, 139);
            this.grapeSodaPanel.TabIndex = 7;
            // 
            // grapeSodaPriceTextBox
            // 
            this.grapeSodaPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grapeSodaPriceTextBox.Location = new System.Drawing.Point(45, 88);
            this.grapeSodaPriceTextBox.Name = "grapeSodaPriceTextBox";
            this.grapeSodaPriceTextBox.ReadOnly = true;
            this.grapeSodaPriceTextBox.Size = new System.Drawing.Size(37, 16);
            this.grapeSodaPriceTextBox.TabIndex = 5;
            this.grapeSodaPriceTextBox.TabStop = false;
            // 
            // grapeSodaQtyTextBox
            // 
            this.grapeSodaQtyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grapeSodaQtyTextBox.Location = new System.Drawing.Point(78, 111);
            this.grapeSodaQtyTextBox.Name = "grapeSodaQtyTextBox";
            this.grapeSodaQtyTextBox.ReadOnly = true;
            this.grapeSodaQtyTextBox.Size = new System.Drawing.Size(18, 16);
            this.grapeSodaQtyTextBox.TabIndex = 3;
            this.grapeSodaQtyTextBox.TabStop = false;
            // 
            // grapeSodaQtyLabel
            // 
            this.grapeSodaQtyLabel.AutoSize = true;
            this.grapeSodaQtyLabel.Location = new System.Drawing.Point(3, 111);
            this.grapeSodaQtyLabel.Name = "grapeSodaQtyLabel";
            this.grapeSodaQtyLabel.Size = new System.Drawing.Size(74, 15);
            this.grapeSodaQtyLabel.TabIndex = 2;
            this.grapeSodaQtyLabel.Text = "Qty in Stock:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Price:";
            // 
            // creamSodaPanel
            // 
            this.creamSodaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creamSodaPanel.Controls.Add(this.creamSodaPriceTextBox);
            this.creamSodaPanel.Controls.Add(this.creamSodaQtyTextBox);
            this.creamSodaPanel.Controls.Add(this.creamSodaQtyLabel);
            this.creamSodaPanel.Controls.Add(this.label10);
            this.creamSodaPanel.Controls.Add(this.creamSodaPictureBox);
            this.creamSodaPanel.Location = new System.Drawing.Point(129, 158);
            this.creamSodaPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.creamSodaPanel.Name = "creamSodaPanel";
            this.creamSodaPanel.Size = new System.Drawing.Size(100, 139);
            this.creamSodaPanel.TabIndex = 6;
            // 
            // creamSodaPriceTextBox
            // 
            this.creamSodaPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.creamSodaPriceTextBox.Location = new System.Drawing.Point(55, 88);
            this.creamSodaPriceTextBox.Name = "creamSodaPriceTextBox";
            this.creamSodaPriceTextBox.ReadOnly = true;
            this.creamSodaPriceTextBox.Size = new System.Drawing.Size(37, 16);
            this.creamSodaPriceTextBox.TabIndex = 5;
            this.creamSodaPriceTextBox.TabStop = false;
            // 
            // creamSodaQtyTextBox
            // 
            this.creamSodaQtyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.creamSodaQtyTextBox.Location = new System.Drawing.Point(79, 111);
            this.creamSodaQtyTextBox.Name = "creamSodaQtyTextBox";
            this.creamSodaQtyTextBox.ReadOnly = true;
            this.creamSodaQtyTextBox.Size = new System.Drawing.Size(18, 16);
            this.creamSodaQtyTextBox.TabIndex = 3;
            this.creamSodaQtyTextBox.TabStop = false;
            // 
            // creamSodaQtyLabel
            // 
            this.creamSodaQtyLabel.AutoSize = true;
            this.creamSodaQtyLabel.Location = new System.Drawing.Point(3, 111);
            this.creamSodaQtyLabel.Name = "creamSodaQtyLabel";
            this.creamSodaQtyLabel.Size = new System.Drawing.Size(74, 15);
            this.creamSodaQtyLabel.TabIndex = 2;
            this.creamSodaQtyLabel.Text = "Qty in Stock:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Price:";
            // 
            // totalPanel
            // 
            this.totalPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPanel.Controls.Add(this.totalQuantityTextBox);
            this.totalPanel.Controls.Add(this.totalSalesTextBox);
            this.totalPanel.Controls.Add(this.label11);
            this.totalPanel.Controls.Add(this.label12);
            this.totalPanel.Location = new System.Drawing.Point(245, 158);
            this.totalPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.totalPanel.Name = "totalPanel";
            this.totalPanel.Size = new System.Drawing.Size(100, 139);
            this.totalPanel.TabIndex = 8;
            // 
            // totalQuantityTextBox
            // 
            this.totalQuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalQuantityTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalQuantityTextBox.Location = new System.Drawing.Point(7, 33);
            this.totalQuantityTextBox.Name = "totalQuantityTextBox";
            this.totalQuantityTextBox.ReadOnly = true;
            this.totalQuantityTextBox.Size = new System.Drawing.Size(52, 18);
            this.totalQuantityTextBox.TabIndex = 5;
            this.totalQuantityTextBox.TabStop = false;
            // 
            // totalSalesTextBox
            // 
            this.totalSalesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalSalesTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesTextBox.Location = new System.Drawing.Point(7, 108);
            this.totalSalesTextBox.Name = "totalSalesTextBox";
            this.totalSalesTextBox.ReadOnly = true;
            this.totalSalesTextBox.Size = new System.Drawing.Size(52, 18);
            this.totalSalesTextBox.TabIndex = 3;
            this.totalSalesTextBox.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Total Quantity:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Total Sales:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(140, 433);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 20);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outOfStockListBox
            // 
            this.outOfStockListBox.BackColor = System.Drawing.SystemColors.Control;
            this.outOfStockListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outOfStockListBox.FormattingEnabled = true;
            this.outOfStockListBox.ItemHeight = 15;
            this.outOfStockListBox.Location = new System.Drawing.Point(128, 313);
            this.outOfStockListBox.Name = "outOfStockListBox";
            this.outOfStockListBox.Size = new System.Drawing.Size(109, 105);
            this.outOfStockListBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 468);
            this.Controls.Add(this.outOfStockListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalPanel);
            this.Controls.Add(this.creamSodaPanel);
            this.Controls.Add(this.grapeSodaPanel);
            this.Controls.Add(this.rootBeerPanel);
            this.Controls.Add(this.lemonLimePanel);
            this.Controls.Add(this.colaPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drink Vending Machine";
            ((System.ComponentModel.ISupportInitialize)(this.colaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lemonLimePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootBeerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creamSodaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grapeSodaPictureBox)).EndInit();
            this.colaPanel.ResumeLayout(false);
            this.colaPanel.PerformLayout();
            this.lemonLimePanel.ResumeLayout(false);
            this.lemonLimePanel.PerformLayout();
            this.rootBeerPanel.ResumeLayout(false);
            this.rootBeerPanel.PerformLayout();
            this.grapeSodaPanel.ResumeLayout(false);
            this.grapeSodaPanel.PerformLayout();
            this.creamSodaPanel.ResumeLayout(false);
            this.creamSodaPanel.PerformLayout();
            this.totalPanel.ResumeLayout(false);
            this.totalPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox colaPictureBox;
        private System.Windows.Forms.PictureBox lemonLimePictureBox;
        private System.Windows.Forms.PictureBox rootBeerPictureBox;
        private System.Windows.Forms.PictureBox creamSodaPictureBox;
        private System.Windows.Forms.PictureBox grapeSodaPictureBox;
        private System.Windows.Forms.Panel colaPanel;
        private System.Windows.Forms.TextBox colaQtyTextBox;
        private System.Windows.Forms.Label colaQtyLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel lemonLimePanel;
        private System.Windows.Forms.TextBox lemonLimeQtyTextBox;
        private System.Windows.Forms.Label lemonLimeQtyLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel rootBeerPanel;
        private System.Windows.Forms.TextBox rootBeerQtyTextBox;
        private System.Windows.Forms.Label rootBeerQtyLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel grapeSodaPanel;
        private System.Windows.Forms.TextBox grapeSodaQtyTextBox;
        private System.Windows.Forms.Label grapeSodaQtyLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel creamSodaPanel;
        private System.Windows.Forms.TextBox creamSodaQtyTextBox;
        private System.Windows.Forms.Label creamSodaQtyLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel totalPanel;
        private System.Windows.Forms.TextBox totalSalesTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox colaPriceTextBox;
        private System.Windows.Forms.TextBox lemonLimePriceTextBox;
        private System.Windows.Forms.TextBox rootBeerPriceTextBox;
        private System.Windows.Forms.TextBox grapeSodaPriceTextBox;
        private System.Windows.Forms.TextBox creamSodaPriceTextBox;
        private System.Windows.Forms.TextBox totalQuantityTextBox;
        private System.Windows.Forms.ListBox outOfStockListBox;
    }
}

