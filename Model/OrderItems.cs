using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderItems:BaseEntity
    {
        private Orders order_id;
        private Products product_id;
        private int amount;

        public Orders Order_Id { get => order_id; set => order_id = value; }
        public Products Product_Id { get => product_id; set => product_id = value; }
        public int Amount { get => amount; set => amount = value; }

        public override string ToString()
        {
            return $"OrderItem: Order = {Order_Id?.Id}, Product = {Product_Id?.Id}, Amount = {Amount}";
        }
    }
}
