using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class BaseUserGroupRight
    {
        public string UserGroupRightId { get; set; }
        public string UserGroupId { get; set; }
        public string MenuId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }

        public BaseUserGroup UserGroup { get; set; }
    }
}
