using System;
using System.IO;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class ContactsApp : Form
    {
        /// <summary>
        ///     Экземпляр списка контактов после поиска
        /// </summary>
        private readonly Project _project;

        private readonly ProjectManager _projectManager;

        public ContactsApp()
        {
            InitializeComponent();


            _projectManager = new ProjectManager(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "ContactApp.contacts"));
            if (_projectManager.IsExistProjectFile())
            {
                _project = _projectManager.LoadFromFile();
                ShowListBoxContact();
            }
            else
            {
                _project = new Project();
            }
        }

        /// <summary>
        ///     Вывод выбранного контакта для просмотра
        /// </summary>
        /// < param name=" sender "> </param>
        /// < param name=" e "> </param>
        private void ContactsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsList.SelectedIndex < 0)
                return;
            var contact = _project.Contacts;
            var selectIndex = ContactsList.SelectedIndex;

            SurnameTextBox.Text = contact[selectIndex].Surname;
            NameTextBox.Text = contact[selectIndex].Name;
            EmailTextBox.Text = contact[selectIndex].Email;
            VKTextBox.Text = contact[selectIndex].VK;
            BirthdayDayTool.Value = contact[selectIndex].Birthday.Date;
            PhoneTextBox.Text = contact[selectIndex].Number.Number.ToString();
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            MethAddContact();
        }

        public void MethAddContact()
        {
            var addContactForm = new AddEditContactsForm();

            addContactForm.ShowDialog();

            if (addContactForm.DialogResult == DialogResult.OK)
            {
                _project.Contacts.Add(addContactForm.NewContact);
                ContactsList.Items.Add($"{addContactForm.NewContact.Name} " +
                                       $"{addContactForm.NewContact.Surname}");
            }
        }

        /// <summary>
        ///     Метод изменения контакта. Контакт должен изменяться поштучно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemovContactButton_Click(object sender, EventArgs e)
        {
            MethEditContact();
        }

        public void MethEditContact()
        {
            if (ContactsList.SelectedItem == null)
            {
                MessageBox.Show("Контакт не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var addContactForm = new AddEditContactsForm();
            var selectContact = _project.Contacts[ContactsList.SelectedIndex];

            addContactForm.NewContact = selectContact;
            addContactForm.ShowDialog();

            ShowListBoxContact();
        }

        public void MethRemoveContact()
        {
            if (ContactsList.SelectedItem == null)
            {
                MessageBox.Show("Контакт не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show(
                "Вы точно хотите удалить контакт: " + ContactsList.Items[ContactsList.SelectedIndex],
                "Удаление контакта", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                var selectContact = _project.Contacts[ContactsList.SelectedIndex];

                _project.Contacts.Remove(selectContact);
                ContactsList.Items.Remove(selectContact);

                ShowListBoxContact();
            }
        }

        /// < summary>
        ///     Кнопка удаления контакта
        /// </summary>
        /// < param name=" sender "> </param>
        /// < param name=" e "> </param>
        private void DeleteContactButton_Click(object sender, EventArgs e)
        {
            MethRemoveContact();
        }


        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.ShowDialog();
        }

        private void AddContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethAddContact();
        }

        private void EditContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethEditContact();
        }

        private void RemoveCpntactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethRemoveContact();
        }

        /// <summary>
        ///     Заполнить список контактов. Если в списке уже есть данные (список ранее был заполнен),
        ///     то список будет очищен и снова заполнен.
        /// </summary>
        public void ShowListBoxContact()
        {
            ContactsList.Items.Clear();
            ClearAll();

            if (_project.Contacts.Count <= 0)
                return;

            foreach (var t in _project.Contacts) ContactsList.Items.Add($"{t.Name} {t.Surname}");
        }

        public void ClearAll()
        {
            SurnameTextBox.Text = "";
            NameTextBox.Text = "";
            EmailTextBox.Text = "";
            VKTextBox.Text = "";
            PhoneTextBox.Text = "";
        }


        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void ContactsApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            _projectManager.SaveToFile(_project);
        }

        private void FindTextBoxOnTextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                ContactsList.Items.Clear();
                var searchString = textBox.Text;

                foreach (var contact in _project.Contacts)
                {
                    if ($"{contact.Name} {contact.Surname}".Contains(searchString))
                    {
                        ContactsList.Items.Add($"{contact.Name} {contact.Surname}");
                    }
                }
            }
        }
    }
}