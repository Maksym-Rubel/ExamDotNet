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

        while (true)
        {
            Console.WriteLine("1 - Print records");
            Console.WriteLine("2 - Add records");
            Console.WriteLine("3 - Delete records");
            Console.WriteLine("4 - Update records");
            Console.WriteLine("5 - Sell record");
            Console.WriteLine("6 - Search records");
            Console.WriteLine("7 - Watch filter");


            Console.Write("Enter choice --> ");
            int choice = int.Parse(Console.ReadLine()!);
            switch (choice)
            {
                case 1:
                    VIews.PrintAlbum(context);
                    break;
                case 2:
                    VIews.AddRecord(context);
                    break;
                case 3:
                    VIews.DeleteRecord(context);
                    break;
                case 4:
                    VIews.UpdateRecord(context);
                    break;
                case 5:
                    VIews.SellRecord(context);
                    break;
                case 6:
                    Console.WriteLine(" 1 - Name records");
                    Console.WriteLine(" 2 - Artist records");
                    Console.WriteLine(" 3 - Genre records");
                    Console.Write(" Enter choice --> ");
                    int choice2 = int.Parse(Console.ReadLine()!);
                    if(choice2 == 1)
                    {
                        VIews.FindNameRecord(context);
                    }
                    else if (choice2 == 2)
                    {
                        VIews.FindArtistRecord(context);
                    }
                    else if (choice2 == 3)
                    {
                        VIews.FindGenreRecord(context);
                    }
                    break;
                case 7:
                    Console.WriteLine(" 1 - Most popular records");
                    Console.WriteLine(" 2 - Most popular artist");
                    Console.WriteLine(" 3 - Most popular genre");
                    Console.Write(" Enter choice --> ");
                    choice2 = int.Parse(Console.ReadLine()!);
                    if (choice2 == 1)
                    {
                        VIews.FindNameRecord(context);
                    }
                    else if (choice2 == 2)
                    {
                        VIews.FindArtistRecord(context);
                    }
                    else if (choice2 == 3)
                    {
                        VIews.FindGenreRecord(context);
                    }
                    break;
                case 0:
                    return;

            }
        }
        
        //VIews.AddRecord(context);
    }
}