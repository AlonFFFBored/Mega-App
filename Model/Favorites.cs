using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Favorites:BaseEntity
    {
        private Users user_id;
        private Products product_id;

        public Products Product_id { get => product_id; set => product_id = value; }
        public Users User_id { get => user_id; set => user_id = value; }

        public override string ToString()
        {
            return $"Favorite: User = {User_id?.Id}, Product = {Product_id?.Id}";
        }
    }
}
