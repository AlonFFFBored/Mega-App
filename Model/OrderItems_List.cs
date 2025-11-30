using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderItems_List:List<OrderItems>
    {
        public OrderItems_List() { }
        public OrderItems_List(IEnumerable<OrderItems> list) : base(list) { }
        public OrderItems_List(IEnumerable<BaseEntity> list) : base(list.Cast<OrderItems>().ToList()) { }
    }
}
