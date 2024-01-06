namespace car_service.DAL.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PassportNumber { get; set; }
        public string DriversLicenseNumber { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
