using System.Linq;
using System.Collections.Generic;
using Dapper;
using ui;
using Xunit;

namespace unit_tests
{
    public class ExampleTest
    {
        [Fact]
        public void TestDatabaseConnection()
        {
            var dbConnection = new Database().GetConnection;
            dbConnection.Open();

            var sql = "SELECT 1";
            var expectedResult = 1;
            var actualResult = dbConnection.QueryFirst<int>(sql);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void NumberOfBranchesFetchedCorrectly()
        {
            var dbConnection = new Database().GetConnection;
            dbConnection.Open();
            var sql = "SELECT COUNT(*) FROM branches";
            var expectedResult = dbConnection.QueryFirst<int>(sql);
            dbConnection.Close();

            var db = new Database();
            var actualResult = db.FetchAllBranches();

            Assert.Equal(expectedResult, actualResult.Count());
        }

        [Fact]
        public void NumberOfOrdersFetchedCorrectly()
        {
            var dbConnection = new Database().GetConnection;
            dbConnection.Open();
            var sql = "SELECT * FROM orders";
            var expectedResult = dbConnection.Query(sql);
            dbConnection.Close();

            var db = new Database();
            var actualResult = db.FetchOrdersCount();

            Assert.Equal(expectedResult.Count(), actualResult);
        }

        [Fact]
        public void OrderDetailsColumnsFetchedCorrectly()
        {
            // Column names are predefined in the Form DataTable, so
            // a test to ensure column names haven't been missed/changed
            // in the database is needed.
            string[] columnNames = { "order_number", "order_date", 
                "sale_price", "deposit", "customer_number", "forename", 
                "surname", "telephone_number", "branch_name", "postcode"};

            var db = new Database();
            var actualResult = db.FetchOrderDetails(1);
            var actualResultDict = actualResult.First() as IDictionary<string, object>;

            Assert.Equal(actualResultDict.Keys, columnNames);
        }

        [Fact]
        public void OrderDetailsDateFilterFunctioning()
        {
            // The date filter should block any order number search
            // that is before the specified date
            var db = new Database();
            var orderOne = db.FetchOrderDetails(1);
            var orderOneDict = orderOne.First() as IDictionary<string, object>;
            System.DateTime orderOneDate = (System.DateTime)orderOneDict["order_date"];

            var goodStartDate = orderOneDate.AddMonths(-1).ToString("yyyy-MM-dd");
            var badStartDate = orderOneDate.AddMonths(1).ToString("yyyy-MM-dd");

            var goodResult = db.FetchDateFilteredOrderDetails(1, goodStartDate);
            Assert.True(goodResult.Count() > 0);

            var badResult = db.FetchDateFilteredOrderDetails(1, badStartDate);
            Assert.True(badResult.Count() == 0);
        }
    }
}