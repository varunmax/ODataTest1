namespace ODataService.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Policy { get; set; }

        public DateTime Expiry { get; set; }
        public string Location { get; set; }
        public string State { get; set; }
        public string Region { get; set; }
        public double InsuredValue { get; set; }
        public string Construction { get; set; }
        public string BusinessType { get; set; }
        public string Earthquake { get; set; }
        public string Flood { get; set; }

        public decimal TaxRate { get; set; }
    }
}