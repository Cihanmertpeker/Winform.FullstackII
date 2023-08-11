using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.FullstackII.Defaults;
using Winform.FullstackII.Entities;

namespace Winform.FullstackII.Forms
{
    public partial class ProductsForm : Form
    {
        public ProductsForm(string userFullname)
        {
            InitializeComponent();

            this.userFullname = userFullname;
            Reload();
        }
        public string userFullname;
        Product selectedProduct;




        public void Reload()
        {
            var notes = ListProduct();
            listNote.DataSource = null;
            listNote.DataSource = notes;
            listNote.DisplayMember = "Name";
            listNote.ValueMember = "Id";
        }


        private void ProductsForm_Load(object sender, EventArgs e)
        {
            var item = listNote.SelectedItem as Product;
            lblTest.Text = item.Stock.ToString();
            lblUser.Text = userFullname;
        }

        private List<Product> ListProduct()
        {
            var productlist = new List<Product>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from Products";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var product = new Product();
                product.Id = Convert.ToInt32(reader[0]);
                product.Name = Convert.ToString(reader[1]);
                product.Stock = Convert.ToInt32(reader[2]);

                productlist.Add(product);
            }
            reader.Close();
            connection.Close();

            return productlist;


        }

        private void ProductsForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listNote.SelectedItem != null)
            {
                selectedProduct = listNote.SelectedItem as Product;
                txtStock.Text = selectedProduct.Stock + "";
                txtProductName.Text = selectedProduct.name;
                lblTest.Text = selectedProduct.Stock.ToString();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(txtStock.Text))
            {
                UpdatedProduct(new Product { Name = txtProductName.Text, Stock = int.Parse(txtStock.Text), Id = selectedProduct.Id });
                Reload();

            }


        }
        private int UpdatedProduct(Product updatedProduct)
        {
            SqlConnection connection = new SqlConnection("Server=.\\SQLExpress; database=TutorialDb; integrated security=True;");

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "Update Products set Name = @Name , Stock=@Stock where Id=@Id";
            command.Parameters.AddWithValue("@Name", updatedProduct.Name);
            command.Parameters.AddWithValue("@Stock", updatedProduct.Stock);
            command.Parameters.AddWithValue("@Id", updatedProduct.Id);

            connection.Open();
            int affectedRows = command.ExecuteNonQuery();
            connection.Close();

            return affectedRows;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
            selectedProduct = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(txtStock.Text))
            {
                SqlConnection connection = new SqlConnection("Server =.\\SQLExpress; database= TutorialDb; integrated security=True;");
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "insert into Products values (@Name,@Stock)";
                var stock = int.Parse(txtStock.Text);

                command.Parameters.AddWithValue("@name", txtProductName.Text);
                command.Parameters.AddWithValue("@Stock", stock);
                connection.Open();
                var affectedRows = command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.Close();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Successfully added.");
                    Reload();
                    ClearText();
                }
            }
            else
            {
                MessageBox.Show("Please fill the empty fields");
            }


        }

        private void ClearText()
        {
            txtProductName.Text = string.Empty;
            txtStock.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            { 
                SqlConnection connection = new SqlConnection("server = .\\SQLExpress; database=TutorialDb; integrated security = True");
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText= "delete from Products where Id = @Id";

                command.Parameters.AddWithValue("@Id", selectedProduct.Id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                Reload();
                ClearText();


            }
            else
            {
                MessageBox.Show(MessageDefaults.ProductNotSelected);
            }

        }


    }
}

