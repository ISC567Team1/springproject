//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BKLevel1
    {
        public int BKLevel1ID { get; set; }
        public Nullable<int> programid { get; set; }
        public Nullable<int> curriculumid { get; set; }
        public Nullable<int> NumberL1 { get; set; }
        public string Title { get; set; }
    
        public virtual curriculum curriculum { get; set; }
        public virtual program program { get; set; }
    }
}
