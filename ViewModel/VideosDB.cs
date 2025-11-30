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
    public class VideosDB : BaseDB
    {
        public override BaseEntity NewEntity()
        {
            throw new NotImplementedException();
        }
        public Videos_List SelectAll()
        {
            command.CommandText = $"SELECT * FROM Favorites";

            Videos_List videos_list = new Videos_List(base.Select());
            return videos_list;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Videos v = entity as Videos;
            v.Video_Link = reader["video_link"].ToString();
            v.Video_Name = reader["video_name"].ToString();
            base.CreateModel(entity);
            return entity;
        }
        static private Videos_List list = new Videos_List();
        public static Videos SelectById(int id)
        {
            VideosDB db = new VideosDB();
            list = db.SelectAll();
            Videos v = list.Find(item => item.Id == id); return v;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Videos v = entity as Videos;
            if (v != null)
            {
                string sqlStr = $"DELETE FROM Videos where id=@vid";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@vid", v.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Videos v = entity as Videos;
            if (v != null)
            {
                string sqlStr = $"Insert INTO VideosTbl (Video_Name,Link,Product_ID) VALUES (@vVideoName,@vVideoLink,@vProductID)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@vVideoName", v.Video_Name));
                command.Parameters.Add(new OleDbParameter("@vVideoLink", v.Video_Link));
                command.Parameters.Add(new OleDbParameter("@vProductID", v.Product_Id.Id));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Videos v = entity as Videos;
            if (v != null)
            {
                string sqlStr = $"UPDATE Videos SET VideoName=@vName,VideoLink=@vLink,ProductId=@pid WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", v.Video_Name));
                command.Parameters.Add(new OleDbParameter("@vLink", v.Video_Link));
                command.Parameters.Add(new OleDbParameter("@pId",v.Product_Id.Product_Name));
                command.Parameters.Add(new OleDbParameter("@pId", v.Product_Id.Product_Description));
                command.Parameters.Add(new OleDbParameter("@pId", v.Product_Id.Amount_In_Stock));
                command.Parameters.Add(new OleDbParameter("@pId", v.Product_Id.Price));
                command.Parameters.Add(new OleDbParameter("@pId", v.Product_Id.Picture));
                command.Parameters.Add(new OleDbParameter("@pId", v.Product_Id.Id));
                command.Parameters.Add(new OleDbParameter("@id", v.Id));
            }
        }
    }
}
