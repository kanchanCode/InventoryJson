using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;
using System.IO;

namespace JsonReader
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //string inventoryJson = JsonSerializer.Serialize(inventory);
            //Console.WriteLine(inventoryJson);

            Console.WriteLine("Welcome to Json Reader!");
            FileReader fileReader = new FileReader();
            Console.WriteLine( fileReader.GetInventory());
            //Console.WriteLine(fileReader.inventoryList);
            Console.WriteLine("");
        }
    }
}
