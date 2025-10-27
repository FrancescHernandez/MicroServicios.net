

namespace Pizzas
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Costo { get; set; }
    }
    
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string url { get; set; }
        public decimal Price { get; set; }
        public List<Ingrediente> ingredientes { get; set; }
    }
}
