using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContactsAppUI
{
    public partial class AddEditContactsForm : Form
    {
        public AddEditContactsForm()
        {
            InitializeComponent();
            
           
        }

        private void OK_Click(object sender, EventArgs e)
        {

            string m = NameTextBox.Text;
            string Text = File.ReadAllText("C:\\Users\\Натали\\AppData\\Roaming\\ContactsApp\\ContactsApp.txt");
            using (StreamReader sr = new StreamReader("C:\\Users\\Натали\\AppData\\Roaming\\ContactsApp\\ContactsApp.txt"))
            {
                if(Text.Contains (m))
                {
                    MessageBox.Show("Контакт существует");
                }
                else
                {
                    sr.Close();
                    System.IO.StreamWriter writer = new System.IO.StreamWriter("C:\\Users\\Натали\\AppData\\Roaming\\ContactsApp\\ContactsApp.txt", true);
                    
                    writer.WriteLine(NameTextBox);
                    writer.WriteLine(SurnameTextBox);
                    writer.WriteLine(BirthdayDateTimePicker);
                    writer.WriteLine(PhoneTextBox);
                    writer.WriteLine(EmailTextBox);
                    writer.WriteLine(VKTextBox);
                    writer.Close();

                    NameTextBox.Text = "";
                    SurnameTextBox.Text = "";
                    BirthdayDateTimePicker.Text = "";
                    PhoneTextBox.Text = "";
                    EmailTextBox.Text = "";
                    VKTextBox.Text = "";

                   MessageBox.Show("Контакт сохранен");
                }
            }
        }
    }
}
