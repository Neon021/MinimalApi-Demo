using DataAccess.Data;
using DataAccess.Models;

namespace MinimalApi
{
    public static class Api
    {
        public static void ConfigureApi(this WebApplication app)
        {
            app.MapGet(pattern: "/Users", GetBands);
            app.MapGet(pattern: "/Users/{id}", GetBand);
            app.MapGet(pattern: "/Users", InsertBand);
            app.MapGet(pattern: "/Users", UpdateBand);
            app.MapGet(pattern: "/Users", DeleteBand);
        }

        private static async Task<IResult> GetBands(IBandData bandData)
        {
            try
            {
                return Results.Ok(await bandData.GetAllBand());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }


        private static async Task<IResult> GetBand(int id, IBandData data)
        {
            try
            {
                var results = await data.GetBand(id);
                if (results == null)
                    return Results.NotFound();
                return Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> InsertBand(BandModel bandData, IBandData band)
        {
            try
            {
                await band.CreateBand(bandData);
                return Results.Ok();

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);

            }
        }

        private static async Task<IResult> UpdateBand(BandModel bandData, IBandData band)
        {
            try
            {
                await band.UpdateBand(bandData);
                return Results.Ok();
            }
            catch (Exception e)

            {
                return Results.Problem(e.Message);
            }
        }

        private static async Task<IResult> DeleteBand(int id, IBandData band)
        {
            try
            {
                await band.DeleteBand(id);
                return Results.Ok();
            }
            catch (Exception e)
            {
                return Results.Problem(e.Message);
            }
        }

    }
}
