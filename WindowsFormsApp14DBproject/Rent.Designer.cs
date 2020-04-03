namespace WindowsFormsApp14DBproject
{
    partial class Rent
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
            this.rentalAngencyTtitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.pickUplabel = new System.Windows.Forms.Label();
            this.returnDatelabel = new System.Windows.Forms.Label();
            this.pickUpLocations = new System.Windows.Forms.ComboBox();
            this.dropOffLocations = new System.Windows.Forms.ComboBox();
            this.pickUp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkDropPickSame = new System.Windows.Forms.CheckBox();
            this.goldStarMember = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pickUptime = new System.Windows.Forms.ComboBox();
            this.returnTime = new System.Windows.Forms.ComboBox();
            this.customerNamelabel = new System.Windows.Forms.Label();
            this.customerNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.termsCheckBox = new System.Windows.Forms.CheckBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.customerIDInput = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourcePrice = new System.Windows.Forms.BindingSource(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // rentalAngencyTtitle
            // 
            this.rentalAngencyTtitle.AutoSize = true;
            this.rentalAngencyTtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.rentalAngencyTtitle.Location = new System.Drawing.Point(232, 5);
            this.rentalAngencyTtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rentalAngencyTtitle.Name = "rentalAngencyTtitle";
            this.rentalAngencyTtitle.Size = new System.Drawing.Size(171, 39);
            this.rentalAngencyTtitle.TabIndex = 0;
            this.rentalAngencyTtitle.Text = "31Rentals";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(235, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cheap Car Rentals!";
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimeBegin.Location = new System.Drawing.Point(11, 153);
            this.dateTimeBegin.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(230, 23);
            this.dateTimeBegin.TabIndex = 2;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimeEnd.Location = new System.Drawing.Point(11, 229);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(226, 23);
            this.dateTimeEnd.TabIndex = 3;
            this.dateTimeEnd.Value = new System.DateTime(2020, 3, 12, 19, 26, 54, 0);
            // 
            // pickUplabel
            // 
            this.pickUplabel.AutoSize = true;
            this.pickUplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pickUplabel.Location = new System.Drawing.Point(8, 116);
            this.pickUplabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pickUplabel.Name = "pickUplabel";
            this.pickUplabel.Size = new System.Drawing.Size(124, 17);
            this.pickUplabel.TabIndex = 4;
            this.pickUplabel.Text = "Pick-up Date/Time";
            // 
            // returnDatelabel
            // 
            this.returnDatelabel.AutoSize = true;
            this.returnDatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.returnDatelabel.Location = new System.Drawing.Point(7, 201);
            this.returnDatelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.returnDatelabel.Name = "returnDatelabel";
            this.returnDatelabel.Size = new System.Drawing.Size(120, 17);
            this.returnDatelabel.TabIndex = 5;
            this.returnDatelabel.Text = "Return Date/Time";
            // 
            // pickUpLocations
            // 
            this.pickUpLocations.FormattingEnabled = true;
            this.pickUpLocations.Items.AddRange(new object[] {
            "         ------ ",
            "Edmonton North",
            "Edmonton Downtown",
            "Calgary South",
            "Calgary Downtown",
            "Vancouver West"});
            this.pickUpLocations.Location = new System.Drawing.Point(11, 308);
            this.pickUpLocations.Margin = new System.Windows.Forms.Padding(2);
            this.pickUpLocations.Name = "pickUpLocations";
            this.pickUpLocations.Size = new System.Drawing.Size(230, 21);
            this.pickUpLocations.TabIndex = 6;
            // 
            // dropOffLocations
            // 
            this.dropOffLocations.FormattingEnabled = true;
            this.dropOffLocations.Items.AddRange(new object[] {
            "       ------ ",
            "Edmonton North",
            "Edmonton Downtown",
            "Calgary South",
            "Calgary Downtown",
            "Vancouver West"});
            this.dropOffLocations.Location = new System.Drawing.Point(11, 376);
            this.dropOffLocations.Margin = new System.Windows.Forms.Padding(2);
            this.dropOffLocations.Name = "dropOffLocations";
            this.dropOffLocations.Size = new System.Drawing.Size(230, 21);
            this.dropOffLocations.TabIndex = 7;
            // 
            // pickUp
            // 
            this.pickUp.AutoSize = true;
            this.pickUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pickUp.Location = new System.Drawing.Point(9, 282);
            this.pickUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pickUp.Name = "pickUp";
            this.pickUp.Size = new System.Drawing.Size(113, 17);
            this.pickUp.TabIndex = 8;
            this.pickUp.Text = "Pick-up Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(8, 348);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Drop-off Location";
            // 
            // checkDropPickSame
            // 
            this.checkDropPickSame.AutoSize = true;
            this.checkDropPickSame.Location = new System.Drawing.Point(11, 409);
            this.checkDropPickSame.Margin = new System.Windows.Forms.Padding(2);
            this.checkDropPickSame.Name = "checkDropPickSame";
            this.checkDropPickSame.Size = new System.Drawing.Size(145, 17);
            this.checkDropPickSame.TabIndex = 10;
            this.checkDropPickSame.Text = "Same as pick-up location";
            this.checkDropPickSame.UseVisualStyleBackColor = true;
            this.checkDropPickSame.CheckedChanged += new System.EventHandler(this.checkDropPickSame_CheckedChanged);
            // 
            // goldStarMember
            // 
            this.goldStarMember.AutoSize = true;
            this.goldStarMember.Location = new System.Drawing.Point(421, 409);
            this.goldStarMember.Margin = new System.Windows.Forms.Padding(2);
            this.goldStarMember.Name = "goldStarMember";
            this.goldStarMember.Size = new System.Drawing.Size(101, 17);
            this.goldStarMember.TabIndex = 11;
            this.goldStarMember.Text = "31Gold Member";
            this.goldStarMember.UseVisualStyleBackColor = true;
            this.goldStarMember.CheckedChanged += new System.EventHandler(this.goldStarMember_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIDDataGridViewTextBoxColumn,
            this.locIDDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn1,
            this.makeDataGridViewTextBoxColumn1,
            this.typeIDDataGridViewTextBoxColumn,
            this.branchIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(423, 116);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(374, 211);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            this.carIDDataGridViewTextBoxColumn.DataPropertyName = "carID";
            this.carIDDataGridViewTextBoxColumn.HeaderText = "carID";
            this.carIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            this.carIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.carIDDataGridViewTextBoxColumn.Visible = false;
            this.carIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // locIDDataGridViewTextBoxColumn
            // 
            this.locIDDataGridViewTextBoxColumn.DataPropertyName = "locID";
            this.locIDDataGridViewTextBoxColumn.HeaderText = "locID";
            this.locIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.locIDDataGridViewTextBoxColumn.Name = "locIDDataGridViewTextBoxColumn";
            this.locIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.locIDDataGridViewTextBoxColumn.Visible = false;
            this.locIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // colorDataGridViewTextBoxColumn1
            // 
            this.colorDataGridViewTextBoxColumn1.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn1.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.colorDataGridViewTextBoxColumn1.Name = "colorDataGridViewTextBoxColumn1";
            this.colorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.colorDataGridViewTextBoxColumn1.Width = 150;
            // 
            // makeDataGridViewTextBoxColumn1
            // 
            this.makeDataGridViewTextBoxColumn1.DataPropertyName = "make";
            this.makeDataGridViewTextBoxColumn1.HeaderText = "make";
            this.makeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.makeDataGridViewTextBoxColumn1.Name = "makeDataGridViewTextBoxColumn1";
            this.makeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.makeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // typeIDDataGridViewTextBoxColumn
            // 
            this.typeIDDataGridViewTextBoxColumn.DataPropertyName = "typeID";
            this.typeIDDataGridViewTextBoxColumn.HeaderText = "typeID";
            this.typeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeIDDataGridViewTextBoxColumn.Name = "typeIDDataGridViewTextBoxColumn";
            this.typeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeIDDataGridViewTextBoxColumn.Visible = false;
            this.typeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "branchID";
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "branchID";
            this.branchIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            this.branchIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.branchIDDataGridViewTextBoxColumn.Visible = false;
            this.branchIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(WindowsFormsApp14DBproject.Car);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(9, 450);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(104, 32);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 450);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "Rent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pickUptime
            // 
            this.pickUptime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pickUptime.FormattingEnabled = true;
            this.pickUptime.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00"});
            this.pickUptime.Location = new System.Drawing.Point(266, 151);
            this.pickUptime.Margin = new System.Windows.Forms.Padding(2);
            this.pickUptime.Name = "pickUptime";
            this.pickUptime.Size = new System.Drawing.Size(145, 24);
            this.pickUptime.TabIndex = 18;
            // 
            // returnTime
            // 
            this.returnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.returnTime.FormattingEnabled = true;
            this.returnTime.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00"});
            this.returnTime.Location = new System.Drawing.Point(266, 227);
            this.returnTime.Margin = new System.Windows.Forms.Padding(2);
            this.returnTime.Name = "returnTime";
            this.returnTime.Size = new System.Drawing.Size(145, 24);
            this.returnTime.TabIndex = 19;
            // 
            // customerNamelabel
            // 
            this.customerNamelabel.AutoSize = true;
            this.customerNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customerNamelabel.Location = new System.Drawing.Point(418, 378);
            this.customerNamelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNamelabel.Name = "customerNamelabel";
            this.customerNamelabel.Size = new System.Drawing.Size(45, 17);
            this.customerNamelabel.TabIndex = 20;
            this.customerNamelabel.Text = "Name";
            // 
            // customerNameInput
            // 
            this.customerNameInput.Location = new System.Drawing.Point(473, 378);
            this.customerNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.Size = new System.Drawing.Size(189, 20);
            this.customerNameInput.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 328);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "*Make a Selection";
            // 
            // termsCheckBox
            // 
            this.termsCheckBox.AutoSize = true;
            this.termsCheckBox.Location = new System.Drawing.Point(421, 429);
            this.termsCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.termsCheckBox.Name = "termsCheckBox";
            this.termsCheckBox.Size = new System.Drawing.Size(313, 17);
            this.termsCheckBox.TabIndex = 23;
            this.termsCheckBox.Text = "I\'ve reviewed and agree with 31Rentals terms and conditions";
            this.termsCheckBox.UseVisualStyleBackColor = true;
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "make";
            this.makeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            this.makeDataGridViewTextBoxColumn.Width = 150;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(665, 378);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "31Gold Member ID";
            // 
            // customerIDInput
            // 
            this.customerIDInput.Location = new System.Drawing.Point(775, 376);
            this.customerIDInput.Margin = new System.Windows.Forms.Padding(2);
            this.customerIDInput.Name = "customerIDInput";
            this.customerIDInput.Size = new System.Drawing.Size(169, 20);
            this.customerIDInput.TabIndex = 25;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsFormsApp14DBproject.Car);
            // 
            // bindingSourcePrice
            // 
            this.bindingSourcePrice.DataSource = typeof(WindowsFormsApp14DBproject.Type);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label16.Location = new System.Drawing.Point(819, 266);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "SUV";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label15.Location = new System.Drawing.Point(819, 228);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Crossover";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label14.Location = new System.Drawing.Point(819, 192);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Midsize";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label13.Location = new System.Drawing.Point(819, 157);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Compact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label5.Location = new System.Drawing.Point(897, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "$22";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label6.Location = new System.Drawing.Point(897, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "$20";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label7.Location = new System.Drawing.Point(897, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "$15";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label8.Location = new System.Drawing.Point(897, 157);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "$10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label9.Location = new System.Drawing.Point(956, 268);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "$154";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label10.Location = new System.Drawing.Point(955, 228);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "$140";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label11.Location = new System.Drawing.Point(956, 192);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "$105";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label12.Location = new System.Drawing.Point(955, 157);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "$70";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label17.Location = new System.Drawing.Point(1013, 268);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 53;
            this.label17.Text = "$660";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label18.Location = new System.Drawing.Point(1012, 228);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 52;
            this.label18.Text = "$600";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label19.Location = new System.Drawing.Point(1013, 192);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 51;
            this.label19.Text = "$450";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label20.Location = new System.Drawing.Point(1012, 157);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 50;
            this.label20.Text = "$300";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(884, 105);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 15);
            this.label21.TabIndex = 54;
            this.label21.Text = "Our Rates";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label22.Location = new System.Drawing.Point(892, 129);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 13);
            this.label22.TabIndex = 55;
            this.label22.Text = "Daily";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label23.Location = new System.Drawing.Point(944, 129);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 13);
            this.label23.TabIndex = 56;
            this.label23.Text = "Weekly";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label24.Location = new System.Drawing.Point(1000, 129);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 57;
            this.label24.Text = "Monthly";
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 569);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.customerIDInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.termsCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerNameInput);
            this.Controls.Add(this.customerNamelabel);
            this.Controls.Add(this.returnTime);
            this.Controls.Add(this.pickUptime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.goldStarMember);
            this.Controls.Add(this.checkDropPickSame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pickUp);
            this.Controls.Add(this.dropOffLocations);
            this.Controls.Add(this.pickUpLocations);
            this.Controls.Add(this.returnDatelabel);
            this.Controls.Add(this.pickUplabel);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.dateTimeBegin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rentalAngencyTtitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Rent";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Rent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rentalAngencyTtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label pickUplabel;
        private System.Windows.Forms.Label returnDatelabel;
        private System.Windows.Forms.ComboBox pickUpLocations;
        private System.Windows.Forms.ComboBox dropOffLocations;
        private System.Windows.Forms.Label pickUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkDropPickSame;
        private System.Windows.Forms.CheckBox goldStarMember;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox pickUptime;
        private System.Windows.Forms.ComboBox returnTime;
        private System.Windows.Forms.Label customerNamelabel;
        private System.Windows.Forms.TextBox customerNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox termsCheckBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSourcePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerIDInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
    }
}