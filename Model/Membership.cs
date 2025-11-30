using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Membership:Users
    {
        private DateTime join_date;
        private DateTime birthday_date;

        public DateTime Join_Date { get => join_date; set => join_date = value; }
        public DateTime Birthday_Date { get => birthday_date; set => birthday_date = value; }
    }
}
