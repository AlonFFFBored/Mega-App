using Microsoft.AspNetCore.Mvc;
using Model;
using System.ComponentModel;
using System.Text.RegularExpressions;
using ViewModel;

namespace Server_Manager___API.Controllers
{
    // The route template is "api/Insert/[ActionName]"
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InsertController : Controller
    {
        [HttpPost]
        [ActionName("CategoriesInsertor")]
        public int InsertCategorie([FromBody] Categories categorie)
        {
            CategoriesDB categoriesDB = new CategoriesDB();
            categoriesDB.Insert(categorie);
            int ChangedRecords = categoriesDB.SaveChanges();
            // 200 - OK
            return ChangedRecords;
        }
    }
}