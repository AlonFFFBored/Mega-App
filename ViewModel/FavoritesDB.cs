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
            throw new NotImplementedException();
        }
        public Favorites_List SelectAll()
        {
            command.CommandText = $"SELECT Favorites.User_ID, Favorites.Product_ID, Users.ID, Users.Username, Users.Passkey, Users.Email, Users.Role\r\nFROM" +
                $" (Users INNER JOIN\r\n" +
                $" Favorites ON Users.ID = Favorites.User_ID)";

            Favorites_List favorites_list = new Favorites_List(base.Select());
            return favorites_list;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Favorites f = entity as Favorites;
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
                string sqlStr = $"Insert INTO Favorites (Category) VALUES (@cCategory)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cCategory", f.Product_id.Id));
                command.Parameters.Add(new OleDbParameter("@cCategory", f.User_id.Id));

            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Favorites f = entity as Favorites;
            if (f != null)
            {
                string sqlStr = $"UPDATE Favorites SET User=@uId,Product=@pId WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@uId", f.User_id.Username));
                command.Parameters.Add(new OleDbParameter("@uId", f.User_id.Passkey));
                command.Parameters.Add(new OleDbParameter("@uId", f.User_id.Email));
                command.Parameters.Add(new OleDbParameter("@uId", f.User_id.Role));
                command.Parameters.Add(new OleDbParameter("@uId", f.User_id.Id));
                command.Parameters.Add(new OleDbParameter("@pId", f.Product_id.Product_Name));
                command.Parameters.Add(new OleDbParameter("@pId", f.Product_id.Product_Description));
                command.Parameters.Add(new OleDbParameter("@pId", f.Product_id.Price));
                command.Parameters.Add(new OleDbParameter("@pId", f.Product_id.Amount_In_Stock));
                command.Parameters.Add(new OleDbParameter("@pId", f.Product_id.Picture));
                command.Parameters.Add(new OleDbParameter("@pId", f.Product_id.Id));
                command.Parameters.Add(new OleDbParameter("@id", f.Id));
            }
        }
    }

}
