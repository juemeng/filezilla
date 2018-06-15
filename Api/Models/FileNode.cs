using System;
using System.Collections.Generic;

namespace FileZilla.Web.Models
{
    public class Node
    {
        public bool IsFolder { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public int? Size { get; set; }
        public IEnumerable<Node> Children { get; set; }
    }
}