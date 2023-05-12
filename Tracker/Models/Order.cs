using System.Collections.Generic;

namespace Tracker.Models
{
  public class Order
  {
    public string Name{get; set;}
    public Order(string name)
    {
      Name = name;
    }
  }
}