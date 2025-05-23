using CafeComSeuTioAdmin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CafeComSeuTioAdmin.Pages.Products
{
    public class viewallproductsModel : PageModel
    {
        private IProductRepository _irepo;
        public List<Product> Products { get; set; }
        
        public viewallproductsModel(IProductRepository IProduct)
        {
            _irepo = IProduct;
        }
        public void OnGet()
        {
            Products = _irepo.GetAll();
        }
    }
}
