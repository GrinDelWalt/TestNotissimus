using TestNotissimus.Enam;

namespace TestNotissimus.Models
{
    public abstract class Products
    {
        public int Id { get; set; }
        public TypeProducts Type { get; set; }
        public int Did { get; set; }
        public int Cbid { get; set; }
        public bool Available { get; set; }
        public double Price { get; set; }
        public string Url { get; set; }
        public Currency CurrencyId { get; set; } 
        public string Picture { get; set; }
        public bool Delivery { get; set; }
        public string Description { get; set; }
        public int CategiryId { get; set; }
        public Category Category { get; set; }


        // связь через котегории categoryId 
    }
}
