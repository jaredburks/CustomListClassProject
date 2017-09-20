using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListClass
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void AddInt()//Should add a number to list
        {
            //Arrange
            int expected = 2;
            CustomList<int> list = new CustomList();
            //Act
            list.AddInt(2);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void RemoveInt()//Should remove content (int) from specific index
        {
            //Arrange
            int expected = 0;
            CustomList<int> list = new CustomList() {2};
            //Act
            list.RemoveInt(list[0]);
            //Assert
            Assert.AreEqual(expected, list.Amount);
        }
        [TestMethod]
        public void ClearList()//List can be cleared completely (no content)
        {
            //Arrange
            int expected = 0;
            CustomList<int> list = new CustomList() { 1, 2, 3 };
            //Act
            list.ClearList();
            //Assert
            Assert.AreEqual(expected, list.Amount);
        }
        [TestMethod]
        public void IterateList()//List can be looped through
        {
            //Arrange
            int expected = 3;
            CustomList<int> list = new CustomList();
            //Act
            list.IterateList();
            //Assert
            Assert.AreEqual(expected, list.Amount);
        }
        [TestMethod]
        public void SortList()//Sorts list numerically or alphabetically
        {
            //Arrange
            CustomList<int> list = new CustomList() { 3, 6, 1, 2 };
            int expected = 1;
            //Act
            list.SortList();
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Amount()//Counts number of items in list
        {
            //Arrange
            int expected = 3;
            CustomList<int> list = new CustomList() { 1, 2};
            //Act
            list.AddInt(3);
            //Assert
            Assert.AreEqual(expected, list.Amount);
        }
        [TestMethod]
        public void Zip()//list will have new entries from list 2 in order of list[0], list2[0], list[1], list2[1]..ect
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
    }
}
