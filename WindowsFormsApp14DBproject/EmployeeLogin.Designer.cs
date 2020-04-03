namespace WindowsFormsApp14DBproject
{
    partial class EmployeeLogin
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
            this.empID = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.invalid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "31Rentals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "EmployeeLogin";
            // 
            // empID
            // 
            this.empID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.empID.Location = new System.Drawing.Point(284, 186);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(186, 26);
            this.empID.TabIndex = 2;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(284, 239);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(186, 23);
            this.login.TabIndex = 3;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // invalid
            // 
            this.invalid.AutoSize = true;
            this.invalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.invalid.ForeColor = System.Drawing.Color.Red;
            this.invalid.Location = new System.Drawing.Point(291, 274);
            this.invalid.Name = "invalid";
            this.invalid.Size = new System.Drawing.Size(170, 20);
            this.invalid.TabIndex = 4;
            this.invalid.Text = "EmployeeID is invalid.  ";
            this.invalid.Visible = false;
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.invalid);
            this.Controls.Add(this.login);
            this.Controls.Add(this.empID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeLogin";
            this.Text = "EmployeeLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox empID;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label invalid;
    }
}