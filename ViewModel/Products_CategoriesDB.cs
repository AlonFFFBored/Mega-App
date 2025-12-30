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
    public class Products_CategoriesDB : BaseDB
    {
        public override BaseEntity NewEntity()
        {
            return new Products_Categories();
        }
        public Products_Categories_List SelectAll()
        {
            command.CommandText = $"SELECT * FROM [Products-Categories]";

            Products_Categories_List products_categories_list = new Products_Categories_List(base.Select());
            return products_categories_list;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Products_Categories pc = entity as Products_Categories;
            pc.Product_Name_Id = Products_DB.SelectById(int.Parse(reader["Product_Name_ID"].ToString()));
            pc.Category_Id = CategoriesDB.SelectById(int.Parse(reader["Category_ID"].ToString()));
            base.CreateModel(entity);
            return entity;
        }
        static private Products_Categories_List list = new Products_Categories_List();

        public static Products_Categories SelectById(int id)
        {
            Products_CategoriesDB db = new Products_CategoriesDB();
            list = db.SelectAll();
            Products_Categories pc = list.Find(item => item.Id == id); return pc;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Products_Categories pc = entity as Products_Categories;
            if (pc != null)
            {
                string sqlStr = $"DELETE FROM Products-Categories where id=@pcid";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pcid", pc.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Products_Categories pc = entity as Products_Categories;
            if (pc != null)
            {
                string sqlStr = $"Insert INTO [Products-Categories] (Pro) VALUES (@cCategory)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cCategory", pc.Product_Name_Id.Id));
                command.Parameters.Add(new OleDbParameter("@cCategory", pc.Category_Id.Id));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Products_Categories pc = entity as Products_Categories;
            if (pc != null)
            {
                string sqlStr = $"UPDATE [Products-Categories] SET Product_Name_Id=@pcId,Category_ID=@cid WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pcId", pc.Product_Name_Id.Id));
                command.Parameters.Add(new OleDbParameter("@cId", pc.Category_Id.Id));
                command.Parameters.Add(new OleDbParameter("@id", pc.Id));
            }
        }
    }
}
