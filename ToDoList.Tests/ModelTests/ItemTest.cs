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
  }
}
