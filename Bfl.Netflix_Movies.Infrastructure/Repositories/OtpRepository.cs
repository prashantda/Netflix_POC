using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix.Core.Domain.RepositoryContracts;
using Bfl.Netflix.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Infrastructure.Repositories
{
    public class OtpRepository : GenericRepository<OneTimePassword>, IOtpRepository
    {
        public readonly ApplicationDbContext _context;
        public OtpRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<OneTimePassword> AddOrUpdateAsync(OneTimePassword oneTimePassword)
        {
            var entity = _context.OneTimePasswords.FirstOrDefault(temp => temp.ApplicationUserId == oneTimePassword.ApplicationUserId);
            if(entity == null)
            {
                await _context.OneTimePasswords.AddAsync(oneTimePassword);
                return oneTimePassword;
            }
            else
            {
                entity.OTP=oneTimePassword.OTP;
                entity.TempUserId=oneTimePassword.TempUserId;
                entity.ResetToken=oneTimePassword.ResetToken;
                _context.Update(entity);
                return entity;
            }
        }
    }
}
