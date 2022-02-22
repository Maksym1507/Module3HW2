using System.Collections.Generic;
using System.Globalization;
using Module3HW2.Models;

namespace Module3HW2.Interfaces
{
    public interface IContactListService
    {
        public void InitDictionary();

        public void SetCulture(CultureInfo cultureInfo);

        public void AddContacts(List<Contact> contacts);

        public void ClearContacts();

        public void ShowContacts();
    }
}
