using System.Collections.Generic;
using System.Threading.Tasks;
using VLTStations.Models;

namespace ConsumindoServicos.Api
{
    public class DataRioApi : ApiGetBase<List<Station>>
    {
        public async Task<List<Station>> GetData()
        {
            return await GetAsyncTemplate();
        }
    }
}