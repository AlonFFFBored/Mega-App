using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Status
    {
        Pending = 0,
        Confirmed = 1,
        Pending_To_Ship = 2,
        Ready_To_Ship = 3,
        Shipping = 4,
        Arrived = 5
    };
    public class Orders:BaseEntity
    {
        private DateTime order_date;
        private Status status;
        private Users user_id;

        public DateTime Order_date { get => order_date; set => order_date = value; }
        public Status Status { get => status; set => status = value; }
        public Users User_Id { get => user_id; set => user_id = value; }
    }
}
