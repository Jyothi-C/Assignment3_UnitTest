using System;

namespace Classdigram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
     
        class AssetInformation_Book
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Year { get; set; }
        }
        class AssetHelper : AssetInformation_Book
        { 
            public void AddAsset()
            {
               

            }
            public void SearchAsset()
            {

            }
            public void UpdateAsset()
            {

            }
            public void DeleteAsset()
            {

            }

            public void DisplayAsset()
            {

            }
        }


    }
}

