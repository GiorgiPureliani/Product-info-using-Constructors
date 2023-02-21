namespace Project8
{
    internal class program
    {
        static void Main()
        {
            Product product1 = new Product();
            product1.Name = "Construction Products";
            product1.PriceDollar = 100000;
            product1.WeightTones = 100;

            product1.Factory = new Factory();
            product1.Factory.CompanyName = "SpaceX";
            product1.Factory.BranchName = "SpaceX - GiGaFactory - Germany Branch N1";
            product1.Factory.NumberOfEmployees = 13000;

            product1.Factory.SabajoPunqti = new SabajoPunqti();
            product1.Factory.SabajoPunqti.Name = "Larsis sabajo Punqti";
            product1.Factory.SabajoPunqti.GamtarUnarianoba = "100 Tons Per Week";
            product1.Factory.SabajoPunqti.Tarifi = "1000$ per Tone";

            product1.Factory.SabajoPunqti.Country = new Country();
            product1.Factory.SabajoPunqti.Country.Name = "China";
            product1.Factory.SabajoPunqti.Country.GrossDomesticProduct = "100,000 Trillion US Dollars";
            product1.Factory.SabajoPunqti.Country.NumberOfFactories = 17;
            product1.Factory.SabajoPunqti.Country.NumberOfCompetitors = 12;

            product1.Factory.SabajoPunqti.Country.Region = new Region();
            product1.Factory.SabajoPunqti.Country.Region.Name = "Central Asia";
            product1.Factory.SabajoPunqti.Country.Region.NumberOfCountries = 6;
            product1.Factory.SabajoPunqti.Country.Region.NumberOfFactories = 28;
            product1.Factory.SabajoPunqti.Country.Region.NumberOfCompetitors = 42;

            Console.WriteLine(product1.Name);
            Console.WriteLine(product1.PriceDollar);
            Console.WriteLine(product1.WeightTones);
            Console.WriteLine(product1.Factory.CompanyName);
            Console.WriteLine(product1.Factory.BranchName);
            Console.WriteLine(product1.Factory.NumberOfEmployees);
            Console.WriteLine(product1.Factory.SabajoPunqti.Name);
            Console.WriteLine(product1.Factory.SabajoPunqti.GamtarUnarianoba);
            Console.WriteLine(product1.Factory.SabajoPunqti.Tarifi);
            Console.WriteLine(product1.Factory.SabajoPunqti.Country.Name);
            Console.WriteLine(product1.Factory.SabajoPunqti.Country.GrossDomesticProduct);
            Console.WriteLine(product1.Factory.SabajoPunqti.Country.NumberOfFactories);
            Console.WriteLine(product1.Factory.SabajoPunqti.Country.NumberOfCompetitors);
            Console.WriteLine(product1.Factory.SabajoPunqti.Country.Region.Name);
            Console.WriteLine(product1.Factory.SabajoPunqti.Country.Region.NumberOfCountries);
            Console.WriteLine(product1.Factory.SabajoPunqti.Country.Region.NumberOfFactories);
            Console.WriteLine(product1.Factory.SabajoPunqti.Country.Region.NumberOfCompetitors);
        }
    }
    class Product
    {
        public string? Name { get; set; }
        public double? PriceDollar { get; set; }
        public double? WeightTones { get; set; }
        public Factory Factory { get; set; }

    }
    class Factory
    {
        public string? CompanyName { get; set; }
        public string? BranchName { get; set; }
        public double? NumberOfEmployees { get; set; }
        public SabajoPunqti SabajoPunqti { get; set; }
    }
    class SabajoPunqti
    {
        public string? Name { get; set; }
        public string? GamtarUnarianoba { get; set; }
        public string? Tarifi { get; set; }
        public Country Country { get; set; }
    }
    class Country
    {
        public string? Name { get; set; }
        public string? GrossDomesticProduct { get; set; }
        public int NumberOfFactories { get; set; }
        public int NumberOfCompetitors { get; set; }
        public Region Region { get; set; }
    }
    class Region
    {
        public string? Name { get; set; }
        public int NumberOfCountries { get; set; }
        public int NumberOfFactories { get; set; }
        public int NumberOfCompetitors { get; set; }
    }
}