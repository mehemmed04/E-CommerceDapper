using Dapper;
using E_CommerceDapper.DataAccess.Abstractions;
using E_CommerceDapper.DataAccess.Entites;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDapper.DataAccess.Concretes
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {

        private string ConnectionString { get; set; }
        public OrderDetailsRepository()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        }

        public void Add(OrderDetails data)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = $@"INSERT INTO [Order Details](OrderID,ProductID,UnitPrice,Quantity,Discount)
Values(@orderid,@productid,@unitprice,@quantity,@discount)";
                conn.Execute(sql, new {orderid=data.OrderID,productid=data.ProductID,unitprice=data.UnitPrice,quantity=data.Quantity,discount=data.Discount});
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDetails Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDetails> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(OrderDetails data)
        {
            throw new NotImplementedException();
        }
    }
}
