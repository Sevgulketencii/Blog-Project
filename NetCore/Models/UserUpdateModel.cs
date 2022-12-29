using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class UserUpdateModel
    {
        public string adSoyad { get; set; }
        public string mail { get; set; }
        public string imgUrl { get; set; }
        public string hakkinda { get; set; }
    }
}
