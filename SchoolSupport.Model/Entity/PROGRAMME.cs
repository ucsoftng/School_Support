//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolSupport.Model.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROGRAMME
    {
        public PROGRAMME()
        {
            this.STUDENT_LEVEL = new HashSet<STUDENT_LEVEL>();
        }
    
        public int Programme_Id { get; set; }
        public string Programme_Name { get; set; }
        public string Programme_Description { get; set; }
        public string Programme_Short_Name { get; set; }
        public Nullable<bool> Activated { get; set; }
    
        public virtual ICollection<STUDENT_LEVEL> STUDENT_LEVEL { get; set; }
    }
}