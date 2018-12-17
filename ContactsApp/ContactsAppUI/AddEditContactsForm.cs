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
using ContactsApp;

namespace ContactsAppUI
{
    public partial class AddEditContactsForm : Form
    {
        private Contact _newContact;

        public AddEditContactsForm()
        {
            InitializeComponent();
            NewContact = new Contact();
        }

        public Contact NewContact
        {
            get { return _newContact; }
            set
            {
                _newContact = value;
                EnterData();
            }
        }
        /// <summary>
        /// Флаг верности ввода имени
        /// </summary>
        private bool _isNameCorrect = false;

        /// <summary>
        /// Флаг верности ввода даты
        /// </summary>
        private bool _isDataCorrect = false;

        /// <summary>
        /// Флаг верности ввода номера телефона
        /// </summary>
        private bool _isPhoneCorrect = false;


        
       /// <summary>
        /// 
        /// </summary>
        public void EnterData()
        {
            SurnameTextBox.Text = _newContact.Surname;
            NameTextBox.Text = _newContact.Name;
            EmailTextBox.Text = _newContact.Email;
            VKTextBox.Text = _newContact.VK;

            if (_newContact.Number.Number != 0)
                PhoneMaskedTextBox.Text = _newContact.Number.Number.ToString();

            if (_newContact.Birthday.Date != DateTime.MinValue)
                BirthdayDateTimePicker.Value = _newContact.Birthday.Date;
        }
        
        public Contact EnterContact()
        {

            try
            {
                NewContact.Surname = SurnameTextBox.Text;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                NewContact.Name = NameTextBox.Text;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                NewContact.Email = EmailTextBox.Text;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                NewContact.VK = VKTextBox.Text;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                NewContact.Birthday = BirthdayDateTimePicker.Value.Date;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


            string str = PhoneMaskedTextBox.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Replace("+", "");
            NewContact.Number.Number = Convert.ToInt64(str.Remove(0, 1));

            return NewContact;
        }


        private void OK_Click(object sender, EventArgs e)
        {
            if (NewContact == null)
                NewContact = new Contact();

            if (EnterContact() == null)
                return;

            this.DialogResult = DialogResult.OK;
              MessageBox.Show("Контакт сохранен");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

       

        private void BirthdayDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           
        }
       
    }
        
    
}
