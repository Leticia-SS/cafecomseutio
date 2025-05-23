using CafeComSeuTioAdmin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CafeComSeuTioAdmin.Pages.Products
{
    public class addproductsModel : PageModel
    {
        private CafeContext cafeContext;
        private IProductRepository _productRepository;
        private IWebHostEnvironment webEnv;

        [BindProperty]
        public Product newProduct { get; set; }
        public List<Product> Products {  get; set; } 

        public void OnGet()
        {

        }

        //public addproductsModel(CafeContext context, IWebHostEnvironment webEnv) 
        //{
        public addproductsModel(IProductRepository Irepository, IWebHostEnvironment webEnv, CafeContext context)
        { 
            this.cafeContext = context;
            _productRepository = Irepository;
            this.webEnv = webEnv;
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                //cafeContext.Add<Product>(newProduct);
                //cafeContext.SaveChanges();

                //    var fileName = $"note-{DateTime.Now:yyyyMMddHHmmss}.txt";

                //    var path = Path.Combine("wwwroot/files", fileName);
                //    var productName = newProduct.Name;

                //    System.IO.File.WriteAllText(path, productName);

                if(newProduct.Upload is not null)
                {
                    newProduct.ImageFileName = newProduct.Upload.FileName;

                    var file = Path.Combine(webEnv.ContentRootPath,
                        "wwwroot/images/menu", newProduct.Upload.FileName);
                
                    using (var fileStream = new FileStream(file, FileMode.Create))
                    {
                        await newProduct.Upload.CopyToAsync(fileStream);
                    }
                }

                cafeContext.Add<Product>(newProduct);
                cafeContext.SaveChanges();

            }

            return RedirectToPage("ViewAllProducts", new { id = newProduct.Id });
        }
    }
}
