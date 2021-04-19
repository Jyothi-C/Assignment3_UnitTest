using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Xunit;
using AssetManagement;


namespace AssetManagement
{
    public class BookTests
    {
        [Fact]
        public void Checking_BookAvailableOrNot()
        {
            Book book = new Book();
            List<BookInformation> bookList = new List<BookInformation>();
            bookList.Add(book.AddAsset(16, "sadguru", "gaurgopal", 1995));
            //Act
            BookInformation actual = book.AddAsset(17, "jyothi", "jyothit", 1998);
            // Assert.NotEqual(actual,expected);
        }
        [Theory]
        [InlineData(12, "Wingsoffire", "A.P.J.AbdulKalam", 1876)]
        [InlineData(15, "MagicofThinkingBig", "Shwarz", 1976)]
        public void AddAssetReturnBookObject(int id, string name, string author, int year)
        {
            //Arrange
            Book book = new Book();
            List<BookInformation> bookList = new List<BookInformation>();
            bookList.Add(book.AddAsset(16, "sadguru", "gaurgopal", 1995));

            //Act
            BookInformation actual = book.AddAsset(id, name, author, year);
            bookList.Add(actual);
            BookInformation expected = bookList[1];

            //Assert
            Assert.Equal(expected.Id, actual.Id);
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.Author, actual.Author);
            Assert.Equal(expected.Year, actual.Year);
        }
        [Theory]
        [InlineData(16)]
        [InlineData(12)]
        [InlineData(15)]
        public void SearchBook_Available(int searchId, string name, string author, int year)
        {
            Book book = new Book();
            List<BookInformation> bookList = new List<BookInformation>();

            int expected = searchId;
            bookList.Add(book.AddAsset(16, "sadguru", "gaurgopal", 1995));
            bookList.Add(book.AddAsset(12, "Wingsoffire", "A.P.J.AbdulKalam", 1876));
            bookList.Add(book.AddAsset(15, "MagicofThinkingBig", "Shwarz", 1976));

            //  Act
          //  BookInformation actual = book.SearchAsset(searchId, name, author, year);

            //Assert
           // Assert.Equal(expected, actual.Id);
        }
        [Theory]
        [InlineData(16)]
        [InlineData(12)]
        [InlineData(15)]
        public void DeleteBook_ByIdTest(int bookId)
        {
            Book book = new Book();
            List<BookInformation> bookList = new List<BookInformation>();
            bookList.Add(book.AddAsset(16, "sadguru", "gaurgopal", 1995));
            bookList.Add(book.AddAsset(12, "Wingsoffire", "A.P.J.AbdulKalam", 1876));
            bookList.Add(book.AddAsset(15, "MagicofThinkingBig", "Shwarz", 1976));

            //Act
            bool result = book.DeleteAsset(bookId);

            Assert.True(result, "The book should be deleted");
        }
    }
}
