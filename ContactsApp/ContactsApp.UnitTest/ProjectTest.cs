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
            var contact = new Contact
            {
                Name = "Natasha",
                Surname = "Shevchenko",
                Birthday = new DateTime(2000, 01, 01),
                VK = "3456533",
                Email = "Natasha@gmail.com"
            };

            var project = new Project(new List<Contact>(){contact});
            project.Contacts.Add(contact);
            var actual = new List<Contact>(){contact, contact};

            CollectionAssert.AreEqual(project.Contacts, actual, "");
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
            CollectionAssert.AreEqual(project.Contacts, contact, "");
        }

        [Test(Description = "Проверка создания экземпляра " +
                            "класса без передачи аргументов конструктору")]
        public void ConstructorTest_WithoutParameter()
        {
            var project = new Project();
            Assert.NotNull(project);
            Assert.NotNull(project.Contacts);
        }

        [Test(Description = "Проверка создания экземпляра " +
                            "класса при передаче null конструктору")]
        public void ConstructorTest_NullParameter()
        {
            var project = new Project(null);
            Assert.NotNull(project);
            Assert.NotNull(project.Contacts);
        }
    }
}
