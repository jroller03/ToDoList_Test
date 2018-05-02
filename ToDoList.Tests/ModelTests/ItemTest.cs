using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoListApp.Models;
using ToDoListApp;
using System;
using System.Collections.Generic;

namespace ToDoListApp.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
      public void Dispose()
    {
      // Item.DeleteAll();
    }
    public ItemTests()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=todo_test;";
    }
    [TestMethod]
    public void GetAll_DbStartsEmpty_0()
    {
      //Arrange
      //Act
      int result = Item.GetAll().Count;

      //Assert
      Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      newItem.Save();

      //Act
      string result = newItem.GetDescription();

      //Assert
      Assert.AreEqual(description, result);

    }
  }
}
