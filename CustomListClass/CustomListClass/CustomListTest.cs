using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListClass
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void AddInt()
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
        public void RemoveInt()
        {
            //Arrange
            int expected = 0;
            CustomList<int> list = new CustomList() {2};
            //Act
            list.RemoveInt(list[0]);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void ClearList()
        {
            //Arrange
            int expected = 0;
            CustomList<int> list = new CustomList() { 1, 2, 3 };
            //Act
            list.ClearList();
            //Assert
            Assert.AreEqual(expected, list.Count);
        }
    }
}
