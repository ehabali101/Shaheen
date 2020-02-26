using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shaheen.Models
{
    public class TradeDetail
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string OriginCountry { get; set; }

        [Required]
        [StringLength(250)]
        public string Make { get; set; }

        [Required]
        [StringLength(250)]
        public string Condition { get; set; }

        public Trade Trade { get; set; }

        public string TradeId { get; set; }
    }
}
