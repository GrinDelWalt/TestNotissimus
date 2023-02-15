namespace TestNotissimus.Models
{
    public class Tour : Products 
    {
        public double LocalDeliveryCost { get; set; }
        public string worldRegion { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public int Days { get; set; }
        public DateTime TourStartDate { get; set; }
        public DateTime ThourEndDate { get; set; }
        public string Name { get; set; }
        public string HotelStars { get; set; }
        public string Room { get; set; }
        public int MyProperty { get; set; }
        public string Meal { get; set; }
        public string Included { get; set; }
        public string Transport { get; set; }
    }
}