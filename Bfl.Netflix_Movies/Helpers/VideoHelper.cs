using Azure.Storage.Blobs;
using Bfl.Netflix.Core.Configurations;
using static Bfl.Netflix.Core.Helpers.ConfigurationManager;
using Bfl.Netflix_Service1.StartupExtensions;
using Azure.Storage.Blobs.Models;
using Azure;
using Bfl.Netflix_Service1.Core.DTO.Shared;

namespace Bfl.Netflix.Helpers
{
    public static class VideoHelper
    {
       

        public static async Task<string> UploadVideo(Guid id, IFormFile file,IHostEnvironment _host,string typename)
        {
            var extension = Path.GetExtension(file.FileName);
            if (file == null)
            {
                throw new Error("File is empty");
            }
            var filename = $"{id}-{typename}{extension}";
            if ( extension==".jpg"|| extension==".jpeg" || extension == ".mkv" || extension == ".avi" || extension == ".mp4")
            {
                
                /* string fullpath = Path.Combine(_host.ContentRootPath, Configuration.VideoPath, filename);
                 FileStream stream = new FileStream(fullpath, FileMode.Create);
                 await file.CopyToAsync(stream);*/
                 await UploadBlob(file, filename);
                return filename;
            }
            
             
            throw new Exception("mkv,avi,mp4,jpg,jpeg formats are allowed");
        }
        public static async Task<string> UploadBlob(IFormFile file, string name)
        {
            var blobClient = await GetBlobClient(name);
            using (Stream stream = file.OpenReadStream())
            {
                await blobClient.UploadAsync(stream, overwrite: true);
            }
            return blobClient.Uri.AbsoluteUri;
        }
        public static async Task DeleteVideo(Guid id,string typename)
        {
            string[] extensions = { ".mkv", ".avi", ".mp4", ".jpg", ".jpeg" };
            
            foreach (var extension in extensions  )
            {               
              string  filename = $"{id}-{typename}{extension}";
                /*string filePath = Path.Combine(root, Configuration.VideoPath, filename);
                  if (System.IO.File.Exists(filePath))
                  {
                      System.IO.File.Delete(filePath);
                  }*/
                await DeleteBlob(filename);
            }                     
        }
        public static async Task DeleteBlob(string name)
        {
            var blobClient = await GetBlobClient(name);
            await blobClient.DeleteIfExistsAsync();
        }
        public static async Task<BlobClient> GetBlobClient(string name)
        {
            BlobContainerClient container = new BlobContainerClient(AppSetting["BlobSettings:AzureBlob"], AppSetting["BlobSettings:AzureContainer"]);
            return container.GetBlobClient(name);
        }

        public static async Task<Stream> GetBlob(string name)
        {
            var client=await GetBlobClient(name);
            if(await client.ExistsAsync())
            {
                BlobDownloadResult blobDownloadResult =await client.DownloadContentAsync();
                var stream = blobDownloadResult.Content.ToStream();
                return stream;
            }
            throw new Error("File doesn't exist");
        }
        

    }
}
