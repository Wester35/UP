using System.Drawing;
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // x0Box
            // 
            this.x0Box.Location = new System.Drawing.Point(21, 11);
            this.x0Box.Margin = new System.Windows.Forms.Padding(2);
            this.x0Box.Name = "x0Box";
            this.x0Box.Size = new System.Drawing.Size(76, 20);
            this.x0Box.TabIndex = 0;
            this.x0Box.Text = "x0";
            // 
            // y0Box
            // 
            this.y0Box.Location = new System.Drawing.Point(21, 35);
            this.y0Box.Margin = new System.Windows.Forms.Padding(2);
            this.y0Box.Name = "y0Box";
            this.y0Box.Size = new System.Drawing.Size(76, 20);
            this.y0Box.TabIndex = 1;
            // 
            // rBox
            // 
            this.rBox.Location = new System.Drawing.Point(101, 11);
            this.rBox.Margin = new System.Windows.Forms.Padding(2);
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(76, 20);
            this.rBox.TabIndex = 2;
            // 
            // cBox
            // 
            this.cBox.Location = new System.Drawing.Point(101, 35);
            this.cBox.Margin = new System.Windows.Forms.Padding(2);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(76, 20);
            this.cBox.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(21, 60);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(156, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // buttonRes
            // 
            this.buttonRes.Location = new System.Drawing.Point(21, 149);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(75, 23);
            this.buttonRes.TabIndex = 6;
            this.buttonRes.Text = "Вычислить";
            this.buttonRes.UseVisualStyleBackColor = true;
            this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(102, 149);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(197, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(883, 699);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // formulaResultLabel
            // 
            this.formulaResultLabel.Location = new System.Drawing.Point(21, 264);
            this.formulaResultLabel.Name = "formulaResultLabel";
            this.formulaResultLabel.ReadOnly = true;
            this.formulaResultLabel.Size = new System.Drawing.Size(156, 20);
            this.formulaResultLabel.TabIndex = 9;
            // 
            // monteCarloResultLabel
            // 
            this.monteCarloResultLabel.Location = new System.Drawing.Point(21, 290);
            this.monteCarloResultLabel.Name = "monteCarloResultLabel";
            this.monteCarloResultLabel.ReadOnly = true;
            this.monteCarloResultLabel.Size = new System.Drawing.Size(156, 20);
            this.monteCarloResultLabel.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 715);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}