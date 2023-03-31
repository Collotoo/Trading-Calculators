using System;
using System.Collections.Generic;
using System.Text;

namespace Trading_Calculators.MVVM.model
{
    public static class MyStaticList
    {
        public static List<MyItem> Items { get; set; }

        static MyStaticList()
        {
            // Initialize the list
            Items = new List<MyItem>();


        // Add forex symbols and their pip values and pip sizes
        Items.Add(new MyItem { Name = "EUR/USD", PipValue = 10, PipSize = 0.0001 });
        Items.Add(new MyItem { Name = "USD/JPY", PipValue = 8, PipSize = 0.01 });
        Items.Add(new MyItem { Name = "GBP/USD", PipValue = 10, PipSize = 0.0001 });
        Items.Add(new MyItem { Name = "USD/CHF", PipValue = 9, PipSize = 0.0001 });
        Items.Add(new MyItem { Name = "USD/CAD", PipValue = 10, PipSize = 0.0001 });
        Items.Add(new MyItem { Name = "AUD/USD", PipValue = 10, PipSize = 0.0001 });
        Items.Add(new MyItem { Name = "NZD/USD", PipValue = 10, PipSize = 0.0001 });
        Items.Add(new MyItem { Name = "EUR/JPY", PipValue = 8, PipSize = 0.01 });
        Items.Add(new MyItem { Name = "GBP/JPY", PipValue = 8, PipSize = 0.01 });
        Items.Add(new MyItem { Name = "EUR/GBP", PipValue = 10, PipSize = 0.0001 });
        Items.Add(new MyItem { Name = "EUR/CHF", PipValue = 9, PipSize = 0.0001 });
        Items.Add(new MyItem { Name = "AUD/CAD", PipValue = 10, PipSize = 0.0001 });
        Items.Add(new MyItem { Name = "AUD/JPY", PipValue = 8, PipSize = 0.01 });
        Items.Add(new MyItem { Name = "CAD/JPY", PipValue = 8, PipSize = 0.01 });
        Items.Add(new MyItem { Name = "CHF/JPY", PipValue = 8, PipSize = 0.01 });
        Items.Add(new MyItem { Name = "NZD/JPY", PipValue = 8, PipSize = 0.01 });
        Items.Add(new MyItem { Name = "GBP/CHF", PipValue = 9, PipSize = 0.0001 });
        Items.Add(new MyItem { Name = "GBP/AUD", PipValue = 10, PipSize = 0.0001 });
        Items.Add(new MyItem { Name = "EUR/CAD", PipValue = 10, PipSize = 0.0001 });
        Items.Add(new MyItem { Name = "USD/SGD", PipValue = 10, PipSize = 0.0001 });
        Items.Add(new MyItem { Name = "EUR/SGD", PipValue = 10, PipSize = 0.0001 });
        Items.Add(new MyItem { Name = "GBP/NZD", PipValue = 10, PipSize = 0.0001 });
        Items.Add(new MyItem { Name = "AUD/NZD", PipValue = 10, PipSize = 0.0001 });
        
        }
    }

    public class MyItem
    {
        public string Name { get; set; }
        public double PipValue { get; set; }
        public double PipSize { get; set; }
    }

}
