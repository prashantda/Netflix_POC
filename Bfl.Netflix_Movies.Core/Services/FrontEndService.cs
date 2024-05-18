using Azure.Storage.Blobs;
using Azure.Storage.Sas;
using Azure.Storage;
using Bfl.Netflix_Movies.Core.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bfl.Netflix.Core.Configurations;
using Azure.Storage.Blobs.Specialized;

namespace Bfl.Netflix_Movies.Core.Services
{
    public class FrontEndService : IFrontEndService
    {
        public Task<string> GetBlobUrl(string bolobName)
        {
          
            BlobSasBuilder sasBuilder = new BlobSasBuilder()
            {
                BlobContainerName = Configuration.AzurePublicContainer,
                BlobName = bolobName,
                StartsOn = DateTimeOffset.UtcNow,
                ExpiresOn = DateTimeOffset.UtcNow.AddMinutes(10) // Set an appropriate expiration time
            };

            sasBuilder.SetPermissions(BlobSasPermissions.Read);       
            BlobClient blobClient = new (Configuration.AzureConnection, Configuration.AzurePublicContainer, bolobName);
            string sasToken = sasBuilder.ToSasQueryParameters(new StorageSharedKeyCredential(Configuration.AzureStorageName,Configuration.AzureStorageKey)).ToString();
            string imageUrl = $"{blobClient.Uri}?{sasToken}";
            return Task.FromResult(imageUrl);
        }


    }
}
