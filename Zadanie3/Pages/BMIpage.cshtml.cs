using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie3.Models;

namespace Zadanie3.Pages
{
    public class BMIpageModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public User user { get; set; }
        public void OnGet(User usr)
        {
            user = usr;
        }
    }
}
