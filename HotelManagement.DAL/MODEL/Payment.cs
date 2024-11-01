namespace HotelManagement.DAL.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payment
    {
        public int PaymentID { get; set; }

        public int? BookingID { get; set; }

        public int? RoomID { get; set; }

        public int? UserID { get; set; }

        public DateTime? PaymentDate { get; set; }

        public decimal Amount { get; set; }

        public virtual Booking Booking { get; set; }

        public virtual Room Room { get; set; }

        public virtual User User { get; set; }
    }
}
