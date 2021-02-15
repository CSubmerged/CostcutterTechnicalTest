using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using ui.Properties;

namespace ui
{
    public class Database
    {
        private readonly string _ConnectionString = Settings.Default.DbConnectionString;

        public MySqlConnection GetConnection => new MySqlConnection(_ConnectionString);


        public IEnumerable<dynamic> FetchAllBranches()
        {
            var dbConnection = new Database().GetConnection;
            dbConnection.Open();

            var sql = "SELECT * from branches";
            var result = dbConnection.Query(sql);
            dbConnection.Close();
            return result;
        }

        public int FetchOrdersCount()
        {
            var dbConnection = new Database().GetConnection;
            dbConnection.Open();

            var sql = "SELECT Count(*) from orders";
            var result = dbConnection.QueryFirst<int>(sql);
            dbConnection.Close();
            return result;
        }

        public IEnumerable<dynamic> FetchOrderDetails(int orderNumber)
        {
            var dbConnection = new Database().GetConnection;
            dbConnection.Open();

            var sql = "SELECT o.order_number, o.order_date, o.sale_price, o.deposit, " +
                "c.customer_number, c.forename, c.surname, c.telephone_number, " +
                "bande.branch_name, bande.postcode " +
                "FROM practicaltest.orders o " +
                "LEFT JOIN practicaltest.customers c ON (o.customer_number=c.customer_number) " +
                "LEFT JOIN (SELECT e.employee_number, b.branch_name, b.postcode " +
                    "FROM practicaltest.branches b " +
                    "LEFT JOIN practicaltest.employees e ON (b.branch_name=e.branch_name)) bande " +
                "ON (o.employee_number=bande.employee_number) " +
                "WHERE o.order_number=" + orderNumber.ToString();

            var result = dbConnection.Query(sql);
            dbConnection.Close();
            return result;
        }

        public IEnumerable<dynamic> FetchDateFilteredOrderDetails(int orderNumber, string startDate)
        {
            var dbConnection = new Database().GetConnection;
            dbConnection.Open();

            var sql = "SELECT o.order_number, o.order_date, o.sale_price, o.deposit, " +
                "c.customer_number, c.forename, c.surname, c.telephone_number, " +
                "bande.branch_name, bande.postcode " +
                "FROM practicaltest.orders o " +
                "LEFT JOIN practicaltest.customers c ON (o.customer_number=c.customer_number) " +
                "LEFT JOIN (SELECT e.employee_number, b.branch_name, b.postcode " +
                    "FROM practicaltest.branches b " +
                    "LEFT JOIN practicaltest.employees e ON (b.branch_name=e.branch_name)) bande " +
                "ON (o.employee_number=bande.employee_number) " +
                "WHERE o.order_number=" + orderNumber.ToString() +
                " AND o.order_date>='" + startDate + "';";

            var result = dbConnection.Query(sql);
            dbConnection.Close();
            return result;
        }
    }
}
