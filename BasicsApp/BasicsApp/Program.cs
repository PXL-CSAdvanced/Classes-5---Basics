using BasicsApp;
using System;

public class Program
{   
    public static void Main(string[] args)
    {
        #region Opdracht1
        /*
        Console.WriteLine("Opdracht 1:\n");
        Vehicle vehicle = new Vehicle { NumberOfWheels = 2, Brand = "Yamaha", DriverLicense = "A", MaxSpeed = 145 };
        Console.WriteLine(vehicle.DescribeVehicle());
        Console.WriteLine(vehicle.Drive());
        Console.ReadLine();
        */
        #endregion

        #region Opdracht2
        /*
        List<StarWarsCharacter> characters = new List<StarWarsCharacter>()
        {
            new StarWarsCharacter()
            {
                Name = "Anakin Skywalker",
                Alliance = "Jedi",
                Rank = "Jedi Knight",
                LightSaberColor = "Blue",
                Quotes = new List<string>
                {
                    "I see through the lies of the Jedi.",
                    "This is where the fun begins."
                }
            },
            new StarWarsCharacter()
            {
                Name = "Obi-Wan Kenobi",
                Alliance = "Jedi",
                Rank = "Jedi Master",
                LightSaberColor = "Blue",
                Quotes = new List<string>
                {
                    "I have the high ground.",
                    "Only a Sith deals in absolutes.",
                    "These are not the droids you are looking for."
                }
            },
            new StarWarsCharacter()
            {
                Name = "Darth Vader",
                Alliance = "Sith",
                Rank = "Sith Lord",
                LightSaberColor = "Red",
                Quotes = new List<string>
                {
                    "I find your lack of faith disturbing.",
                    "You don't know the power of the Dark Side."
                }
            },
            new StarWarsCharacter()
            {
                Name = "Yoda",
                Alliance = "Jedi",
                Rank = "Grand Master",
                LightSaberColor = "Green",
                Quotes = new List<string>
                {
                    "Do or do not. There is no try.",
                    "Fear is the path to the dark side."
                }
            },
            new StarWarsCharacter()
            {
                Name = "Darth Sidious",
                Alliance = "Sith",
                Rank = "Emperor",
                LightSaberColor = "Red",
                Quotes = new List<string>
                {
                    "Power! Unlimited power!",
                    "The Dark Side of the Force is a pathway to many abilities some consider to be unnatural."
                }
            },
            new StarWarsCharacter()
            {
                Name = "Luke Skywalker",
                Alliance = "Jedi",
                Rank = "Jedi Knight",
                LightSaberColor = "Green",
                Quotes = new List<string>
                {
                    "I am a Jedi, like my father before me.",
                    "No one’s ever really gone."
                }
            },
            new StarWarsCharacter()
            {
                Name = "Darth Maul",
                Alliance = "Sith",
                Rank = "Sith Apprentice",
                LightSaberColor = "Red",
                Quotes = new List<string>
                {
                    "At last, we will reveal ourselves to the Jedi. At last, we will have revenge.",
                    "I was lost, and yet I found purpose again."
                }
            },
            new StarWarsCharacter()
            {
                Name = "Qui-Gon Jinn",
                Alliance = "Jedi",
                Rank = "Jedi Master",
                LightSaberColor = "Green",
                Quotes = new List<string>
                {
                    "Your focus determines your reality.",
                    "Feel, don’t think. Trust your instincts."
                }
            }
        };

        int index = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Opdracht 2:\n");
            Console.WriteLine(characters[index].DescribeCharacter());
            Console.WriteLine("\nQuotes:");
            characters[index].ShowQuotes();

            Console.WriteLine("\nGebruik de pijltjestoetsen om te navigeren (Links/Rechts), of druk op Escape om af te sluiten.");

            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.RightArrow)
            {
                index = (index + 1) % characters.Count;
            }
            else if (key == ConsoleKey.LeftArrow)
            {
                index = (index - 1 + characters.Count) % characters.Count;
            }
            else if (key == ConsoleKey.Escape)
            {
                break;
            }
        }
        */
        #endregion

        #region Opdracht3
        /*
        Console.Clear();
        Console.WriteLine("Opdracht 3:\n");
        
        Bank bank = new Bank { Name = "Galactic Bank" };

        Person person = new Person
        {
            FirstName = "Luke",
            LastName = "Skywalker",
            DateOfBirth = new DateTime(1951, 9, 25),
            IsMan = true
        };

        Person person2 = new Person
        {
            FirstName = "Leia",
            LastName = "Organa",
            DateOfBirth = new DateTime(1956, 10, 21),
            IsMan = false
        };

        BankAccount account = new BankAccount
        {
            Owner = person,
            AccountNumber = "BE123456789"
        };

        BankAccount account2 = new BankAccount
        {
            Owner = person2,
            AccountNumber = "BE987654321"
        };

        account.AddTransaction(new Transaction(420.00));
        account.AddTransaction(new Transaction(-25.75));
        account.AddTransaction(new Transaction(-9.99));
        account.AddTransaction(new Transaction(-9.9999));

        account2.AddTransaction(new Transaction(9000));

        bank.AddCustomer(account);
        bank.AddCustomer(account2);

        Console.WriteLine($"Bankkapitaal: {bank.ShowBankCapital()} EUR");

        foreach (string customer in bank.GetAllCustomers())
        {
            Console.WriteLine($"Klant: {customer}");
        }

        Console.ReadLine();
        */
        #endregion
    }
}