using System;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.UnitTest
{
    /// <summary>
    /// Тесты для Contact.
    /// </summary>
    [TestFixture]
    public class ContactTest
    {
        private Contact _contact;
        private PhoneNumber _number;

        [SetUp]
        public void InitContact()
        {
            _contact = new Contact();
            _number = new PhoneNumber();
        }

        /// <summary>
        /// Позитивный тест Get Surname
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="message"></param>
        [TestCase("Смирнов", "Выполняется, если фамилия удачно присваевается",
            TestName = "Позитивный тест геттера Surname")]

        [Category("SurnameTests")]
        public void TestSurnameGet_CorrectValue(string expected, string message)
        {
            _contact.Surname = expected;
            var actual = _contact.Surname;

            Assert.AreEqual(expected, actual, "Геттер возвращает неправильную фамилию");
        }

        /// <summary>
        /// Позитивный тест Get Name
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="message"></param>
        [TestCase("Наталья", "Выполняется, если имя удачно присваевается",
            TestName = "Позитивный тест геттера Name")]
        public void TestNameGet_CorrectValue(string expected, string message)
        {
            _contact.Name = expected;
            var actual = _contact.Name;

            Assert.AreEqual(expected, actual, "Геттер возвращает неправильное имя");
        }

        /// <summary>
        /// Позитивный тест Get Birhday
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="message"></param>
        [TestCase("2000.01.01", "Выполняется, если присвоение даты происходит коректно",
            TestName = "Позитивый тесте геттера Birhday")]
        public void TestDateGet_CorrectValue(DateTime expected, string message)
        {
            _contact.Birthday = expected;
            var actual = expected;
            Assert.AreEqual(expected, actual, message);
        }

        /// <summary>
        /// Позитивный тест Get Email
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="message"></param>
        [TestCase("Natasha@gmail.com", "Выполняется, если почтовый ящик удачно присваевается",
            TestName = "Позитивный тест геттера Email")]
        public void TestEmailGet_CorrectValue(string expected, string message)
        {
            _contact.Email = expected;
            var actual = _contact.Email;
            Assert.AreEqual(expected, actual, "Геттер возвращает неправильный почтовый ящик");
        }

        /// <summary>
        /// Позитивный тест Get VK
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="message"></param>
        [TestCase("123456", "Выполняется, если id Вконтакте удачно присваевается",
            TestName = "Позитивный тест геттера VK")]
        public void TestVkGet_CorrectValue(string expected, string message)
        {
            _contact.VK = expected;
            var actual = _contact.VK;

            Assert.AreEqual(expected, actual, "Геттер возвращает неправильный почтовый ящик");
        }

        /// <summary>
        /// Позитивный тест Get Number
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="message"></param>
        [TestCase(79528854134, "Выполняется если номер телефона удачно присваевается",
            TestName = "Позитивный тест метода Set Number")]
        public void TestPhoneNumberGet_CorrectValue(long expected, string message)
        {
            _number.Number = expected;
            var actual = _number.Number;

            Assert.AreEqual(expected, actual, message);
        }

        /// <summary>
        /// Тесты Set Surname
        /// </summary>
        /// <param name="wrongSurname"></param>
        /// <param name="expectedException"></param>
        /// <param name="message"></param>
        [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов", typeof(ArgumentException),
            "Должно возникать исключение, если фамилия длиннее 50 символов"
        , TestName = "Присвоение неправильной фамилии больше 50 символов")]
        [TestCase("", typeof(ArgumentNullException), "Должно возникнуть исключение, если фамилия - пустая строка",
            TestName = "Присвоение пустой строки в качестве фамилии")]
        public void TestSurnameSet_ArgumentException(string wrongSurname, Type expectedException, string message)
        {
            NUnit.Framework.Assert.Throws(expectedException, () => { _contact.Surname = wrongSurname; }, message);
        }

        /// <summary>
        /// Тесты Set Name
        /// </summary>
        /// <param name="wrongName"></param>
        /// <param name="expectedException"></param>
        /// <param name="message"></param>
        [TestCase("Наташа-Наташа-Наташа-Наташа-Наташа-Наташа-Наташа-Наташа-Наташа", typeof(ArgumentException),
            "Должно возникать исключение, если имя длиннее 50 символов"
            , TestName = "Присвоение неправильного имени больше 50 символов")]
        [TestCase("", typeof(ArgumentNullException), "Должно возникнуть исключение, если имя - пустая строка",
            TestName = "Присвоение пустой строки в качестве имени")]
        public void TestNameSet_ArgumentException(string wrongName, Type expectedException, string message)
        {
            NUnit.Framework.Assert.Throws(expectedException, () => { _contact.Name = wrongName; }, message);
        }

        /// <summary>
        /// Тесты Set Birhday
        /// </summary>
        /// <param name="wrongDate"></param>
        /// <param name="message"></param>
        [TestCase("2090.01.01", typeof(ArgumentException), "Должно возникнуть изсключение, если дата больше нынешней даты",
                TestName = "Ожидается исключение, если дата больше нынешней даты")]
        public void TestDateSet_ArgimenExpected(DateTime wrongDate, Type expectedException, string message)
        {
            NUnit.Framework.Assert.Throws(expectedException, () => { _contact.Birthday = wrongDate; }, message);
        }


        /// <summary>
        /// Тесты Set Email
        /// </summary>
        /// <param name="wrongEmail"></param>
        /// <param name="expectedException"></param>
        /// <param name="message"></param>
        [TestCase("sdfsdadffefjkszkdjfkljsdfjksdjfddsfdfsdeffvcxwerewrsdfcfdg.com", typeof(ArgumentException),
            "Должно возникать исключение, если почтовый ящик длиннее 50 символов"
            , TestName = "Присвоение неправильного почтового ящика больше 50 символов")]
        public void TestEmailSet_ArgumentNullException(string wrongEmail, Type expectedException, string message)
        {
            NUnit.Framework.Assert.Throws(expectedException, () => { _contact.Email = wrongEmail; }, message);

        }

        /// <summary>
        /// Тесты Set VK
        /// </summary>
        /// <param name="wrongVkId"></param>
        /// <param name="expectedException"></param>
        /// <param name="message"></param>
        [TestCase("id@sdfsfddfkslfdsfsdfbdfgredsfdfsdfdc", typeof(ArgumentException),
            "Должно возникать исключение, если id Вконтакте длиннее 15 символов"
            , TestName = "Присвоение неправильного id Вконтакте больше 15 символов")]
       
        public void TestVkSet_ArgumentNullException(string wrongVK, Type expectedException, string message)
        {
            NUnit.Framework.Assert.Throws(expectedException, () => { _contact.VK = wrongVK; }, message);
        }

        /// <summary>
        /// Тест Set PhoneNumber
        /// </summary>
        /// <param name="wrongNumber"></param>
        /// <param name="expectedException"></param>
        /// <param name="message"></param>
        [TestCase("", typeof(ArgumentNullException), "Должно возникнуть исключение, если номер телефона - пустая строка",
           TestName = "Присвоение пустой строки в качестве телефона")]
        [TestCase(7941234567888999, typeof(ArgumentException), "Должно возникнуть исключение, если длинна номера телефона не 11 символов",
            TestName = "Присвоение неправильного номера телефона - длинна номера не 11 символов")]
        public void TestPhoneNumberSet_FormatExpected(long wrongNumber, Type expectedException, string message)
        {
            NUnit.Framework.Assert.Throws(expectedException, () => { _number.Number = wrongNumber; }, message);
        }
    }
}