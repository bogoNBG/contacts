namespace Telefonen_ukazater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phonebook\n" + "Select:\n" + "1. Add Contact\n" + "2. See Contacts\n" + "3. Search for contact \n" +"4. Delete contact\n" + "x for Exit " );

            Dictionary<string, string> contacts = new();

            var userInput = Console.ReadLine();
            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Contact name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact number:");
                        var num = Console.ReadLine();
                        contacts.Add(name, num);
                        break;

                    case "2":
                        foreach (var cont in contacts)
                        {
                            Console.WriteLine("Name: {0}, Number: {1}", cont.Key, cont.Value);
                        }
                        break;

                    case "3":
                        Console.WriteLine("Exact name of contact:");
                        string value;
                        var key = Console.ReadLine();
                        bool hasValue = contacts.TryGetValue(key, out value);
                        if (hasValue)
                        {
                            Console.WriteLine(value);
                        }
                        else
                        {
                            Console.WriteLine("No such contact");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Exact name of contact:");
                        string value1;
                        var key1 = Console.ReadLine();
                        bool hasValue1 = contacts.TryGetValue(key1, out value1);
                        if (hasValue1)
                        {
                            Console.WriteLine("{0} is removed", key1);
                            contacts.Remove(key1);
                        }
                        else
                        {
                            Console.WriteLine("No such contact");
                        }
                        break;

                    case "x":
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Unvalid operation!");
                        break;
                }
                Console.WriteLine("Select operation:" + "1. Add Contact\n" + "2. See Contacts\n" + "3. Search for contact \n" + "4. Delete contact\n" + "x for Exit ");
                userInput = Console.ReadLine();
            }
            

            

        }
    }
}