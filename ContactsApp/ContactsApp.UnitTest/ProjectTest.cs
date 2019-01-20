using System;
using NUnit.Framework;
using ContactsApp;
using System.Collections.Generic;

namespace ContactsApp.UnitTest
{
    /// <summary>
    /// Тесты для Project.
    /// </summary>
    [TestFixture]
    public class ProjectTest
    {
       
        [Test(Description = "Проверка добавления контакт в Project")]
        public void TestAddContactToProject()
        {
            var contact = new Contact();
            contact.Name = "Natasha";
            contact.Surname = "Shevchenko";
            contact.Birthday = new DateTime(2000, 01, 01); ;
            //contact.Number = 9999999999;
            contact.VK = "3456533";
            contact.Email = "Natasha@gmail.com";

            var project = new Project(new List<Contact>(){contact});
            project.Contacts.Add(contact);
            var actual = project.Contacts;
            Assert.AreEqual(project.Contacts, actual, "");
        }

        [Test(Description = "Проверка списка контактов в Project")]
        public void TestListContactToProject()
        {
            var contact = new List<Contact>
            {
                new Contact {Name = "Name 1"},
                new Contact {Name = "Name 2"},
                new Contact {Name = "Name 3"}
            };

            var project = new Project(contact);
            Assert.AreEqual(project.Contacts, contact, "");
        }
    }
}
