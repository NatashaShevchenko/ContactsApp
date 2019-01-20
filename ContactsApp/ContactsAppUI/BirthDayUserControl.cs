using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class BirthDayUserControl : UserControl
    {
        public BirthDayUserControl()
        {
            InitializeComponent();
        }

        public void SetBirhdayContacts(IEnumerable<string> contactSurnames)
        {
            foreach (var contactSurname in contactSurnames)
            {
                birthdayContactsLabel.Text += contactSurname;
            }
        }
    }
}
