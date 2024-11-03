namespace CarCareAPI.Models
{
    public class Repair
    {
        public string? Id { get; set; }
        public double? Cost { get; set; }
        public string? TypeId { get; set; }
        public double? LastRepairKm { get; set; }
        public string? Date { get; set; }
        public double? ReminderKm { get; set; }
        public string? CarId { get; set; }
    }
}
