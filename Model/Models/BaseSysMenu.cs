using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class BaseSysMenu
    {
        public string MenuId { get; set; }
        public string ParentId { get; set; }
        public string MenuName { get; set; }
        public string MenuTitle { get; set; }
        public string MenuImg { get; set; }
        public int? MenuType { get; set; }
        public string NavigateUrl { get; set; }
        public string Target { get; set; }
        public int? AllowEdit { get; set; }
        public int? AllowDelete { get; set; }
        public int? SortCode { get; set; }
        public int? DeleteMark { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
    }
}
