using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shaheen.Models
{
    public class Trade
    {
        
        public string Id { get; set; }

        [Required(ErrorMessage ="*")]
        [StringLength(250)]
        public string TradeName { get; set; }

        [StringLength(250)]
        public string ManufactureCompany { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(250)]
        public string AdditionalInfo { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(250)]
        public string TestCertificateIssuer { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(250)]
        public string TestReportNumber { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(250)]
        public string TestCertificateNumber { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(250)]
        public string SupplierCommercialRegistry { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(250)]
        public string SupplierName { get; set; }

    }
}
