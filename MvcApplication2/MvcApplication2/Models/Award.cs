//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Award
    {
        public int TitleId { get; set; }
        public Nullable<bool> AwardWon { get; set; }
        public Nullable<int> AwardYear { get; set; }
        public string Award1 { get; set; }
        public string AwardCompany { get; set; }
        public int Id { get; set; }
    
        public virtual Title Title { get; set; }
    }
}
