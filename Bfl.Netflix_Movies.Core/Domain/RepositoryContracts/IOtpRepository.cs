using Bfl.Netflix.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.Domain.RepositoryContracts
{
    public interface IOtpRepository:IGenericRepository<OneTimePassword>
    {
        Task<OneTimePassword> AddOrUpdateAsync(OneTimePassword oneTimePassword);
    }
}
