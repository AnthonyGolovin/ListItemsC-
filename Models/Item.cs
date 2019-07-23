using System; 
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    // We add set; to the line below.
    public string Description { get; set; }
    private static List<Item> _instances = new List<Item> {};
    public Item(string description)
    {
      _description = description;
      _instances.Add(this); 
    }
    private string _description;
    public string GetDescription()
    {
        return _description;
    }
    public static List<Item> GetAll()
    {
    return _instances;
    }

    public static void ClearAll()
{
  _instances.Clear();
}


  }
}