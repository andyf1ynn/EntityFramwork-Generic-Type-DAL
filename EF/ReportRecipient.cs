//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReportRecipient
    {
        public int pkReportRecipientsID { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> fkAddedByUserID { get; set; }
        public Nullable<int> fkEmailRecipientID { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> fkReportID { get; set; }
    
        public virtual EmailRecipient EmailRecipient { get; set; }
    }
}