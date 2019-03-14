using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class BaseRecyclebin
    {
        public string RecyclebinId { get; set; }
        public string RecyclebinName { get; set; }
        public string RecyclebinDatabase { get; set; }
        public string RecyclebinTable { get; set; }
        public string RecyclebinFieldKey { get; set; }
        public string RecyclebinEventField { get; set; }
        public string RecyclebinRemark { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
    }
}
