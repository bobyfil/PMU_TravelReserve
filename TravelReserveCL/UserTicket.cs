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

    public partial class UserTicket
    {
        public UserTicket(Protobuf.UserTicket userTicketPb)
        {
            this.Id = userTicketPb.Id;
            this.UserId = userTicketPb.UserId;
            this.TicketId = userTicketPb.TicketId;
            this.SeatNo = userTicketPb.SeatNo;

            this.Ticket = new Ticket(userTicketPb.Ticket);
            this.User = new User(userTicketPb.User);
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TicketId { get; set; }
        public int SeatNo { get; set; }

        public virtual Ticket Ticket { get; set; }
        public virtual User User { get; set; }

        public Protobuf.UserTicket ToPBMessage()
        {
            Protobuf.UserTicket userTicketPb = new Protobuf.UserTicket();
            userTicketPb.Id = this.Id;
            userTicketPb.UserId = this.UserId;
            userTicketPb.TicketId = this.TicketId;
            userTicketPb.SeatNo = this.SeatNo;

            userTicketPb.Ticket = this.Ticket.ToPBMessage();
            userTicketPb.User = this.User.ToPBMessage();
            return userTicketPb;
        }


    }
}
