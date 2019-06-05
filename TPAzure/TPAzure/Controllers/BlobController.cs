using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace TPAzure.Controllers
{
    public class BlobController : Controller
    {
        // GET: Blob
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateBlobContainer()
        {
            // The code in this section goes here.
            CloudBlobContainer container = GetCloudBlobContainer();
            ViewBag.BlobContainerName = container.Name;
            ViewBag.Success = !String.IsNullOrEmpty(container.Name);
            return View();
        }

        private CloudBlobContainer GetCloudBlobContainer()
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                    CloudConfigurationManager.GetSetting("AzureStorageConnectionString-1"));
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference("images");

            string path = @"D:\Cours\4Annee\MajeureCloudComputing\TPCloud\TPAzure\TPAzure/img/coucou.jpg";

            using (var fileStream = System.IO.File.OpenRead(path))
            {

                CloudBlockBlob blockBlob = container.GetBlockBlobReference("images");
                blockBlob.UploadFromStream(fileStream);
            }
            return container;
        }
    }
}