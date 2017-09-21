using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListClass
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_Number()//Should add a number (or any type) to list
        {
            //Arrange
            int expected = 2;
            CustomList<int> list = new CustomList();
            //Act
            list.Add(2);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Add_Letter()//Should add a String (or any type) to list
        {
            //Arrange
            string expected = "a";
            CustomList<string> list = new CustomList();
            //Act
            list.Add("a");
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Add_MultipleNumbers()//Should add many ints (or any type) to list
        {
            //Arrange
            CustomList<int> expected = new CustomList() { 1, 2, 3, 4, 5 };
            CustomList<int> list = new CustomList();
            //Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            //Assert
            Assert.AreEqual(expected, list);
        }
        [TestMethod]
        public void Add_Char()//Should add a character (or any type) to list
        {
            //Arrange
            string expected = "!";
            CustomList<string> list = new CustomList();
            //Act
            list.Add("!");
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Remove_Number()//Should remove content (int) from specific index
        {
            //Arrange
            int expected = 0;
            CustomList<int> list = new CustomList() {2};
            //Act
            list.Remove(list[0]);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Remove_String()//Should remove content (string) from specific index
        {
            //Arrange
            CustomList<string> list = new CustomList() { "h", "e", "l", "l" };
            CustomList<string> list = new CustomList() { "h", "e", "l", "l", "o"};
            //Act
            list.Remove(list[4]);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Remove_MultipleNumbers()//Should remove many ints (or any type) from list
        {
            //Arrange
            CustomList<int> expected = new CustomList() { 1 };
            CustomList<int> list = new CustomList() { 1, 2, 3, 4, 5 };
            //Act
            list.Remove(2);
            list.Remove(3);
            list.Remove(4);
            list.Remove(5);
            //Assert
            Assert.AreEqual(expected, list);
        }
        [TestMethod]
        public void Iterate()//List can be looped through
        {
            //Arrange
            int expected = 3;
            CustomList<int> list = new CustomList();
            //Act
            list.Iterate();
            //Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Sort_Numbers()//Sorts list numerically or alphabetically
        {
            //Arrange
            CustomList<int> list = new CustomList() { 3, 6, 1, 2 };
            CustomList<int> expected = new CustomList() { 1, 2, 3, 6 };
            //Act
            list.Sort();
            //Assert
            Assert.AreEqual(expected, list);
        }
        [TestMethod]
        public void Sort_Strings()//Sorts list numerically or alphabetically
        {
            //Arrange
            CustomList<string> list = new CustomList() { "c", "d", "a", "b"};
            CustomList<string> expected = new CustomList() { "a", "b", "c", "d"};
            //Act
            list.Sort();
            //Assert
            Assert.AreEqual(expected, list);
        }
        [TestMethod]
        public void Count_Number()//Counts number of items in list
        {
            //Arrange
            int expected = 3;
            CustomList<int> list = new CustomList() { 1, 2};
            //Act
            list.Add(3);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Count_String()//Counts number of items in list
        {
            //Arrange
            int expected = 5;
            CustomList<string> list = new CustomList() { "j", "a", "r", "e", "d"};
            //Act
            //Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Zip_Numbers()//list will have new entries from list 2 in order of list[0], list2[0], list[1], list2[1]..ect
        {
            //Arrange
            int expected = 3;
            CustomList<int> list = new CustomList() { 1, 3, 5 };
            CustomList<int> list2 = new CustomList() { 2, 4, 6 };
            //Act
            list.Zip(list2);
            //Assert
            Assert.AreEqual(expected, list[2]);
        }
        [TestMethod]
        public void Zip_Strings()//list will have new entries from list 2 in order of list[0], list2[0], list[1], list2[1]..ect
        {
            //Arrange
            string expected = "o";
            CustomList<string> list = new CustomList() { "h", "l", "o" };
            CustomList<string> list2 = new CustomList() { "e", "l"};
            //Act
            list.Zip(list2);
            //Assert
            Assert.AreEqual(expected, list[4]);
        }
        [TestMethod]
        public override string ToString_Number()//converts contents of list into a string
        {
            //Arrange
            string expected = "1";
            CustomList<int> list = new CustomList() { 1 };
            //Act
            list.ToString();
            //Assert
            Assert.AreEqual(expected, list[0]);
            return list;
        }
        [TestMethod]
        public override string ToString_MultipleNumbers()//converts contents of list into a string
        {
            //Arrange
            string expected = "123";
            CustomList<int> list = new CustomList() { 1, 2, 3 };
            //Act
            list.ToString();
            //Assert
            Assert.AreEqual(expected, list);
            return list;
        }
        [TestMethod]
        public override string ToString_Object()//converts contents of list into a string
        {
            //Arrange
            object obj1 = new object();
            string expected = "Object1 : yee";
            CustomList<object> list = new CustomList() {obj1};
            //Act
            list.ToString();
            //Assert
            Assert.AreEqual(expected, list);
            return list;
        }
        [TestMethod]
        public static CustomListClass operator+(CustomList<T> list, CustomList<T> list2)//Adds the contents of both lists into 1
        {
            //Arrange
            CustomList<int> expected = new CustomList() { 1, 2, 3, 4, 5, 6 };
            CustomList<int> list = new CustomList() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList() { 4, 5, 6 };
            //Act
            list += list2;
            //Assert
            Assert.AreEqual(expected, list);
        }
        [TestMethod]
        public static CustomListClass operator +(CustomList<T> list, CustomList<T> list2)//Adds the contents of both lists into 1
        {
            //Arrange
            CustomList<string> expected = new CustomList() { "h", "e", "l", "l", "o" };
            CustomList<string> list = new CustomList() { "h", "e", "l" };
            CustomList<string> list2 = new CustomList() { "l", "o"};
            //Act
            list += list2;
            //Assert
            Assert.AreEqual(expected, list);
        }
        [TestMethod]
        public static CustomListClass operator-(CustomList<T> list, CustomList<T> list2)//subtracts the contents of both lists
        {
            //Arrange
            CustomList<int> expected = new CustomList() { 2, 3 };
            CustomList<int> list = new CustomList() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList() { 4, 1, 6 };
            //Act
            list -= list2;
            //Assert
            Assert.AreEqual(expected, list);
        }
        [TestMethod]
        public static CustomListClass operator -(CustomList<T> list, CustomList<T> list2)//subtracts the contents of both lists
        {
            //Arrange
            CustomList<string> expected = new CustomList() { "h", "e", "o"};
            CustomList<string> list = new CustomList() { "h", "e", "l", "l", "o" };
            CustomList<string> list2 = new CustomList() { "l"}; //Does this subtract 1 "l" or all "l's"?
            //Act
            list -= list2;
            //Assert
            Assert.AreEqual(expected, list);
        }
    }
}
