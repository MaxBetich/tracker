using System.Collections.Generic;

namespace Tracker.Models
{
  public class Order
  {
    public string Name{get; set;}
    public string Description{get;set;}
    public Order(string name, string description)
    {
      Name = name;
      Description = description;
    }
  }
}