using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class BaseStaffOrganize
    {
        public string StaffOrganizeId { get; set; }
        public string OrganizationId { get; set; }
        public string UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }

        public BaseOrganization Organization { get; set; }
        public BaseUserInfo User { get; set; }
    }
}
