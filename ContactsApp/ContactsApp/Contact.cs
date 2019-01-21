using System;

namespace ContactsApp
{
    /// <summary>
    ///     Класс контакты, в котором хранится информация о фамилии, имени, номере телефона
    ///     почты, вк пользователя
    /// </summary>
    public class Contact : IEquatable<Contact>
    {
        private DateTime _birthday;
        private string _email;
        private string _name;
        private string _surname;
        private string _vk;

        public PhoneNumber Number { get; set; } = new PhoneNumber();

        /// <summary>
        ///     Задает и возвращает фамилию контакта
        /// </summary>
        public string Surname
        {
            get => _surname;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentNullException("Поле Фамилии не может быть пустым");
                if (value.Length > 50)
                    throw new ArgumentException(
                        "Фамилия должна быть короче 50-ти символов");

                _surname = char.ToUpper(value[0]) + value.Substring(1);
            }
        }

        /// <summary>
        ///     Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentNullException("Поле имени не может быть пустым");

                if (value.Length > 50)
                    throw new ArgumentException(
                        "Имя должно быть короче 50-ти символов");

                _name = char.ToUpper(value[0]) + value.Substring(1);
            }
        }

        /// <summary>
        ///     Возвращает и задает email контакта.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if (value != null)
                {
                    if (value.Length > 50)
                        throw new ArgumentException("E-mail не может быть больше 50 символов");

                    _email = value;
                }
            }
        }

        /// <summary>
        ///     Возвращает и задает id вконтакте.
        /// </summary>
        public string VK
        {
            get => _vk;
            set
            {
                if (value != null)
                {
                    if (value.Length > 15)
                        throw new ArgumentException("ID VK должно быть короче 15 символов");

                    _vk = value;
                }
            }
        }

        /// <summary>
        ///     Возвращает и задает дату рождения контакта.
        /// </summary>
        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                if (value > DateTime.Today)
                    throw new ArgumentException("Дата рождения не может " +
                                                "быть раньше текущего времени, " +
                                                "а былаvalue.Date.ToLongDateString()");

                if (value.Year < 1900)
                    throw new IndexOutOfRangeException("Дата рождения не может " +
                                                       "быть ранее 1900-го года");

                _birthday = value;
            }
        }

        public bool Equals(Contact other)
        {
            if (other == null)
                return false;

            return Name == other.Name
                   && Surname == other.Surname
                   && VK == other.VK
                   && Birthday == other.Birthday
                   && Email == other.Email
                   && Number.Number == other.Number.Number;
        }

        /// <summary>
        ///     Клонирование объекта.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            var newContact = new Contact
            {
                Name = Name,
                Surname = Surname,
                Birthday = Birthday,
                Email = Email,
                VK = VK,
                Number = {Number = Number.Number}
            };


            return newContact;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}