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
    
    public partial class ROLE
    {
        public ROLE()
        {
            this.USER = new HashSet<USER>();
        }
    
        public int Role_Id { get; set; }
        public string Role_Name { get; set; }
    
        public virtual ICollection<USER> USER { get; set; }
    }
}
