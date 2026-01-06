using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Products_Categories:BaseEntity
    {
        private Products product_name_id;
        private Categories category_id;

        public Products Product_Name_Id { get => product_name_id; set => product_name_id = value; }
        public Categories Category_Id { get => category_id; set => category_id = value; }

        public override string ToString()
        {
            return $"ProductCategory: Product = {Product_Name_Id?.Id}, Category = {Category_Id?.Id}";
        }
    }
}
