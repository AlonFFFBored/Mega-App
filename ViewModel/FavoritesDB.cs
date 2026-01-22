using Library_Mega_App;
using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace ViewModel
{
    public class FavoritesDB : BaseDB
    {
        public override BaseEntity NewEntity()
        {
            return new Favorites();
        }
        public Favorites_List SelectAll()
        {
            command.CommandText = $"SELECT Favorites.User_ID, Favorites.Product_ID, Users.ID, Users.Username, Users.Passkey, Users.Email, Users.Role FROM" +
                $" (Users INNER JOIN " +
                $" Favorites ON Users.ID = Favorites.User_ID) Order By Favorites.Id";

            Favorites_List favorites_list = new Favorites_List(base.Select());
            return favorites_list;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Favorites f = entity as Favorites;
            f.User_id = UsersDB.SelectById(int.Parse(reader["User_ID"].ToString()));
            f.Product_id = Products_DB.SelectById(int.Parse(reader["Product_ID"].ToString()));
            base.CreateModel(entity);
            return entity;
        }
        static private Favorites_List list = new Favorites_List();

        public static Favorites SelectById(int id)
        {
            FavoritesDB db = new FavoritesDB();
            list = db.SelectAll();
            Favorites f = list.Find(item => item.Id == id); 
            return f;

        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Favorites f = entity as Favorites;
            if (f != null)
            {
                string sqlStr = $"DELETE FROM Favorites where id=@fid";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@fid", f.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Favorites f = entity as Favorites;
            if (f != null)
            {
                string sqlStr = $"Insert INTO Favorites (User_ID,Product_ID) VALUES (@pUser_ID,@pProduct_ID)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pUser_ID", f.User_id.Id));
                command.Parameters.Add(new OleDbParameter("@pProduct_ID", f.Product_id.Id));

            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Favorites f = entity as Favorites;
            if (f != null)
            {
                string sqlStr = $"UPDATE Favorites SET User_ID=@uId,Product_ID=@pId WHERE ID=@id";
                command.CommandText = sqlStr;

                command.Parameters.Add(new OleDbParameter("@uId", f.User_id.Id));
                command.Parameters.Add(new OleDbParameter("@pId", f.Product_id.Id));
                command.Parameters.Add(new OleDbParameter("@id", f.Id));
            }
        }
    }

}
