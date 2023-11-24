using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Association_Relationship_One_to_Many_Example2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        Shop aShop = new Shop();
        private void shopSaveButton_Click(object sender, EventArgs e)
        {
            aShop.Name = shopNameTextBox.Text;
            aShop.Address = shopAddressTextBox.Text;
            MessageBox.Show("Shop has been added");
        }

        private void productSaveButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Code = productCodeTextBox.Text.ToUpper();
            bool checkCode = aShop.SameProductCode(product.Code);
            if(checkCode)
            {
                aShop.UpdateQuantity(product.Code, Convert.ToInt32(productQuantityTextBox.Text));
            }
            else
            {
                product.Quantity = Convert.ToInt32(productQuantityTextBox.Text);
                aShop.ProductList.Add(product);
            }

            MessageBox.Show("Product has been added");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showShopNameTextBox.Text = aShop.Name;
            showNumberOfProductTextBox.Text = aShop.ProductList.Count.ToString();
            
            productListBox.Items.Clear();
            foreach(Product product in aShop.ProductList)
            {
                productListBox.Items.Add(product.Code+"\t"+ product.Quantity);
            }
        }
    }
}
