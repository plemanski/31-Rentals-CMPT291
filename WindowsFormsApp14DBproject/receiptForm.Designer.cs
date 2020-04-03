namespace WindowsFormsApp14DBproject
{
    partial class receiptForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.rentalDateLabel = new System.Windows.Forms.Label();
            this.rentalPeriod = new System.Windows.Forms.Label();
            this.carDetailLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(8, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Success! Here is confirmation of your reservation!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(8, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(8, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rental Dates:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(8, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rental Period:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(8, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Car Detail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(8, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label7.Location = new System.Drawing.Point(8, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "31Rentals";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customerNameLabel.Location = new System.Drawing.Point(142, 101);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(46, 17);
            this.customerNameLabel.TabIndex = 7;
            this.customerNameLabel.Text = "label8";
            this.customerNameLabel.Click += new System.EventHandler(this.customerNameLabel_Click);
            // 
            // rentalDateLabel
            // 
            this.rentalDateLabel.AutoSize = true;
            this.rentalDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rentalDateLabel.Location = new System.Drawing.Point(142, 140);
            this.rentalDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rentalDateLabel.Name = "rentalDateLabel";
            this.rentalDateLabel.Size = new System.Drawing.Size(46, 17);
            this.rentalDateLabel.TabIndex = 8;
            this.rentalDateLabel.Text = "label9";
            // 
            // rentalPeriod
            // 
            this.rentalPeriod.AutoSize = true;
            this.rentalPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rentalPeriod.Location = new System.Drawing.Point(142, 182);
            this.rentalPeriod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rentalPeriod.Name = "rentalPeriod";
            this.rentalPeriod.Size = new System.Drawing.Size(54, 17);
            this.rentalPeriod.TabIndex = 9;
            this.rentalPeriod.Text = "label10";
            // 
            // carDetailLabel
            // 
            this.carDetailLabel.AutoSize = true;
            this.carDetailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.carDetailLabel.Location = new System.Drawing.Point(142, 221);
            this.carDetailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carDetailLabel.Name = "carDetailLabel";
            this.carDetailLabel.Size = new System.Drawing.Size(54, 17);
            this.carDetailLabel.TabIndex = 10;
            this.carDetailLabel.Text = "label11";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.totalPriceLabel.Location = new System.Drawing.Point(142, 260);
            this.totalPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(54, 17);
            this.totalPriceLabel.TabIndex = 11;
            this.totalPriceLabel.Text = "label12";
            // 
            // receiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 338);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.carDetailLabel);
            this.Controls.Add(this.rentalPeriod);
            this.Controls.Add(this.rentalDateLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "receiptForm";
            this.Text = "receiptForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label rentalDateLabel;
        private System.Windows.Forms.Label rentalPeriod;
        private System.Windows.Forms.Label carDetailLabel;
        private System.Windows.Forms.Label totalPriceLabel;
    }
}