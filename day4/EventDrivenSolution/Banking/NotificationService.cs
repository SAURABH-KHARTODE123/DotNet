namespace Notification;

public static class NotificationService
{
    public static void SendEmail(string to, string content){
        Console.WriteLine(content + " Email sent to " + to );
    }

    public static void SendSMS(string to, string content){
        Console.WriteLine(content + " SMS sent to " + to );
    }

    public static void SendWhatsApp(string to, string content){
        Console.WriteLine(content + " WhatsApp message sent to " + to  );
    }

}