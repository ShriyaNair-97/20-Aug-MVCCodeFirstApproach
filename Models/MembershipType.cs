using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieCustomerMVCAppWithAuthentication.Models
{
    public class MembershipType
    {
        [Key]
        public int MembershipTypeId { get; set; }
        public short SignUpFree { get; set; }
        public byte  DurationInMonths{ get; set; }
        public byte DiscountRate { get; set; }
    }
}