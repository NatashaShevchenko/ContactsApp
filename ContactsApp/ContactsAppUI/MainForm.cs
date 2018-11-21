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
        private List<Contact> _contacts = new List<Contact>();

        public MainForm()
        {
            InitializeComponent();

        
            //this.Text = "Главное окно программы";
            //this.Size = new Size(400, 250);

            //var button = new Button();
            //button.Text = "Сменить заголовок окна";
            //button.Size = new Size(150, 25);
            //button.Location = new Point(150, 150);

            ////Подписываем кнопку на обработчик
            //button.Click += Button_Click;

            ////Помещаем кнопку на форму
            //this.Controls.Add(button);





            Contact contact = new Contact();
            contact.Surname = "Shevchenko";
            contact.Name = "Natasha";
            contact.VK = "9876543";
            contact.Email = "NatashaShevchenko@gmail.com";
            contact.Birthday = new DateTime(1996, 07, 27);
            Project project = new Project();
            project.Contacts.Add(contact);
            ProjectManager.SaveToFile(project, "filename");

            //Contact c1 = ProjectManager.LoadFromFile("Filename");
            //Для текстбокса, чтобы выводил день рождения
            // DateTime t = c1.Birthday;

            // DateTime datetime = dateTimePicker1.Value;

            //создать один-два контакта
            //создать проект и поместить в него два контакта
            //с помощью ProjectManager сохранить проект в какой-нибудь файл
        }
       
       

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ContactsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Обработчик события нажатия кнопки
        //private void Button_Click(object sender, EventArgs e)
        //{
        //   //Здесь пишем код, который должен выполняться
        //    // каждый раз при нажатии на кнопку.
        //    this.Text = "Новый заголовок";
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{

        //    //Здесь пишем код, который должен выполняться
        //    // каждый раз при нажатии на кнопку.
        //   this.Text = "Новый заголовок";
        //}
    }

}

