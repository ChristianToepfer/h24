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
    
    public partial class api_queue
    {
        public int q_id { get; set; }
        public System.DateTime q_dtime { get; set; }
        public string q_url { get; set; }
        public string q_content { get; set; }
        public string q_status { get; set; }
        public string q_response { get; set; }
        public Nullable<System.DateTime> as_of_date { get; set; }
    }
}
