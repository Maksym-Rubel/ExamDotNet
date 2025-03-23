using DB_Controller;
using DB_Controller.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Music_Shop_Db.View;

internal class Program
{
    private static void Main(string[] args)
    {
        Data_Conttroler context = new Data_Conttroler();
        //var artist = new Artist { Name = "Pink Floyd" };
        //var artist2 = new Artist { Name = "The Beatles" };


        //context.Artists.AddRange(artist, artist2);
        //context.SaveChanges();
        //var album1 = new Record
        //{
        //    Name = "The Dark Side of the Moon",
        //    ArtistId = 1,
        //    PublisherName = "Harvest Records",
        //    SongCount = 10,
        //    Genre = "Progressive Rock",
        //    Year = 1973,
        //    Price = 29.99f,
        //    CostPrice = 15.50f
        //};

        //var album2 = new Record
        //{
        //    Name = "Abbey Road",
        //    ArtistId = 2,
        //    PublisherName = "Apple Records",
        //    SongCount = 17,
        //    Genre = "Rock",
        //    Year = 1969,
        //    Price = 35.00f,
        //    CostPrice = 20.00f
        //};
        //context.Records.AddRange(album1, album2);
        //context.SaveChanges();
        //context.Accounts.Add(new Account { Login = "Maks", Password = "Maks1" });
        //context.SaveChanges();
        //context.Artists.Add(new Artist { Name = "Nirvana" });
        //context.Artists.Add(new Artist { Name = "Megadeth" });
        //context.Artists.Add(new Artist { Name = "AC/DC" });
        //context.Artists.Add(new Artist { Name = "Korn" });
        //context.Artists.Add(new Artist { Name = "Foo Fighters" });
        //context.SaveChanges();

        //context.Records.Add(
        //    new Record
        //    {
        //        Name = "Nevermind",
        //        ArtistId = 3,
        //        PublisherName = "DGC Records",
        //        SongCount = 12,
        //        Genre = "Grunge",
        //        Year = 1991,
        //        Price = 39.00f,
        //        CostPrice = 22.50f
        //    });
        //context.Records.Add(
        //    new Record
        //    {
        //        Name = "Rust in Peace",
        //        ArtistId = 4,
        //        PublisherName = "Capitol Records",
        //        SongCount = 9,
        //        Genre = "Thrash Metal",
        //        Year = 1990,
        //        Price = 36.00f,
        //        CostPrice = 20.00f
        //    });

        //context.Records.Add(
        //    new Record
        //    {
        //        Name = "Highway to Hell",
        //        ArtistId = 5,
        //        PublisherName = "Atlantic Records",
        //        SongCount = 10,
        //        Genre = "Hard Rock",
        //        Year = 1979,
        //        Price = 38.00f,
        //        CostPrice = 21.00f
        //    });

        //context.Records.Add(
        //    new Record
        //    {
        //        Name = "Follow the Leader",
        //        ArtistId = 6,
        //        PublisherName = "Immortal Records",
        //        SongCount = 14,
        //        Genre = "Nu Metal",
        //        Year = 1998,
        //        Price = 37.00f,
        //        CostPrice = 22.00f
        //    });


        //context.Records.Add(
        //    new Record
        //    {
        //        Name = "The Colour and the Shape",
        //        ArtistId = 7,
        //        PublisherName = "Roswell Records",
        //        SongCount = 13,
        //        Genre = "Alternative Rock",
        //        Year = 1997,
        //        Price = 35.50f,
        //        CostPrice = 20.50f
        //    });
        //context.SaveChanges();
        //context.Accounts.Add(new Account { Login = "Maks", Password = "Maks1" });
        //context.SaveChanges();
        //var client1 = new Clients
        //{
        //    Name = "John",
        //    Surname = "Doe",
        //    Email = "john.doe@example.com",
        //    BuyCount = 5
        //};

        //var client2 = new Clients
        //{
        //    Name = "Jane",
        //    Surname = "Smith",
        //    Email = "jane.smith@example.com",
        //    BuyCount = 3
        //};

        //var client3 = new Clients
        //{
        //    Name = "Mike",
        //    Surname = "Johnson",
        //    Email = "mike.johnson@example.com",
        //    BuyCount = 10
        //};

        
        //context.Clients.AddRange(client1, client2, client3);
        //context.SaveChanges();
        bool Validation = false;
        while (true)
        {
            Console.WriteLine("1- Login/2- Register");

            int log2 = int.Parse(Console.ReadLine()!);
            Console.Clear();
            if (log2 == 1)
            {
                Console.WriteLine(new string('-', 50));
                Console.Write("Enter login --> ");
                string log = Console.ReadLine()!;
                Console.Write("Enter password --> ");
                string pass = Console.ReadLine()!;
                var log1 = context.Accounts.FirstOrDefault(x => x.Login == log && x.Password == pass);
                Console.WriteLine(new string('-', 50));
                if (log1 != null)
                {
                    Validation = true;
                    break;
                }
                Console.WriteLine("Invalid login or password. Try again.");
            }
            else if (log2 == 2)
            {
                Console.WriteLine(new string('-', 50));

                Console.Write("Enter login --> ");
                string log = Console.ReadLine()!;
                Console.Write("Enter password --> ");
                string pass = Console.ReadLine()!;
                Console.Clear();
                context.Accounts.Add(new Account { Login = log, Password = pass });
                context.SaveChanges();
            }
        }
            if(Validation)
            {

            Console.WriteLine(new string('-', 50));
            Console.Clear();
            while (true)
                {
                    
                    Console.WriteLine("1 - Print records");
                    Console.WriteLine("2 - Add records");
                    Console.WriteLine("3 - Delete records");
                    Console.WriteLine("4 - Update records");
                    Console.WriteLine("5 - Sell record");
                    Console.WriteLine("6 - Search records");
                    Console.WriteLine("7 - Watch filter");
                    Console.WriteLine("8 - Watch clients");
                    Console.WriteLine("8 - Print selles");



                    Console.Write("Enter choice --> ");
                    int choice = int.Parse(Console.ReadLine()!);
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            VIews.PrintAlbum(context);
                            break;
                        case 2:
                            Console.Clear();
                            VIews.AddRecord(context);
                            break;
                        case 3:
                            Console.Clear();
                            VIews.DeleteRecord(context);
                            break;
                        case 4:
                            Console.Clear();
                            VIews.UpdateRecord(context);
                            break;
                        case 5:
                            Console.Clear();
                            VIews.SellRecord(context);
                            break;
                        case 6:
                            Console.Clear();

                            Console.WriteLine(" 1 - Name records");
                            Console.WriteLine(" 2 - Artist records");
                            Console.WriteLine(" 3 - Genre records");
                            Console.Write(" Enter choice --> ");
                            int choice2 = int.Parse(Console.ReadLine()!);
                            Console.Clear();

                            if (choice2 == 1)
                            {
                           
                            VIews.FindNameRecord(context);
                            }
                            else if (choice2 == 2)
                            {
                                Console.Clear();
                                VIews.FindArtistRecord(context);
                            }
                            else if (choice2 == 3)
                            {
                                Console.Clear();
                                VIews.FindGenreRecord(context);
                            }
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine(" 1 - Most popular records");
                            Console.WriteLine(" 2 - Most popular artist");
                            Console.Write(" Enter choice --> ");
                            choice2 = int.Parse(Console.ReadLine()!);
                            Console.Clear();
                            if (choice2 == 1)
                            {
                                VIews.MostPopularRecord(context);
                            }
                            else if (choice2 == 2)
                            {
                                VIews.MostPopularArtist(context);
                            }
                            break;
                        case 8:
                            Console.Clear();
                            VIews.PrintClients(context);
                            break;
                        case 9:
                            Console.Clear();
                            VIews.PrintSells(context);
                        break;
                    case 0:
                            return;

                    }
                }
            
            }

            
        }
    }
