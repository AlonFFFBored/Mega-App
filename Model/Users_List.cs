using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Users_List:List<Users>
    {
        public Users_List() { }
        public Users_List(IEnumerable<Users> list) : base(list) { }
        public Users_List(IEnumerable<BaseEntity> list) : base(list.Cast<Users>().ToList()) { }
    }
}
