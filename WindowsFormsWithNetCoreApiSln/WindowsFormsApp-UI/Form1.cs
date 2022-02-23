using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_UI.Models;

namespace WindowsFormsApp_UI
{
    public partial class Form1 : Form
    {
        HttpClient client = new HttpClient();
        //fonte:
        //https://docs.microsoft.com/pt-br/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client


        public Form1()
        {
            InitializeComponent();
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://localhost:44326/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async void btnListarAll_Click(object sender, EventArgs e)
        {
            IEnumerable<Product> products = null;
            HttpResponseMessage response = await client.GetAsync("api/product");
            if (response.IsSuccessStatusCode)
            {
                products = await response.Content.ReadAsAsync<IEnumerable<Product>>();
            }

            txtResult.AppendText("Id     -      Nome: ");
            txtResult.AppendText(Environment.NewLine);

            foreach (var product in products.ToList())
            {
                txtResult.AppendText(product.Id.ToString() + " - " + product.Name);
                txtResult.AppendText(Environment.NewLine);
            }
        }

        private async void btnCriarNovo_Click(object sender, EventArgs e)
        {

            Product newProd = new Product()
            {
                Name = "Novo Prod",
                Category = "Office",
                Price = 250.90M
            };

            HttpResponseMessage response = await client.PostAsJsonAsync("api/product", newProd);
            if (response.IsSuccessStatusCode)
            {
                newProd = await response.Content.ReadAsAsync<Product>();
            }

            txtBoxAdd.AppendText("Id     -      Nome: ");
            txtBoxAdd.AppendText(Environment.NewLine);
            txtBoxAdd.AppendText(newProd.Id.ToString() + " - " + newProd.Name);

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            Product newProd = new Product()
            {
                Id = 1,
                Name = "Alicate",
                Category = "Office",
                Price = 250.90M
            };

            HttpResponseMessage response = await client.PutAsJsonAsync($"api/product/{newProd.Id}", newProd);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            newProd = await response.Content.ReadAsAsync<Product>();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = await client.DeleteAsync($"api/product/{1}");
            object result = await response.Content.ReadAsAsync<object>();
            var teste = result;

        }
    }
}
