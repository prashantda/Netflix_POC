using Bfl.Netflix_Tv.Core.DTO.Shared;
using Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Core.SyncDataServices.GRPC
{
    public interface IGrpcTvDataClientServices
    {
        Task<IEnumerable<CastOrCategoryDTO>> GetAllCastsOrCategories(string action, string token);
    }
}
