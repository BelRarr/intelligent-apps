namespace CalicotGaming.Web.Models
{
    
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? PhotoUrl { get; set; }
        public string? Description { get; set; }        
    }
}
