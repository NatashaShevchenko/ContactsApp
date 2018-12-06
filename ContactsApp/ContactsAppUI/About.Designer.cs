namespace ContactsAppUI
{
    partial class About
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
            this.ContactsApp = new System.Windows.Forms.Label();
            this.V = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.git = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ContactsApp
            // 
            this.ContactsApp.AutoSize = true;
            this.ContactsApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsApp.Location = new System.Drawing.Point(5, 23);
            this.ContactsApp.Name = "ContactsApp";
            this.ContactsApp.Size = new System.Drawing.Size(160, 29);
            this.ContactsApp.TabIndex = 0;
            this.ContactsApp.Text = "ContactsApp";
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.Location = new System.Drawing.Point(7, 52);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(43, 13);
            this.V.TabIndex = 1;
            this.V.Text = "v. 1.0.0";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(7, 104);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(148, 13);
            this.Author.TabIndex = 2;
            this.Author.Text = "Author: Natasha Shevchenko";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(7, 161);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 13);
            this.email.TabIndex = 3;
            this.email.Text = "e-mail for feedback:";
            // 
            // git
            // 
            this.git.AutoSize = true;
            this.git.Location = new System.Drawing.Point(7, 174);
            this.git.Name = "git";
            this.git.Size = new System.Drawing.Size(43, 13);
            this.git.TabIndex = 4;
            this.git.Text = "GitHub:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "2018 Natasha Shevchenko";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(113, 161);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "squirrel.sheff@gmai.com";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(56, 174);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(174, 13);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "NatashaShevchenko/ContactsApp";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 243);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.git);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.V);
            this.Controls.Add(this.ContactsApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ContactsApp;
        private System.Windows.Forms.Label V;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label git;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}