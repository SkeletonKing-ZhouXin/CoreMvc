using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class BaseRoles
    {
        public BaseRoles()
        {
            BaseRoleRight = new HashSet<BaseRoleRight>();
            BaseUserRole = new HashSet<BaseUserRole>();
        }

        public string RolesId { get; set; }
        public string ParentId { get; set; }
        public string RolesName { get; set; }
        public string RoleRestriction { get; set; }
        public string RolesRemark { get; set; }
        public int? AllowEdit { get; set; }
        public int? AllowDelete { get; set; }
        public int? SortCode { get; set; }
        public int? DeleteMark { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }

        public ICollection<BaseRoleRight> BaseRoleRight { get; set; }
        public ICollection<BaseUserRole> BaseUserRole { get; set; }
    }
}
