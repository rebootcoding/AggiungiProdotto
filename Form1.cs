using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AggiungiProdotto
{
    public partial class Form1 : Form
    {
        public DataBase db;
        public Form1()
        {
            InitializeComponent();
            db = new DataBase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection())
            {
                var rows = db.GetListaProdotti().DefaultView;
                dgr_lista_prodotti.DataSource = rows;
                var rowsBrands = db.GetListaBrands().DefaultView;
                cbx_brand.DisplayMember = "brand_name";
                cbx_brand.DataSource = rowsBrands;
                var rowsCategory = db.GetListaCategorie().DefaultView;
                cbx_categoria.DisplayMember = "category_name";
                cbx_categoria.DataSource = rowsCategory;

                //var rows = db.GetCustomers().DefaultView;
                //cbx_customers.DisplayMember = "Nome Completo";
                //cbx_customers.DataSource = rows;

            }
        }

        private void btn_carica_lista_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection())
            {
                var rows = db.UpdateListaProdotti().DefaultView;
                dgr_lista_prodotti.DataSource = rows;
            }
        }

        private void btn_carica_prodotto_Click(object sender, EventArgs e)
        {
            var nome = tbx_nome.Text;
            var selBrand = cbx_brand.SelectedItem as DataRowView;
            var brand_id = $"{selBrand["brand_id"]}";
            var selCat = cbx_categoria.SelectedItem as DataRowView;
            var category_id = $"{selCat["category_id"]}";
            var model_year = tbx_anno.Text;
            var list_price = tbx_prezzo.Text;
            db.InsertNewProduct(nome.ToString(), int.Parse(brand_id), int.Parse(category_id), int.Parse(model_year), decimal.Parse(list_price));

            //var selItem = cbx_customers.SelectedItem as DataRowView;

            //var id_customer = $"{selItem["customer_id"]}";
            //var table = db.GetAllOrdersByCustomer(id_customer);
            //dataGridView1.DataSource = table;
        }
    }
}
