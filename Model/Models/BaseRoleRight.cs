using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class BaseRoleRight
    {
        public string RoleRightId { get; set; }
        public string RolesId { get; set; }
        public string MenuId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }

        public BaseRoles Roles { get; set; }
    }
}
