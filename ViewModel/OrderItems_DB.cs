using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Mega_App;
using Model;
namespace ViewModel
{
    internal class OrderItems_DB : BaseDB
    {
        public override BaseEntity NewEntity()
        {
            throw new NotImplementedException();
        }
        public OrderItems_List SelectAll()
        {
            command.CommandText = $"SELECT * FROM OrderItems";

            OrderItems_List orderitems_list = new OrderItems_List(base.Select());
            return orderitems_list;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            OrderItems o = entity as OrderItems;
            o.Amount = int.Parse(reader["amount"].ToString());
            base.CreateModel(entity);
            return entity;
        }
        static private OrderItems_List list = new OrderItems_List();

        public static OrderItems SelectById(int id)
        {
            OrderItems_DB db = new OrderItems_DB();
            list = db.SelectAll();
            OrderItems o = list.Find(item => item.Id == id); 
            return o;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            OrderItems oi = entity as OrderItems;
            if (oi != null)
            {
                string sqlStr = $"DELETE FROM OrderItems where id=@oiid";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@oiid", oi.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            OrderItems oi = entity as OrderItems;
            if (oi != null)
            {
                string sqlStr = $"Insert INTO OrderItems (Order_ID,Product_ID,Amount) VALUES (@oiOrderID,@oiProductID,@oiAmount)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@oiOrderID", oi.Order_Id.Id));
                command.Parameters.Add(new OleDbParameter("@oiProduct", oi.Product_Id.Id));
                command.Parameters.Add(new OleDbParameter("@oiAmount", oi.Amount));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            OrderItems oi = entity as OrderItems;
            if (oi != null)
            {
                string sqlStr = $"UPDATE Videos SET OrderItemsAmount=@oiAmount,OrderItems=@oiId,Product=@pId WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@oiAmount", oi.Amount));
                command.Parameters.Add(new OleDbParameter("@oiId", oi.Order_Id.User_Id));
                command.Parameters.Add(new OleDbParameter("@oiId", oi.Order_Id.Order_date));
                command.Parameters.Add(new OleDbParameter("@oiId", oi.Order_Id.Status));
                command.Parameters.Add(new OleDbParameter("@oiId", oi.Order_Id.Id));
                command.Parameters.Add(new OleDbParameter("@pId", oi.Product_Id.Product_Name));
                command.Parameters.Add(new OleDbParameter("@pId", oi.Product_Id.Product_Description));
                command.Parameters.Add(new OleDbParameter("@pId", oi.Product_Id.Price));
                command.Parameters.Add(new OleDbParameter("@pId", oi.Product_Id.Amount_In_Stock));
                command.Parameters.Add(new OleDbParameter("@pId", oi.Product_Id.Picture));
                command.Parameters.Add(new OleDbParameter("@pId", oi.Product_Id.Id));
                command.Parameters.Add(new OleDbParameter("@id", oi.Id));
            }
        }
    }
}
