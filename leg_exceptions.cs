//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace h24
{
    using System;
    using System.Collections.Generic;
    
    public partial class leg_exceptions
    {
        public int ex_id { get; set; }
        public int leg_id { get; set; }
        public string ex_leg_status { get; set; }
        public bool ex_valid_flag { get; set; }
        public System.TimeSpan ex_dsk_penalty { get; set; }
        public System.DateTime as_of_date { get; set; }
    }
}
