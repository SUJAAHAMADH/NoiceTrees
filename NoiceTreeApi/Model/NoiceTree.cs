using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoiceTreeApi.Model
{
    public class NoiceTree
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string JsonFormat { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedDate { get; set; }
    }
}
