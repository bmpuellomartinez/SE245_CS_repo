
namespace Puello_WindowsAssigment
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
            this.pfname = new System.Windows.Forms.Label();
            this.pmname = new System.Windows.Forms.Label();
            this.plname = new System.Windows.Forms.Label();
            this.pfstreet = new System.Windows.Forms.Label();
            this.pSstreet = new System.Windows.Forms.Label();
            this.pcity = new System.Windows.Forms.Label();
            this.pstate = new System.Windows.Forms.Label();
            this.pzip = new System.Windows.Forms.Label();
            this.pphone = new System.Windows.Forms.Label();
            this.pemail = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFstreet = new System.Windows.Forms.TextBox();
            this.txtSstreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtPnumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.feedbackbutton = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkDiscountM = new System.Windows.Forms.CheckBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtRewards = new System.Windows.Forms.TextBox();
            this.calCustomerSince = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // pfname
            // 
            this.pfname.AutoSize = true;
            this.pfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pfname.Location = new System.Drawing.Point(168, 217);
            this.pfname.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.pfname.Name = "pfname";
            this.pfname.Size = new System.Drawing.Size(184, 37);
            this.pfname.TabIndex = 0;
            this.pfname.Text = "First Name:";
            this.pfname.UseWaitCursor = true;
            // 
            // pmname
            // 
            this.pmname.AutoSize = true;
            this.pmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pmname.Location = new System.Drawing.Point(168, 315);
            this.pmname.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.pmname.Name = "pmname";
            this.pmname.Size = new System.Drawing.Size(214, 37);
            this.pmname.TabIndex = 1;
            this.pmname.Text = "Middle Name:";
            this.pmname.UseWaitCursor = true;
            // 
            // plname
            // 
            this.plname.AutoSize = true;
            this.plname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.plname.Location = new System.Drawing.Point(168, 396);
            this.plname.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.plname.Name = "plname";
            this.plname.Size = new System.Drawing.Size(182, 37);
            this.plname.TabIndex = 2;
            this.plname.Text = "Last Name:";
            this.plname.UseWaitCursor = true;
            // 
            // pfstreet
            // 
            this.pfstreet.AutoSize = true;
            this.pfstreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pfstreet.Location = new System.Drawing.Point(190, 473);
            this.pfstreet.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.pfstreet.Name = "pfstreet";
            this.pfstreet.Size = new System.Drawing.Size(182, 37);
            this.pfstreet.TabIndex = 3;
            this.pfstreet.Text = "First Street:";
            this.pfstreet.UseWaitCursor = true;
            // 
            // pSstreet
            // 
            this.pSstreet.AutoSize = true;
            this.pSstreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pSstreet.Location = new System.Drawing.Point(142, 554);
            this.pSstreet.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.pSstreet.Name = "pSstreet";
            this.pSstreet.Size = new System.Drawing.Size(227, 37);
            this.pSstreet.TabIndex = 4;
            this.pSstreet.Text = "Second Street:";
            this.pSstreet.UseWaitCursor = true;
            this.pSstreet.Click += new System.EventHandler(this.pSstreet_Click);
            // 
            // pcity
            // 
            this.pcity.AutoSize = true;
            this.pcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pcity.Location = new System.Drawing.Point(262, 627);
            this.pcity.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.pcity.Name = "pcity";
            this.pcity.Size = new System.Drawing.Size(80, 37);
            this.pcity.TabIndex = 5;
            this.pcity.Text = "City:";
            this.pcity.UseWaitCursor = true;
            // 
            // pstate
            // 
            this.pstate.AutoSize = true;
            this.pstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pstate.Location = new System.Drawing.Point(270, 798);
            this.pstate.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.pstate.Name = "pstate";
            this.pstate.Size = new System.Drawing.Size(100, 37);
            this.pstate.TabIndex = 6;
            this.pstate.Text = "State:";
            this.pstate.UseWaitCursor = true;
            // 
            // pzip
            // 
            this.pzip.AutoSize = true;
            this.pzip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pzip.Location = new System.Drawing.Point(524, 1842);
            this.pzip.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.pzip.Name = "pzip";
            this.pzip.Size = new System.Drawing.Size(71, 37);
            this.pzip.TabIndex = 7;
            this.pzip.Text = "Zip:";
            this.pzip.UseWaitCursor = true;
            // 
            // pphone
            // 
            this.pphone.AutoSize = true;
            this.pphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pphone.Location = new System.Drawing.Point(124, 2052);
            this.pphone.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.pphone.Name = "pphone";
            this.pphone.Size = new System.Drawing.Size(204, 37);
            this.pphone.TabIndex = 8;
            this.pphone.Text = "Cell Number:";
            this.pphone.UseWaitCursor = true;
            this.pphone.Click += new System.EventHandler(this.label9_Click);
            // 
            // pemail
            // 
            this.pemail.AutoSize = true;
            this.pemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pemail.Location = new System.Drawing.Point(468, 2252);
            this.pemail.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.pemail.Name = "pemail";
            this.pemail.Size = new System.Drawing.Size(106, 37);
            this.pemail.TabIndex = 9;
            this.pemail.Text = "Email:";
            this.pemail.UseWaitCursor = true;
            this.pemail.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFname.Location = new System.Drawing.Point(428, 212);
            this.txtFname.Margin = new System.Windows.Forms.Padding(12);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(616, 44);
            this.txtFname.TabIndex = 10;
            this.txtFname.UseWaitCursor = true;
            this.txtFname.TextChanged += new System.EventHandler(this.txtFname_TextChanged);
            // 
            // txtMname
            // 
            this.txtMname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMname.Location = new System.Drawing.Point(428, 304);
            this.txtMname.Margin = new System.Windows.Forms.Padding(12);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(616, 44);
            this.txtMname.TabIndex = 11;
            this.txtMname.UseWaitCursor = true;
            this.txtMname.TextChanged += new System.EventHandler(this.pmnamevar_TextChanged);
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLname.Location = new System.Drawing.Point(428, 390);
            this.txtLname.Margin = new System.Windows.Forms.Padding(12);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(616, 44);
            this.txtLname.TabIndex = 12;
            this.txtLname.UseWaitCursor = true;
            // 
            // txtFstreet
            // 
            this.txtFstreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFstreet.Location = new System.Drawing.Point(428, 473);
            this.txtFstreet.Margin = new System.Windows.Forms.Padding(12);
            this.txtFstreet.Name = "txtFstreet";
            this.txtFstreet.Size = new System.Drawing.Size(616, 44);
            this.txtFstreet.TabIndex = 13;
            this.txtFstreet.UseWaitCursor = true;
            // 
            // txtSstreet
            // 
            this.txtSstreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSstreet.Location = new System.Drawing.Point(428, 554);
            this.txtSstreet.Margin = new System.Windows.Forms.Padding(12);
            this.txtSstreet.Name = "txtSstreet";
            this.txtSstreet.Size = new System.Drawing.Size(608, 44);
            this.txtSstreet.TabIndex = 14;
            this.txtSstreet.UseWaitCursor = true;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCity.Location = new System.Drawing.Point(388, 627);
            this.txtCity.Margin = new System.Windows.Forms.Padding(12);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(648, 44);
            this.txtCity.TabIndex = 15;
            this.txtCity.UseWaitCursor = true;
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtState.Location = new System.Drawing.Point(398, 792);
            this.txtState.Margin = new System.Windows.Forms.Padding(12);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(638, 44);
            this.txtState.TabIndex = 16;
            this.txtState.UseWaitCursor = true;
            this.txtState.TextChanged += new System.EventHandler(this.txtState_TextChanged);
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtZip.Location = new System.Drawing.Point(736, 1819);
            this.txtZip.Margin = new System.Windows.Forms.Padding(12);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(1014, 44);
            this.txtZip.TabIndex = 17;
            this.txtZip.UseWaitCursor = true;
            this.txtZip.TextChanged += new System.EventHandler(this.txtZip_TextChanged);
            // 
            // txtPnumber
            // 
            this.txtPnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPnumber.Location = new System.Drawing.Point(736, 2031);
            this.txtPnumber.Margin = new System.Windows.Forms.Padding(12);
            this.txtPnumber.Name = "txtPnumber";
            this.txtPnumber.Size = new System.Drawing.Size(1014, 44);
            this.txtPnumber.TabIndex = 18;
            this.txtPnumber.UseWaitCursor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(736, 2231);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(12);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(1014, 44);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.UseWaitCursor = true;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFeedback.Location = new System.Drawing.Point(1700, 1052);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(160, 37);
            this.lblFeedback.TabIndex = 20;
            this.lblFeedback.Text = "FeedBack";
            this.lblFeedback.Click += new System.EventHandler(this.lblFeedback_Click);
            // 
            // feedbackbutton
            // 
            this.feedbackbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.feedbackbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.feedbackbutton.Location = new System.Drawing.Point(1676, 877);
            this.feedbackbutton.Margin = new System.Windows.Forms.Padding(12);
            this.feedbackbutton.Name = "feedbackbutton";
            this.feedbackbutton.Size = new System.Drawing.Size(212, 100);
            this.feedbackbutton.TabIndex = 21;
            this.feedbackbutton.Text = "Add Book";
            this.feedbackbutton.UseVisualStyleBackColor = false;
            this.feedbackbutton.Click += new System.EventHandler(this.feedbackbutton_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(132, 4471);
            this.lblDate.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 25);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "label1";
            this.lblDate.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(1286, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer Since:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(1286, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 37);
            this.label2.TabIndex = 24;
            this.label2.Text = "Total Purcheses:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(1286, 554);
            this.label3.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 37);
            this.label3.TabIndex = 25;
            this.label3.Text = "Discount Member:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(1278, 473);
            this.label4.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 37);
            this.label4.TabIndex = 26;
            this.label4.Text = "Rewards Member:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chkDiscountM
            // 
            this.chkDiscountM.AutoSize = true;
            this.chkDiscountM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkDiscountM.Location = new System.Drawing.Point(2868, 994);
            this.chkDiscountM.Margin = new System.Windows.Forms.Padding(12);
            this.chkDiscountM.Name = "chkDiscountM";
            this.chkDiscountM.Size = new System.Drawing.Size(104, 41);
            this.chkDiscountM.TabIndex = 27;
            this.chkDiscountM.Text = "Yes";
            this.chkDiscountM.UseVisualStyleBackColor = true;
            this.chkDiscountM.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTotal.Location = new System.Drawing.Point(2796, 496);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(12);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(516, 50);
            this.txtTotal.TabIndex = 29;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // txtRewards
            // 
            this.txtRewards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRewards.Location = new System.Drawing.Point(2796, 744);
            this.txtRewards.Margin = new System.Windows.Forms.Padding(12);
            this.txtRewards.Name = "txtRewards";
            this.txtRewards.Size = new System.Drawing.Size(516, 44);
            this.txtRewards.TabIndex = 30;
            // 
            // calCustomerSince
            // 
            this.calCustomerSince.Location = new System.Drawing.Point(2796, 304);
            this.calCustomerSince.Margin = new System.Windows.Forms.Padding(8);
            this.calCustomerSince.Name = "calCustomerSince";
            this.calCustomerSince.Size = new System.Drawing.Size(848, 31);
            this.calCustomerSince.TabIndex = 31;
            this.calCustomerSince.ValueChanged += new System.EventHandler(this.calCustomerSince_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2740, 1783);
            this.Controls.Add(this.calCustomerSince);
            this.Controls.Add(this.txtRewards);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.chkDiscountM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.feedbackbutton);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPnumber);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtSstreet);
            this.Controls.Add(this.txtFstreet);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtMname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.pemail);
            this.Controls.Add(this.pphone);
            this.Controls.Add(this.pzip);
            this.Controls.Add(this.pstate);
            this.Controls.Add(this.pcity);
            this.Controls.Add(this.pSstreet);
            this.Controls.Add(this.pfstreet);
            this.Controls.Add(this.plname);
            this.Controls.Add(this.pmname);
            this.Controls.Add(this.pfname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pfname;
        private System.Windows.Forms.Label pmname;
        private System.Windows.Forms.Label plname;
        private System.Windows.Forms.Label pfstreet;
        private System.Windows.Forms.Label pSstreet;
        private System.Windows.Forms.Label pcity;
        private System.Windows.Forms.Label pstate;
        private System.Windows.Forms.Label pzip;
        private System.Windows.Forms.Label pphone;
        private System.Windows.Forms.Label pemail;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFstreet;
        private System.Windows.Forms.TextBox txtSstreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtPnumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button feedbackbutton;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkDiscountM;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtRewards;
        private System.Windows.Forms.DateTimePicker calCustomerSince;
    }
}

