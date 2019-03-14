using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class BaseUserInfoUserGroup
    {
        public string UserInfoUserGroupId { get; set; }
        public string UserId { get; set; }
        public string UserGroupId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }

        public BaseUserInfo User { get; set; }
        public BaseUserGroup UserGroup { get; set; }
    }
}
