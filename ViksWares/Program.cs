using System;
using System.Collections.Generic;
using ViksWares.Models;

namespace ViksWares;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome To our shop!");

        IList<Item> Items = new List<Item>{
            new Item {Name = "Shoe Laces", SellBy = 10, Value = 20},
            new Item {Name = "Aged Parmigiano", SellBy = 2, Value = 0},
            new Item {Name = "Book of Resolutions", SellBy = 5, Value = 7},
            new Item {Name = "Saffron Powder", SellBy = 0, Value = 80},
            new Item {Name = "Saffron Powder", SellBy = -1, Value = 80},
            new Item
            {
                Name = "Concert tickets to Talkins Festival",
                SellBy = 15,
                Value = 20
            },
            new Item
            {
                Name = "Concert tickets to Talkins Festival",
                SellBy = 10,
                Value = 49
            },
            new Item
            {
                Name = "Concert tickets to Talkins Festival",
                SellBy = 5,
                Value = 49
            },
            // this Refrigerated item does not work properly yet
            new Item {Name = "Refrigerated milk", SellBy = 3, Value = 6}
        };

        var app = new global::ViksWares.Application.ViksWares(Items);
        
        for (var i = 0; i < 5; i++)
        {
            Console.WriteLine("         -------- day " + (i + 1) + " --------");
            Console.WriteLine("{0,-36} {1,-10} {2,-5}", "Name", "SellBy", "Value");
            foreach (var item in Items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("");
            app.UpdateValue();
        }

        Console.ReadKey();
    }
}