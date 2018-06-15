using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using FileZilla.Web.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FileZilla.Web.Common
{
    public static class Extensions
    {
        public static IEnumerable<Node> Children(this DirectoryInfo directoryInfo)
        {
            var dirs = directoryInfo.GetDirectories().Select(d => new Node
            {
                FullName = d.FullName,
                Name = d.Name,
                IsFolder = true,
                LastModifiedTime = d.LastWriteTime,
                
            });

            var files = directoryInfo.GetFiles().Select(f => new Node
            {
                Name = f.Name,
                FullName = f.Name
            });

            return dirs.Concat(files);
        }
    }
}