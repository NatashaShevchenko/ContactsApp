using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class ContactsApp : Form
    {
        private List<Contact> _contact = new List<Contact>();
     

        public ContactsApp()
        {
            InitializeComponent();
  

            Contact contact = new Contact();
            contact.Surname = "Shevchenko";
            contact.Name = "Natasha";
            contact.VK = "9876543";
           // contact.Number = 123;
            contact.Email = "NatashaShevchenko@gmail.com";
            contact.Birthday = new DateTime(1996, 07, 27);

            Project project = new Project();
            project.Contacts.Add(contact);
            ProjectManager.SaveToFile(project, "filename");

        
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            AddEditContactsForm addContact = new AddEditContactsForm();
            addContact.ShowDialog(); 

           
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditContactsForm addContact = new AddEditContactsForm();
            addContact.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                this.Close();
        }

        

        /// < summary >
        /// Кнопка удаления контакта
        /// </ summary >
        /// < param  name = " sender " > </ param >
        /// < param  name = " e " > </ param >
        private void DeleteContactButton_Click(object sender, EventArgs e)
        {
            int index = ContactsList.SelectedIndices[0];
            _contact.RemoveAt(index);
           //ContactsList.Items[index].Remove();

        }

        /// <summary>
        /// Вывод выбранного контакта для просмотра
        /// </summary>
        /// < param  name = " sender " > </ param >
        /// < param  name = " e " > </ param >
        private void ContactsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsList.SelectedIndices.Count != 0)
            {
                SurnameTextBox.Text = _contact[ContactsList.SelectedIndices[0]].Surname;
                NameTextBox.Text = _contact[ContactsList.SelectedIndices[0]].Name;
                BirthdayDayTool.Value = _contact[ContactsList.SelectedIndices[0]].Birthday;
                PhoneTextBox.Text = Convert.ToString(_contact[ContactsList.SelectedIndices[0]].Number);
                EmailTextBox.Text = _contact[ContactsList.SelectedIndices[0]].Email;
                VKTextBox.Text = _contact[ContactsList.SelectedIndices[0]].VK;
            }
        }
    }

}

