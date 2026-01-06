using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Products_List:List<Products>
    {
        public Products_List() { }
        public Products_List(IEnumerable<Products> list) : base(list) { }
        public Products_List(IEnumerable<BaseEntity> list) : base(list.Cast<Products>().ToList()) { }
    }
}
