using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DeleteController : ControllerBase
    {
        [HttpDelete("{id}")]
        [ActionName("DeleteAUser")]
        public int DeleteUser(int id)
        {
            UsersDB usersDB = new UsersDB();
            usersDB.Delete(new Users() { Id = id});
            return usersDB.SaveChanges();
        }

        [HttpDelete("{id}")]
        [ActionName("DeleteACategory")]
        public int DeleteCategory(int id)
        {
            CategoriesDB categoriesDB = new CategoriesDB();
            categoriesDB.Delete(new Categories() { Id = id });
            return categoriesDB.SaveChanges();
        }

        [HttpDelete("{id}")]
        [ActionName("DeleteAFavorite")]
        public int DeleteFavorite(int id)
        {
            FavoritesDB favoritesDB = new FavoritesDB();
            favoritesDB.Delete(new Favorites() { Id = id });
            return favoritesDB.SaveChanges();
        }

        [HttpDelete("{id}")]
        [ActionName("DeleteAMember")]
        public int DeleteMember(int id)
        {
            Membership_DB membershipDB = new Membership_DB();
            membershipDB.Delete(new Membership() { Id = id });
            return membershipDB.SaveChanges();
        }

        [HttpDelete("{id}")]
        [ActionName("DeleteAOrder")]
        public int DeleteOrder(int id)
        {
            Order_DB ordersDB = new Order_DB();
            ordersDB.Delete(new Orders() { Id = id });
            return ordersDB.SaveChanges();
        }

        [HttpDelete("{id}")]
        [ActionName("DeleteAOrderItem")]
        public int DeleteOrderItem(int id)
        {
            OrderItems_DB orderItemsDB = new OrderItems_DB();
            orderItemsDB.Delete(new OrderItems() { Id = id });
            return orderItemsDB.SaveChanges();
        }

        [HttpDelete("{id}")]
        [ActionName("DeleteAProduct")]
        public int DeleteProduct(int id)
        {
            Products_DB productsDB = new Products_DB();
            productsDB.Delete(new Products() { Id = id });
            return productsDB.SaveChanges();
        }

        [HttpDelete("{id}")]
        [ActionName("DeleteAProduct_Category")]
        public int DeleteProduct_Category(int id)
        {
            Products_CategoriesDB productsCDB = new Products_CategoriesDB();
            productsCDB.Delete(new Products_Categories() { Id = id });
            return productsCDB.SaveChanges();
        }

        [HttpDelete("{id}")]
        [ActionName("DeleteAVideo")]
        public int DeleteVideo(int id)
        {
            VideosDB videosDB = new VideosDB();
            videosDB.Delete(new Videos() { Id = id });
            return videosDB.SaveChanges();
        }
    }
}
