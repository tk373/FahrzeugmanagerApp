using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;


namespace FahrezeugManagerProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<FahrezeugManagerProject.Customer> customers = jsonToFile.KundenView.GetListOfCustomers("lol.json");
            foreach (Customer customer in customers) {
                listViewCars.Items.Add(customer.Nachname + "  " + customer.Vorname);
            }
            

        }

       
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
            public void listViewCars_SelectedIndexChanged(object sender, EventArgs e)
             {
           

             }

        private void listViewCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            CustomerModel customerModel = new CustomerModel();
            int selectedindex;
            selectedindex = listViewCars.FocusedItem.Index;

            if (selectedindex >= 0)
            {
                customerModel.removeCustomer(selectedindex);
                listViewCars.Items.Clear();

                List<FahrezeugManagerProject.Customer> customers = jsonToFile.KundenView.GetListOfCustomers("lol.json");
                foreach (Customer customer in customers)
                {
                    listViewCars.Items.Add(customer.Nachname + "  " + customer.Vorname);
                }

            }
        }


        private void newButtons_Click(object sender, EventArgs e)
        {
            int a = 0;
            int i = 0;
            Form2 form = new Form2(i, a);
            form.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

      

        private void listViewCars_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2)
            {
                int i = 1;
                int selectedindex = listViewCars.FocusedItem.Index;
                Form2 form = new Form2(i, selectedindex);
                form.Show();
                this.Hide();
            }
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
