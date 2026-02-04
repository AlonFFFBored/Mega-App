using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InsertController : ControllerBase
    {
        [HttpPost]
        [ActionName("InsertAUser")]
        public int InsertUser(Users user)
        {
            UsersDB usersDB = new UsersDB();
            usersDB.Insert(user);
            return usersDB.SaveChanges();
        }

        [HttpPost]
        [ActionName("InsertACategory")]
        public int InsertCategory(Categories category)
        {
            CategoriesDB categoriesDB = new CategoriesDB();
            categoriesDB.Insert(category);
            return categoriesDB.SaveChanges();
        }

        [HttpPost]
        [ActionName("InsertAFavorite")]
        public int InsertFavorite(Favorites favorite)
        {
            FavoritesDB favoritesDB = new FavoritesDB();
            favoritesDB.Insert(favorite);
            return favoritesDB.SaveChanges();
        }

        [HttpPost]
        [ActionName("InsertAMember")]
        public int InsertMember(Membership member)
        {
            Membership_DB membershipDB = new Membership_DB();
            membershipDB.Insert(member);
            return membershipDB.SaveChanges();
        }

        [HttpPost]
        [ActionName("InsertAOrder")]
        public int InsertOrder(Orders order)
        {
            Order_DB ordersDB = new Order_DB();
            ordersDB.Insert(order);
            return ordersDB.SaveChanges();
        }

        [HttpPost]
        [ActionName("InsertAOrderItem")]
        public int InsertOrderItem(OrderItems orderitem)
        {
            OrderItems_DB orderItemsDB = new OrderItems_DB();
            orderItemsDB.Insert(orderitem);
            return orderItemsDB.SaveChanges();
        }

        [HttpPost]
        [ActionName("InsertAProducts")]
        public int InsertProduct(Products product)
        {
            Products_DB productsDB = new Products_DB();
            productsDB.Insert(product);
            return productsDB.SaveChanges();
        }

        [HttpPost]
        [ActionName("InsertAProductCaegory")]
        public int InsertProductCategory(Products_Categories productscategories)
        {
            Products_CategoriesDB productsCategoriesDB = new Products_CategoriesDB();
            productsCategoriesDB.Insert(productscategories);
            return productsCategoriesDB.SaveChanges();
        }

        [HttpPost]
        [ActionName("InsertAVideo")]
        public int InsertVideo(Videos video)
        {
            VideosDB videosDB = new VideosDB();
            videosDB.Insert(video);
            return videosDB.SaveChanges();
        }
    }
}
