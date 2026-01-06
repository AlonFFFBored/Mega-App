using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Products_Categories_List:List<Products_Categories>
    {
        public Products_Categories_List() { }
        public Products_Categories_List(IEnumerable<Products_Categories> list) : base(list) { }
        public Products_Categories_List(IEnumerable<BaseEntity> list) : base(list.Cast<Products_Categories>().ToList()) { }
    }
}
