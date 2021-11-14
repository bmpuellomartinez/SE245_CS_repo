
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
            this.pfnamevar = new System.Windows.Forms.TextBox();
            this.pmnamevar = new System.Windows.Forms.TextBox();
            this.plnamevar = new System.Windows.Forms.TextBox();
            this.pfstreetvar = new System.Windows.Forms.TextBox();
            this.pSstreetvar = new System.Windows.Forms.TextBox();
            this.pcityvar = new System.Windows.Forms.TextBox();
            this.pstatevar = new System.Windows.Forms.TextBox();
            this.pzipvar = new System.Windows.Forms.TextBox();
            this.pphonevar = new System.Windows.Forms.TextBox();
            this.pemailvar = new System.Windows.Forms.TextBox();
            this.pfeedback = new System.Windows.Forms.Label();
            this.feedbackbutton = new System.Windows.Forms.Button();
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
            this.pemail.Location = new System.Drawing.Point(131, 659);
            this.pemail.Name = "pemail";
            this.pemail.Size = new System.Drawing.Size(106, 37);
            this.pemail.TabIndex = 9;
            this.pemail.Text = "Email:";
            this.pemail.Click += new System.EventHandler(this.label10_Click);
            // 
            // pfnamevar
            // 
            this.pfnamevar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pfnamevar.Location = new System.Drawing.Point(290, 74);
            this.pfnamevar.Name = "pfnamevar";
            this.pfnamevar.Size = new System.Drawing.Size(387, 44);
            this.pfnamevar.TabIndex = 10;
            // 
            // pmnamevar
            // 
            this.pmnamevar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pmnamevar.Location = new System.Drawing.Point(290, 143);
            this.pmnamevar.Name = "pmnamevar";
            this.pmnamevar.Size = new System.Drawing.Size(387, 44);
            this.pmnamevar.TabIndex = 11;
            // 
            // plnamevar
            // 
            this.plnamevar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.plnamevar.Location = new System.Drawing.Point(290, 212);
            this.plnamevar.Name = "plnamevar";
            this.plnamevar.Size = new System.Drawing.Size(387, 44);
            this.plnamevar.TabIndex = 12;
            // 
            // pfstreetvar
            // 
            this.pfstreetvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pfstreetvar.Location = new System.Drawing.Point(290, 270);
            this.pfstreetvar.Name = "pfstreetvar";
            this.pfstreetvar.Size = new System.Drawing.Size(387, 44);
            this.pfstreetvar.TabIndex = 13;
            // 
            // pSstreetvar
            // 
            this.pSstreetvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pSstreetvar.Location = new System.Drawing.Point(290, 338);
            this.pSstreetvar.Name = "pSstreetvar";
            this.pSstreetvar.Size = new System.Drawing.Size(387, 44);
            this.pSstreetvar.TabIndex = 14;
            // 
            // pcityvar
            // 
            this.pcityvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pcityvar.Location = new System.Drawing.Point(290, 400);
            this.pcityvar.Name = "pcityvar";
            this.pcityvar.Size = new System.Drawing.Size(387, 44);
            this.pcityvar.TabIndex = 15;
            // 
            // pstatevar
            // 
            this.pstatevar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pstatevar.Location = new System.Drawing.Point(290, 472);
            this.pstatevar.Name = "pstatevar";
            this.pstatevar.Size = new System.Drawing.Size(387, 44);
            this.pstatevar.TabIndex = 16;
            // 
            // pzipvar
            // 
            this.pzipvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pzipvar.Location = new System.Drawing.Point(290, 537);
            this.pzipvar.Name = "pzipvar";
            this.pzipvar.Size = new System.Drawing.Size(387, 44);
            this.pzipvar.TabIndex = 17;
            // 
            // pphonevar
            // 
            this.pphonevar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pphonevar.Location = new System.Drawing.Point(290, 599);
            this.pphonevar.Name = "pphonevar";
            this.pphonevar.Size = new System.Drawing.Size(387, 44);
            this.pphonevar.TabIndex = 18;
            // 
            // pemailvar
            // 
            this.pemailvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pemailvar.Location = new System.Drawing.Point(290, 672);
            this.pemailvar.Name = "pemailvar";
            this.pemailvar.Size = new System.Drawing.Size(387, 44);
            this.pemailvar.TabIndex = 19;
            // 
            // pfeedback
            // 
            this.pfeedback.AutoSize = true;
            this.pfeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pfeedback.Location = new System.Drawing.Point(695, 835);
            this.pfeedback.Name = "pfeedback";
            this.pfeedback.Size = new System.Drawing.Size(160, 37);
            this.pfeedback.TabIndex = 20;
            this.pfeedback.Text = "FeedBack";
            // 
            // feedbackbutton
            // 
            this.feedbackbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.feedbackbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.feedbackbutton.Location = new System.Drawing.Point(684, 915);
            this.feedbackbutton.Name = "feedbackbutton";
            this.feedbackbutton.Size = new System.Drawing.Size(188, 54);
            this.feedbackbutton.TabIndex = 21;
            this.feedbackbutton.Text = "Add Book";
            this.feedbackbutton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 1142);
            this.Controls.Add(this.feedbackbutton);
            this.Controls.Add(this.pfeedback);
            this.Controls.Add(this.pemailvar);
            this.Controls.Add(this.pphonevar);
            this.Controls.Add(this.pzipvar);
            this.Controls.Add(this.pstatevar);
            this.Controls.Add(this.pcityvar);
            this.Controls.Add(this.pSstreetvar);
            this.Controls.Add(this.pfstreetvar);
            this.Controls.Add(this.plnamevar);
            this.Controls.Add(this.pmnamevar);
            this.Controls.Add(this.pfnamevar);
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
        private System.Windows.Forms.TextBox pfnamevar;
        private System.Windows.Forms.TextBox pmnamevar;
        private System.Windows.Forms.TextBox plnamevar;
        private System.Windows.Forms.TextBox pfstreetvar;
        private System.Windows.Forms.TextBox pSstreetvar;
        private System.Windows.Forms.TextBox pcityvar;
        private System.Windows.Forms.TextBox pstatevar;
        private System.Windows.Forms.TextBox pzipvar;
        private System.Windows.Forms.TextBox pphonevar;
        private System.Windows.Forms.TextBox pemailvar;
        private System.Windows.Forms.Label pfeedback;
        private System.Windows.Forms.Button feedbackbutton;
    }
}

