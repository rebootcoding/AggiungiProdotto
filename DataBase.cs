using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AggiungiProdotto
{
    public class DataBase
    {
        private SqlConnectionStringBuilder connectionStringBuilder
        {
            get
            {
                var builder = new SqlConnectionStringBuilder();
                builder.DataSource = "WINAPHS2OH2TH8K\\SQLEXPRESS";
                builder.InitialCatalog = "AcademyNet";
                builder.IntegratedSecurity = true; //unione tra sistemi diversi, aumenta livello di sicurezza integrato, APPROFONDIRE
                return builder;
            }
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionStringBuilder.ConnectionString);
        }

        public DataTable GetListaProdotti()
        {
            using (var conn = GetConnection())
            {
                var command = new SqlCommand();
                command.CommandText = $"SELECT * " + "FROM production.products";
                command.Connection = conn;

                try
                {
                    conn.Open();
                    var reader = command.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public DataTable UpdateListaProdotti()
        {
            using (var conn = GetConnection())
            {
                var command = new SqlCommand();
                command.CommandText = $"SELECT * " + "FROM production.products " + "ORDER BY product_id DESC";
                command.Connection = conn;

                try
                {
                    conn.Open();
                    var reader = command.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void InsertNewProduct(string name, int brand_id, int category_id, int model_year, decimal list_price)

        {
            using (var conn = GetConnection())
            {
                var command = new SqlCommand();
                command.CommandText = $"INSERT INTO production.products (product_name, brand_id, category_id, model_year, list_price) " + "VALUES ('" + name + "','" + brand_id + "','" + category_id + "','" + model_year + "','" + list_price + "')";

                command.Connection = conn;
                try
                {
                    conn.Open();
                    var writer = command.ExecuteNonQuery();
                    MessageBox.Show("Hai inserito un nuovo prodotto!");

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public DataTable GetListaBrands()
        {
            using (var conn = GetConnection())
            {
                var command = new SqlCommand();
                command.CommandText = $"SELECT b.brand_name "+"FROM production.brands b "+"ORDER BY b.brand_name";
                command.Connection = conn;

                try
                {
                    conn.Open();
                    var reader = command.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
        public DataTable GetListaCategorie()
        {
            using (var conn = GetConnection())
            {
                var command = new SqlCommand();
                command.CommandText = $"SELECT b.category_name " + "FROM production.categories b " + "ORDER BY b.category_name";
                command.Connection = conn;

                try
                {
                    conn.Open();
                    var reader = command.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
}
