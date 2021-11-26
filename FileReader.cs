using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

using System.Text.Json.Serialization;

using System.Runtime.Serialization;

namespace JsonReader
{
    public class FileReader
    {
        public List<Inventory> inventoryList = new List<Inventory>();
        
        public List<Inventory> GetInventory()
        {
            var inventory = new Inventory();
            string filePath= File.ReadAllText("C:\\Users\\hp\\Desktop\\jsonReader\\JsonFileReader-master\\JsonReader\\Data.json");

            
            
           string JsonData= JsonConvert.SerializeObject(inventory);
            Console.WriteLine(JsonData);
            inventoryList = JsonConvert.DeserializeObject<List<Inventory>>(filePath);
           // Console.WriteLine(inventoryList);
            return inventoryList;
        }

    }
}
