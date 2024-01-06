namespace car_service.DAL.Model
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public int ExecutionPeriod { get; set; }
        public int Warranty { get; set; }
    }
}
