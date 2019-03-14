using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class BaseOASetup
    {
        public string SetupId { get; set; }
        public string UserId { get; set; }
        public string SetupIname { get; set; }
        public string NavigateUrl { get; set; }
        public string Target { get; set; }
        public string SetupImg { get; set; }
        public string SetupRemak { get; set; }
        public int? SortCode { get; set; }

        public BaseUserInfo User { get; set; }
    }
}
