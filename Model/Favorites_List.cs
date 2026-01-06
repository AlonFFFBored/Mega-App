using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Favorites_List:List<Favorites>
    {
        public Favorites_List() { }
        public Favorites_List(IEnumerable<Favorites> list) : base(list) { }
        public Favorites_List(IEnumerable<BaseEntity> list) : base(list.Cast<Favorites>().ToList()) { }
    }
}
