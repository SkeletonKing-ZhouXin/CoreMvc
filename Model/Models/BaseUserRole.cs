using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class BaseUserRole
    {
        public string UserRoleId { get; set; }
        public string UserId { get; set; }
        public string RolesId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }

        public BaseRoles Roles { get; set; }
        public BaseUserInfo User { get; set; }
    }
}
