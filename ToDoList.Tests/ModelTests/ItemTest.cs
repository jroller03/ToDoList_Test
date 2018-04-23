using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoListApp.Models;

namespace ToDoListApp.Controllers
{
  [TestClass]
  public class ItemTest
  {
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
