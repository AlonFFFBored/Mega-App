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
            return new Videos();
        }
        public Videos_List SelectAll()
        {
            command.CommandText = $"SELECT * FROM Videos";

            Videos_List videos_list = new Videos_List(base.Select());
            return videos_list;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Videos v = entity as Videos;
            v.Video_Link = reader["Link"].ToString();
            v.Video_Name = reader["video_name"].ToString();
            v.Product_Id = Products_DB.SelectById(int.Parse(reader["Product ID"].ToString()));
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
                string sqlStr = $"Insert INTO Videos (Video_Name,Link,[Product ID]) VALUES (@vVideoName,@vVideoLink,@vProductID)";
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
                string sqlStr = $"UPDATE Videos SET Video_Name=@vName,Link=@vLink,[Product Id]=@pid WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", v.Video_Name));
                command.Parameters.Add(new OleDbParameter("@vLink", v.Video_Link));
                command.Parameters.Add(new OleDbParameter("@pId", v.Product_Id.Id));
                command.Parameters.Add(new OleDbParameter("@id", v.Id));
            }
        }
    }
}
