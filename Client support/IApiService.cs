using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace Client_support
{
    public interface IApiService
    {
        // Categories
        Task<Categories_List> GetAllCategories();
        Task<int> AddCategory(Categories categories);
        Task<int> UpdateCategory(Categories categories);
        Task<int> DeleteCategory(int id);

        // Users
        Task<Users_List> GetAllUsers();
        Task<int> AddUser(Users users);
        Task<int> UpdateUser(Users users);
        Task<int> DeleteUser(int id);

        // Membership
        Task<Membership_List> GetAllMembers();
        Task<int> AddMember(Membership membership);
        Task<int> UpdateMember(Membership membership);
        Task<int> DeleteMember(int id);

        // Favorites
        Task<Favorites_List> GetAllFavorites();
        Task<int> AddFavorite(Favorites favorites);
        Task<int> UpdateFavorite(Favorites favorites);
        Task<int> DeleteFavorite(int id);

        // Orders
        Task<Orders_List> GetAllOrders();
        Task<int> AddOrder(Orders orders);
        Task<int> UpdateOrder(Orders orders);
        Task<int> DeleteOrder(int id);

        // OrderItems
        Task<OrderItems_List> GetAllOrderItems();
        Task<int> AddOrderItems(OrderItems items);
        Task<int> UpdateOrderItems(OrderItems items);
        Task<int> DeleteOrderItem(int id);

        // Products
        Task<Products_List> GetAllProducts();
        Task<int> AddProduct(Products products);
        Task<int> UpdateProduct(Products products);
        Task<int> DeleteProduct(int id);

        // Products Categories
        Task<Products_Categories_List> GetAllProducts_Categories();
        Task<int> AddProduct_Category(Products_Categories products_Categories);
        Task<int> UpdateProduct_Category(Products_Categories products_Categories);
        Task<int> DeleteProduct_Category(int id);

        // Videos
        Task<Videos_List> GetAllVideos();
        Task<int> AddVideos(Videos videos);
        Task<int> UpdateVideos(Videos videos);
        Task<int> DeleteVideos(int id);
    }
}