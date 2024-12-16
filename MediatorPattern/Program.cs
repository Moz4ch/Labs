using Mediator_Pattern_Chat;


namespace ChatSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatMediator chatMediator = new ChatMediator();

            User user1 = new User("Данил", chatMediator);
            User user2 = new User("Влад", chatMediator);
            User user3 = new User("Настя", chatMediator);

            chatMediator.AddUser(user1);
            chatMediator.AddUser(user2);
            chatMediator.AddUser(user3);

            user1.SendMessage("Всем привет", "Влад");
            user2.SendMessage("Я работаю!", "Данил");
            user3.SendMessage("Когда спать?", "Влад");

            Console.WriteLine();
            chatMediator.ShowMessageHistory("Данил");
            Console.WriteLine();
            chatMediator.ShowMessageHistory("Влад");
            Console.WriteLine();
            chatMediator.ShowMessageHistory("Настя");

            Console.WriteLine();
            chatMediator.RemoveUser("Настя");
        }
    }
}