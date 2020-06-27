using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class BlogPost
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string PostTitle { get; set; }
        public string PostContents { get; set; }
    }
}
