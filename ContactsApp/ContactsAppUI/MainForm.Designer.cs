namespace ContactsAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ContactsList = new System.Windows.Forms.ListBox();
            this.addContactButton = new System.Windows.Forms.Button();
            this.RemovContactButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCpntactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Find = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.VK = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.BirthdayDayTool = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactsList
            // 
            this.ContactsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsList.FormattingEnabled = true;
            this.ContactsList.ItemHeight = 16;
            this.ContactsList.Location = new System.Drawing.Point(37, 95);
            this.ContactsList.Name = "ContactsList";
            this.ContactsList.Size = new System.Drawing.Size(218, 292);
            this.ContactsList.TabIndex = 0;
            this.ContactsList.SelectedIndexChanged += new System.EventHandler(this.ContactsList_SelectedIndexChanged);
            // 
            // addContactButton
            // 
            this.addContactButton.Location = new System.Drawing.Point(38, 415);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(75, 23);
            this.addContactButton.TabIndex = 1;
            this.addContactButton.Text = "Add";
            this.addContactButton.UseVisualStyleBackColor = true;
            this.addContactButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemovContactButton
            // 
            this.RemovContactButton.Location = new System.Drawing.Point(180, 415);
            this.RemovContactButton.Name = "RemovContactButton";
            this.RemovContactButton.Size = new System.Drawing.Size(75, 23);
            this.RemovContactButton.TabIndex = 2;
            this.RemovContactButton.Text = "Remove";
            this.RemovContactButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(92, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 29);
            this.textBox1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.removeCpntactToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editContactToolStripMenuItem.Text = "Edit Contact";
            // 
            // removeCpntactToolStripMenuItem
            // 
            this.removeCpntactToolStripMenuItem.Name = "removeCpntactToolStripMenuItem";
            this.removeCpntactToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeCpntactToolStripMenuItem.Text = "Remove Cpntact";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Find
            // 
            this.Find.AutoSize = true;
            this.Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Find.Location = new System.Drawing.Point(33, 51);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(53, 24);
            this.Find.TabIndex = 3;
            this.Find.Text = "Find:";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.Location = new System.Drawing.Point(298, 95);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(64, 18);
            this.Surname.TabIndex = 6;
            this.Surname.Text = "Surame:";
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name1.Location = new System.Drawing.Point(298, 125);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(52, 18);
            this.Name1.TabIndex = 7;
            this.Name1.Text = "Name:";
            this.Name1.Click += new System.EventHandler(this.label3_Click);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.Location = new System.Drawing.Point(298, 185);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(55, 18);
            this.Phone.TabIndex = 8;
            this.Phone.Text = "Phone:";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birthday.Location = new System.Drawing.Point(298, 155);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(65, 18);
            this.Birthday.TabIndex = 9;
            this.Birthday.Text = "Birthday:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(298, 215);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(54, 18);
            this.Email.TabIndex = 10;
            this.Email.Text = "E-Mail:";
            // 
            // VK
            // 
            this.VK.AutoSize = true;
            this.VK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VK.Location = new System.Drawing.Point(298, 245);
            this.VK.Name = "VK";
            this.VK.Size = new System.Drawing.Size(61, 18);
            this.VK.TabIndex = 11;
            this.VK.Text = "vk.com:";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTextBox.Location = new System.Drawing.Point(422, 92);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(366, 24);
            this.SurnameTextBox.TabIndex = 12;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(422, 122);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(366, 24);
            this.NameTextBox.TabIndex = 13;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTextBox.Location = new System.Drawing.Point(422, 212);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(366, 24);
            this.EmailTextBox.TabIndex = 14;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneTextBox.Location = new System.Drawing.Point(422, 182);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(366, 24);
            this.PhoneTextBox.TabIndex = 15;
            // 
            // VKTextBox
            // 
            this.VKTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VKTextBox.Location = new System.Drawing.Point(422, 242);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(366, 24);
            this.VKTextBox.TabIndex = 16;
            // 
            // BirthdayDayTool
            // 
            this.BirthdayDayTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayDayTool.Location = new System.Drawing.Point(422, 152);
            this.BirthdayDayTool.MaxDate = new System.DateTime(2018, 11, 21, 19, 23, 33, 0);
            this.BirthdayDayTool.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthdayDayTool.Name = "BirthdayDayTool";
            this.BirthdayDayTool.Size = new System.Drawing.Size(200, 24);
            this.BirthdayDayTool.TabIndex = 17;
            this.BirthdayDayTool.Value = new System.DateTime(2018, 11, 21, 0, 0, 0, 0);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BirthdayDayTool);
            this.Controls.Add(this.VKTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.VK);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.RemovContactButton);
            this.Controls.Add(this.addContactButton);
            this.Controls.Add(this.ContactsList);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ContactsList;
        private System.Windows.Forms.Button addContactButton;
        private System.Windows.Forms.Button RemovContactButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCpntactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label Find;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label VK;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.DateTimePicker BirthdayDayTool;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

