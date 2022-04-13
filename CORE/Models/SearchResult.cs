using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Models
{
    public class SearchResult
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Address { get; set; }
    }
}
