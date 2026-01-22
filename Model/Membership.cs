using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Membership:Users
    {
        private DateTime join_date = DateTime.MinValue;
        private DateTime birthday_date = DateTime.MinValue;

        public DateTime Join_Date { get => join_date; set => join_date = value; }
        public DateTime Birthday_Date { get => birthday_date; set => birthday_date = value; }

        public override string ToString()
        {
            return $"Membership: Join Date = {Join_Date:yyyy-MM-dd}, Birthday = {Birthday_Date:yyyy-MM-dd}";
        }
    }
}
