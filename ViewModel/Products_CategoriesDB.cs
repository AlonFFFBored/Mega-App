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
            throw new NotImplementedException();
        }
        public Products_Categories_List SelectAll()
        {
            command.CommandText = $"SELECT * FROM Product_Categories";

            Products_Categories_List products_categories_list = new Products_Categories_List(base.Select());
            return products_categories_list;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Products_Categories pc = entity as Products_Categories;
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
                string sqlStr = $"DELETE FROM Products_Categories where id=@pcid";
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
                string sqlStr = $"UPDATE Videos SET ProductNameId=@pcId,Category=@cid WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pcId", pc.Product_Name_Id.Product_Name));
                command.Parameters.Add(new OleDbParameter("@pcId", pc.Product_Name_Id.Product_Description));
                command.Parameters.Add(new OleDbParameter("@pcId", pc.Product_Name_Id.Amount_In_Stock));
                command.Parameters.Add(new OleDbParameter("@pcId", pc.Product_Name_Id.Price));
                command.Parameters.Add(new OleDbParameter("@pcId", pc.Product_Name_Id.Picture));
                command.Parameters.Add(new OleDbParameter("@pcId", pc.Product_Name_Id.Id));
                command.Parameters.Add(new OleDbParameter("@cId", pc.Category_Id.Category));
                command.Parameters.Add(new OleDbParameter("@cId", pc.Category_Id.Id));
                command.Parameters.Add(new OleDbParameter("@id", pc.Id));
            }
        }
    }
}
