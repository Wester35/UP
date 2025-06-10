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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // x0Box
            // 
            this.x0Box.Location = new System.Drawing.Point(12, 39);
            this.x0Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.x0Box.Name = "x0Box";
            this.x0Box.Size = new System.Drawing.Size(100, 22);
            this.x0Box.TabIndex = 0;
            this.x0Box.Text = "x0";
            // 
            // y0Box
            // 
            this.y0Box.Location = new System.Drawing.Point(12, 68);
            this.y0Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.y0Box.Name = "y0Box";
            this.y0Box.Size = new System.Drawing.Size(100, 22);
            this.y0Box.TabIndex = 1;
            // 
            // rBox
            // 
            this.rBox.Location = new System.Drawing.Point(119, 39);
            this.rBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(100, 22);
            this.rBox.TabIndex = 2;
            // 
            // cBox
            // 
            this.cBox.Location = new System.Drawing.Point(119, 68);
            this.cBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(100, 22);
            this.cBox.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 131);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 99);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(208, 22);
            this.numericUpDown1.TabIndex = 5;
            // 
            // buttonRes
            // 
            this.buttonRes.Location = new System.Drawing.Point(12, 208);
            this.buttonRes.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(100, 28);
            this.buttonRes.TabIndex = 6;
            this.buttonRes.Text = "Вычислить";
            this.buttonRes.UseVisualStyleBackColor = true;
            this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(120, 208);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 28);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(239, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1177, 751);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // formulaResultLabel
            // 
            this.formulaResultLabel.Location = new System.Drawing.Point(12, 338);
            this.formulaResultLabel.Margin = new System.Windows.Forms.Padding(4);
            this.formulaResultLabel.Name = "formulaResultLabel";
            this.formulaResultLabel.ReadOnly = true;
            this.formulaResultLabel.Size = new System.Drawing.Size(207, 22);
            this.formulaResultLabel.TabIndex = 9;
            // 
            // monteCarloResultLabel
            // 
            this.monteCarloResultLabel.Location = new System.Drawing.Point(12, 370);
            this.monteCarloResultLabel.Margin = new System.Windows.Forms.Padding(4);
            this.monteCarloResultLabel.Name = "monteCarloResultLabel";
            this.monteCarloResultLabel.ReadOnly = true;
            this.monteCarloResultLabel.Size = new System.Drawing.Size(207, 22);
            this.monteCarloResultLabel.TabIndex = 10;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1470, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "Analysis";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel2.Text = "About";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 816);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
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
    }
}