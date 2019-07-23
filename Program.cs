using System;
using System.Collections.Generic;
using ToDoList.Models;

 public class Program
  {
    public static void Main()
    {
        List<Item> ItemList = new List<Item>();
        Welcome();
        AddItem();
    }
    
    public static void Welcome()
    {
        Console.WriteLine("-------" + "Welcome to the To Do List Console App" + "-------");
    }
    
    public static void AddItem()
    {
        Console.WriteLine("Would you like to add an item to your list or view your list (Add/View)");
        string checkAdd = Console.ReadLine();
        if (checkAdd.ToLower() == "add")
        {
            Console.WriteLine("Type what you would like to add to your list");
            string inputListItem = Console.ReadLine();
            Item newItem = new Item(inputListItem);

                Console.WriteLine("=============================");
                // Console.WriteLine(newItem.description());
                Console.WriteLine(newItem.GetDescription());

                ItemList.Add(newItem);
        }
        else if (checkAdd.ToLower() == "View")
        {
             
        }

    }
  }
