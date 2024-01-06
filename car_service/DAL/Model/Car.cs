namespace car_service.DAL.Model
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Models { get; set; }
        public string Gen { get; set; }
        public string RegNumber { get; set; }
        public string TechPassport { get; set;}
        public string Color { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string EngineNumber { get; set; }
        public string BodyNumber { get; set; }
    }
}
