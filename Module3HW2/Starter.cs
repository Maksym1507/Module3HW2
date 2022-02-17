using System;
using System.Collections.Generic;
using System.Globalization;
using Module3HW2.Models;
using Module3HW2.Services;

namespace Module3HW2
{
    public class Starter
    {
        private List<Contact> Contacts { get; } = new List<Contact>()
            {
                new Contact("Bubokop", "Yunky", "Sanich", 0635672525),
                new Contact("Ivanov", "Dmitriy", "Romanovich", 0956235694),
                new Contact("Kalibaba", "Dmitriy", "Evgenievich", 0956235694),
                new Contact("Шмидт", "Александр", "Евгениевич", 0636129674),
                new Contact("?Порфенов", "Олег", "Владимирович", 0986726496),
                new Contact("Власов", "Владислав", "Петрович", 0672954348),
                new Contact("Антипов", "Николай", "Федорович", 0996726756),
                new Contact("Treskov", "Pavel", "Olekseevich", 0636129674),
                new Contact("6Franko", "Sergey", "Olegovich", 0668792077),
                new Contact("$Gregoriy", "Nemchinsiy", "Antonovich", 0636128912),
                new Contact("Barlomov", "Leonid", "Kirillovich", 0960101627),
                new Contact("0686698814", "Дмитрий", "Якович", 0686698814),
                new Contact("21Starichenko", "Vladislav", "Sergeevich", 0956235694),
                new Contact("Потемкин", "Антон", "Ростиславович", 0506718679),
                new Contact("Филипов", "Антон", "Бедросович", 0984723545),
                new Contact("Зеленский", "Владимир", "Александрович", 0975682376),
                new Contact("Андропов", "Самойло", "Нефёдович", 0734754365),
                new Contact("Franko", "Ivan", "Yakovich", 0955431256),
                new Contact("(:Shevchenko", "Taras", "Grigorievich", 0662675456),
                new Contact("Мельник", "Мария", "Михайловна", 0992564651),
                new Contact("Илларионов", "Максим", "Yurievich", 0994362363),
                new Contact("Bogom Dan", "Bogdan", "Eh Bogdan", 0954356723)
            };

        public void Run()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Enter local en/ru: ");

                CultureInfo cultureInfo = Console.ReadLine() switch
                {
                    "en" => new CultureInfo("en-GB"),
                    "ru" => new CultureInfo("ru-RU"),
                    _ => new CultureInfo("en-GB"),
                };

                var contactsService = new ContactListService(cultureInfo);

                contactsService.AddContacts(Contacts);

                Console.WriteLine("Contact book");

                contactsService.ShowContacts();

                contactsService.ClearContacts();
            }
        }
    }
}
