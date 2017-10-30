using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListClass
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_Number_2()//Should add a number (or any type) to list
        {
            //Arrange
            int expected = 2;
            CustomList<int> list = new CustomList<int>();
            //Act
            list.Add(2);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Add_Letter_a()//Should add a String (or any type) to list
        {
            //Arrange
            string expected = "a";
            CustomList<string> list = new CustomList<string>();
            //Act
            list.Add("a");
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Add_MultipleNumbers_12345()//Should add many ints (or any type) to list
        {
            //Arrange
            int expected = 9;
            CustomList<int> list = new CustomList<int>();
            //Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            //Assert
            Assert.AreEqual(expected, list[8]);
        }
        [TestMethod]
        public void Add_Character()//Should add a character (or any type) to list
        {
            //Arrange
            char expected = '!';
            CustomList<char> list = new CustomList<char>();
            //Act
            list.Add('!');
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Remove_Number_2()//Should remove content (int) from specific index
        {
            //Arrange
            int expected = 0;
            CustomList<int> list = new CustomList<int>() {2};
            //Act
            list.Remove(list[0]);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Remove_String_l()//Should remove content (string) from specific index
        {
            //Arrange
            CustomList<string> expected = new CustomList<string>() { "h", "l", "l", "o"};
            CustomList<string> list = new CustomList<string>() { "h", "e", "l", "l", "o"};
            //Act
            list.Remove("e");
            //Assert
            Assert.AreEqual(expected[1], list[1]);
        }
        [TestMethod]
        public void Remove_MultipleNumbers_2345()//Should remove many ints (or any type) from list
        {
            //Arrange
            int expected = 1;
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4, 5 };
            //Act
            list.Remove(2);
            list.Remove(3);
            list.Remove(4);
            list.Remove(5);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Count_Number_3()//Counts number of items in list
        {
            //Arrange
            int expected = 3;
            CustomList<int> list = new CustomList<int>() { 1, 2};
            //Act
            list.Add(3);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Count_String_5()//Counts number of items in list
        {
            //Arrange
            int expected = 5;
            CustomList<string> list = new CustomList<string>() { "j", "a", "r", "e", "d"};
            //Act
            //Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Zip_Numbers_123456()//list will have new entries from list 2 in order of list[0], list2[0], list[1], list2[1]..ect
        {
            //Arrange
            int expected = 3;
            CustomList<int> list = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
            //Act
            list.Zip(list2);
            //Assert
            Assert.AreEqual(expected, list[2]);
        }
        [TestMethod]
        public void Zip_Strings_hello()//list will have new entries from list 2 in order of list[0], list2[0], list[1], list2[1]..ect
        {
            //Arrange
            string expected = "o";
            CustomList<string> list = new CustomList<string>() { "h", "l", "o" };
            CustomList<string> list2 = new CustomList<string>() { "e", "l"};
            //Act
            list.Zip(list2);
            //Assert
            Assert.AreEqual(expected, list[4]);
        }
        [TestMethod]
        public void ToString_Number_1()//converts contents of list into a string
        {
            //Arrange
            string expected = "1";
            CustomList<int> list = new CustomList<int>() { 1 };
            //Act
            string result = list.ToString();
            //Assert
            Assert.AreEqual(expected[0], result[0]);
        }
        [TestMethod]
        public void ToString_MultipleNumbers_123()//converts contents of list into a string
        {
            //Arrange
            string expected = "123";
            CustomList<int> list = new CustomList<int>() { 1, 2, 3 };
            //Act
            string result = list.ToString();
            //Assert
            Assert.AreEqual(expected[2], result[2]);
        }

        [TestMethod]
        public void PlusOperator_Numbers()//Adds the contents of both lists into 1
        {
            //Arrange
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            CustomList<int> list = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> result = new CustomList<int>();
            //Act
            result = list + list2;
            //Assert
            Assert.AreEqual(expected[3], result[3]);
        }
        [TestMethod]
        public void PlusOperator_Letters()//Adds the contents of both lists into 1
        {
            //Arrange
            CustomList<string> expected = new CustomList<string>() { "h", "e", "l", "l", "o" };
            CustomList<string> list = new CustomList<string>() { "h", "e", "l" };
            CustomList<string> list2 = new CustomList<string>() { "l", "o"};
            CustomList<string> result = new CustomList<string>();
            //Act
            result = list + list2;
            //Assert
            Assert.AreEqual(expected[4], result[4]);
        }
        [TestMethod]
        public void MinusOperator_Numbers()//subtracts the contents of both lists
        {
            //Arrange
            CustomList<int> expected = new CustomList<int>() { 2, 3 };
            CustomList<int> list = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 1 };
            CustomList<int> result = new CustomList<int>();
            //Act
            result = list - list2;
            //Assert
            Assert.AreEqual(expected[0], result[0]);
        }
        [TestMethod]
        public void MinusOperator_Letters()//subtracts the contents of both lists
        {
            //Arrange
            CustomList<string> expected = new CustomList<string>() { "h", "e", "l", "o" };
            CustomList<string> list = new CustomList<string>() { "h", "e", "l", "l", "o" };
            CustomList<string> list2 = new CustomList<string>() { "l"}; //This subtract 1st "l".
            CustomList<string> result = new CustomList<string>();
            //Act
            result = list - list2;
            //Assert
            Assert.AreEqual(expected[3], result[3]);
        }
    }
}
