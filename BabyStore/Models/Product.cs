namespace BabyStore.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
