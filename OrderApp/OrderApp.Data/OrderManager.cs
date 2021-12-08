using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Data
{
    public class OrderManager
    {
        public List<Order> GetAllOrders()
        {
            List <Order> orders = new List<Order>();
            string sql = "SELECT * FROM Orderr";
            SqlConnection connection = new SqlConnection(Database.ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Order order = new Order();
                order.Id = reader.GetInt32(0);
                order.CustomerName = reader.GetString(1);
                order.Bill = reader.GetInt32(2);
                orders.Add(order);
            }
            connection.Close();
            return orders;
        }

        public List<Item> GetAllItems()
        {
            List<Item> items = new List<Item>();
            string sql = "SELECT * FROM Item";
            SqlConnection connection = new SqlConnection(Database.ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Item item = new Item();
                item.Id = reader.GetInt32(0);
                item.Name = reader.GetString(1);
                item.UnitPrice = reader.GetInt32(2);
                items.Add(item);
            }
            connection.Close();
            return items;
        }

        public void SaveOrder(Order order, List<OrderItem> orderItems)
        {
            order.Bill = CalculateBill(orderItems);
            
            InsertOrder(order);

            InsertOrderItems(orderItems);
        }

        private int CalculateBill(List<OrderItem> orderItems)
        {
            List<Item> items = GetAllItems();
            int bill = 0;
            foreach (var orderItem in orderItems)
            {
                Item item = items.Where(x => x.Id == orderItem.ItemId).First();
                bill += item.UnitPrice * orderItem.Quantity;
            }
            return bill;
        }

        private void InsertOrder(Order order)
        {
            //string sql = "INSERT INTO ORDERR (Id, CustomerName, Bill) VALUES ()";
            string sql = "INSERT INTO ORDERR (Id, CustomerName, Bill) VALUES (" + order.Id + ",'" + order.CustomerName + "'," + order.Bill + ")";
            SqlConnection connection = new SqlConnection(Database.ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void InsertOrderItems(List<OrderItem> orderItems)
        {
            SqlConnection connection = new SqlConnection(Database.ConnectionString);
            connection.Open();
            SqlCommand cmd;
            foreach (var item in orderItems)
            {
                string sql = "INSERT INTO ORDERITEM (OrderId, ItemId, Quantity) VALUES (" + item.OrderId+ "," + item.ItemId + "," + item.Quantity + ")";
                cmd = new SqlCommand(sql, connection);
                int result = cmd.ExecuteNonQuery();
            }
            connection.Close();
        }
        
    }
}
