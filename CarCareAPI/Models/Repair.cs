namespace CarCareAPI.Models;
public class Repair
{
    public string Id { get; set; }
    public decimal? Cost { get; set; }
    public string TypeId { get; set; }
    public int LastRepairKM { get; set; }
    public string CarId { get; set; }
    public string Date { get; set; }
}
