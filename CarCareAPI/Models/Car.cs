namespace CarCareAPI.models;
public class Car
{
    public string? id { get; set; }
    public string? make { get; set; }
    public string? model { get; set; }
    public int? year { get; set; }
    public string? classid { get; set; }
    public string? license_expiration_date { get; set; }
    public string? examination_date { get; set; }
    public string? notify_every { get; set; }
    public double? Km { get; set; }
    public string? profileid { get; set; }
}