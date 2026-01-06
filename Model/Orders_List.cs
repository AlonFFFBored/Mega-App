using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Orders_List:List<Orders>
    {
        public Orders_List() { }
        public Orders_List(IEnumerable<Orders> list) : base(list) { }
        public Orders_List(IEnumerable<BaseEntity> list) : base(list.Cast<Orders>().ToList()) { }
    }
}
