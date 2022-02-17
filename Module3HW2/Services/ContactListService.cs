using System;
using System.Globalization;
using System.Collections.Generic;
using Module3HW2.Models;

namespace Module3HW2.Services
{
    public class ContactListService
    {
        public ContactListService(CultureInfo cultureInfo)
        {
            CultureInfo = cultureInfo.Name;

            if (CultureInfo == "ru-RU")
            {
                ContactsList = new Dictionary<string, List<Contact>>()
                {
                    { "А", new List<Contact>() },
                    { "Б", new List<Contact>() },
                    { "В", new List<Contact>() },
                    { "Г", new List<Contact>() },
                    { "Д", new List<Contact>() },
                    { "Е", new List<Contact>() },
                    { "Ё", new List<Contact>() },
                    { "Ж", new List<Contact>() },
                    { "З", new List<Contact>() },
                    { "И", new List<Contact>() },
                    { "Й", new List<Contact>() },
                    { "К", new List<Contact>() },
                    { "Л", new List<Contact>() },
                    { "М", new List<Contact>() },
                    { "Н", new List<Contact>() },
                    { "О", new List<Contact>() },
                    { "П", new List<Contact>() },
                    { "Р", new List<Contact>() },
                    { "С", new List<Contact>() },
                    { "Т", new List<Contact>() },
                    { "У", new List<Contact>() },
                    { "Ф", new List<Contact>() },
                    { "Х", new List<Contact>() },
                    { "Ц", new List<Contact>() },
                    { "Ч", new List<Contact>() },
                    { "Ш", new List<Contact>() },
                    { "Щ", new List<Contact>() },
                    { "Ъ", new List<Contact>() },
                    { "Ы", new List<Contact>() },
                    { "Ь", new List<Contact>() },
                    { "Э", new List<Contact>() },
                    { "Ю", new List<Contact>() },
                    { "Я", new List<Contact>() },
                    { "#", new List<Contact>() },
                    { "0-9", new List<Contact>() }
                };
            }
            else
            {
                ContactsList = new Dictionary<string, List<Contact>>()
                {
                    { "A", new List<Contact>() },
                    { "B", new List<Contact>() },
                    { "C", new List<Contact>() },
                    { "D", new List<Contact>() },
                    { "E", new List<Contact>() },
                    { "F", new List<Contact>() },
                    { "G", new List<Contact>() },
                    { "H", new List<Contact>() },
                    { "I", new List<Contact>() },
                    { "J", new List<Contact>() },
                    { "K", new List<Contact>() },
                    { "L", new List<Contact>() },
                    { "M", new List<Contact>() },
                    { "N", new List<Contact>() },
                    { "O", new List<Contact>() },
                    { "P", new List<Contact>() },
                    { "Q", new List<Contact>() },
                    { "R", new List<Contact>() },
                    { "S", new List<Contact>() },
                    { "T", new List<Contact>() },
                    { "U", new List<Contact>() },
                    { "V", new List<Contact>() },
                    { "W", new List<Contact>() },
                    { "X", new List<Contact>() },
                    { "Y", new List<Contact>() },
                    { "Z", new List<Contact>() },
                    { "#", new List<Contact>() },
                    { "0-9", new List<Contact>() }
                };
            }
        }

        public Dictionary<string, List<Contact>> ContactsList { get; set; }

        private string CultureInfo { get; set; }

        public void AddContacts(List<Contact> contacts)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                if (char.IsDigit(contacts[i].FullName[0]))
                {
                    ContactsList["0-9"].Add(contacts[i]);
                }
                else if (!char.IsLetter(contacts[i].FullName.ToUpper()[0]))
                {
                    ContactsList["#"].Add(contacts[i]);
                }
                else
                {
                    bool ifAdded = false;

                    foreach (var item in ContactsList)
                    {
                        if (contacts[i].FullName.ToUpper().StartsWith($"{item.Key}"))
                        {
                            ContactsList[item.Key].Add(contacts[i]);
                            ifAdded = true;
                        }
                    }

                    if (!ifAdded)
                    {
                        ContactsList["#"].Add(contacts[i]);
                    }
                }
            }
        }

        public void ClearContacts()
        {
            ContactsList.Clear();
        }

        public void ShowContacts()
        {
            foreach (var item in ContactsList)
            {
                if (ContactsList[item.Key].Count != 0)
                {
                    item.Value.Sort();

                    Console.WriteLine($"{item.Key}");

                    for (int i = 0; i < item.Value.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {item.Value[i]}");
                    }
                }
            }
        }
    }
}
