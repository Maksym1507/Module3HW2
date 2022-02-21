using System;
using System.Collections.Generic;
using System.Globalization;
using Module3HW2.Models;
using Module3HW2.Interfaces;

namespace Module3HW2
{
    public class Starter
    {
        private readonly IContactListService _contactListService;

        private readonly INotificationService _notificationService;

        public Starter(IContactListService contactListService, INotificationService notificationService)
        {
            _contactListService = contactListService;
            _notificationService = notificationService;
        }

        private List<Contact> Contacts { get; } = new List<Contact>()
            {
                new Contact("Bubokop", "Yunky", "Sanich", 635672525),
                new Contact("Ivanov", "Dmitriy", "Romanovich", 956235694),
                new Contact("Kalibaba", "Dmitriy", "Evgenievich", 956235694),
                new Contact("Шмидт", "Александр", "Евгениевич", 636129674),
                new Contact("?Порфенов", "Олег", "Владимирович", 986726496),
                new Contact("Власов", "Владислав", "Петрович", 672954348),
                new Contact("Антипов", "Николай", "Федорович", 996726756),
                new Contact("Treskov", "Pavel", "Olekseevich", 636129674),
                new Contact("6Franko", "Sergey", "Olegovich", 668792077),
                new Contact("$Gregoriy", "Nemchinsiy", "Antonovich", 636128912),
                new Contact("Barlomov", "Leonid", "Kirillovich", 960101627),
                new Contact("0686698814", "Дмитрий", "Якович", 686698814),
                new Contact("21Starichenko", "Vladislav", "Sergeevich", 956235694),
                new Contact("Потемкин", "Антон", "Ростиславович", 506718679),
                new Contact("Филипов", "Антон", "Бедросович", 984723545),
                new Contact("Зеленский", "Владимир", "Александрович", 975682376),
                new Contact("Андропов", "Самойло", "Нефёдович", 734754365),
                new Contact("Franko", "Ivan", "Yakovich", 955431256),
                new Contact("(:Shevchenko", "Taras", "Grigorievich", 662675456),
                new Contact("Мельник", "Мария", "Михайловна", 992564651),
                new Contact("Илларионов", "Максим", "Yurievich", 994362363),
                new Contact("Bogom Dan", "Bogdan", "Eh Bogdan", 954356723)
            };

        public void Run()
        {
            for (int i = 0; i < 2; i++)
            {
                _notificationService.ShowMessage("Enter local en/ru: ");

                CultureInfo cultureInfo = Console.ReadLine() switch
                {
                    "en" => new CultureInfo("en-GB"),
                    "ru" => new CultureInfo("ru-RU"),
                    _ => new CultureInfo("en-GB"),
                };

                _contactListService.SetCulture(cultureInfo);
                _contactListService.InitDictionary();

                _contactListService.AddContacts(Contacts);

                _notificationService.ShowMessage("Contact book\n");

                _contactListService.ShowContacts();

                _contactListService.ClearContacts();
            }
        }
    }
}
