using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoListApp.Models;
using ToDoListApp;
using System;
using System.Collections.Generic;

namespace ToDoListApp.Tests
{
  [TestClass]
  public class ItemTest : IDisposable
  {
      public void Dispose()
    {
      Item.ClearAll();
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
    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Item newItem1 = new Item(description01);
      newItem1.Save();
      Item newItem2 = new Item(description02);
      newItem2.Save();
      List<Item> newList = new List<Item> { newItem1, newItem2 };

      //Act
      List<Item> result = Item.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
      foreach (Item thisItem in result)
      {
        Console.WriteLine("Output: " + thisItem.GetDescription());
      }
    }
  }
}
