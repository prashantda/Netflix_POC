using Azure.Storage.Sas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Movies.Core.ServiceContracts
{
    public interface IFrontEndService
    {
        public Task<string> GetBlobUrl(string bolobName);
        
    }
}
