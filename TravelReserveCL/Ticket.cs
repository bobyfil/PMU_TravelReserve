//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelReserveCL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    public partial class Ticket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ticket()
        {
            this.UserTicket = new HashSet<UserTicket>();
        }

        public Ticket(Protobuf.Ticket ticketPb)
        {
            this.Id = ticketPb.Id;
            this.TripId = ticketPb.TripId;
            this.Price = Convert.ToDecimal(ticketPb.Price);
            this.FromDate = DateTime.FromBinary(ticketPb.FromDate);
            this.ToDate = DateTime.FromBinary(ticketPb.ToDate);

            this.Trip = new Trip(ticketPb.Trip);
            this.UserTicket = (HashSet<UserTicket>)ticketPb.UserTicket.Select(ut => new UserTicket(ut));

        }

        public int Id { get; set; }
        public int TripId { get; set; }
        public decimal Price { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        public virtual Trip Trip { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTicket> UserTicket { get; set; }

        public Protobuf.Ticket ToPBMessage()
        {
            Protobuf.Ticket ticketPb = new Protobuf.Ticket();
            ticketPb.Id = this.Id;
            ticketPb.TripId = this.TripId;
            ticketPb.Price = (double)this.Price;
            ticketPb.FromDate = this.FromDate.ToBinary();
            if (this.ToDate.HasValue)
                ticketPb.ToDate = this.ToDate.Value.ToBinary();

            ticketPb.Trip = this.Trip.ToPBMessage();
            ticketPb.UserTicket.AddRange(this.UserTicket.Select(ut => ut.ToPBMessage()));
            return ticketPb;
        }
    }
}
