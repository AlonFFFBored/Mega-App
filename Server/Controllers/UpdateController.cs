using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UpdateController : ControllerBase
    {
        [HttpPut]
        [ActionName("UpdateAUser")]
        public int UpdateUser(Users user)
        {
            UsersDB usersDB = new UsersDB();
            usersDB.Update(user);
            return usersDB.SaveChanges();
        }

        [HttpPut]
        [ActionName("UpdateACategory")]
        public int UpdateCategory(Categories category)
        {
            CategoriesDB categoriesDB = new CategoriesDB();
            categoriesDB.Update(category);
            return categoriesDB.SaveChanges();
        }

        [HttpPut]
        [ActionName("UpdateAFavorite")]
        public int UpdateFavorite(Favorites favorites)
        {
            FavoritesDB favoritesDB = new FavoritesDB();
            favoritesDB.Update(favorites);
            return favoritesDB.SaveChanges();
        }

        [HttpPut]
        [ActionName("UpdateAMember")]
        public int UpdateMember(Membership member)
        {
            Membership_DB membershipDB = new Membership_DB();
            membershipDB.Update(member);
            return membershipDB.SaveChanges();
        }

        [HttpPut]
        [ActionName("UpdateAOrder")]
        public int UpdateOrder(Orders order)
        {
            Order_DB ordersDB = new Order_DB();
            ordersDB.Update(order);
            return ordersDB.SaveChanges();
        }

        [HttpPut]
        [ActionName("UpdateAOrderItem")]
        public int UpdateOrderItem(OrderItems orderitems)
        {
            OrderItems_DB orderItemsDB = new OrderItems_DB();
            orderItemsDB.Update(orderitems);
            return orderItemsDB.SaveChanges();
        }

        [HttpPut]
        [ActionName("UpdateAProduct")]
        public int UpdateProduct(Products product)
        {
            Products_DB productsDB = new Products_DB();
            productsDB.Update(product);
            return productsDB.SaveChanges();
        }

        [HttpPut]
        [ActionName("UpdateAProductCategory")]
        public int UpdateProductCategory(Products_Categories products_categories)
        {
            Products_CategoriesDB products_CategoriesDB = new Products_CategoriesDB();
            products_CategoriesDB.Update(products_categories);
            return products_CategoriesDB.SaveChanges();
        }

        [HttpPut]
        [ActionName("UpdateAVideo")]
        public int UpdateVideo(Videos video)
        {
            VideosDB videosDB = new VideosDB();
            videosDB.Update(video);
            return videosDB.SaveChanges();
        }
    }
}
