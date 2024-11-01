namespace HotelManagement.DAL.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BookingDetail
    {
        public int BookingDetailID { get; set; }

        public int? BookingID { get; set; }

        public int? RoomID { get; set; }

        public decimal RoomPrice { get; set; }

        public DateTime? CheckInDate { get; set; }

        public DateTime? CheckOutDate { get; set; }

        public virtual Booking Booking { get; set; }

        public virtual Room Room { get; set; }
    }
}
