using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._23_dz
{
    enum Profile { IT, Marketing, Law, Education, Trading, Shipping, Restaurant, Hotel, Shop }
    class Firm
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public  Profile FirmProfile { get; set; }
        public string BossName { get; set; }
        public int NumberOfEmployee { get; set; }
        public string Address { get; set; }
        public Firm() { }
        public Firm(string name, DateTime date, Profile firmProfile, string bossName, int numberOfEmployee, string address)
        {
            Name = name;
            Date = date;
            FirmProfile = firmProfile;
            BossName = bossName;
            NumberOfEmployee = numberOfEmployee;
            Address = address;
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var firms = new List<Firm>() 
            {
            new Firm("ABC", new DateTime(2001, 3, 12), Profile.IT ,  "Bob Bobey", 406, "New York, Manhatten, New Avenue, 2"),
            new Firm("Some Food", new DateTime(2021, 12, 21 ), Profile.Restaurant, "Walley White", 40, "London, Backer str, 42 "),
            new Firm("Another Food", new DateTime(2022, 11, 2 ), Profile.Restaurant, "Jakob Newest", 101, "London, Grossy str, 21"),
            new Firm("Marketing Market", new DateTime(2017, 6,6 ), Profile.Marketing, "Mike Jhons", 203, "New Jersey, Mark Avenue, 147"),
            new Firm("Some Marketing", new DateTime(2013, 4,2 ), Profile.Marketing, "Nik Karter", 94, "Warsaw, Bibirki, 23"),
            new Firm("Top IT", new DateTime(2023, 2, 9 ), Profile.IT, "Vasye Pupkin", 24, "Kharkiv, Pushkina, 23"),
            new Firm("White Hotel", new DateTime(2023, 1,27 ), Profile.Hotel, "Joe Black", 57, "Dublin, Pupushkina, 10"),
            };
         

            foreach (var f in firms)
            {
                Console.WriteLine($"{f.Name}, {f.Date.ToShortDateString()}, {f.FirmProfile}, {f.BossName}, {f.NumberOfEmployee}");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------\n");


            foreach (var f in firms.Where(i => i.Name.Contains("Food")))
            {
                Console.WriteLine($"{f.Name}, {f.Date.ToShortDateString()}, {f.FirmProfile}, {f.BossName}, {f.NumberOfEmployee}");
            }
            Console.WriteLine();


            foreach (var f in firms.Where(i => i.FirmProfile == Profile.Marketing))
            {
                Console.WriteLine($"{f.Name}, {f.Date.ToShortDateString()}, {f.FirmProfile}, {f.BossName}, {f.NumberOfEmployee}");
            }
            Console.WriteLine();


            foreach (var f in firms.Where(
                i => i.FirmProfile == Profile.IT ||
                i.FirmProfile == Profile.Marketing
            ))
            {
                Console.WriteLine($"{f.Name}, {f.Date.ToShortDateString()}, {f.FirmProfile}, {f.BossName}, {f.NumberOfEmployee}");
            }
            Console.WriteLine();


            foreach (var f in firms.Where(i => i.NumberOfEmployee > 100))
            {
                Console.WriteLine($"{f.Name}, {f.Date.ToShortDateString()}, {f.FirmProfile}, {f.BossName}, {f.NumberOfEmployee}");
            }
            Console.WriteLine();


            foreach (var f in firms.Where(
                i => i.NumberOfEmployee >= 100 &&
                i.NumberOfEmployee <= 300
            ))
            {
                Console.WriteLine($"{f.Name}, {f.Date.ToShortDateString()}, {f.FirmProfile}, {f.BossName}, {f.NumberOfEmployee}");
            }
            Console.WriteLine();


            foreach (var f in firms.Where(i => i.BossName.Contains("White")))
            {
                Console.WriteLine($"{f.Name}, {f.Date.ToShortDateString()}, {f.FirmProfile}, {f.BossName}, {f.NumberOfEmployee}");
            }
            Console.WriteLine();


            foreach (var f in firms.Where(i => DateTime.Now - i.Date > new TimeSpan(10000, 0, 0, 0, 0)))
            {
                Console.WriteLine($"{f.Name}, {f.Date.ToShortDateString()}, {f.FirmProfile}, {f.BossName}, {f.NumberOfEmployee}");
            }
            Console.WriteLine();



            Console.ReadLine();


        }
    }
}
