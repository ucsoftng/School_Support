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
    
    public partial class SCHOOL
    {
        public SCHOOL()
        {
            this.STUDENT = new HashSet<STUDENT>();
        }
    
        public int School_Id { get; set; }
        public string School_Name { get; set; }
        public Nullable<byte> School_Short_Code { get; set; }
    
        public virtual ICollection<STUDENT> STUDENT { get; set; }
    }
}
