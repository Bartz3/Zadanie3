using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie3.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Zadanie3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet =true)]
        public User user { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost(User user)
        {

            var ctx = new ValidationContext(user);
            var results = new List<ValidationResult>();

            var xd=Validator.TryValidateObject(user, ctx, results, false);

            if (ModelState.IsValid)
            {
                if (user.HeightUnit == "m") user.Result = Math.Round((user.Weight / ((user.Height) * (user.Height))), 2);
                else user.Result = Math.Round((user.Weight / ((user.Height / 100) * (user.Height / 100))), 2);

                return RedirectToPage("BMIpage",user);
            }
            else
            {
                return Page();
            }
        }
    }
}