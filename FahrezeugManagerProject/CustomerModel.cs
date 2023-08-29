using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FahrezeugManagerProject
{
    class CustomerModel
    {
        public List<Customer> customers = new List<Customer>();


        public List<Customer> getCustomers() { return customers; }

        public void setCustomer(List<Customer> customers) { this.customers = customers; } 
        

        public void addEmployee(Customer customer) {
            List<FahrezeugManagerProject.Customer> customers = jsonToFile.KundenView.GetListOfCustomers("lol.json");
  
            customers.Add(customer);   
            
            jsonToFile.KundenView.JsonToFile(customers, "lol.json");
        }

        public void removeCustomer(int selectedindex) {
            List<FahrezeugManagerProject.Customer> customers = jsonToFile.KundenView.GetListOfCustomers("lol.json");
            
            customers.RemoveAt(selectedindex);
            jsonToFile.KundenView.JsonToFile(customers, "lol.json");

        }

        public void updateCustomer(int index, Customer customer) {
            List<FahrezeugManagerProject.Customer> customers = jsonToFile.KundenView.GetListOfCustomers("lol.json");
            
            jsonToFile.KundenView.JsonToFile(customers, "lol.json");
        }

        

        
    }
}
