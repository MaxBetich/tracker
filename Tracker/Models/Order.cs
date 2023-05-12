using System.Collections.Generic;
using System;

namespace Tracker.Models
{
  public class Order
  {
    public string Name{get; set;}
    public string Description{get;set;}
    public DateOnly Date{get;set;}
    public string Price{get;set;}
    private static List<Order> _instances = new List<Order> {};
    public int Id{get;}
    public Order(string name, string description, DateOnly date, string price)
    {
      Name = name;
      Description = description;
      Date = date;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}