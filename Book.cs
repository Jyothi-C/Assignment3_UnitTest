using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetManagement
{
    public class Book 
    {
        bool res;
        Book obj = new Book();
        // static BookInformation objBook = new BookInformation();
        static List<BookInformation> bookList = new List<BookInformation>();
        public BookInformation AddAsset(int id, string name, string author, int year)
        {
            BookInformation book = new BookInformation(id, name, author, year);
            bookList.Add(book);
            Console.WriteLine("book added successfully");
            return book;
        }
        public BookInformation searchAsset(int id,string name,string author,int year)
        {
            //Book book = new Book();
            foreach(BookInformation book in bookList)
            {
                if(book.Id.Equals(id))
                {
                    Console.WriteLine("Book found");
                    return book;
                }
            }
            return null;
        }
        public static void UpdateAsset()
        {
            Console.WriteLine("which field you want to update:1.Name/t2.year");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Enter which name you want to change");
                    string keyName = (Console.ReadLine());

                    bookList.ForEach((BookInformation) =>
                {
                    if (BookInformation.Name == keyName)
                    {
                        Console.WriteLine("Enter new name");
                        string newName = Console.ReadLine();
                        BookInformation.Name = newName;
                        Console.WriteLine("{0}\t{1}\t{2}", BookInformation.Id, BookInformation.Name, BookInformation.Year);
                    }
                });
                    break;
                case 2:
                    Console.WriteLine("Enter which year you want to change");
                    int keyYear = int.Parse(Console.ReadLine());
                    bookList.ForEach((BookInformation) =>
                   {
                       if (BookInformation.Year == keyYear)
                       {
                           Console.WriteLine("Enter new year");
                           int newYear = int.Parse(Console.ReadLine());
                           BookInformation.Year = newYear;
                           Console.WriteLine("{0}\t{1}\t{2}", BookInformation.Id, BookInformation.Name, BookInformation.Year);
                       }
                   });
                    break;
                default:
                    break;
            }

        }
        public bool DeleteAsset(int id)
        {
            Console.WriteLine("which Id you want to delete");
            //int keyId = int.Parse(Console.ReadLine());
            int availableIndex = bookList.FindIndex(item => item.Id == id);

            if (availableIndex > -1)
            {
                bookList.RemoveAt(availableIndex);
                Console.WriteLine("Deleted Successfully");
                return true;
            }
            else
            {
                Console.WriteLine("Given id not available to delete");
                return false;
            }

        }


    }
}