using System;
using System.Collections.Generic;
using System.Text;

namespace MobileMovies
{
    public class Movieitem
    {
        public Movieitem()
        {
            TargetType = typeof(MasterDetailPage1Detail);
        }

        public long Id { get; set; }
        public string url { get; set; }
        public string Name { get; set; }

        public Type TargetType { get; set; }
    }
}
