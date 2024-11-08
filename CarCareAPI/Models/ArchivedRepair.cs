namespace CarCareAPI.Models;
public class ArchivedRepair
{
    public string? Id { get; set; }
    public double? Cost { get; set; }
    public double? LastRepairKM { get; set; }
    public string? Date { get; set; }
    public double? ReminderKm { get; set; }
    public string? ArchivedAt { get; set; }
    public string? CarId { get; set; }
    public string? RepairId { get; set; }
}
