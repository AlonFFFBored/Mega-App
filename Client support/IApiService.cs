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

        public Task<int> AddCategory();

        public Task<int> UpdateCategory();

        public Task<int> DeleteCategory();

        public Task<Users_List> GetAllUsers();

        public Task<int> AddUser();

        public Task<int> UpdateUser();

        public Task<int> DeleteUser();

        public Task<Membership_List> GetAllMembers();

        public Task<int> AddMember();

        public Task<int> UpdateMember();

        public Task<int> DeleteMember();

        public Task<Favorites_List> GetAllFavorites();

        public Task<int> AddFavorite();

        public Task<int> UpdateFavorite();

        public Task<int> DeleteFavorite();

        public Task<Orders_List> GetAllOrders();

        public Task<int> AddOrder();

        public Task<int> UpdateOrder();

        public Task<int> DeleteOrder();

        public Task<OrderItems_List> GetAllOrderItems();

        public Task<int> AddOrderItems();

        public Task<int> UpdateOrderItems();

        public Task<int> DeleteOrderItem();

        public Task<Products_List> GetAllProducts();

        public Task<int> AddProduct();

        public Task<int> UpdateProduct();

        public Task<int> DeleteProduct();

        public Task<Products_Categories_List> GetAllProducts_Categories();

        public Task<int> AddProduct_Category();

        public Task<int> UpdateProduct_Category();

        public Task<int> DeleteProduct_Category();

        public Task<Videos_List> GetAllVideos();

        public Task<int> AddVideos();

        public Task<int> UpdateVideos();

        public Task<int> DeleteVideos();
    }
}
