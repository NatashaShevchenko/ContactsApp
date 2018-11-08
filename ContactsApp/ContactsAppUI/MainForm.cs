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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Contact contact = new Contact();
            contact.Surname = "Shevchenko";
            contact.Name = "Natasha";
            contact.VK = "9876543";
            contact.Email = "NatashaShevchenko@gmail.com";
            contact.Email = "27.07.1996";

            //DateTime datetime = dateTimePicker1.Value;

            //создать один-два контакта
            //создать проект и поместить в него два контакта
            //с помощью ProjectManager сохранить проект в какой-нибудь файл
        }
    }
}
