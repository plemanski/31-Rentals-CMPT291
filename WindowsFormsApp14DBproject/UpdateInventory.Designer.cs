namespace WindowsFormsApp14DBproject
{
    partial class UpdateInventory
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
            this.carIDlabel = new System.Windows.Forms.Label();
            this.carID = new System.Windows.Forms.TextBox();
            this.locID = new System.Windows.Forms.TextBox();
            this.locIDlabel = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.licensePlate = new System.Windows.Forms.TextBox();
            this.licensePlatelabel = new System.Windows.Forms.Label();
            this.make = new System.Windows.Forms.TextBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.typeID = new System.Windows.Forms.TextBox();
            this.typeIDLabel = new System.Windows.Forms.Label();
            this.fkBranchID = new System.Windows.Forms.TextBox();
            this.fkBranchLabel = new System.Windows.Forms.Label();
            this.searchCarsButton = new System.Windows.Forms.Button();
            this.updateCarsButton = new System.Windows.Forms.Button();
            this.deleteCarsButton = new System.Windows.Forms.Button();
            this.dateOfEntryLabel = new System.Windows.Forms.Label();
            this.dateTimeUpdated = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addCarButton = new System.Windows.Forms.Button();
            this.customerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.transactionID = new System.Windows.Forms.TextBox();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.checkInButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // carIDlabel
            // 
            this.carIDlabel.AutoSize = true;
            this.carIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.carIDlabel.Location = new System.Drawing.Point(8, 23);
            this.carIDlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carIDlabel.Name = "carIDlabel";
            this.carIDlabel.Size = new System.Drawing.Size(41, 15);
            this.carIDlabel.TabIndex = 0;
            this.carIDlabel.Text = "Car ID";
            // 
            // carID
            // 
            this.carID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.carID.Location = new System.Drawing.Point(179, 19);
            this.carID.Margin = new System.Windows.Forms.Padding(2);
            this.carID.Name = "carID";
            this.carID.Size = new System.Drawing.Size(239, 21);
            this.carID.TabIndex = 6;
            // 
            // locID
            // 
            this.locID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.locID.Location = new System.Drawing.Point(179, 57);
            this.locID.Margin = new System.Windows.Forms.Padding(2);
            this.locID.Name = "locID";
            this.locID.Size = new System.Drawing.Size(239, 21);
            this.locID.TabIndex = 8;
            // 
            // locIDlabel
            // 
            this.locIDlabel.AutoSize = true;
            this.locIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.locIDlabel.Location = new System.Drawing.Point(9, 60);
            this.locIDlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.locIDlabel.Name = "locIDlabel";
            this.locIDlabel.Size = new System.Drawing.Size(61, 15);
            this.locIDlabel.TabIndex = 7;
            this.locIDlabel.Text = "Branch ID";
            // 
            // color
            // 
            this.color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.color.Location = new System.Drawing.Point(179, 95);
            this.color.Margin = new System.Windows.Forms.Padding(2);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(239, 21);
            this.color.TabIndex = 10;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.colorLabel.Location = new System.Drawing.Point(9, 101);
            this.colorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(36, 15);
            this.colorLabel.TabIndex = 9;
            this.colorLabel.Text = "Color";
            // 
            // licensePlate
            // 
            this.licensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.licensePlate.Location = new System.Drawing.Point(179, 133);
            this.licensePlate.Margin = new System.Windows.Forms.Padding(2);
            this.licensePlate.Name = "licensePlate";
            this.licensePlate.Size = new System.Drawing.Size(239, 21);
            this.licensePlate.TabIndex = 12;
            // 
            // licensePlatelabel
            // 
            this.licensePlatelabel.AutoSize = true;
            this.licensePlatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.licensePlatelabel.Location = new System.Drawing.Point(9, 136);
            this.licensePlatelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.licensePlatelabel.Name = "licensePlatelabel";
            this.licensePlatelabel.Size = new System.Drawing.Size(81, 15);
            this.licensePlatelabel.TabIndex = 11;
            this.licensePlatelabel.Text = "License Plate";
            // 
            // make
            // 
            this.make.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.make.Location = new System.Drawing.Point(179, 170);
            this.make.Margin = new System.Windows.Forms.Padding(2);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(239, 21);
            this.make.TabIndex = 14;
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.makeLabel.Location = new System.Drawing.Point(9, 174);
            this.makeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(38, 15);
            this.makeLabel.TabIndex = 13;
            this.makeLabel.Text = "Make";
            // 
            // typeID
            // 
            this.typeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.typeID.Location = new System.Drawing.Point(179, 208);
            this.typeID.Margin = new System.Windows.Forms.Padding(2);
            this.typeID.Name = "typeID";
            this.typeID.Size = new System.Drawing.Size(239, 21);
            this.typeID.TabIndex = 16;
            // 
            // typeIDLabel
            // 
            this.typeIDLabel.AutoSize = true;
            this.typeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.typeIDLabel.Location = new System.Drawing.Point(9, 212);
            this.typeIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeIDLabel.Name = "typeIDLabel";
            this.typeIDLabel.Size = new System.Drawing.Size(33, 15);
            this.typeIDLabel.TabIndex = 15;
            this.typeIDLabel.Text = "Type";
            // 
            // fkBranchID
            // 
            this.fkBranchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.fkBranchID.Location = new System.Drawing.Point(179, 250);
            this.fkBranchID.Margin = new System.Windows.Forms.Padding(2);
            this.fkBranchID.Name = "fkBranchID";
            this.fkBranchID.Size = new System.Drawing.Size(239, 21);
            this.fkBranchID.TabIndex = 18;
            // 
            // fkBranchLabel
            // 
            this.fkBranchLabel.AutoSize = true;
            this.fkBranchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.fkBranchLabel.Location = new System.Drawing.Point(9, 254);
            this.fkBranchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fkBranchLabel.Name = "fkBranchLabel";
            this.fkBranchLabel.Size = new System.Drawing.Size(139, 15);
            this.fkBranchLabel.TabIndex = 17;
            this.fkBranchLabel.Text = "Current Branch Location";
            // 
            // searchCarsButton
            // 
            this.searchCarsButton.Location = new System.Drawing.Point(437, 208);
            this.searchCarsButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchCarsButton.Name = "searchCarsButton";
            this.searchCarsButton.Size = new System.Drawing.Size(69, 25);
            this.searchCarsButton.TabIndex = 19;
            this.searchCarsButton.Text = "Search";
            this.searchCarsButton.UseVisualStyleBackColor = true;
            // 
            // updateCarsButton
            // 
            this.updateCarsButton.Location = new System.Drawing.Point(437, 250);
            this.updateCarsButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateCarsButton.Name = "updateCarsButton";
            this.updateCarsButton.Size = new System.Drawing.Size(69, 25);
            this.updateCarsButton.TabIndex = 20;
            this.updateCarsButton.Text = "Update";
            this.updateCarsButton.UseVisualStyleBackColor = true;
            // 
            // deleteCarsButton
            // 
            this.deleteCarsButton.Location = new System.Drawing.Point(524, 249);
            this.deleteCarsButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteCarsButton.Name = "deleteCarsButton";
            this.deleteCarsButton.Size = new System.Drawing.Size(69, 25);
            this.deleteCarsButton.TabIndex = 21;
            this.deleteCarsButton.Text = "Delete";
            this.deleteCarsButton.UseVisualStyleBackColor = true;
            // 
            // dateOfEntryLabel
            // 
            this.dateOfEntryLabel.AutoSize = true;
            this.dateOfEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateOfEntryLabel.Location = new System.Drawing.Point(434, 18);
            this.dateOfEntryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateOfEntryLabel.Name = "dateOfEntryLabel";
            this.dateOfEntryLabel.Size = new System.Drawing.Size(33, 15);
            this.dateOfEntryLabel.TabIndex = 22;
            this.dateOfEntryLabel.Text = "Date";
            // 
            // dateTimeUpdated
            // 
            this.dateTimeUpdated.Location = new System.Drawing.Point(553, 16);
            this.dateTimeUpdated.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeUpdated.Name = "dateTimeUpdated";
            this.dateTimeUpdated.Size = new System.Drawing.Size(209, 20);
            this.dateTimeUpdated.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 294);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(719, 214);
            this.dataGridView1.TabIndex = 24;
            // 
            // addCarButton
            // 
            this.addCarButton.Location = new System.Drawing.Point(524, 208);
            this.addCarButton.Margin = new System.Windows.Forms.Padding(2);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(69, 25);
            this.addCarButton.TabIndex = 25;
            this.addCarButton.Text = "Add";
            this.addCarButton.UseVisualStyleBackColor = true;
            // 
            // customerID
            // 
            this.customerID.Location = new System.Drawing.Point(553, 97);
            this.customerID.Margin = new System.Windows.Forms.Padding(2);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(209, 20);
            this.customerID.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Return Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(553, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Customer Name";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(553, 133);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(209, 20);
            this.customerName.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Transaction ID";
            // 
            // transactionID
            // 
            this.transactionID.Location = new System.Drawing.Point(553, 173);
            this.transactionID.Name = "transactionID";
            this.transactionID.Size = new System.Drawing.Size(209, 20);
            this.transactionID.TabIndex = 34;
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(610, 208);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(69, 25);
            this.checkOutButton.TabIndex = 35;
            this.checkOutButton.Text = "Check-Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            
            // 
            // checkInButton
            // 
            this.checkInButton.Location = new System.Drawing.Point(610, 249);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(69, 25);
            this.checkInButton.TabIndex = 36;
            this.checkInButton.Text = "Check-In";
            this.checkInButton.UseVisualStyleBackColor = true;
            this.checkInButton.Click += new System.EventHandler(this.checkInButton_Click);
            // 
            // UpdateInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 519);
            this.Controls.Add(this.checkInButton);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.transactionID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimeUpdated);
            this.Controls.Add(this.dateOfEntryLabel);
            this.Controls.Add(this.deleteCarsButton);
            this.Controls.Add(this.updateCarsButton);
            this.Controls.Add(this.searchCarsButton);
            this.Controls.Add(this.fkBranchID);
            this.Controls.Add(this.fkBranchLabel);
            this.Controls.Add(this.typeID);
            this.Controls.Add(this.typeIDLabel);
            this.Controls.Add(this.make);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.licensePlate);
            this.Controls.Add(this.licensePlatelabel);
            this.Controls.Add(this.color);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.locID);
            this.Controls.Add(this.locIDlabel);
            this.Controls.Add(this.carID);
            this.Controls.Add(this.carIDlabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateInventory";
            this.Text = "UpdateInventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carIDlabel;
        private System.Windows.Forms.TextBox carID;
        private System.Windows.Forms.TextBox locID;
        private System.Windows.Forms.Label locIDlabel;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.TextBox licensePlate;
        private System.Windows.Forms.Label licensePlatelabel;
        private System.Windows.Forms.TextBox make;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.TextBox typeID;
        private System.Windows.Forms.Label typeIDLabel;
        private System.Windows.Forms.TextBox fkBranchID;
        private System.Windows.Forms.Label fkBranchLabel;
        private System.Windows.Forms.Button searchCarsButton;
        private System.Windows.Forms.Button updateCarsButton;
        private System.Windows.Forms.Button deleteCarsButton;
        private System.Windows.Forms.Label dateOfEntryLabel;
        private System.Windows.Forms.DateTimePicker dateTimeUpdated;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox transactionID;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Button checkInButton;
    }
}