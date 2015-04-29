using Template.DomainInterface;

namespace Template.Data.ORM
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HFBDataContext : DbContext
    {
        public HFBDataContext()
            : base("name=HFB")
        {
        }


        public virtual DbSet<EFTHold> EFTHolds { get; set; }
        public virtual DbSet<HamiltonLevel> HamiltonLevels { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<ProspectDeniedAppPrinted> ProspectDeniedAppPrinteds { get; set; }
        public virtual DbSet<Prospect> Prospects { get; set; }
        public virtual DbSet<SavingsCalculatorData> SavingsCalculatorDatas { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ZipCode> ZipCodes { get; set; }
        public virtual DbSet<PasswordHintQuestion> PasswordHintQuestions { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<UserMessage> UserMessages { get; set; }
        public virtual DbSet<GetProspectCreditInfo> GetProspectCreditInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EFTHold>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<EFTHold>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<EFTHold>()
                .Property(e => e.ReferenceNumber)
                .IsUnicode(false);

            modelBuilder.Entity<EFTHold>()
                .Property(e => e.PaymentAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<EFTHold>()
                .Property(e => e.Security_Id)
                .IsUnicode(false);

            modelBuilder.Entity<EFTHold>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.ts_location)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.tk_level)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.rpt_date_ti)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.tx_num_ti)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.ts_tankserialnum)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.base_id_ti)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.address_bi)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.city_bi)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.state_bi)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.ts_access)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.tk_w_dau)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.ts_capacity)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.tat_ttanklow)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.tat_ttankcrit)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.ts_cat_1)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.ts_cat_2)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.ts_cat_3)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.ts_cat_4)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.ts_code)
                .IsUnicode(false);

            modelBuilder.Entity<HamiltonLevel>()
                .Property(e => e.base_temp)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Latitude)
                .HasPrecision(18, 12);

            modelBuilder.Entity<Location>()
                .Property(e => e.Longitude)
                .HasPrecision(18, 12);

            modelBuilder.Entity<Prospect>()
                .Property(e => e.SSN)
                .IsUnicode(false);

            modelBuilder.Entity<Prospect>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Prospect>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Prospect>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Prospect>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Prospect>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<Prospect>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<Prospect>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Prospect>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Prospect>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<Prospect>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Prospect>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<Prospect>()
                .Property(e => e.Plan)
                .IsUnicode(false);

            modelBuilder.Entity<Prospect>()
                .Property(e => e.ReportTextMessage)
                .IsUnicode(false);

            modelBuilder.Entity<SavingsCalculatorData>()
                .Property(e => e.FirstFillPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SavingsCalculatorData>()
                .Property(e => e.AdvantageProgramPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SavingsCalculatorData>()
                .Property(e => e.SalesTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SavingsCalculatorData>()
                .Property(e => e.CurrentPriceEntered)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SavingsCalculatorData>()
                .Property(e => e.FirstYearCalculated)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SavingsCalculatorData>()
                .Property(e => e.SecondYearCalculated)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ZipCode>()
                .Property(e => e.ZipCode1)
                .IsUnicode(false);

            modelBuilder.Entity<ZipCode>()
                .Property(e => e.NotifyAddress)
                .IsUnicode(false);

            modelBuilder.Entity<PasswordHintQuestion>()
                .Property(e => e.HintText)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<UserMessage>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<GetProspectCreditInfo>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<GetProspectCreditInfo>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<GetProspectCreditInfo>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<GetProspectCreditInfo>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<GetProspectCreditInfo>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<GetProspectCreditInfo>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<GetProspectCreditInfo>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<GetProspectCreditInfo>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<GetProspectCreditInfo>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<GetProspectCreditInfo>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<GetProspectCreditInfo>()
                .Property(e => e.Plan)
                .IsUnicode(false);
        }

        public object GetEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(object source)
        {
            throw new NotImplementedException();
        }

        public int Add(object source)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id, bool removeRelation)
        {
            throw new NotImplementedException();
        }

        public object GetEntityByMasterId(int masterId)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.List<object> GetEntitiesByMasterId(int masterId)
        {
            throw new NotImplementedException();
        }
    }
}
