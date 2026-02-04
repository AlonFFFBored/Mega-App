using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Client_support;
using Model;

namespace Mega_App.Pages
{
    public partial class Page1 : Page
    {
        private ApiService api = new ApiService();

        public Page1()
        {
            InitializeComponent();
        }

        private void Log(string message)
        {
            Output.Text += $"[{DateTime.Now:HH:mm:ss}] {message}\n";
            Scroller.ScrollToBottom();
        }

        private void ClearLog_Click(object sender, RoutedEventArgs e) => Output.Text = "";

        // --- TEST HANDLERS ---
        private async void TestMembership_Click(object sender, RoutedEventArgs e)
        {
            Log("Starting Membership Test...");
            var item = new Membership
            {
                Email = "",
                Username = "MembershipUser",
                Passkey = "pass123",
                Role = (Role)2,
                Join_Date = DateTime.Now,
                Birthday_Date = new DateTime(2000, 8, 5)
            };
            await RunFullTest("Membership",
                () => api.AddMember(item),
                () => api.UpdateMember(item),
                () => api.DeleteMember(item.Id));
        }

        private async void TestUsers_Click(object sender, RoutedEventArgs e)
        {
            Log("Starting Users Test...");
            var item = new Users
            {
                Username = "TestUser_" + Guid.NewGuid().ToString().Substring(0, 4),
                Email = "test@gmail.com",
                Passkey = "1234",
                Role = (Role)1
            };
            await RunFullTest("User",
                () => api.AddUser(item),
                () => api.UpdateUser(item),
                () => api.DeleteUser(item.Id));
        }

        private async void TestCategories_Click(object sender, RoutedEventArgs e)
        {
            Log("Starting Categories Test...");
            var item = new Categories { Category = "Test Category" };
            await RunFullTest("Category",
                () => api.AddCategory(item),
                () => api.UpdateCategory(item),
                () => api.DeleteCategory(item.Id));
        }

        private async void TestProducts_Click(object sender, RoutedEventArgs e)
        {
            Log("Starting Products Test...");
            var item = new Products
            {
                Product_Name = "Test Product",
                Price = 10.99,
                Amount_In_Stock = 100,
                Picture = "test.png",
                Product_Description = "This is a test product."
            };
            await RunFullTest("Product",
                () => api.AddProduct(item),
                () => api.UpdateProduct(item),
                () => api.DeleteProduct(item.Id));
        }

        private async void TestFavorites_Click(object sender, RoutedEventArgs e)
        {
            Log("Starting Favorites Test...");
            var item = new Favorites {
                User_id = new Users
                    {
                        Id = 1,
                        Username = "NL708",
                        Email = "noam9472@gmail.com",
                        Passkey = "noam1234",
                        Role = (Role)2
                    },
                Product_id = new Products
                    {
                    Id = 1,
                    Product_Name = "Aerolamp",
                    Product_Description = "Soft-glow",
                    Price = 99.99,
                    Picture = "aerolamp.png",
                    Amount_In_Stock = 120
                }
            }; 
            await RunFullTest("Favorite",
                () => api.AddFavorite(item),
                () => api.UpdateFavorite(item),
                () => api.DeleteFavorite(item.Id));
        }

        private async void TestOrders_Click(object sender, RoutedEventArgs e)
        {
            Log("Starting Orders Test...");
            var item = new Orders { User_Id = new Users
            {
                Id = 1,
                Username = "NL708",
                Email = "noam9472@gmail.com",
                Passkey = "noam1234",
                Role = (Role)2
            },
                Order_date = DateTime.Now,
                Status = (Status)1 
            };
            await RunFullTest("Order",
                () => api.AddOrder(item),
                () => api.UpdateOrder(item),
                () => api.DeleteOrder(item.Id));
        }

        private async void TestOrderItems_Click(object sender, RoutedEventArgs e)
        {
            Log("Starting OrderItems Test...");
            var item = new OrderItems { 
                Order_Id = new Orders
                {
                    Id = 1,
                    User_Id = new Users
                    {
                        Id = 1,
                        Username = "NL708",
                        Email = "noam9472@gmail.com",
                        Passkey = "noam1234",
                        Role = (Role)2
                    },
                    Order_date = new DateTime(2025, 6, 6),
                    Status = (Status)1
                },
                Product_Id = new Products
                {
                    Id = 1,
                    Product_Name = "Aerolamp",
                    Product_Description = "Soft-glow",
                    Price = 99.99,
                    Picture = "aerolamp.png",
                    Amount_In_Stock = 120
                },
                Amount = 5 
            };
            await RunFullTest("OrderItem",
                () => api.AddOrderItems(item),
                () => api.UpdateOrderItems(item),
                () => api.DeleteOrderItem(item.Id));
        }

        private async void TestVideos_Click(object sender, RoutedEventArgs e)
        {
            Log("Starting Videos Test...");
            var item = new Videos {
                Video_Name = "Test Video",
                Video_Link = "http://test.com",
                Product_Id = new Products
                {
                    Id = 1,
                    Product_Name = "Aerolamp",
                    Product_Description = "Soft-glow",
                    Price = 99.99,
                    Picture = "aerolamp.png",
                    Amount_In_Stock = 120
                }
            }; // Based on Videos.txt 
            await RunFullTest("Video",
                () => api.AddVideos(item),
                () => api.UpdateVideos(item),
                () => api.DeleteVideos(item.Id));
        }

        // --- GENERIC TEST ENGINE ---
        private async Task RunFullTest(string name, Func<Task<int>> add, Func<Task<int>> update, Func<Task<int>> delete)
        {
            try
            {
                int addResult = await add();
                Log($"{name} Insert: {(addResult == 1 ? "SUCCESS" : $"FAILED {addResult}")}");

                int updateResult = await update();
                Log($"{name} Update: {(updateResult == 1 ? "SUCCESS" : $"FAILED {updateResult}")}");

                // Using a placeholder ID for delete testing
                int deleteResult = await delete();
                Log($"{name} Delete: {(deleteResult >= 0 ? "SUCCESS" : "FAILED")}");

                Log($"--- {name} Test Complete ---\n");
            }
            catch (Exception ex)
            {
                Log($"ERROR in {name} Test: {ex.Message}");
            }
        }
    }
}