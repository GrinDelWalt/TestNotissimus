namespace TestNotissimus.Models
{
    public class Video : Products
    {
        public string Title { get; set; }
        public DateTime Year { get; set; }
        public string Media { get; set; }
        public string Starring { get; set; }
        public string Director { get; set; }
        public string OriginalName { get; set; }
        public string Country { get; set; }
    }
}