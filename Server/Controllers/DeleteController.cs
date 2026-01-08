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


    }
}
