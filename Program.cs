using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.IO;
using Newtonsoft.Json.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace AssetManagement
{
    public class Program
    {

        //Main method
        public static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("Enter Which Asset you want");
                Console.WriteLine(" 1.Books\n 2.SoftwareLicence\n 3.Hardware\n");
                int asset = Convert.ToInt32(Console.ReadLine());
                //switch case to select the required asset
                switch (asset)
                {
                    case 1:
                        Console.WriteLine("Welcome to Book Management");
                        Operations();
                        break;

                    case 2:
                        Console.WriteLine("Welcome to SoftwareLicence Management");
                        Operations();

                        break;

                    case 3:
                        Console.WriteLine("Welcome to Hardware Management");
                        Operations();
                        break;
                    default:
                        Console.WriteLine("Wrong Entry");
                        break;
                }
                Console.WriteLine("Do you want to continue y/n:");
                choice = Console.ReadLine();

            } while (choice == "y");

        }
        public static void Operations()
        {
            Console.WriteLine("Enter which operation u want to perform\n 1.Adding\n2.Searching\n3.Updating\n4.Deleting");
            int userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    //calling add_asset function
                    //AssetHelper.AddAsset(AssetInformation info);
                    break;
                case 2:
                    //calling search_asset function
                    AssetHelper.SearchAsset();
                    break;
                case 3:
                    //calling Update_asset function
                    AssetHelper.UpdateAsset();
                    break;
                case 4:
                    //calling.delete_asset function
                    AssetHelper.DeleteAsset();
                    break;
                default:
                    break;
            }
        }
    }
}

