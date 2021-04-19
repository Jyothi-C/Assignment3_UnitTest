using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AssetManagement
{
              class Program
    {
        public enum Operation
        {
            Add = 1,
            Search,
            Update,
            Delete,
            Display

        };
        public static void Main(string[] args)
        {
            Book obj = new Book();
            int assetType;
            string choice;
            Operation operationType;
            Book asset;


            Console.WriteLine("Enter 1 for Book ");
            assetType = Convert.ToInt32(Console.ReadLine());
            asset = new Book();

            {
                Console.WriteLine("Enter which operation u want to perform\n 1.Adding\n2.Searching\n3.Updating\n4.Deleting");
                operationType = (Operation)Convert.ToInt32(Console.ReadLine());
                switch (operationType)
                {
                    case Operation.Add:
                        Console.WriteLine("Enter Id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Author");
                        string author = Console.ReadLine();
                        Console.WriteLine("Enter year");
                        int year = Convert.ToInt32(Console.ReadLine());
                        var addResult = asset.AddAsset(id, name, author, year);
                        break;
                    case Operation.Search:
                        Console.WriteLine("Enter the id of the book");
                        int bookId = int.Parse(Console.ReadLine());
                      //  var book1 = asset.SearchAsset(bookId,name,author,year);
                        break;
                    case Operation.Delete:
                        Console.WriteLine("Enter the id of the book");
                        int givenId = int.Parse(Console.ReadLine());
                        var book2 = asset.DeleteAsset(givenId);
                        break;
                }
                Console.WriteLine("Do you want to continue");
                choice = Console.ReadLine();
            } while (choice == "y") ;
        }
    }
}
