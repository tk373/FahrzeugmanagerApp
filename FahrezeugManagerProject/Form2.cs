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
using System.Windows.Forms;

namespace FahrezeugManagerProject
{

    public partial class Form2 : Form
    {

        public Form2(int i, int index)
        {
            InitializeComponent();
            
            if (i == 1) {
                buttonCancel.Visible = false;
                List<FahrezeugManagerProject.Customer> customers = jsonToFile.KundenView.GetListOfCustomers("lol.json");
                CustomerModel customerModel = new CustomerModel();
                customerModel.removeCustomer(index);
                textBox1.Text = customers[index].Vorname;
                textBox2.Text = customers[index].Nachname;
                textBox3.Text = customers[index].Adress;
                textBox4.Text = customers[index].Plz;
                textBox5.Text = customers[index].Wohnort;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
            Form1 form = new Form1();
            form.Show();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            CustomerModel customerModel = new CustomerModel();


            Customer customer = new Customer()
            {
                Vorname = textBox1.Text,
                Nachname = textBox2.Text,
                Adress = textBox3.Text,
                Plz = textBox4.Text,
                Wohnort = textBox5.Text
            };

            customerModel.addEmployee(customer);

            this.Close();

            Form1 form = new Form1();
            form.Show();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
