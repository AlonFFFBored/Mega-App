using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Products : BaseEntity
    {
        private string product_name;
        private string product_description;
        private double price;
        private string picture;
        private int amount_in_stock;
        public string Product_Name { get => product_name; set => product_name = value; }
        public string Product_Description { get => product_description; set => product_description = value; }
        public double Price { get => price; set => price = value; }
        public string Picture { get => picture; set => picture = value; }
        public int Amount_In_Stock { get => amount_in_stock; set => amount_in_stock = value; }
    }

}
