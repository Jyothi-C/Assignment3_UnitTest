using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Xunit;
using Newtonsoft.Json;
using System.Text.Json;
using static Newtonsoft.Json.JsonSerializer;
//using System.Text.Json.Serialization;
using Moq;



namespace AssetManagement
{
    public class AssetTestCases
    {
        [Fact]
        public void CheckingAddAssetListTest()
        {
            AssetInformation asset = new AssetInformation()
            {
                Id = 12,
                Name = "jyothi",
                Year = 1998
            };
            var mockInfo = new Mock<AssetInformation>();
      
            using (StreamReader r = new StreamReader("SearchAsset.json"))
            {
                AssetInformation item1 = new AssetInformation();
                string json = r.ReadToEnd();
                List<AssetInformation> items = JsonConvert.DeserializeObject<List<AssetInformation>>(json);
                items.Add(item1);
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var item in array)
                {
                    Console.WriteLine("{0} {1} {2}", item.Id, item.Name, item.Year);
                }
                AssetHelper.AddAsset(mockInfo.Object);
                Assert.Equal(asset, item1);
            }
        }

        [Theory]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(15)]
        public void SearchingBookAssetbyId(int id)
        {
            AssetInformation book = new AssetInformation();
            using (StreamReader r = new StreamReader("SearchAsset.json"))
            {
                AssetInformation actualId = new AssetInformation();
                string json = r.ReadToEnd();
                List<AssetInformation> items = JsonConvert.DeserializeObject<List<AssetInformation>>(json);
                items.Add(actualId);
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var item in array)
                {
                    Console.WriteLine("{0} {1} {2}", item.Id, item.Name, item.Year);
                }
                AssetHelper.SearchAsset();
                if (actualId.Id == id)
                {
                    Assert.Equal(book.Id, actualId.Id);
                }
                else
                {
                    Assert.NotEqual(book.Id, actualId.Id);
                }
            }
        }
        [Theory]
        [InlineData("TheWakefield")]
        [InlineData("TheMonti")]
        [InlineData("TheFire")]
        public void SearchingBookTestbyName(string Name)
        {
            AssetInformation book = new AssetInformation();
            using (StreamReader r = new StreamReader("SearchAsset.json"))
            {
                AssetInformation actualName = new AssetInformation();
                string json = r.ReadToEnd();
                List<AssetInformation> items = JsonConvert.DeserializeObject<List<AssetInformation>>(json);
                items.Add(actualName );
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var item in array)
                {
                    Console.WriteLine("{0} {1} {2}", item.Id, item.Name, item.Year);
                }
                AssetHelper.SearchAsset();
                if (actualName .Name == Name)
                {
                    Assert.Equal(book.Name, actualName .Name);
                }
                else
                {
                    Assert.NotEqual(book.Name, actualName .Name);
                }
            }
        }
        [Theory]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(15)]
        public void SearchingSoftwareTestbyId(int id)
        {
            AssetInformation software = new AssetInformation();
            using (StreamReader r = new StreamReader("SearchAsset.json"))
            {
                AssetInformation actualId = new AssetInformation();
                string json = r.ReadToEnd();
                List<AssetInformation> items = JsonConvert.DeserializeObject<List<AssetInformation>>(json);
                items.Add( actualId );
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var item in array)
                {
                    Console.WriteLine("{0} {1} {2}", item.Id, item.Name, item.Year);
                }
                AssetHelper.SearchAsset();
                if ( actualId .Id == id)
                {
                    Assert.Equal(software.Id,  actualId .Id);
                }
                else
                {
                    Assert.NotEqual(software.Id,  actualId .Id);
                }
            }
        }
        [Theory]
        [InlineData("TheWakefield")]
        [InlineData("TheMonti")]
        [InlineData("TheFire")]
        public void SearchingSoftwareTestbyName(string Name)
        {
            AssetInformation software = new AssetInformation();
            using (StreamReader r = new StreamReader("SearchAsset.json"))
            {
                AssetInformation actualName = new AssetInformation();
                string json = r.ReadToEnd();
                List<AssetInformation> items = JsonConvert.DeserializeObject<List<AssetInformation>>(json);
                items.Add(actualName);
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var item in array)
                {
                    Console.WriteLine("{0} {1} {2}", item.Id, item.Name, item.Year);
                }
                AssetHelper.SearchAsset();
                if (actualName.Name == Name)
                {
                    Assert.Equal(software.Name,actualName.Name);
                }
                else
                {
                    Assert.Equal(software.Name,actualName.Name);
                }
            }
        }
        [Theory]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(15)]
        public void SearchingHardwareTestbyId(int id)
        {
            AssetInformation hardware = new AssetInformation();
            using (StreamReader r = new StreamReader("SearchAsset.json"))
            {
                AssetInformation actualId = new AssetInformation();
                string json = r.ReadToEnd();
                List<AssetInformation> items = JsonConvert.DeserializeObject<List<AssetInformation>>(json);
                items.Add(actualId);
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var item in array)
                {
                    Console.WriteLine("{0} {1} {2}", item.Id, item.Name, item.Year);
                }
                AssetHelper.SearchAsset();
                if (actualId.Id == id)
                {
                    Assert.Equal(hardware.Id, actualId.Id);
                }
                else
                {
                    Assert.NotEqual(hardware.Id, actualId.Id);
                }
            }
        }
        [Theory]
        [InlineData("TheWakefield")]
        [InlineData("TheMonti")]
        [InlineData("TheFire")]
        public void SearchingHardwareTestbyName(string Name)
        {
            AssetInformation hardware = new AssetInformation();
            using (StreamReader r = new StreamReader("SearchAsset.json"))
            {
                AssetInformation actualName = new AssetInformation();
                string json = r.ReadToEnd();
                List<AssetInformation> items = JsonConvert.DeserializeObject<List<AssetInformation>>(json);
                items.Add(actualName );
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var item in array)
                {
                    Console.WriteLine("{0} {1} {2}", item.Id, item.Name, item.Year);
                }
                AssetHelper.SearchAsset();
                if (actualName .Name == Name)
                {
                    Assert.Equal(hardware.Name, actualName .Name);
                }
                else
                {
                    Assert.NotEqual(hardware.Name,actualName.Name);
                }
            }
        }

    }
}
