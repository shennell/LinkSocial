using Azure.Storage.Blobs;
using LinkSocial.Shared.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkSocial.Server.Controllers
{
    /*[Route("api/[controller]")]*/
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public FileController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /*[HttpGet]
        [Route("api/GetImage")]
        public async Task<ActionResult> Get()
        {
            *//*string imageName;
            var container = GetContainer();
            string prefix = container.Uri.ToString();*//*
        }*/

        [HttpPost]
        [Route("api/UploadImage")]
        public async Task<ActionResult> Post()
        {
            string fileName = "";
            try
            {
                var container = GetContainer();
                fileName = $"{Guid.NewGuid().ToString()}.jpg";

                var blob = container.GetBlobClient(fileName);
                await blob.UploadAsync(Request.Body);
                //await container.UploadBlobAsync(fileName, file.OpenReadStream());
            }
            catch
            {
                return new BadRequestObjectResult("Error saving file");
            }

            return Content(fileName);
        }

        #region helper
        private BlobContainerClient GetContainer()
        {
            string blobConnectionString = _configuration.GetConnectionString("blobConnectionString");
            string blobContainerName = _configuration.GetSection("AzureContainers").GetSection("blobStorageContainer").Value;

            var container = new BlobContainerClient(blobConnectionString, blobContainerName);
            return container;
        }
        #endregion
    }
}
