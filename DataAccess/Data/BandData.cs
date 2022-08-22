using DataAccess.DBAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class BandData: IBandData
    {
        private readonly ISqlDataAccess _db;

        public BandData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task CreateBand(BandModel bandModel) => _db.SaveData(storedProcedures: "dbo.spBand_Create", new { bandModel.name, bandModel.genres, bandModel.albums });
        

        public Task DeleteBand(int bandId) =>
        _db.SaveData(storedProcedures: "dbo.spBand_Delete", new { Id = bandId });
       

        public Task<IEnumerable<BandModel>> GetAllBand() => _db.LoadData<BandModel, dynamic>(storedProcedures: "dbo.spBand_GetAll", new { });

        public async Task<BandModel?> GetBand(int bandId)
        {
            var result =  await _db.LoadData<BandModel, dynamic>(storedProcedures: "dbo.spBand_Get", new { Id = bandId });
            return result.FirstOrDefault();
        }

        public Task UpdateBand(BandModel bandModel) => _db.SaveData(storedProcedures: "dbo.spBand_Update", new { bandModel });
    }
}
