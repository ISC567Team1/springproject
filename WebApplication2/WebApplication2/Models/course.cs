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
    
    public partial class course
    {
        public course()
        {
            this.key1 = new HashSet<key1>();
            this.courseoutcomes = new HashSet<courseoutcome>();
        }
    
        public int courseid { get; set; }
        public string shorttitle { get; set; }
        public Nullable<int> programid { get; set; }
        public string longtitle { get; set; }
        public string catdesc { get; set; }
        public string topics { get; set; }
        public string discussion { get; set; }
        public string yearinprog { get; set; }
        public Nullable<int> sequencenum { get; set; }
    
        public virtual ICollection<key1> key1 { get; set; }
        public virtual ICollection<courseoutcome> courseoutcomes { get; set; }
        public virtual program program { get; set; }
    }
}
