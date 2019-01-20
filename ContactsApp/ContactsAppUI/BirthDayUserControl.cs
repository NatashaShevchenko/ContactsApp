using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class BirthDayUserControl : UserControl
    {
        public BirthDayUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Установить отображение фамилий контактов, у которых день рожение
        /// </summary>
        /// <param name="contacts"></param>
        public void SetBirhdayContact(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                if (string.IsNullOrEmpty(birthdayContactsLabel.Text))
                {
                    birthdayContactsLabel.Text += contact.Surname;
                    continue;
                }
                birthdayContactsLabel.Text += $", {contact.Surname}";
            }
        }

        /// <summary>
        /// Очистить отображение фамилий контактов, у которых день рожение
        /// </summary>
        public void Clear()
        {
            birthdayContactsLabel.Text = string.Empty;
        }
    }
}
