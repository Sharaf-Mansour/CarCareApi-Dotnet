namespace CarCareAPI.models;
public class ArchivedRepair
{
    public string? id { get; set; }
    public double? cost { get; set; }
    public double? lastRepairKm { get; set; }
    public string? date { get; set; }
    public double? reminder_Km { get; set; }
    public string? archivedAt { get; set; }
    public string? carid { get; set; }
    public string? repairid { get; set; }
}