namespace UP
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.deleteIDButton = new System.Windows.Forms.Button();
            this.databaseHelperBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseHelperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseHelperBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseHelperBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(866, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.Location = new System.Drawing.Point(9, 450);
            this.deleteAllButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(286, 26);
            this.deleteAllButton.TabIndex = 1;
            this.deleteAllButton.Text = "Удалить ВСЕ";
            this.deleteAllButton.UseVisualStyleBackColor = true;
            this.deleteAllButton.Click += new System.EventHandler(this.deleteAllButton_Click);
            // 
            // deleteIDButton
            // 
            this.deleteIDButton.Location = new System.Drawing.Point(590, 450);
            this.deleteIDButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteIDButton.Name = "deleteIDButton";
            this.deleteIDButton.Size = new System.Drawing.Size(286, 26);
            this.deleteIDButton.TabIndex = 2;
            this.deleteIDButton.Text = "Удалить по ID";
            this.deleteIDButton.UseVisualStyleBackColor = true;
            this.deleteIDButton.Click += new System.EventHandler(this.deleteIDButton_Click);
            // 
            // databaseHelperBindingSource1
            // 
            this.databaseHelperBindingSource1.DataSource = typeof(UP.DatabaseHelper);
            // 
            // databaseHelperBindingSource
            // 
            this.databaseHelperBindingSource.DataSource = typeof(UP.DatabaseHelper);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 483);
            this.Controls.Add(this.deleteIDButton);
            this.Controls.Add(this.deleteAllButton);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HistoryForm";
            this.Text = "Результаты";
            this.Load += new System.EventHandler(this.AnalysisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseHelperBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseHelperBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource databaseHelperBindingSource;
        private System.Windows.Forms.Button deleteAllButton;
        private System.Windows.Forms.Button deleteIDButton;
        private System.Windows.Forms.BindingSource databaseHelperBindingSource1;
    }
}