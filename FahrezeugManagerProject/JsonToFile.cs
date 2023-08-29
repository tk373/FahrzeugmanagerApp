using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.Json;
using System.IO;
using Newtonsoft.Json;


namespace jsonToFile
{
    public class KundenView
    {
        public static void JsonToFile(List<FahrezeugManagerProject.Customer> customers, string path) {
            string json = JsonConvert.SerializeObject(customers, Formatting.Indented);
            File.WriteAllText(path, json);
        
        }
        
            public static List<FahrezeugManagerProject.Customer> GetListOfCustomers(string path)
            {
                string json = File.ReadAllText(path);
                List<FahrezeugManagerProject.Customer> customers = JsonConvert.DeserializeObject<List<FahrezeugManagerProject.Customer>>(json);
                return customers;
            }
       

    }
}
