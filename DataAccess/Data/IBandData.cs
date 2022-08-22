using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IBandData
    {
        Task CreateBand(BandModel bandModel);
        Task DeleteBand(int bandId);
        Task<IEnumerable<BandModel>> GetAllBand();
        Task<BandModel?> GetBand(int bandId);
        Task UpdateBand(BandModel bandModel);
    }
}