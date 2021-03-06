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
    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            this.Bus = new HashSet<Bus>();
        }

        public Company(Protobuf.Company companyPb)
        {
            this.Id = companyPb.Id;
            this.name = companyPb.Name;
            this.logo = companyPb.Logo.ToByteArray();

            this.Bus = (HashSet < Bus > )companyPb.Bus.Select(b => new Bus(b));
        }
        
        public int Id { get; set; }
        public string name { get; set; }
        public byte[] logo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bus> Bus { get; set; }

        public Protobuf.Company ToPBMessage()
        {
            Protobuf.Company companyPb = new Protobuf.Company();
            companyPb.Id = this.Id;
            companyPb.Name = this.name;
            companyPb.Logo = Google.Protobuf.ByteString.CopyFrom(this.logo);

            companyPb.Bus.AddRange(this.Bus.Select(b => b.ToPBMessage()));
            return companyPb;
        }
    }
}
