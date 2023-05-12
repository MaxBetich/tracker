using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tracker.Models;
using System;

namespace Tracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test","");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "test name";
      string description = "test description";
      Order newOrder = new Order(name, description);
      string result = newOrder.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "test name";
      string description = "test description";
      Order newOrder = new Order(name, description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDescription_DateOnly()
    {
      string name = "test name";
      string description = "test description";
      DateOnly date = new DateOnly(2023,1,1);
      Order newOrder = new Order(name, description, date);
      DateOnly result = newOrder.Date;
      Assert.AreEqual(date, result);
    }
  }
}