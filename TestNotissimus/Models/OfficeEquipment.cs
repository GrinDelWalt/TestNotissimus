using TestNotissimus.Enam;

namespace TestNotissimus.Models
{
    public class OfficeEquipment : Products
    {
        public double LocalDeliveryCost { get; set; }
        public string TypePrefix { get; set; }
        public string Vendor { get; set; }
        public string VendorCode { get; set; }
        public string Model { get; set; }
        public bool ManufacturerWarranty { get; set; }
        public string CountryOfOrigin { get; set; }
    }
}
