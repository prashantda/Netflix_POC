using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Service1.Core.DTO.Accounts
{
    public class PasswordGenerateResponse
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public Guid TempUserId { get; set; }
        public string ResetToken { get; set; }
    }
}
