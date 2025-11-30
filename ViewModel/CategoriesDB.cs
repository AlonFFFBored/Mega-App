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
    public class CategoriesDB : BaseDB
    {
        public override BaseEntity NewEntity()
        {
            throw new NotImplementedException();
        }

        public Categories_List SelectAll()
        {
            command.CommandText = $"SELECT * FROM Categories";

            Categories_List categories_list = new Categories_List(base.Select());
            return categories_list;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Categories c = entity as Categories;
            c.Category = reader["areaName"].ToString();
            base.CreateModel(entity);
            return entity;
        }

        static private Categories_List list = new Categories_List();

        public static Categories SelectById(int id)
        {
            CategoriesDB db = new CategoriesDB();
            list = db.SelectAll();
            Categories c = list.Find(item => item.Id == id); 
            return c;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Categories c = entity as Categories;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM Categories where id=@cid";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cid", c.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Categories c = entity as Categories;
            if (c != null)
            {
                string sqlStr = $"Insert INTO CategoryTbl (Category) VALUES (@cCategory)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cCategory", c.Category));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Categories c = entity as Categories;
            if (c != null)
            {
                string sqlStr = $"UPDATE Videos SET CategoryName=@cName WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.Category));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
    }
}
