using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Membership_List:List<Membership>
    {
        public Membership_List() { }
        public Membership_List(IEnumerable<Membership> list) : base(list) { }
        public Membership_List(IEnumerable<BaseEntity> list) : base(list.Cast<Membership>().ToList()) { }
    }
}
