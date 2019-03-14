using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class BaseButton
    {
        public string ButtonId { get; set; }
        public string ButtonName { get; set; }
        public string ButtonTitle { get; set; }
        public string ButtonImg { get; set; }
        public string ButtonCode { get; set; }
        public int? SortCode { get; set; }
        public string ButtonType { get; set; }
        public string ButtonRemak { get; set; }
        public int? DeleteMark { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
    }
}
