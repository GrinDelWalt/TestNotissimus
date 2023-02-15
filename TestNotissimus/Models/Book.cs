using TestNotissimus.Enam;

namespace TestNotissimus.Models
{
    public class Book : Products
    {
        public double LocalDeliveryCost { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Series { get; set; }
        public DateTime Year { get; set; }
        public string ISBN { get; set; }
        public int Volume { get; set; }
        public int Part { get; set; }
        public string Language { get; set; }
        public string Binding { get; set; }
        public int PageExtent { get; set; }
        public bool Downloadable { get; set; }
    }
}
