using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Service1.Core.DTO.Accounts
{
    public class SubscriptionRequest
    {
        public Guid CustomerId { get; set; }
        public int Amount { get; set; }
    }
}
