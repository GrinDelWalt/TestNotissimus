namespace TestNotissimus.Models
{
    public class AudioBook : Products
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public DateTime Year { get; set; }
        public string ISBN { get; set; }
        public string Language { get; set; }
        public string Performed { get; set; }
        public string PerformanceType { get; set; }
        public string Storage { get; set; }
        public string Format { get; set; }
        public string RecordingLength { get; set; }
        public bool Downloadable { get; set; }

    }
}

