using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class BaseAppendProperty
    {
        public string PropertyId { get; set; }
        public string PropertyFunction { get; set; }
        public string PropertyFunctionUrl { get; set; }
        public string PropertyControlId { get; set; }
        public string PropertyName { get; set; }
        public int? PropertyControlType { get; set; }
        public string PropertyControlDataSource { get; set; }
        public string PropertyControlLength { get; set; }
        public int? PropertyControlMaxlength { get; set; }
        public string PropertyControlStyle { get; set; }
        public string PropertyControlValidator { get; set; }
        public int? PropertyColspan { get; set; }
        public string PropertyEvent { get; set; }
        public int? SortCode { get; set; }
        public int? DeleteMark { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
    }
}
