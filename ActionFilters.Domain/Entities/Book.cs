namespace ActionFilters.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long EAN { get; set; }
        public decimal CostPrice { private get; set; }
        public decimal RetailPrice { get; set; }
    }
}