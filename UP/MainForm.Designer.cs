﻿using System.Drawing;
using System;

namespace UP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.x0Box = new System.Windows.Forms.TextBox();
            this.y0Box = new System.Windows.Forms.TextBox();
            this.rBox = new System.Windows.Forms.TextBox();
            this.cBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonRes = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formulaResultLabel = new System.Windows.Forms.TextBox();
            this.monteCarloResultLabel = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolAnalisys = new System.Windows.Forms.ToolStripLabel();
            this.toolHelp = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.loadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // x0Box
            // 
            this.x0Box.Location = new System.Drawing.Point(9, 32);
            this.x0Box.Margin = new System.Windows.Forms.Padding(2);
            this.x0Box.Name = "x0Box";
            this.x0Box.Size = new System.Drawing.Size(76, 20);
            this.x0Box.TabIndex = 0;
            this.x0Box.Text = "x0";
            // 
            // y0Box
            // 
            this.y0Box.Location = new System.Drawing.Point(9, 55);
            this.y0Box.Margin = new System.Windows.Forms.Padding(2);
            this.y0Box.Name = "y0Box";
            this.y0Box.Size = new System.Drawing.Size(76, 20);
            this.y0Box.TabIndex = 1;
            // 
            // rBox
            // 
            this.rBox.Location = new System.Drawing.Point(89, 32);
            this.rBox.Margin = new System.Windows.Forms.Padding(2);
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(76, 20);
            this.rBox.TabIndex = 2;
            // 
            // cBox
            // 
            this.cBox.Location = new System.Drawing.Point(89, 55);
            this.cBox.Margin = new System.Windows.Forms.Padding(2);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(76, 20);
            this.cBox.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(9, 80);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(156, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // buttonRes
            // 
            this.buttonRes.Location = new System.Drawing.Point(9, 169);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(75, 23);
            this.buttonRes.TabIndex = 6;
            this.buttonRes.Text = "Вычислить";
            this.buttonRes.UseVisualStyleBackColor = true;
            this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(90, 169);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(179, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(883, 610);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // formulaResultLabel
            // 
            this.formulaResultLabel.Location = new System.Drawing.Point(9, 275);
            this.formulaResultLabel.Name = "formulaResultLabel";
            this.formulaResultLabel.ReadOnly = true;
            this.formulaResultLabel.Size = new System.Drawing.Size(156, 20);
            this.formulaResultLabel.TabIndex = 9;
            // 
            // monteCarloResultLabel
            // 
            this.monteCarloResultLabel.Location = new System.Drawing.Point(9, 301);
            this.monteCarloResultLabel.Name = "monteCarloResultLabel";
            this.monteCarloResultLabel.ReadOnly = true;
            this.monteCarloResultLabel.Size = new System.Drawing.Size(156, 20);
            this.monteCarloResultLabel.TabIndex = 10;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolAnalisys,
            this.toolHelp,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1102, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(107, 22);
            this.toolStripLabel1.Text = "История расчетов";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolAnalisys
            // 
            this.toolAnalisys.Name = "toolAnalisys";
            this.toolAnalisys.Size = new System.Drawing.Size(47, 22);
            this.toolAnalisys.Text = "Анализ";
            this.toolAnalisys.Click += new System.EventHandler(this.toolAnalisys_Click);
            // 
            // toolHelp
            // 
            this.toolHelp.Name = "toolHelp";
            this.toolHelp.Size = new System.Drawing.Size(53, 22);
            this.toolHelp.Text = "Справка";
            this.toolHelp.Click += new System.EventHandler(this.toolHelp_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(82, 22);
            this.toolStripLabel2.Text = "О программе";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(9, 342);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(156, 33);
            this.loadButton.TabIndex = 12;
            this.loadButton.Text = "Загрузить по ID";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 663);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.monteCarloResultLabel);
            this.Controls.Add(this.formulaResultLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.rBox);
            this.Controls.Add(this.y0Box);
            this.Controls.Add(this.x0Box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x0Box;
        private System.Windows.Forms.TextBox y0Box;
        private System.Windows.Forms.TextBox rBox;
        private System.Windows.Forms.TextBox cBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonRes;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox formulaResultLabel;
        private System.Windows.Forms.TextBox monteCarloResultLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ToolStripLabel toolAnalisys;
        private System.Windows.Forms.ToolStripLabel toolHelp;
    }
}