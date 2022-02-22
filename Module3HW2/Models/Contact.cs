using System;

namespace Module3HW2.Models
{
    public class Contact : IComparable
    {
        public Contact(string surname, string firstName, string patronymic, int phoneNumber)
        {
            Surname = surname;
            FirstName = firstName;
            Patronymic = patronymic;
            FullName = $"{Surname} {FirstName} {Patronymic}";
            PhoneNumber = phoneNumber;
        }

        public string Surname { private get; set; }

        public string FirstName { private get; set; }

        public string Patronymic { private get; set; }

        public string FullName { get; }

        public int PhoneNumber { get; set; }

        public int CompareTo(object obj)
        {
            var contact = obj as Contact;

            return FullName.CompareTo(contact.FullName);
        }

        public override string ToString()
        {
            return $"FIO: {FullName} | Phone number: +380{PhoneNumber}";
        }
    }
}
