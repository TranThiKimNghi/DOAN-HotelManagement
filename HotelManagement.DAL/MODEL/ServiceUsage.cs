namespace HotelManagement.DAL.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceUsage")]
    public partial class ServiceUsage
    {
        public int ServiceUsageID { get; set; }

        public int? BookingID { get; set; }

        public int? ServiceID { get; set; }

        public int? UserID { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal TotalAmount { get; set; }

        public virtual Booking Booking { get; set; }

        public virtual Service Service { get; set; }

        public virtual User User { get; set; }
    }
}
