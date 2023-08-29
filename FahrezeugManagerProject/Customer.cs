 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahrezeugManagerProject
{
    public class Customer
    {

        public String Vorname { get; set; }
        public String Nachname { get; set; }
        public String Adress { get; set; }
        public String Plz { get; set; }
        public String Wohnort { get; set; }

        public void ToInt(String toInt) {
            int x = Int32.Parse(toInt);
        }

    }
}
