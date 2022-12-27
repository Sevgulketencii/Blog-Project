using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi.DataAccesLayer
{
    public class Yazarlar
    {
        [Key]
        public int YazarId { get; set; }
        public string YazarAdi { get; set; }
    }
}
