using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Yorumlar> Yorumlars { get; set; }
    }
}