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
                if (value.Length > 50)
                {
                    throw new ArgumentException("Фамилия должна быть меньше 50 символов.");
                }
                else
                {
                    _surname = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                
                if (value.Length > 50)
                {
                    throw new ArgumentException("Имя должно быть меньше 50 символов");
                }
                else
                    _name = value;
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
                if (value.Length > 50)
                {
                    throw new ArgumentException("Длина Email должна быть менее 50");
                }
                else
                    _email = value;
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
                if (value.Length > 15)
                {
                    throw new ArgumentException("Длина id vk должна быть менее 15");
                }
                else
                    _vk = value;
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
                    throw new ArgumentException("Дата не должна быть больше " + DateTime.Today.ToShortDateString() + ", а была " + value.Date.ToShortDateString());
                }
                else
                    _birthday = value;
            }
        }




    }
}
