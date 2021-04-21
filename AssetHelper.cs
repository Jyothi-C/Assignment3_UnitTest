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
    public class AssetHelper
    {
        private readonly AssetInformation info;
        // To Add the information into Assets
        public static List<AssetInformation> assetList = new List<AssetInformation>();
        public static void AddAsset(AssetInformation info)
        {
            Console.WriteLine("Enter how many records you want records:");
            int noOfRecords = Convert.ToInt32(Console.ReadLine());
            for (int item = 0; item < noOfRecords; item++)
            {

                AssetInformation asset = new AssetInformation();
                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter year");
                int year = Convert.ToInt32(Console.ReadLine());
                asset.Id = id;
                asset.Name = name;
                asset.Year = year;
                assetList.Add(asset);
                // string jsonString = JsonSerializer.Serialize(asset);
                // jsonString = JsonSerializer.Serialize(asset);
                // File.WriteAllText(@"asset.json", jsonString);
                // Console.WriteLine("stored");
            }
            Console.WriteLine("Id\tName\tyear\t");
            assetList.ForEach((AssetInformation) => Console.WriteLine("{0}\t{1}\t{2}", AssetInformation.Id, AssetInformation.Name, AssetInformation.Year));
        }
        //Searching the asset by the given id or name or year
        public static void SearchAsset()
        {
            Console.WriteLine("Enter the feild to search for an asset/t1.Id2.Name3.Year");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter unique Asset Id");
                    int keyId = int.Parse(Console.ReadLine());
                    assetList.ForEach((AssetInformation) =>
                    {
                        if (AssetInformation.Id == keyId)
                        {
                            Console.WriteLine("{0}\t{1}\t{2}", AssetInformation.Id, AssetInformation.Name, AssetInformation.Year);
                            Console.WriteLine("search id is available");
                        }

                    });
                    break;
                case 2:
                    Console.WriteLine("Enter Asset Name");
                    string keyName = Console.ReadLine();
                    assetList.ForEach((AssetInformation) =>
                    {
                        if (AssetInformation.Name == keyName)
                        {
                            Console.WriteLine("List Of Asset with related name choose which one you want");
                                // Console.WriteLine( AssetInformation.Name);
                                int length1 = keyName.Length / 2;
                            assetList.ForEach((AssetInformation) =>
                            {
                                int length2 = (AssetInformation.Name.Length) / 2;
                                if (keyName.Substring(0, length1) == AssetInformation.Name.Substring(0, length2))
                                {
                                    Console.WriteLine("{0}\t{1}", AssetInformation.Name, AssetInformation.Year);
                                }
                            });
                            Console.WriteLine("Enter Name and Year of asset");
                            string perfectName = Console.ReadLine();
                            int perfectyear = int.Parse(Console.ReadLine());

                            assetList.ForEach((AssetInformation) =>
                           {
                               if (AssetInformation.Name == perfectName && AssetInformation.Year == perfectyear)
                               {
                                   Console.WriteLine("{0}\t{1}\t{2}", AssetInformation.Id, AssetInformation.Name, AssetInformation.Year);
                                   Console.WriteLine("search Asset is available");

                               }
                           });
                        }
                    });

                    break;
                case 3:
                    Console.WriteLine("Enter Asset Year");
                    int keyYear = int.Parse(Console.ReadLine());
                    assetList.ForEach((AssetInformation) =>
                    {
                        if (AssetInformation.Year == keyYear)
                        {
                                //Console.WriteLine("List Of Asset with related year choose which one you want by name");
                                assetList.ForEach((AssetInformation) =>
                            {
                                if (AssetInformation.Year == keyYear)
                                {
                                    Console.WriteLine("{0}\t{1}", AssetInformation.Name, AssetInformation.Year);
                                }
                            });
                            Console.WriteLine("Enter Name and Year of asset");
                            string perfectName = Console.ReadLine();
                            int perfectyear = int.Parse(Console.ReadLine());
                            assetList.ForEach((AssetInformation) =>
                            {
                                if (AssetInformation.Name == perfectName && AssetInformation.Year == perfectyear)
                                {
                                    Console.WriteLine("{0}\t{1}\t{2}", AssetInformation.Id, AssetInformation.Name, AssetInformation.Year);
                                    Console.WriteLine("search Asset is available");
                                }
                            });
                        }
                    });
                    break;
                default:
                    Console.WriteLine("Wrong Entry");
                    break;

            }
        }
        //To update the given asset
        public static void UpdateAsset()
        {
            Console.WriteLine("which field you want to update:1.Name/t2.year");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Enter which name you want to change");
                    string keyName = (Console.ReadLine());

                    assetList.ForEach((AssetInformation) =>
                {
                    if (AssetInformation.Name == keyName)
                    {
                        Console.WriteLine("Enter new name");
                        string newName = Console.ReadLine();
                        AssetInformation.Name = newName;
                        Console.WriteLine("{0}\t{1}\t{2}", AssetInformation.Id, AssetInformation.Name, AssetInformation.Year);
                    }
                });
                    break;
                case 2:
                    Console.WriteLine("Enter which year you want to change");
                    int keyYear = int.Parse(Console.ReadLine());

                    assetList.ForEach((AssetInformation) =>
                   {
                       if (AssetInformation.Year == keyYear)
                       {
                           Console.WriteLine("Enter new year");
                           int newYear = int.Parse(Console.ReadLine());
                           AssetInformation.Year = newYear;
                           Console.WriteLine("{0}\t{1}\t{2}", AssetInformation.Id, AssetInformation.Name, AssetInformation.Year);
                       }
                   });
                    break;

                default:
                    break;
            }
        }
        //  for delete an existing asset
        public static void DeleteAsset()
        {
            Console.WriteLine("which Id you want to delete");
            int keyId = int.Parse(Console.ReadLine());
            int availableIndex = assetList.FindIndex(item => item.Id == keyId);
            if (availableIndex > -1)
            {
                assetList.RemoveAt(availableIndex);
                Console.WriteLine("Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Given id not available to delete");
            }
        }
    }
}