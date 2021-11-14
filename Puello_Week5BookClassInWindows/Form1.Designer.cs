
namespace Puello_Week5BookClassInWindows
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblfisrt = new System.Windows.Forms.Label();
            this.Alastname = new System.Windows.Forms.Label();
            this.Aemail = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Tdate = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthorFirst = new System.Windows.Forms.TextBox();
            this.txtAuthorLast = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.calDate = new System.Windows.Forms.DateTimePicker();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbltitle.Location = new System.Drawing.Point(248, 62);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(86, 37);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Title:";
            // 
            // lblfisrt
            // 
            this.lblfisrt.AutoSize = true;
            this.lblfisrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblfisrt.Location = new System.Drawing.Point(47, 157);
            this.lblfisrt.Name = "lblfisrt";
            this.lblfisrt.Size = new System.Drawing.Size(289, 37);
            this.lblfisrt.TabIndex = 1;
            this.lblfisrt.Text = "Author First Name:";
            this.lblfisrt.Click += new System.EventHandler(this.Afirstname_Click);
            // 
            // Alastname
            // 
            this.Alastname.AutoSize = true;
            this.Alastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Alastname.Location = new System.Drawing.Point(47, 234);
            this.Alastname.Name = "Alastname";
            this.Alastname.Size = new System.Drawing.Size(287, 37);
            this.Alastname.TabIndex = 2;
            this.Alastname.Text = "Author Last Name:";
            this.Alastname.Click += new System.EventHandler(this.Alastname_Click);
            // 
            // Aemail
            // 
            this.Aemail.AccessibleDescription = "";
            this.Aemail.AccessibleName = "";
            this.Aemail.AutoSize = true;
            this.Aemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Aemail.Location = new System.Drawing.Point(228, 377);
            this.Aemail.Name = "Aemail";
            this.Aemail.Size = new System.Drawing.Size(106, 37);
            this.Aemail.TabIndex = 3;
            this.Aemail.Text = "Email:";
            // 
            // price
            // 
            this.price.AccessibleName = "";
            this.price.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.price.Location = new System.Drawing.Point(228, 457);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(98, 37);
            this.price.TabIndex = 4;
            this.price.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 5;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 6;
            // 
            // Tdate
            // 
            this.Tdate.AutoSize = true;
            this.Tdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tdate.Location = new System.Drawing.Point(92, 301);
            this.Tdate.Name = "Tdate";
            this.Tdate.Size = new System.Drawing.Size(242, 37);
            this.Tdate.TabIndex = 7;
            this.Tdate.Text = "Date Published:";
            this.Tdate.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtTitle.Location = new System.Drawing.Point(366, 51);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(483, 53);
            this.txtTitle.TabIndex = 8;
            this.txtTitle.TextChanged += new System.EventHandler(this.titlevar_TextChanged);
            // 
            // txtAuthorFirst
            // 
            this.txtAuthorFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtAuthorFirst.Location = new System.Drawing.Point(366, 141);
            this.txtAuthorFirst.Name = "txtAuthorFirst";
            this.txtAuthorFirst.Size = new System.Drawing.Size(483, 53);
            this.txtAuthorFirst.TabIndex = 9;
            // 
            // txtAuthorLast
            // 
            this.txtAuthorLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtAuthorLast.Location = new System.Drawing.Point(366, 218);
            this.txtAuthorLast.Name = "txtAuthorLast";
            this.txtAuthorLast.Size = new System.Drawing.Size(483, 53);
            this.txtAuthorLast.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtEmail.Location = new System.Drawing.Point(366, 366);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(483, 53);
            this.txtEmail.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPrice.Location = new System.Drawing.Point(366, 441);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(483, 53);
            this.txtPrice.TabIndex = 12;
            // 
            // calDate
            // 
            this.calDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.calDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.calDate.Location = new System.Drawing.Point(366, 305);
            this.calDate.Name = "calDate";
            this.calDate.Size = new System.Drawing.Size(483, 38);
            this.calDate.TabIndex = 13;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFeedback.Location = new System.Drawing.Point(758, 667);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(160, 37);
            this.lblFeedback.TabIndex = 14;
            this.lblFeedback.Text = "FeedBack";
            this.lblFeedback.Click += new System.EventHandler(this.lblFeedback_Click);
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addbutton.Location = new System.Drawing.Point(723, 956);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(268, 57);
            this.addbutton.TabIndex = 15;
            this.addbutton.Text = "Add Book";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1695, 1058);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.calDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAuthorLast);
            this.Controls.Add(this.txtAuthorFirst);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.Tdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.price);
            this.Controls.Add(this.Aemail);
            this.Controls.Add(this.Alastname);
            this.Controls.Add(this.lblfisrt);
            this.Controls.Add(this.lbltitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblfisrt;
        private System.Windows.Forms.Label Alastname;
        private System.Windows.Forms.Label Aemail;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Tdate;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthorFirst;
        private System.Windows.Forms.TextBox txtAuthorLast;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker calDate;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button addbutton;
    }
}

