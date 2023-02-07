namespace MyCartDomain.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Color { get; set; }
        public decimal Price { get; set; }
        public Brand? Brand { get; set; }
        public Category? Category { get; set; }
    }
}
