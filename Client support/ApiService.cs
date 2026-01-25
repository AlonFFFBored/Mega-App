using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Client_support
{
    public class ApiService : IApiService
    {
        public HttpClient client;
        public ApiService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7179/");
        }

        public async Task<T> Select<T>(string endpoint)
        {
            try
            {
                return await client.GetFromJsonAsync<T>(endpoint);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> AddCategory()
        {
            throw new NotImplementedException();
        }

        public async Task<int> AddUser()
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteCategory()
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteUser()
        {
            throw new NotImplementedException();
        }

        public async Task<Categories_List> GetAllCategories()
        {
            return await Select<Categories_List>("api/Select/GetCategories");
        }

        public async Task<Favorites_List> GetAllFavorites()
        {
            return await Select<Favorites_List>("api/Select/GetFavorites");
        }

        public async Task<Membership_List> GetAllMembers()
        {
            return await Select<Membership_List>("api/Select/GetMembership");
        }

        public async Task<OrderItems_List> GetAllOrderItems()
        {
            return await Select<OrderItems_List>("api/Select/GetOrderItems");
        }

        public async Task<Orders_List> GetAllOrders()
        {
            return await Select<Orders_List>("api/Select/GetOrders");
        }

        public async Task<Products_List> GetAllProducts()
        {
            return await Select<Products_List>("api/Select/GetProducts");
        }

        public async Task<Users_List> GetAllUsers()
        {
            return await Select<Users_List>("api/Select/GetUsers");
        }

        public async Task<int> UpdateCategory()
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateUser()
        {
            throw new NotImplementedException();
        }

        public async Task<Products_Categories_List> GetAllProducts_Categories()
        {
            return await Select<Products_Categories_List>("api/Select/GetProducts-Categories");
        }

        public Task<int> AddMember()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateMember()
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteMember()
        {
            throw new NotImplementedException();
        }

        public Task<int> AddFavorite()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateFavorite()
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteFavorite()
        {
            throw new NotImplementedException();
        }

        public Task<int> AddOrder()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateOrder()
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteOrder()
        {
            throw new NotImplementedException();
        }

        public Task<int> AddOrderItems()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateOrderItems()
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteOrderItem()
        {
            throw new NotImplementedException();
        }

        public Task<int> AddProduct()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateProduct()
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteProduct()
        {
            throw new NotImplementedException();
        }

        public Task<int> AddProduct_Category()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateProduct_Category()
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteProduct_Category()
        {
            throw new NotImplementedException();
        }

        public Task<Videos_List> GetAllVideos()
        {
            throw new NotImplementedException();
        }

        public Task<int> AddVideos()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateVideos()
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteVideos()
        {
            throw new NotImplementedException();
        }
    }
}
