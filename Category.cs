namespace project
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Relationship to Products
        public List<Product> Products { get; set; }
    }
}
