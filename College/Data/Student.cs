//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace College.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string PermanentAddress { get; set; }
        public string ActualAddress { get; set; }
        public string Education { get; set; }
        public int GroupId { get; set; }
        public int StarostaOrNo { get; set; }
    
        public virtual Group Group { get; set; }
    }
}
