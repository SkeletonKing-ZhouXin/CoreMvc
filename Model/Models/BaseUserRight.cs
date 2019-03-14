using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class BaseUserRight
    {
        public string UserRightId { get; set; }
        public string UserId { get; set; }
        public string MenuId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }

        public BaseUserInfo User { get; set; }
    }
}
