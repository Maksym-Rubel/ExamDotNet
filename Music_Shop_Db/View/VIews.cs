using DB_Controller;
using DB_Controller.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Music_Shop_Db.View
{
    internal class VIews
    {
        
        public static void PrintAlbum(Data_Conttroler context)
        {

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("--------------------All records-------------------");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"{"Id",-6}{"Name",-30}{"Artist",-20}{"PublisherName",-20}{"Year",-7}{"Price",-10}{"Listers",-10}{"Genre",-10}");

            var values = context.Records.Include(x => x.Artist);
            foreach (var item in values)
            {
                Console.WriteLine($"{item.Id,-6}{item.Name,-30}{item.Artist.Name,-20}{item.PublisherName,-20}{item.Year,-7}{item.Price,-10}{item.Listers,-10}{item.Genre,-10}");


            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(new string('-', 50));



        }
        public static void PrintAlbum1(List<Record> values)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("--------------------All records-------------------");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"{"Id",-6}{"Name",-30}{"Artist",-20}{"PublisherName",-20}{"Year",-7}{"Price",-10}{"Listers",-10}{"Genre",-10}");


            foreach (var item in values)
            {
                Console.WriteLine($"{item.Id,-6}{item.Name,-30}{item.Artist.Name,-20}{item.PublisherName,-20}{item.Year,-7}{item.Price,-10}{item.Listers,-10}{item.Genre,-10}");

            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(new string('-', 50));
        }
        public static void AddRecord(Data_Conttroler context)
        {

            Console.WriteLine(new string('-', 50));
            foreach (var item in context.Artists)
            {
                Console.WriteLine($"{item.Name,-30}");
            }
            Console.WriteLine("You want add new artist Y/N");
            string a = Console.ReadLine()!;
            if(a == "Y" || a == "y")
            {
                Console.WriteLine("Enter name");
                a = Console.ReadLine()!;
                context.Artists.Add(new Artist { Name = a });
                context.SaveChanges();
                Console.Write("Enter name record --> ");
                string name = Console.ReadLine()!;
                Console.Write("Enter genre --> ");
                string genre = Console.ReadLine()!;
                Console.Write("Enter publisher name --> ");
                string pub = Console.ReadLine()!;
                Console.Write("Enter song count --> ");
                int count = int.Parse(Console.ReadLine()!);
                Console.Write("Enter cost price --> ");
                int cost = int.Parse(Console.ReadLine()!);
                Console.Write("Enter price --> ");
                int price = int.Parse(Console.ReadLine()!);
                Console.Write("Enter year creation --> ");
                int year = int.Parse(Console.ReadLine()!);
                var art = context.Artists.FirstOrDefault(x => x.Name == a);
                context.Records.Add(new Record { Name = name, ArtistId = art.Id, Genre = genre, PublisherName = pub, SongCount = count,CostPrice = cost,Price = price, Year = year });
                context.SaveChanges();

            }
            else
            {
                Console.Write("Enter name record --> ");
                string name = Console.ReadLine()!;
                Console.Write("Enter genre --> ");
                string genre = Console.ReadLine()!;
                Console.Write("Enter publisher name --> ");
                string pub = Console.ReadLine()!;
                Console.Write("Enter song count --> ");
                int count = int.Parse(Console.ReadLine()!);
                Console.Write("Enter cost price --> ");
                int cost = int.Parse(Console.ReadLine()!);
                Console.Write("Enter price --> ");
                int price = int.Parse(Console.ReadLine()!);
                Console.Write("Enter year creation --> ");
                int year = int.Parse(Console.ReadLine()!);
                Console.Write("Enter artist id --> ");
                int artid = int.Parse(Console.ReadLine()!);
                context.Records.Add(new Record { Name = name, ArtistId = artid, Genre = genre, PublisherName = pub, SongCount = count, CostPrice = cost, Price = price, Year = year });
                context.SaveChanges();

            }



        }
        public static void DeleteRecord(Data_Conttroler context)
        {

            PrintAlbum(context);
            Console.Write("Enter Id for delete --> ");
            int id = int.Parse(Console.ReadLine()!);
            var record = context.Records.Find(id);
            if (record != null)
            {
                context.Records.Remove(record);
                context.SaveChanges();
            }

        }
        public static void UpdateRecord(Data_Conttroler context)
        {

            PrintAlbum(context);
            Console.Write("Enter Id for update --> ");
            int id = int.Parse(Console.ReadLine()!);
            var record = context.Records.Find(id);
            if (record != null)
            {
                Console.Write("Enter new name (leave empty to keep current) --> ");
                string name = Console.ReadLine()!;
                if (!string.IsNullOrWhiteSpace(name))
                    record.Name = name;
                Console.Write("Enter new genre (leave empty to keep current) --> ");
                string genre = Console.ReadLine()!;
                if (!string.IsNullOrWhiteSpace(genre))
                    record.Genre = genre;

                Console.Write("Enter new publisher name (leave empty to keep current) --> ");
                string pub = Console.ReadLine()!;
                if (!string.IsNullOrWhiteSpace(pub))
                    record.PublisherName = pub;

                Console.Write("Enter new song count (leave empty to keep current) --> ");
                string countInput = Console.ReadLine()!;
                if (int.TryParse(countInput, out int count))
                    record.SongCount = count;

                Console.Write("Enter new cost price (leave empty to keep current) --> ");
                string costInput = Console.ReadLine()!;
                if (float.TryParse(costInput, out float cost))
                    record.CostPrice = cost;

                Console.Write("Enter new price (leave empty to keep current) --> ");
                string priceInput = Console.ReadLine()!;
                if (float.TryParse(priceInput, out float price))
                    record.Price = price;

                Console.Write("Enter new year of creation (leave empty to keep current) --> ");
                string yearInput = Console.ReadLine()!;
                if (int.TryParse(yearInput, out int year))
                    record.Year = year;
                Console.Write("Enter new listener (leave empty to keep current) --> ");
                string listInput = Console.ReadLine()!;
                if (int.TryParse(listInput, out int list))
                    record.Listers = list;

                context.SaveChanges();
            }
            

        }
        public static void SellRecord(Data_Conttroler context)
        {

            PrintAlbum(context);
            Console.Write("Enter Id for sell --> ");
            int id = int.Parse(Console.ReadLine()!);
            var record = context.Records.Find(id);
            if (record != null)
            {
                foreach (var item in context.Accounts)
                {
                    Console.WriteLine($"{item.Id,-6}{item.Login,-25}");
                }
                Console.Write("Enter buyer Id --> ");
                int id1 = int.Parse(Console.ReadLine()!);
                var record1 = context.Accounts.Find(id1);
                if(record1 != null)
                {
                    context.Selles.Add(new Selles { Name = record.Name, PublisherName = record.PublisherName,Genre = record.Genre, ArtistId = record.ArtistId, CostPrice = record.CostPrice, Price = record.Price, SongCounts = record.SongCount, Year = record.Year, AccountId = id1});

                }
                context.Records.Remove(record);
                context.SaveChanges();
            }


        }
        public static void FindNameRecord(Data_Conttroler context)
        {

            
            Console.Write("Enter name --> ");
            string name = Console.ReadLine()!;
            var album = context.Records.Where(x => x.Name.Contains(name));
            PrintAlbum(context);



        }
        public static void FindArtistRecord(Data_Conttroler context)
        {

            
            Console.Write("Enter artist --> ");
            string name = Console.ReadLine()!;
            var album = context.Records.Include(x=> x.Artist).Where(x => x.Artist.Name.Contains(name));
            PrintAlbum(context);



        }
        public static void FindGenreRecord(Data_Conttroler context)
        {


            Console.Write("Enter genre --> ");
            string name = Console.ReadLine()!;
            var album = context.Records.Where(x => x.Genre.Contains(name));
            PrintAlbum(context);


        }
        public static void MostPopularRecord(Data_Conttroler context)
        {



            List<Record> album = context.Records.OrderByDescending(x => x.Listers).ToList();
            PrintAlbum1(album);



        }
        public static void MostPopularArtist(Data_Conttroler context)
        {

            List<Artist> album1 = context.Artists.Include(x => x.Records).OrderByDescending(x => x.Records.Average(x=> x.Listers)).ToList();
            Console.WriteLine(new string('-', 50));
            foreach (var item in album1)
            {
                double averageListers = item.Records.Any() ? item.Records.Average(x => x.Listers) : 0;
                if(averageListers != 0)
                    Console.WriteLine($"{item.Name,-30}{averageListers}");
            }


        }
    }
}
