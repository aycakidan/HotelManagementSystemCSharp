//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagement.App
{
    using System;
    using System.Collections.Generic;
    
    public partial class payment
    {
        public int pay_id { get; set; }
        public int guest_id { get; set; }
        public int res_id { get; set; }
    
        public virtual guest guest { get; set; }
        public virtual guestReservation guestReservation { get; set; }
    }
}
