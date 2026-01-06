using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Categories_List:List<Categories>
    {
        public Categories_List() { }
        public Categories_List(IEnumerable<Categories> list) : base(list){}
        public Categories_List(IEnumerable<BaseEntity> list) : base(list.Cast<Categories>().ToList()){}
    }
}
