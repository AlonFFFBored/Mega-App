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

        public async Task<int> Insert<T>(string endpoint, T entity) where T : BaseEntity
        {
            try
            {
                HttpResponseMessage result = await client.PostAsJsonAsync<T>(endpoint, entity);
                return result.IsSuccessStatusCode != true ? 0 : 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> Update<T>(string endpoint, T entity) where T : BaseEntity
        {
            try
            {
                HttpResponseMessage result = await client.PutAsJsonAsync<T>(endpoint, entity);
                return result.IsSuccessStatusCode != true ? 0 : 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> Delete<T>(string endpoint, int id) where T : BaseEntity
        {
            try
            {
                T result = await client.DeleteFromJsonAsync<T>((endpoint + $"/{id}"));
                return result == null ? 0 : 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> AddCategory(Categories categories)
        {
            return await Insert<Categories>("api/Insert/InsertACategory", categories);
        }

        public async Task<int> AddUser(Users users)
        {
            return await Insert<Users>("api/Insert/InsertAUser", users);
        }

        public async Task<int> DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteUser(int id)
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

        public async Task<int> UpdateCategory(Categories categories)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateUser(Users users)
        {
            throw new NotImplementedException();
        }

        public async Task<Products_Categories_List> GetAllProducts_Categories()
        {
            return await Select<Products_Categories_List>("api/Select/GetProducts-Categories");
        }

        public async Task<int> AddMember(Membership membership)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateMember(Membership membership)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteMember(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> AddFavorite(Favorites favorites)
        {
            return await Insert<Favorites>("api/Insert/InsertAFavorite", favorites);
        }

        public async Task<int> UpdateFavorite(Favorites favorites)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteFavorite(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> AddOrder(Orders orders)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateOrder(Orders orders)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> AddOrderItems(OrderItems orderItems)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateOrderItems(OrderItems orderItems)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteOrderItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> AddProduct(Products products)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateProduct(Products products)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> AddProduct_Category(Products_Categories products_Categories)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateProduct_Category(Products_Categories products_Categories)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteProduct_Category(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Videos_List> GetAllVideos()
        {
            return await Select<Videos_List>("api/Select/GetVideos");
        }

        public async Task<int> AddVideos(Videos videos)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateVideos(Videos videos)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteVideos(int id)
        {
            throw new NotImplementedException();
        }
    }
}
