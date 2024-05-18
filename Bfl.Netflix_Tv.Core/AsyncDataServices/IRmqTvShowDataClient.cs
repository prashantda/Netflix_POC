using Bfl.Netflix_Tv.Core.DTO.TvShowCast;
using Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Core.AsyncDataServices
{
    public interface IRmqTvShowDataClient
    {
        //Task AddTvShowCast(TvRequestResponse request);

        Task AddTvShowCast(TvRequestResponse request);
    }
}
