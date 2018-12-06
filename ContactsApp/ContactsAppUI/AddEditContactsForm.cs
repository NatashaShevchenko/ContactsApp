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
