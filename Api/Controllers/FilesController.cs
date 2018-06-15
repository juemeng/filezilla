using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using FileZilla.Web.Common;
using FileZilla.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FileZilla.Web.Controllers
{
    public class FilesController : ControllerBase
    {
        private readonly string _baseFolder;


        public FilesController(IConfiguration configuration)
        {
            _baseFolder = configuration["folder"];
        }

        [HttpGet]
        [Route("api/files/root")]
        public IEnumerable<Node> Root()
        {
            var baseDir = new DirectoryInfo(_baseFolder);
            return baseDir.Children();
        }
        
        [HttpGet]
        [Route("api/files/{dir}")]
        public IEnumerable<Node> Folder(string dir)
        {
            dir = WebUtility.UrlDecode(dir);
            var baseDir = new DirectoryInfo(dir);
            return baseDir.Children();
        }
    }
}