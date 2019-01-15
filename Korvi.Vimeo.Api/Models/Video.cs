using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korvi.Vimeo.Api.Models
{
    public class Video
    {
        public string uri { get; set; }
        public string name { get; set; }
        public object description { get; set; }
        public string link { get; set; }
        public int duration { get; set; }
        public int width { get; set; }
        public object language { get; set; }
        public int height { get; set; }
        public DateTime created_time { get; set; }
        public DateTime modified_time { get; set; }
        public DateTime release_time { get; set; }
        public List<string> content_rating { get; set; }
        public object license { get; set; }
        public Pictures pictures { get; set; }
        public Stats stats { get; set; }
        public User user { get; set; }
        public string status { get; set; }
        public string resource_key { get; set; }
        public Upload upload { get; set; }
        public Transcode transcode { get; set; }
        public List<VideoFile> files { get; set; }
    }
}
