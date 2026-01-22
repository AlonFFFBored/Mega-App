using Library_Mega_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class Order_DB : BaseDB
    {
        public override BaseEntity NewEntity()
        {
            return new Orders();
        }
        public Orders_List SelectAll()
        {
            command.CommandText = $"SELECT Orders.[User ID], Orders.Oreder_Date, Orders.Status, Users.Email, Users.Username, Users.ID, Users.Passkey, Users.Role FROM" +
                $"  (Users INNER JOIN" +
                $" Orders ON Users.ID = Orders.[User ID]) Order By Orders.Id";

          Orders_List orders_list = new Orders_List(base.Select());
            return orders_list;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Orders o = entity as Orders;
            o.User_Id= UsersDB.SelectById(int.Parse(reader["User ID"].ToString()));
            o.Order_date = DateTime.Parse(reader["oreder_date"].ToString());
            o.Status = (Status)(int.Parse(reader["status"].ToString()));
            base.CreateModel(entity);
            return entity;
        }

        static private Orders_List list = new Orders_List();
        public static Orders SelectById(int id)
        {
            Order_DB db = new Order_DB();
            list = db.SelectAll();
            Orders o = list.Find(item => item.Id == id); 
            return o;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Orders o = entity as Orders;
            if (o != null)
            {
                string sqlStr = $"DELETE FROM Orders where id=@oid";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@oid", o.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Orders o = entity as Orders;
            if (o != null)
            {
                string sqlStr = $"Insert INTO Orders (User_Id,Oreder_Date,Status) VALUES (@oUserId,@oOrderDate,@oStatus)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@oUserId", o.User_Id.Id));
                OleDbParameter param1 = new OleDbParameter("@oDate", OleDbType.DBDate);
                param1.Value = o.Order_date;
                command.Parameters.Add(param1);
                command.Parameters.Add(new OleDbParameter("@oStatus", o.Status));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Orders o = entity as Orders;
            if (o != null)
            {
                string sqlStr = $"UPDATE Orders SET User_ID=@uId,Oreder_Date=@oDate,status=@oStatus WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@uId", o.User_Id.Id));
                OleDbParameter param1 = new OleDbParameter("@oDate", OleDbType.DBDate);
                param1.Value = o.Order_date;
                command.Parameters.Add(param1);
                command.Parameters.Add(new OleDbParameter("@oStatus", o.Status));
                command.Parameters.Add(new OleDbParameter("@id", o.Id));
            }
        }
    }
}
