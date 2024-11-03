namespace CarCareAPI.Models;
public class Car
{
    public string? Id { get; set; }
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int? Year { get; set; }
    public string? ClassId { get; set; }
    public string? LicenseExpirationDate { get; set; }
    public string? ExaminationDate { get; set; }
    public string? NotifyEvery { get; set; }
    public int? Km { get; set; }
    public string? ProfileId { get; set; }
}
