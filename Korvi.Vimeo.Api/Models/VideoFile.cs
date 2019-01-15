using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korvi.Vimeo.Api.Models
{
    public class VideoFile
    {
        public string quality { get; set; }
        public string type { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string link { get; set; }
        public DateTime created_time { get; set; }
        public decimal  fps { get; set; }
        public string md5 { get; set; }
    }
}
