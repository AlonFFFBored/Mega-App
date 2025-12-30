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
    public class UsersDB : BaseDB
    {
        public override BaseEntity NewEntity()
        {
             return new Users();
        }
        public Users_List SelectAll()
        {
            command.CommandText = $"SELECT * FROM Users";

            Users_List users_list = new Users_List(base.Select());
            return users_list;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Users u = entity as Users;
            u.Username = reader["username"].ToString();
            u.Role = (Role)int.Parse(reader["role"].ToString());
            u.Email = reader["Email"].ToString();
            u.Passkey = reader["passkey"].ToString();
            base.CreateModel(entity);
            return entity;
        }
        static private Users_List list = new Users_List();

        public static Users SelectById(int id)
        {
            UsersDB db = new UsersDB();
            list = db.SelectAll();
            Users u = list.Find(item => item.Id == id); return u;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Users u = entity as Users;
            if (u != null)
            {
                string sqlStr = $"DELETE FROM Users where id=@uid";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@uid", u.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Users u = entity as Users;
            if (u != null)
            {
                string sqlStr = $"Insert INTO Users (Username,Email,Passkey,Role) VALUES (@uUsername,@uEmail,@Passkey,@uRole)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@uUsername", u.Username));
                command.Parameters.Add(new OleDbParameter("@uEmail", u.Email));
                command.Parameters.Add(new OleDbParameter("@uPasskey", u.Passkey));
                command.Parameters.Add(new OleDbParameter("@uRole", (int)u.Role));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Users u = entity as Users;
            if (u != null)
            {
                string sqlStr = $"UPDATE Users SET Username=@uName,Passkey=@uPasskey ,Role=@uRole ,Email=@uEmail  WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@uName", u.Username));
                command.Parameters.Add(new OleDbParameter("@uPasskey", u.Passkey));
                command.Parameters.Add(new OleDbParameter("@uRole", u.Role));
                command.Parameters.Add(new OleDbParameter("@uEmail", u.Email));
                command.Parameters.Add(new OleDbParameter("@id", u.Id));
            }
        }
    }
}
