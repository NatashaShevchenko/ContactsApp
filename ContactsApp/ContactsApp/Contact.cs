using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс контакты, в котором хранится информация о фамилии, имени, номере телефона
    /// почты, вк пользователя
    /// </summary>
    public class Contact
    {
        public PhoneNumber Number { get; set; } = new PhoneNumber();
        private string _surname;
        private string _name;
        private DateTime _birthday;
        private string _email;
        private string _vk;

        /// <summary>
        /// Задает и возвращает фамилию контакта
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Поле Фамилии не может быть пустым");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException(
                        "Фамилия должна быть короче 50-ти символов");
                }
                else
                    _surname = char.ToUpper(value[0]) + value.Substring(1);
            }
        }
        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Поле имени не может быть пустым");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException(
                        "Имя должно быть короче 50-ти символов");
                }
                else
                    _name = char.ToUpper(value[0]) + value.Substring(1);
            }
        }

        /// <summary>
        /// Возвращает и задает email контакта.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if (value != null)
                {
                    if (value.Length > 50)
                    {
                        throw new ArgumentException("E-mail не может быть больше 50 символов");
                    }
                    else
                        _email = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задает id вконтакте.
        /// </summary>
        public string VK
        {
            get => _vk;
            set
            {
                if (value != null)
                {
                    if (value.Length > 15)
                    {
                        throw new ArgumentException("ID VK должно быть короче 15 символов");
                    }
                    else
                        _vk = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задает дату рождения контакта.
        /// </summary>
        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                if (value > DateTime.Today)
                {
                    throw new ArgumentException("Дата рождения не может быть раньше текущего времени, а была" + value.Date.ToLongDateString());
                }
                else if (value.Year < 1900)
                {
                    throw new IndexOutOfRangeException("Дата рождения не может быть ранее 1900-го года");
                }
                else
                    _birthday = value;
            }
        }

        /// <summary>
        /// Клонирование объекта.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            var newContact = new Contact();

            newContact.Name = Name;
            newContact.Surname = Surname;
            newContact.Birthday = Birthday;
            newContact.Email = Email;
            newContact.VK = VK;
            newContact.Number.Number = Number.Number;

            return newContact;
        }

    }
}
