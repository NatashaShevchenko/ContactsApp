using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;
using ContactsApp;
using Newtonsoft.Json;

namespace ContactsApp.UnitTest
{
    /// <summary>
    /// Тесты для класса ProjectManager.
    /// </summary>
    [TestFixture]
    public class ProjectManagerTest
    {
        private readonly string _testPath = 
            $"{AppDomain.CurrentDomain.BaseDirectory}test_contacts.json";

        [Test(Description = "Проверка создания экземпляра класса")]
        public void ConstructorTest_TestPath()
        {
            var projectManager = new ProjectManager(_testPath);
            Assert.NotNull(projectManager);
        }

        [Test(Description = "Вызов метода и передача в качестве аргумента null")]
        public void SaveToFileTest_NullParameter()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var projectManager = new ProjectManager(_testPath);
                projectManager.SaveToFile(null);
            });
        }

        [Test(Description = "Вызов метода и передача в качестве " +
                            "аргумента корректную сущность проекта")]
        public void SaveToFileTest_CorrectParameter()
        {
            var contact = GenerateContactList(20);

            var project = new Project(contact);
            var projectManager = new ProjectManager(_testPath);
            projectManager.SaveToFile(project);

            var actualResult = ReadFile();
            var exceptedResult = SerializeProject(project);
            Assert.AreEqual(exceptedResult, actualResult);
        }

        [Test(Description = "Проверка метода загрузки проекта из файла")]
        public void LoadFromFile_CorrectParameter()
        {
            var contacts = GenerateContactList(20);
            var exceptedProject = new Project(contacts);
            SerializeProjectToTestFile(exceptedProject);
            var projectManager = new ProjectManager(_testPath);

            var actualProject = projectManager.LoadFromFile();
            Assert.IsTrue(exceptedProject.Contacts.SequenceEqual(actualProject.Contacts));
        }

        [TearDown]
        public void DeleteTestedFile()
        {
            if (File.Exists(_testPath))
            {
                File.Delete(_testPath);
            }
        }

        private string ReadFile()
        {
            using (var streamReader = new StreamReader(_testPath))
            {
                return streamReader.ReadToEnd();
            }
        }

        private string SerializeProject(Project project)
        {
            var jsonSerializer = JsonSerializer.Create();
            jsonSerializer.Formatting = Formatting.Indented;

            using (StringWriter textWriter = new StringWriter())
            {
                jsonSerializer.Serialize(textWriter, project);
                return textWriter.ToString();
            }
        }

        private void SerializeProjectToTestFile(Project project)
        {
            var jsonSerializer = JsonSerializer.Create();
            jsonSerializer.Formatting = Formatting.Indented;

            using (var streamWriter = new StreamWriter(_testPath))
            using (var jsonWriter = new JsonTextWriter(streamWriter))
            {
                jsonSerializer.Serialize(jsonWriter, project);
            }
        }

        private List<Contact> GenerateContactList(int size)
        {
            var contacts = new List<Contact>();

            for (int i = 1; i < size; i++)
            {
                contacts.Add(new Contact
                {
                    Name = $"Name {i}", Surname = $"Surname {i}",
                    Birthday = DateTime.Now - new TimeSpan(i, 1, 1, 1, 1), Email = $"test{i}@gmail.com",
                    VK = $"id{i}", Number = new PhoneNumber() { Number = i}
                });
            }

            return contacts;
        }
    }
}
