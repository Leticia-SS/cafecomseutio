namespace CafeComSeuTioAdmin.Data
{
    public class ProductRepositoryEF : IProductRepository
    {
        CafeContext _context { get; set; }

        public ProductRepositoryEF(CafeContext context)
        {
            _context = context;
        }

        void IProductRepository.Add(Product product)
        {
            throw new NotImplementedException();
        }

        void IProductRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        List<Product> IProductRepository.GetAll()
        {
            return _context.Products.ToList();
        }

        Product IProductRepository.GetById(int id)
        {
            return _context.Products.First(x => x.Id == id);
        }

        void IProductRepository.Update(Product product)
        {
            //return _context.Products.Where(x => Delete)
            throw new NotImplementedException();

        }
    }
}
