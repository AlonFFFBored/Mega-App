using System;
using System.Collections.Generic;
using System.Net.Http.Json;
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
            // Prevents local tunnel warning pages if he uses them
            client.DefaultRequestHeaders.Add("X-Tunnel-Skip-AntiPhishing-Scan", "true");
        }

        #region Generic Helpers
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
                HttpResponseMessage result = await client.PostAsJsonAsync(endpoint, entity);
                return result.IsSuccessStatusCode ? 1 : 0;
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
                HttpResponseMessage result = await client.PutAsJsonAsync(endpoint, entity);
                return result.IsSuccessStatusCode ? 1 : 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> Delete(string endpoint, int id)
        {
            try
            {
                HttpResponseMessage result = await client.DeleteAsync($"{endpoint}/{id}");
                var jsonHolder = result.Content.ReadAsStringAsync();
                int rowsChanged = int.Parse(jsonHolder.Result.ToString());
                return rowsChanged;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Membership Implementation
        public async Task<Membership_List> GetAllMembers() => await Select<Membership_List>("api/Select/GetMembers");
        public async Task<int> AddMember(Membership membership) => await Insert("api/Insert/InsertAMember", membership);
        public async Task<int> UpdateMember(Membership membership) => await Update("api/Update/UpdateAMember", membership);
        public async Task<int> DeleteMember(int id) => await Delete("api/Delete/DeleteAMember", id);
        #endregion

        #region Categories Implementation
        public async Task<Categories_List> GetAllCategories() => await Select<Categories_List>("api/Select/GetCategories");
        public async Task<int> AddCategory(Categories categories) => await Insert("api/Insert/InsertACategory", categories);
        public async Task<int> UpdateCategory(Categories categories) => await Update("api/Update/UpdateACategory", categories);
        public async Task<int> DeleteCategory(int id) => await Delete("api/Delete/DeleteACategory", id);
        #endregion

        #region Users Implementation
        public async Task<Users_List> GetAllUsers() => await Select<Users_List>("api/Select/GetUsers");
        public async Task<int> AddUser(Users users) => await Insert("api/Insert/InsertAUser", users);
        public async Task<int> UpdateUser(Users users) => await Update("api/Update/UpdateAUser", users);
        public async Task<int> DeleteUser(int id) => await Delete("api/Delete/DeleteAUser", id);
        #endregion

        #region Products Implementation
        public async Task<Products_List> GetAllProducts() => await Select<Products_List>("api/Select/GetProducts");
        public async Task<int> AddProduct(Products products) => await Insert("api/Insert/InsertAProduct", products);
        public async Task<int> UpdateProduct(Products products) => await Update("api/Update/UpdateAProduct", products);
        public async Task<int> DeleteProduct(int id) => await Delete("api/Delete/DeleteAProduct", id);
        #endregion

        #region Videos Implementation
        public async Task<Videos_List> GetAllVideos() => await Select<Videos_List>("api/Select/GetVideos");
        public async Task<int> AddVideos(Videos videos) => await Insert("api/Insert/InsertAVideo", videos);
        public async Task<int> UpdateVideos(Videos videos) => await Update("api/Update/UpdateAVideo", videos);
        public async Task<int> DeleteVideos(int id) => await Delete("api/Delete/DeleteAVideo", id);
        #endregion

        #region Favorites Implementation
        public async Task<Favorites_List> GetAllFavorites() => await Select<Favorites_List>("api/Select/GetFavorites");
        public async Task<int> AddFavorite(Favorites favorites) => await Insert("api/Insert/InsertAFavorite", favorites);
        public async Task<int> UpdateFavorite(Favorites favorites) => await Update("api/Update/UpdateAFavorite", favorites);
        public async Task<int> DeleteFavorite(int id) => await Delete("api/Delete/DeleteAFavorite", id);
        #endregion

        #region Orders Implementation
        public async Task<Orders_List> GetAllOrders() => await Select<Orders_List>("api/Select/GetOrders");
        public async Task<int> AddOrder(Orders orders) => await Insert("api/Insert/InsertAOrder", orders);
        public async Task<int> UpdateOrder(Orders orders) => await Update("api/Update/UpdateAOrder", orders);
        public async Task<int> DeleteOrder(int id) => await Delete("api/Delete/DeleteAOrder", id);
        #endregion

        #region OrderItems Implementation
        public async Task<OrderItems_List> GetAllOrderItems() => await Select<OrderItems_List>("api/Select/GetOrderItems");
        public async Task<int> AddOrderItems(OrderItems items) => await Insert("api/Insert/InsertAOrderItem", items);
        public async Task<int> UpdateOrderItems(OrderItems items) => await Update("api/Update/UpdateAOrderItem", items);
        public async Task<int> DeleteOrderItem(int id) => await Delete("api/Delete/DeleteAOrderItem", id);
        #endregion

        #region Products_Categories Implementation
        public async Task<Products_Categories_List> GetAllProducts_Categories() => await Select<Products_Categories_List>("api/Select/GetProductCategories");
        public async Task<int> AddProduct_Category(Products_Categories products_Categories) => await Insert("api/Insert/InsertAProductCaegory", products_Categories);
        public async Task<int> UpdateProduct_Category(Products_Categories products_Categories) => await Update("api/Update/UpdateAProductCategory", products_Categories);
        public async Task<int> DeleteProduct_Category(int id) => await Delete("api/Delete/DeleteAProductCategory", id);
        #endregion

    }
}