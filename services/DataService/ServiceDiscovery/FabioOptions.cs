using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDiscovery
{
    public class FabioOptions
    {
        public bool Enabled { get; set; }
        public string Url { get; set; }
        public string Service { get; set; }
        public int RequestRetries { get; set; }
    }
}
