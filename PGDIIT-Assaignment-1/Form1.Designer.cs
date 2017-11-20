namespace PGDIIT_Assaignment_1
{
    partial class Form1
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
            this.Cname = new System.Windows.Forms.TextBox();
            this.tDeposit = new System.Windows.Forms.Button();
            this.Tamount = new System.Windows.Forms.TextBox();
            this.tWithdraw = new System.Windows.Forms.Button();
            this.showAmount = new System.Windows.Forms.Label();
            this.exportAmount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cadd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Caccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addCompany = new System.Windows.Forms.Button();
            this.Scname = new System.Windows.Forms.Label();
            this.Scaccount = new System.Windows.Forms.Label();
            this.Scmobile = new System.Windows.Forms.Label();
            this.Scadd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name";
            // 
            // Cname
            // 
            this.Cname.Location = new System.Drawing.Point(172, 6);
            this.Cname.Name = "Cname";
            this.Cname.Size = new System.Drawing.Size(222, 20);
            this.Cname.TabIndex = 1;
            // 
            // tDeposit
            // 
            this.tDeposit.Location = new System.Drawing.Point(99, 188);
            this.tDeposit.Name = "tDeposit";
            this.tDeposit.Size = new System.Drawing.Size(75, 23);
            this.tDeposit.TabIndex = 2;
            this.tDeposit.Text = "Deposit";
            this.tDeposit.UseVisualStyleBackColor = true;
            this.tDeposit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tamount
            // 
            this.Tamount.Location = new System.Drawing.Point(241, 177);
            this.Tamount.Name = "Tamount";
            this.Tamount.Size = new System.Drawing.Size(100, 20);
            this.Tamount.TabIndex = 3;
            // 
            // tWithdraw
            // 
            this.tWithdraw.Location = new System.Drawing.Point(396, 188);
            this.tWithdraw.Name = "tWithdraw";
            this.tWithdraw.Size = new System.Drawing.Size(75, 23);
            this.tWithdraw.TabIndex = 4;
            this.tWithdraw.Text = "withdraw";
            this.tWithdraw.UseVisualStyleBackColor = true;
            this.tWithdraw.Click += new System.EventHandler(this.tWithdraw_Click);
            // 
            // showAmount
            // 
            this.showAmount.AutoSize = true;
            this.showAmount.Location = new System.Drawing.Point(201, 232);
            this.showAmount.Name = "showAmount";
            this.showAmount.Size = new System.Drawing.Size(70, 13);
            this.showAmount.TabIndex = 5;
            this.showAmount.Text = "ShowAmount";
            // 
            // exportAmount
            // 
            this.exportAmount.Location = new System.Drawing.Point(99, 227);
            this.exportAmount.Name = "exportAmount";
            this.exportAmount.Size = new System.Drawing.Size(75, 23);
            this.exportAmount.TabIndex = 6;
            this.exportAmount.Text = "Export";
            this.exportAmount.UseVisualStyleBackColor = true;
            this.exportAmount.Click += new System.EventHandler(this.exportAmount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Company Address";
            // 
            // Cadd
            // 
            this.Cadd.Location = new System.Drawing.Point(532, 6);
            this.Cadd.Name = "Cadd";
            this.Cadd.Size = new System.Drawing.Size(209, 20);
            this.Cadd.TabIndex = 8;
            this.Cadd.Text = "Company Address";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Scadd);
            this.panel1.Controls.Add(this.Scmobile);
            this.panel1.Controls.Add(this.Scaccount);
            this.panel1.Controls.Add(this.Scname);
            this.panel1.Controls.Add(this.addCompany);
            this.panel1.Controls.Add(this.Caccount);
            this.panel1.Controls.Add(this.Cname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Cadd);
            this.panel1.Controls.Add(this.Cmobile);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(24, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 134);
            this.panel1.TabIndex = 9;
            // 
            // Caccount
            // 
            this.Caccount.Location = new System.Drawing.Point(532, 32);
            this.Caccount.Name = "Caccount";
            this.Caccount.Size = new System.Drawing.Size(209, 20);
            this.Caccount.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Company Account No.";
            // 
            // Cmobile
            // 
            this.Cmobile.Location = new System.Drawing.Point(172, 35);
            this.Cmobile.Name = "Cmobile";
            this.Cmobile.Size = new System.Drawing.Size(222, 20);
            this.Cmobile.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Company Mobile Number :";
            // 
            // addCompany
            // 
            this.addCompany.Location = new System.Drawing.Point(172, 65);
            this.addCompany.Name = "addCompany";
            this.addCompany.Size = new System.Drawing.Size(222, 23);
            this.addCompany.TabIndex = 14;
            this.addCompany.Text = "Add Company";
            this.addCompany.UseVisualStyleBackColor = true;
            this.addCompany.Click += new System.EventHandler(this.addCompany_Click);
            // 
            // Scname
            // 
            this.Scname.AutoSize = true;
            this.Scname.Location = new System.Drawing.Point(50, 110);
            this.Scname.Name = "Scname";
            this.Scname.Size = new System.Drawing.Size(35, 13);
            this.Scname.TabIndex = 15;
            this.Scname.Text = "label5";
            // 
            // Scaccount
            // 
            this.Scaccount.AutoSize = true;
            this.Scaccount.Location = new System.Drawing.Point(636, 110);
            this.Scaccount.Name = "Scaccount";
            this.Scaccount.Size = new System.Drawing.Size(35, 13);
            this.Scaccount.TabIndex = 17;
            this.Scaccount.Text = "label7";
            // 
            // Scmobile
            // 
            this.Scmobile.AutoSize = true;
            this.Scmobile.Location = new System.Drawing.Point(444, 110);
            this.Scmobile.Name = "Scmobile";
            this.Scmobile.Size = new System.Drawing.Size(35, 13);
            this.Scmobile.TabIndex = 18;
            this.Scmobile.Text = "label8";
            // 
            // Scadd
            // 
            this.Scadd.AutoSize = true;
            this.Scadd.Location = new System.Drawing.Point(247, 110);
            this.Scadd.Name = "Scadd";
            this.Scadd.Size = new System.Drawing.Size(35, 13);
            this.Scadd.TabIndex = 19;
            this.Scadd.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exportAmount);
            this.Controls.Add(this.showAmount);
            this.Controls.Add(this.tWithdraw);
            this.Controls.Add(this.Tamount);
            this.Controls.Add(this.tDeposit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cname;
        private System.Windows.Forms.Button tDeposit;
        private System.Windows.Forms.TextBox Tamount;
        private System.Windows.Forms.Button tWithdraw;
        private System.Windows.Forms.Label showAmount;
        private System.Windows.Forms.Button exportAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cadd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Caccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cmobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Scadd;
        private System.Windows.Forms.Label Scmobile;
        private System.Windows.Forms.Label Scaccount;
        private System.Windows.Forms.Label Scname;
        private System.Windows.Forms.Button addCompany;
    }
}

