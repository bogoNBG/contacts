namespace Telefonen_ukazater
{
    public class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phonebook\n" + "Select:\n" + "1. Add Contact\n" + "2. See Contacts\n" + "3. Search for contact \n" +"4. Remove contact\n" + "x for Exit " );


            List<Contact> contacts = new();
            var userInput = Console.ReadLine();
                while (true)
                {
                switch (userInput)
                {
                    case "1":
                        Contact contact = new Contact();
                        Console.WriteLine("Contact name:");

                        contact.Name = Console.ReadLine();

                        Console.WriteLine("Contact number:");
                        contact.Number = Console.ReadLine();

                        Console.WriteLine("Contact Email:");
                        contact.Email = Console.ReadLine();

                        contacts.Add(contact);
                        break;

                    case "2":
                        foreach (var cont in contacts)
                        {
                            Console.WriteLine("Name: {0}, Number: {1}, Email: {2}", cont.Name, cont.Number, cont.Email);
                        }
                        break;

                    case "3":
                        Console.WriteLine("Exact name of contact:");
                        var searched = Console.ReadLine();
                        var findName = contacts.Find(x => x.Name == searched);

                        if (findName != null)
                            Console.WriteLine("Name: {0}, Number: {1}, Email: {2}", findName.Name, findName.Number, findName.Email);
                        else Console.WriteLine("No such name!");
                        break;
                        
                    case "4":
                        Console.WriteLine("Exact name of contact:");
                        var searched1 = Console.ReadLine();
                        var findName1 = contacts.Find(x => x.Name == searched1);

                        if (findName1 != null)
                        {
                            contacts.Remove(findName1);
                            Console.WriteLine("Contact removed");
                        }
                        else Console.WriteLine("No such name!");

                        break;
                    case "x":
                            Environment.Exit(1);
                            break;
                        default:
                            Console.WriteLine("Unvalid operation!");
                            break;
                    }
                    Console.WriteLine("Select operation:\n" + "1. Add Contact\n" + "2. See Contacts\n" + "3. Search for contact \n" + "4. Remove contact\n" + "x for Exit ");
                    userInput = Console.ReadLine();
                }
                

           
           /* Contact c1 = new Contact();
            c1.Name = "v";
            c1.Number = "0878";
            c1.Email = "g@gmail";
            Console.WriteLine("contact: {0}, {1}, {2}", c1.Name, c1.Number, c1.Email);
           */
        }
    }
}