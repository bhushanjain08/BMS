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
    
    public partial class Moviedesc
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Actors { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public string Showtime { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
