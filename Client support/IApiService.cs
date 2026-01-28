using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Client_support
{
    public interface IApiService
    {
        public Task<Categories_List> GetAllCategories();

        public Task<int> AddCategory(Categories categories);

        public Task<int> UpdateCategory(Categories categories);

        public Task<int> DeleteCategory(int id);

        public Task<Users_List> GetAllUsers();

        public Task<int> AddUser(Users users);

        public Task<int> UpdateUser(Users users);

        public Task<int> DeleteUser(int id);

        public Task<Membership_List> GetAllMembers();

        public Task<int> AddMember(Membership membership);

        public Task<int> UpdateMember(Membership membership);

        public Task<int> DeleteMember(int id);

        public Task<Favorites_List> GetAllFavorites();

        public Task<int> AddFavorite(Favorites favorites);

        public Task<int> UpdateFavorite(Favorites favorites);

        public Task<int> DeleteFavorite(int id);

        public Task<Orders_List> GetAllOrders();

        public Task<int> AddOrder(Orders orders);

        public Task<int> UpdateOrder(Orders orders);

        public Task<int> DeleteOrder(int id);

        public Task<OrderItems_List> GetAllOrderItems();

        public Task<int> AddOrderItems(OrderItems items);

        public Task<int> UpdateOrderItems(OrderItems items);

        public Task<int> DeleteOrderItem(int id);

        public Task<Products_List> GetAllProducts();

        public Task<int> AddProduct(Products products);

        public Task<int> UpdateProduct(Products products);

        public Task<int> DeleteProduct(int id);

        public Task<Products_Categories_List> GetAllProducts_Categories();

        public Task<int> AddProduct_Category(Products_Categories products_Categories);

        public Task<int> UpdateProduct_Category(Products_Categories products_Categories);

        public Task<int> DeleteProduct_Category(int id);

        public Task<Videos_List> GetAllVideos();

        public Task<int> AddVideos(Videos videos);

        public Task<int> UpdateVideos(Videos videos);

        public Task<int> DeleteVideos(int id);
    }
}
