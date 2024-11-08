using CarCareAPI.models;
namespace CarCareAPI.Services.Foundations;
public interface IGasService
{
    ValueTask AddGasAsync(Gas gas);
    ValueTask<List<Gas>> RetrieveAllGasesAsync();
    ValueTask<Gas> RetrieveGasByidAsync(string gasid);
    ValueTask ModifyGasAsync(Gas gas);
    ValueTask RemoveGasByidAsync(string gasid);
}