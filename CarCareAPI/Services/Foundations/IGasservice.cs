using CarCareAPI.Models;
namespace CarCareAPI.Services.Foundations;
public interface IGasService
{
    ValueTask AddGasAsync(Gas gas);
    ValueTask<List<Gas>> RetrieveAllGasesAsync();
    ValueTask<Gas> RetrieveGasByIdAsync(string gasId);
    ValueTask ModifyGasAsync(Gas gas);
    ValueTask RemoveGasByIdAsync(string gasId);
}