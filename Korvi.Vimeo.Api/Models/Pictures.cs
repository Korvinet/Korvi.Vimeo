using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korvi.Vimeo.Api.Models
{
    public class Pictures
    {
        public string uri { get; set; }
        public bool active { get; set; }
        public string type { get; set; }
        public List<Size> sizes { get; set; }
        public string resource_key { get; set; }
    }
}
