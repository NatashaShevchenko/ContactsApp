using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Project
    {
        public Project(List<Contact> contacts = null)
        {
            Contacts = contacts ?? new List<Contact>();
        }

        public List<Contact> Contacts { get; }

        /// <summary>
        /// Метод сортировки списка контактов в алфавитном порядке
        /// </summary>
        /// <param name="contactsList">Список контактов</param>
        /// <returns>Отсортированный список контактов</returns>
        public List<Contact> SortContact(List<Contact> contactsList = null)
        {
            var sortingList = contactsList ?? Contacts;
            //Сортировка списка контактов
            sortingList.Sort(delegate (Contact x, Contact y)
            {
                if (x.Surname == null && y.Surname == null) return 0;
                else if (x.Surname == null) return -1;
                else if (y.Surname == null) return 1;
                else return x.Surname.CompareTo(y.Surname);
            });
            return sortingList;
        }

        /// <summary>
        /// Метод поиска списка контактов по фамилии, имени и номеру телефона
        /// </summary>
        /// <param name="contactsList">Список контактов</param>
        /// <param name="substring">Подсрока по которой осуществляется поиск</param>
        /// <returns>Найденный список контактов</returns>
        public List<Contact> FindContacts(List<Contact> contactsList, string substring)
        {
            List<Contact> findedContacts = new List<Contact>();
            foreach (var contact in contactsList)
            {
                if (contact.Surname.StartsWith(substring) ||
                    contact.Name.StartsWith(substring) ||
                    contact.Number.Number.ToString().StartsWith(substring))
                {
                    findedContacts.Add(contact);
                }
            }
            return findedContacts;
        }

        public List<Contact> ShowBirthdayList(DateTime date)
        {
            var birthdayContacts = new List<Contact>();
            foreach (var contact in Contacts)
            {
                if (contact.Birthday.Day == date.Day && contact.Birthday.Month == date.Month)
                {
                    birthdayContacts.Add(contact);
                }
            }
            return birthdayContacts;
        }
    }
}
