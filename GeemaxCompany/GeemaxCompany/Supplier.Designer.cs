namespace GeemaxCompany
{
    partial class Supplier
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geemaxInventoryCityDataSet1 = new GeemaxCompany.geemaxInventoryCityDataSet1();
            this.cmbSupState = new System.Windows.Forms.ComboBox();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geemaxInventoryDataSet = new GeemaxCompany.geemaxInventoryDataSet();
            this.txtSupRemarks = new System.Windows.Forms.TextBox();
            this.txtSupEmail = new System.Windows.Forms.TextBox();
            this.txtSupContact = new System.Windows.Forms.TextBox();
            this.txtSupAddress = new System.Windows.Forms.TextBox();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.txtSupWebsite = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetCustomers = new System.Windows.Forms.Button();
            this.btnSupClose = new System.Windows.Forms.Button();
            this.btnSupDelete = new System.Windows.Forms.Button();
            this.btnSupUpdate = new System.Windows.Forms.Button();
            this.btnSupSave = new System.Windows.Forms.Button();
            this.btnSupNew = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.statesTableAdapter = new GeemaxCompany.geemaxInventoryDataSetTableAdapters.statesTableAdapter();
            this.geemaxInventoryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiesTableAdapter = new GeemaxCompany.geemaxInventoryCityDataSet1TableAdapters.CitiesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geemaxInventoryCityDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geemaxInventoryDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geemaxInventoryDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCity);
            this.groupBox1.Controls.Add(this.cmbSupState);
            this.groupBox1.Controls.Add(this.txtSupRemarks);
            this.groupBox1.Controls.Add(this.txtSupEmail);
            this.groupBox1.Controls.Add(this.txtSupContact);
            this.groupBox1.Controls.Add(this.txtSupAddress);
            this.groupBox1.Controls.Add(this.txtSupName);
            this.groupBox1.Controls.Add(this.txtSupWebsite);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(25, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbCity
            // 
            this.cmbCity.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.geemaxInventoryCityDataSet1, "Cities.city_id", true));
            this.cmbCity.DataSource = this.citiesBindingSource;
            this.cmbCity.DisplayMember = "city_name";
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(162, 110);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(177, 21);
            this.cmbCity.TabIndex = 17;
            this.cmbCity.ValueMember = "city_id";
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.geemaxInventoryCityDataSet1;
            // 
            // geemaxInventoryCityDataSet1
            // 
            this.geemaxInventoryCityDataSet1.DataSetName = "geemaxInventoryCityDataSet1";
            this.geemaxInventoryCityDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbSupState
            // 
            this.cmbSupState.DataSource = this.statesBindingSource;
            this.cmbSupState.DisplayMember = "state_name";
            this.cmbSupState.FormattingEnabled = true;
            this.cmbSupState.Location = new System.Drawing.Point(162, 145);
            this.cmbSupState.Name = "cmbSupState";
            this.cmbSupState.Size = new System.Drawing.Size(177, 21);
            this.cmbSupState.TabIndex = 16;
            this.cmbSupState.ValueMember = "state_name";
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "states";
            this.statesBindingSource.DataSource = this.geemaxInventoryDataSet;
            // 
            // geemaxInventoryDataSet
            // 
            this.geemaxInventoryDataSet.DataSetName = "geemaxInventoryDataSet";
            this.geemaxInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSupRemarks
            // 
            this.txtSupRemarks.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtSupRemarks.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSupRemarks.Location = new System.Drawing.Point(162, 325);
            this.txtSupRemarks.Multiline = true;
            this.txtSupRemarks.Name = "txtSupRemarks";
            this.txtSupRemarks.Size = new System.Drawing.Size(420, 84);
            this.txtSupRemarks.TabIndex = 15;
            // 
            // txtSupEmail
            // 
            this.txtSupEmail.Location = new System.Drawing.Point(162, 232);
            this.txtSupEmail.Multiline = true;
            this.txtSupEmail.Name = "txtSupEmail";
            this.txtSupEmail.Size = new System.Drawing.Size(177, 20);
            this.txtSupEmail.TabIndex = 14;
            // 
            // txtSupContact
            // 
            this.txtSupContact.Location = new System.Drawing.Point(162, 189);
            this.txtSupContact.Multiline = true;
            this.txtSupContact.Name = "txtSupContact";
            this.txtSupContact.Size = new System.Drawing.Size(177, 20);
            this.txtSupContact.TabIndex = 13;
            // 
            // txtSupAddress
            // 
            this.txtSupAddress.Location = new System.Drawing.Point(162, 63);
            this.txtSupAddress.Multiline = true;
            this.txtSupAddress.Name = "txtSupAddress";
            this.txtSupAddress.Size = new System.Drawing.Size(365, 20);
            this.txtSupAddress.TabIndex = 10;
            // 
            // txtSupName
            // 
            this.txtSupName.Location = new System.Drawing.Point(162, 18);
            this.txtSupName.Multiline = true;
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(305, 20);
            this.txtSupName.TabIndex = 9;
            // 
            // txtSupWebsite
            // 
            this.txtSupWebsite.Location = new System.Drawing.Point(162, 273);
            this.txtSupWebsite.Name = "txtSupWebsite";
            this.txtSupWebsite.Size = new System.Drawing.Size(177, 20);
            this.txtSupWebsite.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email Address :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contact No. :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "State :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "City : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Remarks :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Full Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Website :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetCustomers);
            this.groupBox2.Controls.Add(this.btnSupClose);
            this.groupBox2.Controls.Add(this.btnSupDelete);
            this.groupBox2.Controls.Add(this.btnSupUpdate);
            this.groupBox2.Controls.Add(this.btnSupSave);
            this.groupBox2.Controls.Add(this.btnSupNew);
            this.groupBox2.Location = new System.Drawing.Point(636, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnGetCustomers
            // 
            this.btnGetCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(75)))));
            this.btnGetCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetCustomers.ForeColor = System.Drawing.Color.White;
            this.btnGetCustomers.Location = new System.Drawing.Point(26, 153);
            this.btnGetCustomers.Name = "btnGetCustomers";
            this.btnGetCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnGetCustomers.TabIndex = 5;
            this.btnGetCustomers.Text = "Suppliers";
            this.btnGetCustomers.UseVisualStyleBackColor = false;
            // 
            // btnSupClose
            // 
            this.btnSupClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(75)))));
            this.btnSupClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupClose.ForeColor = System.Drawing.Color.White;
            this.btnSupClose.Location = new System.Drawing.Point(26, 239);
            this.btnSupClose.Name = "btnSupClose";
            this.btnSupClose.Size = new System.Drawing.Size(75, 23);
            this.btnSupClose.TabIndex = 4;
            this.btnSupClose.Text = "Close";
            this.btnSupClose.UseVisualStyleBackColor = false;
            // 
            // btnSupDelete
            // 
            this.btnSupDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(75)))));
            this.btnSupDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupDelete.ForeColor = System.Drawing.Color.White;
            this.btnSupDelete.Location = new System.Drawing.Point(26, 195);
            this.btnSupDelete.Name = "btnSupDelete";
            this.btnSupDelete.Size = new System.Drawing.Size(75, 23);
            this.btnSupDelete.TabIndex = 3;
            this.btnSupDelete.Text = "Delete";
            this.btnSupDelete.UseVisualStyleBackColor = false;
            // 
            // btnSupUpdate
            // 
            this.btnSupUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(75)))));
            this.btnSupUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupUpdate.ForeColor = System.Drawing.Color.White;
            this.btnSupUpdate.Location = new System.Drawing.Point(26, 107);
            this.btnSupUpdate.Name = "btnSupUpdate";
            this.btnSupUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnSupUpdate.TabIndex = 2;
            this.btnSupUpdate.Text = "Update";
            this.btnSupUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSupSave
            // 
            this.btnSupSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(75)))));
            this.btnSupSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupSave.ForeColor = System.Drawing.Color.White;
            this.btnSupSave.Location = new System.Drawing.Point(26, 61);
            this.btnSupSave.Name = "btnSupSave";
            this.btnSupSave.Size = new System.Drawing.Size(75, 23);
            this.btnSupSave.TabIndex = 1;
            this.btnSupSave.Text = "Save";
            this.btnSupSave.UseVisualStyleBackColor = false;
            this.btnSupSave.Click += new System.EventHandler(this.btnSupSave_Click);
            // 
            // btnSupNew
            // 
            this.btnSupNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(75)))));
            this.btnSupNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupNew.ForeColor = System.Drawing.Color.White;
            this.btnSupNew.Location = new System.Drawing.Point(26, 19);
            this.btnSupNew.Name = "btnSupNew";
            this.btnSupNew.Size = new System.Drawing.Size(75, 23);
            this.btnSupNew.TabIndex = 0;
            this.btnSupNew.Text = "New";
            this.btnSupNew.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(75)))));
            this.textBox5.Location = new System.Drawing.Point(25, 12);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(736, 44);
            this.textBox5.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(75)))));
            this.label9.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(344, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 27);
            this.label9.TabIndex = 3;
            this.label9.Text = "Supplier Entry";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // geemaxInventoryDataSetBindingSource
            // 
            this.geemaxInventoryDataSetBindingSource.DataSource = this.geemaxInventoryDataSet;
            this.geemaxInventoryDataSetBindingSource.Position = 0;
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 495);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geemaxInventoryCityDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geemaxInventoryDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.geemaxInventoryDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSupClose;
        private System.Windows.Forms.Button btnSupDelete;
        private System.Windows.Forms.Button btnSupUpdate;
        private System.Windows.Forms.Button btnSupSave;
        private System.Windows.Forms.Button btnSupNew;
        private System.Windows.Forms.ComboBox cmbSupState;
        private System.Windows.Forms.TextBox txtSupRemarks;
        private System.Windows.Forms.TextBox txtSupEmail;
        private System.Windows.Forms.TextBox txtSupContact;
        private System.Windows.Forms.TextBox txtSupAddress;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.TextBox txtSupWebsite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetCustomers;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private geemaxInventoryDataSet geemaxInventoryDataSet;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private geemaxInventoryDataSetTableAdapters.statesTableAdapter statesTableAdapter;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.BindingSource geemaxInventoryDataSetBindingSource;
        private geemaxInventoryCityDataSet1 geemaxInventoryCityDataSet1;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private geemaxInventoryCityDataSet1TableAdapters.CitiesTableAdapter citiesTableAdapter;
    }
}