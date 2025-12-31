// See https://aka.ms/new-console-template for more information
using Model;
using System.ComponentModel;
using ViewModel;

public class Program
{
    public static void Main(string[] args)
    {
        #region User
        //Console.BackgroundColor = ConsoleColor.Green;
        //UsersDB udb = new UsersDB();
        //int zzz = 0;
        //Users_List uList = udb.SelectAll();
        //foreach (Users u in uList)
        //    Console.WriteLine(u);
        //Users u1 = new Users() { Username = "checker", Email = "lol@gmail.com", Passkey = "5555", Role = Role.User };
        //udb.Insert(u1);
        //zzz = udb.SaveChanges();
        //Console.WriteLine("rows changed: " + zzz);

        //uList = udb.SelectAll();
        //uList.Last().Role = Role.Manager;
        //udb.Update(uList.Last());
        //zzz = udb.SaveChanges();
        //Console.WriteLine($"rows changed: {zzz}");
        //uList = udb.SelectAll();
        //Console.WriteLine(uList.Last());

        //uList = udb.SelectAll();
        //udb.Delete(u1);
        //zzz = udb.SaveChanges();
        //Console.WriteLine("rows changed: " + zzz);
        //uList = udb.SelectAll();
        //Console.WriteLine(uList.Last());
        #endregion

        #region category
        //Console.BackgroundColor = ConsoleColor.Magenta;

        //CategoriesDB categoriesDB = new CategoriesDB();
        //int zz = 0;
        //Categories_List categories = categoriesDB.SelectAll();
        //foreach (Categories c in categories)
        //    Console.WriteLine(c);
        //Console.WriteLine(categories[0]);
        ////categories[0].Category = "New Category Name";
        ////categoriesDB.Update(categories[0]);
        ////Console.WriteLine($"rows changed: {categoriesDB.SaveChanges()}");

        //Categories c1 = new Categories() { Category = "Check Lol" };
        //categoriesDB.Insert(c1);
        //zz = categoriesDB.SaveChanges();
        //Console.WriteLine("Add to cate  " + zz);

        //categoriesDB.Delete(c1);
        //zz = categoriesDB.SaveChanges();
        //Console.WriteLine("delete from cate " + zz);
        #endregion

        #region fav
        //Console.BackgroundColor = ConsoleColor.Red;
        //FavoritesDB favoritesDB = new FavoritesDB();
        //Favorites_List favorites = favoritesDB.SelectAll();
        //foreach (Favorites f in favorites)
        //    Console.WriteLine(f);
        //Console.WriteLine(favorites[0].Product_id);
        //FavoritesDB favoritesDB1 = new FavoritesDB();
        //favorites[0].Product_id = Products_DB.SelectById(2);
        //favoritesDB1.Update(favorites[0]);
        //Console.WriteLine($"rows changed: {favoritesDB1.SaveChanges()}");


        //Favorites f1 = new Favorites() { Product_id = Products_DB.SelectById(3), User_id = UsersDB.SelectById(3) };
        //favoritesDB.Insert(f1);
        //int z = favoritesDB.SaveChanges();
        //Console.WriteLine("Add to favor  " + z);

        //favoritesDB.Delete(f1);
        //int z1 = favoritesDB.SaveChanges();
        //Console.WriteLine("delete from fav " + z1);
        #endregion

        #region memb
        //Console.BackgroundColor = ConsoleColor.Cyan;
        //Membership_DB membershipDB = new Membership_DB();
        //Membership_List membership = membershipDB.SelectAll();
        //foreach (Membership m in membership)
        //    Console.WriteLine(m);
        //Console.WriteLine(membership[0].Join_Date);
        //membership[0].Join_Date = DateTime.Now;
        //membershipDB.Update(membership[0]);
        //Console.WriteLine($"rows changed: {membershipDB.SaveChanges()}");

        //Membership m1 = new Membership()
        //{
        //    Join_Date = new DateTime(2020, 3, 20),
        //    Birthday_Date = new DateTime(1963, 6, 2),
        //    Username = "checker2lol",
        //    Email = "lala@gmail.com",
        //    Passkey = "0909",
        //    Role = Role.User
        //};
        //membershipDB.Insert(m1);
        //int zxz = membershipDB.SaveChanges();
        //Console.WriteLine("Add to memb  " + zxz);

        //membershipDB.Delete(m1);
        //int zxz1 = membershipDB.SaveChanges();
        //Console.WriteLine("delete from mem " + zxz1);
        #endregion

        #region orderitems
        //Console.BackgroundColor = ConsoleColor.Blue;
        //OrderItems_DB orderItems_DB = new OrderItems_DB();
        //OrderItems_List orderItems = orderItems_DB.SelectAll();
        //foreach (OrderItems oi in orderItems)
        //    Console.WriteLine(oi);
        //Console.WriteLine(orderItems[0].Product_Id);
        //orderItems[0].Order_Id = Order_DB.SelectById(2);
        //orderItems_DB.Update(orderItems[0]);
        //Console.WriteLine($"rows changed: {orderItems_DB.SaveChanges()}");

        //OrderItems oi1 = new OrderItems() { Order_Id = Order_DB.SelectById(3), Product_Id = Products_DB.SelectById(3), Amount = 3 };
        //orderItems_DB.Insert(oi1);
        //int zxx = orderItems_DB.SaveChanges();
        //Console.WriteLine("Add to OrderItems " + zxx);

        //orderItems_DB.Delete(oi1);
        //int zxx1 = orderItems_DB.SaveChanges();
        //Console.WriteLine("delete from oi " + zxx1);
        #endregion

        #region orders
        //Console.BackgroundColor = ConsoleColor.Yellow;
        //Order_DB order_DB = new Order_DB();
        //Orders_List orders = order_DB.SelectAll();
        //foreach (Orders o in orders)
        //    Console.WriteLine(o);
        //Console.WriteLine(orders[0].Status);
        //orders[0].Status = (Status)4;
        //order_DB.Update(orders[0]);
        //Console.WriteLine($"rows changed:{order_DB.SaveChanges()}");

        //Orders o1 = new Orders() { Order_date = DateTime.Now, User_Id = UsersDB.SelectById(6), Status = Status.Shipping };
        //order_DB.Insert(o1);
        //int zxzx = order_DB.SaveChanges();
        //Console.WriteLine("Add to Orders " + zxzx);

        //order_DB.Delete(o1);
        //int zxzx1 = order_DB.SaveChanges();
        //Console.WriteLine("delete from orders " + zxzx1);
        #endregion

        #region products
        //Console.BackgroundColor = ConsoleColor.White;
        //Products_DB productsDB = new Products_DB();
        //Products_List products = productsDB.SelectAll();
        //foreach (Products p in products)
        //    Console.WriteLine(p);
        //Console.WriteLine(products[0].Price);
        //Products_DB productsDB1 = new Products_DB();
        //products[0].Price = 99.99;
        //productsDB1.Update(products[0]);
        //Console.WriteLine($"rows changed: {productsDB1.SaveChanges()}");

        //Products p1 = new Products() { Product_Name = "dhfh", Product_Description = "digwivius", Price = 999, Picture = "uhgfydg", Amount_In_Stock = 5 };
        //productsDB1.Insert(p1);
        //int yyy = productsDB1.SaveChanges();
        //Console.WriteLine("Add to p " + yyy);

        //productsDB1.Delete(p1);
        //int yyy1 = productsDB1.SaveChanges();
        //Console.WriteLine(" delete from pro " + yyy1);
        #endregion

        #region products c
        //Console.BackgroundColor = ConsoleColor.DarkYellow;
        //Products_CategoriesDB products_CategoriesDB = new Products_CategoriesDB();
        //Products_Categories_List products_Categories = products_CategoriesDB.SelectAll();
        //foreach (Products_Categories pc in products_Categories)
        //    Console.WriteLine(pc);
        //Console.WriteLine(products_Categories[0].Category_Id);
        //Products_CategoriesDB products_CategoriesDB1 = new Products_CategoriesDB();
        //products_Categories[0].Category_Id = CategoriesDB.SelectById(2);
        //products_CategoriesDB1.Update(products_Categories[0]);
        //Console.WriteLine($"rows changed: {products_CategoriesDB1.SaveChanges()}");

        //Products_Categories pc2 = new Products_Categories() { Category_Id = new Categories() { Id = 5 }, Product_Name_Id = new Products() { Id = 5 } };
        //products_CategoriesDB1.Insert(pc2);
        //int yxy = products_CategoriesDB1.SaveChanges();
        //Console.WriteLine("Add to pc " + yxy);

        //products_CategoriesDB1.Delete(pc2);
        //int yxy1 = products_CategoriesDB1.SaveChanges();
        //Console.WriteLine(" delete from pc " + yxy1);
        #endregion

        #region videos
        //Console.BackgroundColor = ConsoleColor.DarkCyan;
        //VideosDB videosDB = new VideosDB();
        //Videos_List videos = videosDB.SelectAll();
        //foreach (Videos v in videos)
        //    Console.WriteLine(v);
        //Console.WriteLine(videos[0].Video_Name);
        //VideosDB videosDB1 = new VideosDB();
        //videos[0].Video_Name = "New Video Name";
        //videosDB1.Update(videos[0]);
        //Console.WriteLine($"rows changed: {videosDB1.SaveChanges()}");

        //Videos v1 = new Videos() { Video_Name = "Check Video", Video_Link = "This is a test video", Product_Id = new Products() { Id = 5 } };
        //videosDB1.Insert(v1);
        //int eee = videosDB1.SaveChanges();
        //Console.WriteLine("Add to v " + eee);

        //videosDB1.Delete(v1);
        //int eee1 = videosDB1.SaveChanges();
        //Console.WriteLine(" delete frpm vid " + eee1);
        #endregion
    }
}