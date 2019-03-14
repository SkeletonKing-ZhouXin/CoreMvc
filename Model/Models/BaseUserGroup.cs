using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class BaseUserGroup
    {
        public BaseUserGroup()
        {
            BaseUserGroupRight = new HashSet<BaseUserGroupRight>();
            BaseUserInfoUserGroup = new HashSet<BaseUserInfoUserGroup>();
        }

        public string UserGroupId { get; set; }
        public string ParentId { get; set; }
        public string UserGroupCode { get; set; }
        public string UserGroupName { get; set; }
        public string UserGroupRemark { get; set; }
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

        public ICollection<BaseUserGroupRight> BaseUserGroupRight { get; set; }
        public ICollection<BaseUserInfoUserGroup> BaseUserInfoUserGroup { get; set; }
    }
}
