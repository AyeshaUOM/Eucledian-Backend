using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Etudiant.Models
{
    public class DefaultPayment
    {
        public int Id { get; set; }

        public decimal classFee { get; set; }

        public decimal admissionFee { get; set; }

        public int latePaymentDate { get; set; }

        public decimal latePaymentPrecentage { get; set; }

        [DefaultValue(true)]
        public bool latePaymentEnabled { get; set; }

        public decimal monthEndPrecentage { get; set; }

        [DefaultValue(true)]
        public bool monthEndEnabled { get; set; }

        public Branch branch { get; set; }
    }
}
