namespace PhongThi1.Models
{
    public static class ProductsRepository
    {
        private static readonly List<Product> _list = new List<Product>();

        public static IEnumerable<Product> Products { get { return _list; } }  // liet ke tat ca san pham ra

        public static void AddNew(Product product)
        { _list.Add(product); }
        public static void RemoveProducts(Product product)
        { _list.Remove(product);}
        public static void EditProducts(Product product)
        { Product ProductToEdit = _list.FirstOrDefault(p => p.Id == product.Id);
            if (ProductToEdit != null)
            {
                ProductToEdit.Id = product.Id;
                ProductToEdit.Name = product.Name;
                ProductToEdit.Description = product.Description;
                ProductToEdit.Quantity = product.Quantity;
                ProductToEdit.Price = product.Price;
            }
        }
        public static Product product(int productId)
        { return _list.FirstOrDefault(p => p.Id == productId); }
    }

}
