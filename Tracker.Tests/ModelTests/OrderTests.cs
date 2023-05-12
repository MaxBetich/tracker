using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tracker.Models;
using System;

namespace Tracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string date = "2023,1,1";
      string price = "3";
      Order newOrder = new Order("test","",date, price);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "test name";
      string description = "test description";
      string date = "2023,1,1";
      string price = "3";
      Order newOrder = new Order(name, description, date, price);
      string result = newOrder.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "test name";
      string description = "test description";
      string date = "2023,1,1";
      string price = "3";
      Order newOrder = new Order(name, description, date, price);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDescription_DateOnly()
    {
      string name = "test name";
      string description = "test description";
      string date = "2023,1,1";
      string price = "3";
      Order newOrder = new Order(name, description, date, price);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      string name = "test name";
      string description = "test description";
      string date = "2023,1,1";
      string price = "3";
      Order newOrder = new Order(name, description, date, price);
      string result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsListOfOrders_OrderList()
    {
      string name1 = "test name";
      string description1 = "test description";
      string date1 = "2023,1,1";
      string price1 = "3";
      Order newOrder1 = new Order(name1, description1, date1, price1);
      string name2 = "test name2";
      string description2 = "test description2";
      string date2 = "2023,1,2";
      string price2 = "4";
      Order newOrder2 = new Order(name2, description2, date2, price2);
      List<Order> newList = new List<Order> {newOrder1, newOrder2};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}