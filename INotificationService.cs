using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.
//We then create three classes: EmailNotificationService, SmsNotificationService, and PushNotificationService, which implement the INotificationService interface.
//In each implementation, we provide the logic to send notifications through the respective communication channel:
//The EmailNotificationService class simulates sending an email by outputting a message to the console.
//The SmsNotificationService class simulates sending an SMS by outputting a message to the console.
//The PushNotificationService class simulates sending a push notification by outputting a message to the console.
//In the Main method, we create instances of each notification service class and call the SendNotification method with sample recipient and message values.
//This implementation allows you to easily switch between different notification channels
//by creating new classes that implement the INotificationService interface and provide the specific logic for each channel.


namespace OOP4
{
    public interface INotificationService
    {
        public void SendNotification(string recipient,string message);
    }
    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"MR/MRS {recipient} this is your Email {message}");
        }
    }
    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"MR/MRS {recipient} this is your SMS  {message}");
        }
    }
    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"MR/MRS {recipient} this is your Push Notification {message}");
        }
    }

}
