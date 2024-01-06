namespace car_service.DAL.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public string Car { get; set; }
        public DateTime dateOfReceint { get; set; }
        public DateTime assessmenDeadline { get; set; }
        public DateTime? dateCompletion { get; set; }
        public int Cost {  get; set; }
    }
}
