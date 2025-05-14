using CafeComSeuTioAdmin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CafeComSeuTioAdmin.Pages.Products
{
    public class addproductsModel : PageModel
    {
        private CafeContext cafeContext;

        [BindProperty]
        public Product newProduct { get; set; }

        public void OnGet()
        {
        }

        public addproductsModel(CafeContext context) 
        {
            this.cafeContext = context;
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                cafeContext.Add<Product>(newProduct);
                cafeContext.SaveChanges();

                //    var fileName = $"note-{DateTime.Now:yyyyMMddHHmmss}.txt";

                //    var path = Path.Combine("wwwroot/files", fileName);
                //    var productName = newProduct.Name;

                //    System.IO.File.WriteAllText(path, productName);
            }
        }
    }
}
