using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class BaseOrganization
    {
        public BaseOrganization()
        {
            BaseStaffOrganize = new HashSet<BaseStaffOrganize>();
        }

        public string OrganizationId { get; set; }
        public string OrganizationCode { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationInnerPhone { get; set; }
        public string OrganizationOuterPhone { get; set; }
        public string OrganizationManager { get; set; }
        public string OrganizationAssistantManager { get; set; }
        public string OrganizationFax { get; set; }
        public string OrganizationZipcode { get; set; }
        public string OrganizationAddress { get; set; }
        public string ParentId { get; set; }
        public string OrganizationRemark { get; set; }
        public int? SortCode { get; set; }
        public int? DeleteMark { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }

        public ICollection<BaseStaffOrganize> BaseStaffOrganize { get; set; }
    }
}
