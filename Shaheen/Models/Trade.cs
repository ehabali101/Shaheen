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
        [Display(Name = "اسم العلامة التجارية")]
        public string TradeName { get; set; }

        [StringLength(250)]
        [Display(Name = "الشركة المصنعة")]
        public string ManufactureCompany { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(250)]
        [Display(Name = "معلومات اضافية")]
        public string AdditionalInfo { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(250)]
        [Display(Name = "جهة اصدار شهادة الاختبار")]
        public string TestCertificateIssuer { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(250)]
        [Display(Name = "رقم التقرير")]
        public string TestReportNumber { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(250)]
        [Display(Name = "رقم شهادة الاختبار")]
        public string TestCertificateNumber { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(250)]
        [Display(Name = "السجل التجاري للمورد")]
        public string SupplierCommercialRegistry { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(250)]
        [Display(Name = "اسم المورد")]
        public string SupplierName { get; set; }

    }
}
