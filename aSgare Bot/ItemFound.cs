using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aSgare_Bot
{
    public class ItemFound
    {
        public string Titre { get; set; }
        public string Description { get; set; }
        public string Url_image { get; set; }
        public string Url { get; set; }
        public string Iframe_source { get; set; }
        public string Domain { get; set; }
        public string Date { get; set; }

        public List<object> parts = new List<object>(); 
    }
}
