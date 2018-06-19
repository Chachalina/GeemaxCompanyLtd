namespace GeemaxCompany
{
    partial class Categories
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
            this.categoryDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCateClose = new System.Windows.Forms.Button();
            this.btnCateDel = new System.Windows.Forms.Button();
            this.btnCateUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCateNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryDataGrid
            // 
            this.categoryDataGrid.AllowUserToAddRows = false;
            this.categoryDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.categoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.categoryDataGrid.Location = new System.Drawing.Point(30, 79);
            this.categoryDataGrid.Name = "categoryDataGrid";
            this.categoryDataGrid.ReadOnly = true;
            this.categoryDataGrid.Size = new System.Drawing.Size(246, 265);
            this.categoryDataGrid.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Category";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCateClose);
            this.groupBox1.Controls.Add(this.btnCateDel);
            this.groupBox1.Controls.Add(this.btnCateUpdate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCateNew);
            this.groupBox1.Location = new System.Drawing.Point(336, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnCateClose
            // 
            this.btnCateClose.Location = new System.Drawing.Point(21, 203);
            this.btnCateClose.Name = "btnCateClose";
            this.btnCateClose.Size = new System.Drawing.Size(75, 23);
            this.btnCateClose.TabIndex = 4;
            this.btnCateClose.Text = "Close";
            this.btnCateClose.UseVisualStyleBackColor = true;
            // 
            // btnCateDel
            // 
            this.btnCateDel.Location = new System.Drawing.Point(21, 156);
            this.btnCateDel.Name = "btnCateDel";
            this.btnCateDel.Size = new System.Drawing.Size(75, 23);
            this.btnCateDel.TabIndex = 3;
            this.btnCateDel.Text = "Delete";
            this.btnCateDel.UseVisualStyleBackColor = true;
            // 
            // btnCateUpdate
            // 
            this.btnCateUpdate.Location = new System.Drawing.Point(21, 110);
            this.btnCateUpdate.Name = "btnCateUpdate";
            this.btnCateUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCateUpdate.TabIndex = 2;
            this.btnCateUpdate.Text = "Update";
            this.btnCateUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 64);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCateNew
            // 
            this.btnCateNew.Location = new System.Drawing.Point(21, 19);
            this.btnCateNew.Name = "btnCateNew";
            this.btnCateNew.Size = new System.Drawing.Size(75, 23);
            this.btnCateNew.TabIndex = 0;
            this.btnCateNew.Text = "New";
            this.btnCateNew.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category :";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(103, 31);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(173, 20);
            this.txtCategory.TabIndex = 3;
            this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.categoryDataGrid);
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView categoryDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCateClose;
        private System.Windows.Forms.Button btnCateDel;
        private System.Windows.Forms.Button btnCateUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCateNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategory;
    }
}