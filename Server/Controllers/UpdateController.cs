using Microsoft.AspNetCore.Mvc;
using Model;
using System.Text.RegularExpressions;
using ViewModel;

namespace Server_Manager___API.Controllers
{
    // The route template is "api/Update/[ActionName]"
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UpdateController : Controller
    {
        [HttpPut]
        [ActionName("CategoriesUpdateor")]
        public int UpdateCategories([FromBody] Categories categorie)
        {
            CategoriesDB categoriesDB = new CategoriesDB();
            categoriesDB.Update(categorie);
            int ChangedRecords = categoriesDB.SaveChanges();
            // 200 - OK
            return ChangedRecords;
        }
    }
}