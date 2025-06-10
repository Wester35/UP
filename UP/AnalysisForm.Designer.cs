namespace UP
{
    partial class AnalysisForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.deleteIDButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1155, 535);
            this.dataGridView1.TabIndex = 0;
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.Location = new System.Drawing.Point(12, 554);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(381, 32);
            this.deleteAllButton.TabIndex = 1;
            this.deleteAllButton.Text = "Удалить ВСЕ";
            this.deleteAllButton.UseVisualStyleBackColor = true;
            this.deleteAllButton.Click += new System.EventHandler(this.deleteAllButton_Click);
            // 
            // deleteIDButton
            // 
            this.deleteIDButton.Location = new System.Drawing.Point(399, 554);
            this.deleteIDButton.Name = "deleteIDButton";
            this.deleteIDButton.Size = new System.Drawing.Size(381, 32);
            this.deleteIDButton.TabIndex = 2;
            this.deleteIDButton.Text = "Удалить по ID";
            this.deleteIDButton.UseVisualStyleBackColor = true;
            this.deleteIDButton.Click += new System.EventHandler(this.deleteIDButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(786, 554);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(381, 32);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Загрузить по ID";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // databaseHelperBindingSource1
            // 
            this.databaseHelperBindingSource1.DataSource = typeof(DatabaseHelper);
            // 
            // databaseHelperBindingSource
            // 
            this.databaseHelperBindingSource.DataSource = typeof(DatabaseHelper);
            // 
            // AnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 595);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.deleteIDButton);
            this.Controls.Add(this.deleteAllButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AnalysisForm";
            this.Text = "AnalysisForm";
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
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.BindingSource databaseHelperBindingSource1;
    }
}