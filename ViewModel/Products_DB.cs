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
    public class Products_DB : BaseDB
    {
        public override BaseEntity NewEntity()
        {
            throw new NotImplementedException();
        }
        public Products_List SelectAll()
        {
            command.CommandText = $"SELECT * FROM Favorites";

            Products_List products_list = new Products_List(base.Select());
            return products_list;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Products p = entity as Products;
            p.Product_Name = reader["product_name"].ToString();
            p.Product_Description = reader["product_description"].ToString();
            p.Picture = reader["picture"].ToString();
            p.Price= double.Parse(reader["price"].ToString());
            p.Amount_In_Stock = int.Parse(reader["amount_in_stock"].ToString());
            base.CreateModel(entity);
            return entity;
        }
        static private Products_List list = new Products_List();

        public static Products SelectById(int id)
        {
            Products_DB db = new Products_DB();
            list = db.SelectAll();
            Products p = list.Find(item => item.Id == id); return p;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Products p = entity as Products;
            if (p != null)
            {
                string sqlStr = $"DELETE FROM Products where id=@pid";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", p.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Products p = entity as Products;
            if (p != null)
            {
                string sqlStr = $"Insert INTO ProductsTbl (Product_Name,Description,Price,Picture,Amount_In_Stock) VALUES (@pProductName,@pProductDectription,@pProductPrice,@pProductPicture,@pProductAmountInStock)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pProductName", p.Product_Name));
                command.Parameters.Add(new OleDbParameter("@pProductDescription", p.Product_Description));
                command.Parameters.Add(new OleDbParameter("@pProductPrice", p.Price));
                command.Parameters.Add(new OleDbParameter("@pProductPicture", p.Picture));
                command.Parameters.Add(new OleDbParameter("@pProductAmountInStock", p.Amount_In_Stock));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Products p = entity as Products;
            if (p != null)
            {
                string sqlStr = $"UPDATE Videos SET ProductName=@pName,ProductDescription=@pDescription,ProductAmountInStock=@pAmountInStock,ProductPric@pPrice,ProductPicture=@pPicture WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pName", p.Product_Name));
                command.Parameters.Add(new OleDbParameter("@pDescription", p.Product_Description));
                command.Parameters.Add(new OleDbParameter("@pAmountInStock", p.Amount_In_Stock));
                command.Parameters.Add(new OleDbParameter("@pPrice", p.Price));
                command.Parameters.Add(new OleDbParameter("@pPicture", p.Picture));
                command.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }
    }
}
