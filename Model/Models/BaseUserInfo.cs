using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class BaseUserInfo
    {
        public BaseUserInfo()
        {
            BaseOASetup = new HashSet<BaseOASetup>();
            BaseStaffOrganize = new HashSet<BaseStaffOrganize>();
            BaseUserInfoUserGroup = new HashSet<BaseUserInfoUserGroup>();
            BaseUserRight = new HashSet<BaseUserRight>();
            BaseUserRole = new HashSet<BaseUserRole>();
        }

        public string UserId { get; set; }
        public string UserCode { get; set; }
        public string UserAccount { get; set; }
        public string UserPwd { get; set; }
        public string UserName { get; set; }
        public int? UserSex { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Theme { get; set; }
        public string Question { get; set; }
        public string AnswerQuestion { get; set; }
        public int? DeleteMark { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
        public string UserRemark { get; set; }

        public ICollection<BaseOASetup> BaseOASetup { get; set; }
        public ICollection<BaseStaffOrganize> BaseStaffOrganize { get; set; }
        public ICollection<BaseUserInfoUserGroup> BaseUserInfoUserGroup { get; set; }
        public ICollection<BaseUserRight> BaseUserRight { get; set; }
        public ICollection<BaseUserRole> BaseUserRole { get; set; }
    }
}
