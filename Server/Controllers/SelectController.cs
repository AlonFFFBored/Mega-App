using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SelectController : ControllerBase
    {
        [HttpGet]
        [ActionName("GetUsers")]
        public Users_List GetUsers()
        {
            UsersDB usersDB = new UsersDB();
            Users_List users = usersDB.SelectAll();
            return users;
        }

        [HttpGet]
        [ActionName("GetCategories")]
        public Categories_List GetCategories()
        {
            CategoriesDB categoriesDB = new CategoriesDB();
            Categories_List categories = categoriesDB.SelectAll();
            return categories;
        }

        [HttpGet]
        [ActionName("GetMembership")]
        public Membership_List GetMembership()
        {
            Membership_DB membershipDB = new Membership_DB();
            Membership_List membership = membershipDB.SelectAll();
            return membership;
        }

        [HttpGet]
        [ActionName("GetFavorites")]
        public Favorites_List GetFavorites()
        {
            FavoritesDB favoritesDB = new FavoritesDB();
            Favorites_List favorites = favoritesDB.SelectAll();
            return favorites;
        }

        [HttpGet]
        [ActionName("GetProducts")]
        public Products_List GetProducts()
        {
            Products_DB productsDB = new Products_DB();
            Products_List products = productsDB.SelectAll();
            return products;
        }

        [HttpGet]
        [ActionName("GetProducts-Categories")]
        public Products_Categories_List GetProducts_Categories()
        {
            Products_CategoriesDB products_CategoriesDB = new Products_CategoriesDB();
            Products_Categories_List pc = products_CategoriesDB.SelectAll();
            return pc;
        }

        [HttpGet]
        [ActionName("GetOrders")]
        public Orders_List GetOrders()
        {
            Order_DB ordersDB = new Order_DB();
            Orders_List orders = ordersDB.SelectAll();
            return orders;
        }

        [HttpGet]
        [ActionName("GetOrderItems")]
        public OrderItems_List GetOrderItems()
        {
            OrderItems_DB orderItemsDB = new OrderItems_DB();
            OrderItems_List orderItems = orderItemsDB.SelectAll();
            return orderItems;
        }

        [HttpGet]
        [ActionName("GetVideos")]
        public Videos_List GetVideos()
        {
            VideosDB videosDB = new VideosDB();
            Videos_List videos = videosDB.SelectAll();
            return videos;
        }
    }
}
