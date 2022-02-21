using System;
using System.Globalization;
using System.Collections.Generic;
using Module3HW2.Models;
using Module3HW2.Interfaces;

namespace Module3HW2.Services
{
    public class ContactListService : IContactListService
    {
        private readonly IAlphabetConfigurationService _alphabetConfigurationService;

        public ContactListService(IAlphabetConfigurationService alphabetConfigurationService)
        {
            ContactsList = new Dictionary<string, List<Contact>>();

            _alphabetConfigurationService = alphabetConfigurationService;

            Alphabet = _alphabetConfigurationService.DeserializeAlphabets(@"C:\Users\Maksym\Desktop\Module3HW2\Module3HW2\config.json");
        }

        public Dictionary<string, List<Contact>> ContactsList { get; set; }

        public CultureInfo CultureInfo { get; set; }

        private Alphabet Alphabet { get; }

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

        public void SetCulture(CultureInfo cultureInfo)
        {
            CultureInfo = cultureInfo ?? throw new NullReferenceException();
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

        public void InitDictionary()
        {
            for (int i = 0; i < Alphabet.Alphabets[CultureInfo.Name].Length; i++)
            {
                ContactsList.Add(Alphabet.Alphabets[CultureInfo.Name][i].ToString(), new List<Contact>());
            }

            ContactsList.Add("#", new List<Contact>());
            ContactsList.Add("0-9", new List<Contact>());
        }
    }
}
