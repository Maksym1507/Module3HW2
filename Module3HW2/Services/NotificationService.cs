using System;
using Module3HW2.Interfaces;

namespace Module3HW2.Services
{
    public class NotificationService : INotificationService
    {
        public void ShowMessage(string message)
        {
            Console.Write(message);
        }
    }
}
