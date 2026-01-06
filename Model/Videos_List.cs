using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Videos_List:List<Videos>
    {
        public Videos_List() { }
        public Videos_List(IEnumerable<Videos> list) : base(list) { }
        public Videos_List(IEnumerable<BaseEntity> list) : base(list.Cast<Videos>().ToList()) { }
    }
}
