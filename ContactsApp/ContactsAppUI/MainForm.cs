using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
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

        private readonly BindingList<Contact> _contacts;
        private readonly ProjectManager _projectManager;

        public ContactsApp()
        {
            InitializeComponent();

            BirthDayUserControl.Visible = false;

            _projectManager = new ProjectManager(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "ContactApp.contacts"));
            _project = _projectManager.IsExistProjectFile() 
                ? _projectManager.LoadFromFile() 
                : new Project();

            _contacts = new BindingList<Contact>(_project.Contacts.ToList());
            ContactsList.DataSource = _contacts;
            ShowListBoxContact();

            var clock = new Clock();
            clock.NewDay += (sender, args) => CheckContactsOnBirthDay();

            CheckContactsOnBirthDay();          
        }

        /// <summary>
        ///     Вывод выбранного контакта для просмотра
        /// </summary>
        /// < param name=" sender "> </param>
        /// < param name=" e "> </param>
        private void ContactsList_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateSelectedContact();
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
                _project.SortContact();
                _contacts.Clear();

                foreach (var contact in _project.SortContact())
                {
                    _contacts.Add(contact);
                }
            }

            CheckContactsOnBirthDay();
        }

        private void UpdateSelectedContact()
        {
            if (ContactsList.SelectedItem is Contact contact)
            {
                SurnameTextBox.Text = contact.Surname;
                NameTextBox.Text = contact.Name;
                EmailTextBox.Text = contact.Email;
                VKTextBox.Text = contact.VK;
                BirthdayDayTool.Value = contact.Birthday.Date;
                PhoneTextBox.Text = contact.Number.Number.ToString();
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
            var selectContact = ContactsList.SelectedItem;

            addContactForm.NewContact = selectContact as Contact;
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
                "Вы точно хотите удалить контакт: " + ContactsList.SelectedItem,
                "Удаление контакта", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                var selectContact = ContactsList.SelectedItem;

                _project.Contacts.Remove(selectContact as Contact);
                _contacts.Remove(selectContact as Contact);

                ShowListBoxContact();
                CheckContactsOnBirthDay();
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
            UpdateSelectedContact();
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
            UpdateSelectedContact();
        }

        private void EditContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethEditContact();
            UpdateSelectedContact();
        }

        private void RemoveContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethRemoveContact();
            UpdateSelectedContact();
        }

        /// <summary>
        ///     Заполнить список контактов. Если в списке уже есть данные (список ранее был заполнен),
        ///     то список будет очищен и снова заполнен.
        /// </summary>
        public void ShowListBoxContact()
        {
            _contacts.Clear();

            if (_project.Contacts.Count <= 0)
                return;

            foreach (var t in _project.SortContact()) _contacts.Add(t);
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
            UpdateSelectedContact();
            _contacts.Clear();
            ContactsList.Refresh();
            var searchString = FindTextBox.Text;
            var result = _project.FindContacts(_project.Contacts, searchString);

            foreach (var contact in result) _contacts.Add(contact);
        }

        /// <summary>
        ///     Проверить список контактов на пользователей у которых сегодня день рождения
        /// </summary>
        private void CheckContactsOnBirthDay()
        {
            BirthDayUserControl.Clear();
            var birthdayList = _project.ShowBirthdayList(DateTime.Now);
            if (birthdayList.Any())
            {
                BirthDayUserControl.Visible = true;
                BirthDayUserControl.SetBirhdayContact(birthdayList);
            }
            else
            {
                BirthDayUserControl.Visible = false;
            }
        }
    }
}