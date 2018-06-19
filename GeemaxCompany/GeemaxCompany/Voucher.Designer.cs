namespace GeemaxCompany
{
    partial class Voucher
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.voucherDataGrid = new System.Windows.Forms.DataGridView();
            this.btnVoucherNew = new System.Windows.Forms.Button();
            this.btnVoucherSave = new System.Windows.Forms.Button();
            this.btnVsaveNprint = new System.Windows.Forms.Button();
            this.btnVouUpdate = new System.Windows.Forms.Button();
            this.btnVouDelete = new System.Windows.Forms.Button();
            this.btnVouClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddtoGrid = new System.Windows.Forms.Button();
            this.btnVouRemove = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voucherDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voucher Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.btnVouRemove);
            this.groupBox2.Controls.Add(this.btnAddtoGrid);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVouClose);
            this.groupBox3.Controls.Add(this.btnVouDelete);
            this.groupBox3.Controls.Add(this.btnVouUpdate);
            this.groupBox3.Controls.Add(this.btnVsaveNprint);
            this.groupBox3.Controls.Add(this.btnVoucherSave);
            this.groupBox3.Controls.Add(this.btnVoucherNew);
            this.groupBox3.Location = new System.Drawing.Point(562, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(126, 307);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // voucherDataGrid
            // 
            this.voucherDataGrid.AllowUserToAddRows = false;
            this.voucherDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.voucherDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.voucherDataGrid.Location = new System.Drawing.Point(12, 396);
            this.voucherDataGrid.Name = "voucherDataGrid";
            this.voucherDataGrid.Size = new System.Drawing.Size(544, 150);
            this.voucherDataGrid.TabIndex = 3;
            // 
            // btnVoucherNew
            // 
            this.btnVoucherNew.Location = new System.Drawing.Point(22, 31);
            this.btnVoucherNew.Name = "btnVoucherNew";
            this.btnVoucherNew.Size = new System.Drawing.Size(75, 23);
            this.btnVoucherNew.TabIndex = 0;
            this.btnVoucherNew.Text = "New";
            this.btnVoucherNew.UseVisualStyleBackColor = true;
            // 
            // btnVoucherSave
            // 
            this.btnVoucherSave.Location = new System.Drawing.Point(22, 73);
            this.btnVoucherSave.Name = "btnVoucherSave";
            this.btnVoucherSave.Size = new System.Drawing.Size(75, 23);
            this.btnVoucherSave.TabIndex = 1;
            this.btnVoucherSave.Text = "Save";
            this.btnVoucherSave.UseVisualStyleBackColor = true;
            // 
            // btnVsaveNprint
            // 
            this.btnVsaveNprint.Location = new System.Drawing.Point(22, 118);
            this.btnVsaveNprint.Name = "btnVsaveNprint";
            this.btnVsaveNprint.Size = new System.Drawing.Size(88, 23);
            this.btnVsaveNprint.TabIndex = 2;
            this.btnVsaveNprint.Text = "Save and Print";
            this.btnVsaveNprint.UseVisualStyleBackColor = true;
            // 
            // btnVouUpdate
            // 
            this.btnVouUpdate.Location = new System.Drawing.Point(22, 165);
            this.btnVouUpdate.Name = "btnVouUpdate";
            this.btnVouUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnVouUpdate.TabIndex = 3;
            this.btnVouUpdate.Text = "Update";
            this.btnVouUpdate.UseVisualStyleBackColor = true;
            // 
            // btnVouDelete
            // 
            this.btnVouDelete.Location = new System.Drawing.Point(22, 209);
            this.btnVouDelete.Name = "btnVouDelete";
            this.btnVouDelete.Size = new System.Drawing.Size(75, 23);
            this.btnVouDelete.TabIndex = 4;
            this.btnVouDelete.Text = "Delete";
            this.btnVouDelete.UseVisualStyleBackColor = true;
            // 
            // btnVouClose
            // 
            this.btnVouClose.Location = new System.Drawing.Point(22, 259);
            this.btnVouClose.Name = "btnVouClose";
            this.btnVouClose.Size = new System.Drawing.Size(75, 23);
            this.btnVouClose.TabIndex = 5;
            this.btnVouClose.Text = "Close";
            this.btnVouClose.UseVisualStyleBackColor = true;
            this.btnVouClose.Click += new System.EventHandler(this.btnVouClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voucer No.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Details :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Particulars :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Amount :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Notes :";
            // 
            // btnAddtoGrid
            // 
            this.btnAddtoGrid.Location = new System.Drawing.Point(361, 19);
            this.btnAddtoGrid.Name = "btnAddtoGrid";
            this.btnAddtoGrid.Size = new System.Drawing.Size(75, 23);
            this.btnAddtoGrid.TabIndex = 3;
            this.btnAddtoGrid.Text = "Add To Grid";
            this.btnAddtoGrid.UseVisualStyleBackColor = true;
            // 
            // btnVouRemove
            // 
            this.btnVouRemove.Location = new System.Drawing.Point(463, 19);
            this.btnVouRemove.Name = "btnVouRemove";
            this.btnVouRemove.Size = new System.Drawing.Size(75, 23);
            this.btnVouRemove.TabIndex = 4;
            this.btnVouRemove.Text = "Remove";
            this.btnVouRemove.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 147);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 50);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(144, 35);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(144, 78);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(144, 118);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 45);
            this.textBox6.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Particulars";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Amount";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Details";
            this.Column3.Name = "Column3";
            // 
            // Voucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 558);
            this.Controls.Add(this.voucherDataGrid);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Voucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voucher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.voucherDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView voucherDataGrid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnVouRemove;
        private System.Windows.Forms.Button btnAddtoGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVouClose;
        private System.Windows.Forms.Button btnVouDelete;
        private System.Windows.Forms.Button btnVouUpdate;
        private System.Windows.Forms.Button btnVsaveNprint;
        private System.Windows.Forms.Button btnVoucherSave;
        private System.Windows.Forms.Button btnVoucherNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}