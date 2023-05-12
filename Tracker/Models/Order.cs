using System.Collections.Generic;
using System;

namespace Tracker.Models
{
  public class Order
  {
    public string Name{get; set;}
    public string Description{get;set;}
    public DateOnly Date{get;set;}
    public Order(string name, string description, DateOnly date)
    {
      Name = name;
      Description = description;
      Date = date;
    }
  }
}