using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс номера телефона, содержащий информацию о длинне номера
    /// </summary>
    public class PhoneNumber
    {
        private long _number;

        /// <summary> 
        /// Возвращает и задает номер телефона.
        /// </summary>
        public long Number
        {
            get => _number;
            set
            {
                if (value.ToString() == string.Empty)
                {
                    throw new ArgumentNullException("Поле не может быть пустым.");
                }
                else if (value.ToString().Length > 11)
                {
                    throw new ArgumentException("Длина номера телефона должна быть меньше 11.");
                }

                _number = value;
            }
        }

    }
}
