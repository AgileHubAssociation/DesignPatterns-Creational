﻿using System.Collections.Generic;
using System.Text;

namespace Builder_Pizza_Demo.Classes
{
    public class Pizza
    {
        public Size Size { get; private set; }
        public Crust Crust { get; private set; }
        public BaseSauce BaseSauce { get; private set; }
        public List<Cheese> Cheeses { get; private set; }
        public List<Meat> Meats { get; private set; }
        public List<Vegetable> Vegetables { get; private set; }

        public Pizza(Size size, Crust crust, BaseSauce baseSauce)
        {
            Cheeses = new List<Cheese>();
            Vegetables = new List<Vegetable>();
            Meats = new List<Meat>();
        }

        public string GetOrderedPizza()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Size: {Size}");
            sb.AppendLine($"Crust: {Crust}");
            sb.AppendLine($"BaseSauce: {BaseSauce}");
            sb.AppendLine($"Cheeses: {string.Join(", ", Cheeses)}");
            sb.AppendLine($"Meats: {string.Join(", ", Meats)}");
            sb.AppendLine($"Vegetables: {string.Join(", ", Vegetables)}");
            return sb.ToString();
        }
    }
}
