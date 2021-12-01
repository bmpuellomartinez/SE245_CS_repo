
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.feedbackbutton = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrlEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pfname
            // 
            this.pfname.AutoSize = true;
            this.pfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pfname.Location = new System.Drawing.Point(70, 64);
            this.pfname.Name = "pfname";
            this.pfname.Size = new System.Drawing.Size(184, 37);
            this.pfname.TabIndex = 0;
            this.pfname.Text = "First Name:";
            // 
            // pmname
            // 
            this.pmname.AutoSize = true;
            this.pmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pmname.Location = new System.Drawing.Point(40, 143);
            this.pmname.Name = "pmname";
            this.pmname.Size = new System.Drawing.Size(214, 37);
            this.pmname.TabIndex = 1;
            this.pmname.Text = "Middle Name:";
            // 
            // plname
            // 
            this.plname.AutoSize = true;
            this.plname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.plname.Location = new System.Drawing.Point(70, 206);
            this.plname.Name = "plname";
            this.plname.Size = new System.Drawing.Size(182, 37);
            this.plname.TabIndex = 2;
            this.plname.Text = "Last Name:";
            // 
            // pfstreet
            // 
            this.pfstreet.AutoSize = true;
            this.pfstreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pfstreet.Location = new System.Drawing.Point(59, 270);
            this.pfstreet.Name = "pfstreet";
            this.pfstreet.Size = new System.Drawing.Size(182, 37);
            this.pfstreet.TabIndex = 3;
            this.pfstreet.Text = "First Street:";
            // 
            // pSstreet
            // 
            this.pSstreet.AutoSize = true;
            this.pSstreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pSstreet.Location = new System.Drawing.Point(10, 341);
            this.pSstreet.Name = "pSstreet";
            this.pSstreet.Size = new System.Drawing.Size(227, 37);
            this.pSstreet.TabIndex = 4;
            this.pSstreet.Text = "Second Street:";
            this.pSstreet.Click += new System.EventHandler(this.pSstreet_Click);
            // 
            // pcity
            // 
            this.pcity.AutoSize = true;
            this.pcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pcity.Location = new System.Drawing.Point(148, 407);
            this.pcity.Name = "pcity";
            this.pcity.Size = new System.Drawing.Size(80, 37);
            this.pcity.TabIndex = 5;
            this.pcity.Text = "City:";
            // 
            // pstate
            // 
            this.pstate.AutoSize = true;
            this.pstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pstate.Location = new System.Drawing.Point(141, 472);
            this.pstate.Name = "pstate";
            this.pstate.Size = new System.Drawing.Size(100, 37);
            this.pstate.TabIndex = 6;
            this.pstate.Text = "State:";
            // 
            // pzip
            // 
            this.pzip.AutoSize = true;
            this.pzip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pzip.Location = new System.Drawing.Point(157, 537);
            this.pzip.Name = "pzip";
            this.pzip.Size = new System.Drawing.Size(71, 37);
            this.pzip.TabIndex = 7;
            this.pzip.Text = "Zip:";
            // 
            // pphone
            // 
            this.pphone.AutoSize = true;
            this.pphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pphone.Location = new System.Drawing.Point(-1, 599);
            this.pphone.Name = "pphone";
            this.pphone.Size = new System.Drawing.Size(242, 37);
            this.pphone.TabIndex = 8;
            this.pphone.Text = "Phone Number:";
            this.pphone.Click += new System.EventHandler(this.label9_Click);
            // 
            // pemail
            // 
            this.pemail.AutoSize = true;
            this.pemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pemail.Location = new System.Drawing.Point(131, 679);
            this.pemail.Name = "pemail";
            this.pemail.Size = new System.Drawing.Size(106, 37);
            this.pemail.TabIndex = 9;
            this.pemail.Text = "Email:";
            this.pemail.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFname.Location = new System.Drawing.Point(290, 74);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(387, 44);
            this.txtFname.TabIndex = 10;
            this.txtFname.TextChanged += new System.EventHandler(this.txtFname_TextChanged);
            // 
            // txtMname
            // 
            this.txtMname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMname.Location = new System.Drawing.Point(290, 143);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(387, 44);
            this.txtMname.TabIndex = 11;
            this.txtMname.TextChanged += new System.EventHandler(this.pmnamevar_TextChanged);
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLname.Location = new System.Drawing.Point(290, 212);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(387, 44);
            this.txtLname.TabIndex = 12;
            // 
            // txtFstreet
            // 
            this.txtFstreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFstreet.Location = new System.Drawing.Point(290, 270);
            this.txtFstreet.Name = "txtFstreet";
            this.txtFstreet.Size = new System.Drawing.Size(387, 44);
            this.txtFstreet.TabIndex = 13;
            // 
            // txtSstreet
            // 
            this.txtSstreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSstreet.Location = new System.Drawing.Point(290, 338);
            this.txtSstreet.Name = "txtSstreet";
            this.txtSstreet.Size = new System.Drawing.Size(387, 44);
            this.txtSstreet.TabIndex = 14;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCity.Location = new System.Drawing.Point(290, 400);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(387, 44);
            this.txtCity.TabIndex = 15;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtState.Location = new System.Drawing.Point(290, 472);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(387, 44);
            this.txtState.TabIndex = 16;
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtZip.Location = new System.Drawing.Point(290, 537);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(387, 44);
            this.txtZip.TabIndex = 17;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPhone.Location = new System.Drawing.Point(290, 599);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(387, 44);
            this.txtPhone.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(290, 672);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(387, 44);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFeedback.Location = new System.Drawing.Point(722, 1043);
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
            this.feedbackbutton.Location = new System.Drawing.Point(712, 967);
            this.feedbackbutton.Name = "feedbackbutton";
            this.feedbackbutton.Size = new System.Drawing.Size(188, 54);
            this.feedbackbutton.TabIndex = 21;
            this.feedbackbutton.Text = "Add Book";
            this.feedbackbutton.UseVisualStyleBackColor = false;
            this.feedbackbutton.Click += new System.EventHandler(this.feedbackbutton_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(33, 1209);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 25);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 785);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(83, 757);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 37);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cellphone:";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCellphone.Location = new System.Drawing.Point(290, 754);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(387, 44);
            this.txtCellphone.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(31, 847);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 37);
            this.label3.TabIndex = 26;
            this.label3.Text = "URLInstagram:";
            // 
            // txtUrlEmail
            // 
            this.txtUrlEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUrlEmail.Location = new System.Drawing.Point(290, 847);
            this.txtUrlEmail.Name = "txtUrlEmail";
            this.txtUrlEmail.Size = new System.Drawing.Size(387, 44);
            this.txtUrlEmail.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1841, 1636);
            this.Controls.Add(this.txtUrlEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCellphone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.feedbackbutton);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
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
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button feedbackbutton;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrlEmail;
    }
}

