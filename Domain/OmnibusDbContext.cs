using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace Domain
{
    public partial class OmnibusDbContext : DbContext
    {
        public OmnibusDbContext()
        {
        }

        public OmnibusDbContext(DbContextOptions<OmnibusDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BusScheduleBookings> BusScheduleBookings { get; set; }
        public virtual DbSet<BusScheduleBookingsPayments> BusScheduleBookingsPayments { get; set; }
        public virtual DbSet<BusScheduleBookingsSeats> BusScheduleBookingsSeats { get; set; }
        public virtual DbSet<BusScheduleBookingsTickets> BusScheduleBookingsTickets { get; set; }
        public virtual DbSet<BusScheduleBusTypes> BusScheduleBusTypes { get; set; }
        public virtual DbSet<BusScheduleBuses> BusScheduleBuses { get; set; }
        public virtual DbSet<BusScheduleBusesDates> BusScheduleBusesDates { get; set; }
        public virtual DbSet<BusScheduleBusesLocations> BusScheduleBusesLocations { get; set; }
        public virtual DbSet<BusScheduleCities> BusScheduleCities { get; set; }
        public virtual DbSet<BusScheduleFields> BusScheduleFields { get; set; }
        public virtual DbSet<BusScheduleMultiLang> BusScheduleMultiLang { get; set; }
        public virtual DbSet<BusScheduleOptions> BusScheduleOptions { get; set; }
        public virtual DbSet<BusSchedulePluginCountry> BusSchedulePluginCountry { get; set; }
        public virtual DbSet<BusSchedulePluginLocale> BusSchedulePluginLocale { get; set; }
        public virtual DbSet<BusSchedulePluginLocaleLanguages> BusSchedulePluginLocaleLanguages { get; set; }
        public virtual DbSet<BusSchedulePluginLog> BusSchedulePluginLog { get; set; }
        public virtual DbSet<BusSchedulePluginLogConfig> BusSchedulePluginLogConfig { get; set; }
        public virtual DbSet<BusSchedulePluginOneAdmin> BusSchedulePluginOneAdmin { get; set; }
        public virtual DbSet<BusSchedulePluginPaypal> BusSchedulePluginPaypal { get; set; }
        public virtual DbSet<BusSchedulePluginSms> BusSchedulePluginSms { get; set; }
        public virtual DbSet<BusSchedulePrices> BusSchedulePrices { get; set; }
        public virtual DbSet<BusScheduleRoles> BusScheduleRoles { get; set; }
        public virtual DbSet<BusScheduleRouteDetails> BusScheduleRouteDetails { get; set; }
        public virtual DbSet<BusScheduleRoutes> BusScheduleRoutes { get; set; }
        public virtual DbSet<BusScheduleRoutesCities> BusScheduleRoutesCities { get; set; }
        public virtual DbSet<BusScheduleSeats> BusScheduleSeats { get; set; }
        public virtual DbSet<BusScheduleTickets> BusScheduleTickets { get; set; }
        public virtual DbSet<BusScheduleUsers> BusScheduleUsers { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseMySql("server=host0.domenebi.ge;user=myphp_omnibus;password=Omnibus123;database=myphp_omnibus", x => x.ServerVersion("10.4.11-mariadb"));
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusScheduleBookings>(entity =>
            {
                entity.ToTable("bus_schedule_bookings");

                entity.HasIndex(e => e.BookingDate)
                    .HasName("booking_date");

                entity.HasIndex(e => e.BusId)
                    .HasName("bus_id");

                entity.HasIndex(e => e.PickupId)
                    .HasName("pickup_id");

                entity.HasIndex(e => e.ReturnId)
                    .HasName("return_id");

                entity.HasIndex(e => e.Uuid)
                    .HasName("uuid")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BackId)
                    .HasColumnName("back_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BookingDate)
                    .HasColumnName("booking_date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BookingDatetime)
                    .HasColumnName("booking_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BookingRoute)
                    .HasColumnName("booking_route")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BookingTime)
                    .HasColumnName("booking_time")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BusDepartureDate)
                    .HasColumnName("bus_departure_date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BusId)
                    .HasColumnName("bus_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CAddress)
                    .HasColumnName("c_address")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CCity)
                    .HasColumnName("c_city")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CCompany)
                    .HasColumnName("c_company")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CCountry)
                    .HasColumnName("c_country")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CEmail)
                    .HasColumnName("c_email")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CFname)
                    .HasColumnName("c_fname")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CLname)
                    .HasColumnName("c_lname")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CNotes)
                    .HasColumnName("c_notes")
                    .HasColumnType("text")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CPhone)
                    .HasColumnName("c_phone")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CState)
                    .HasColumnName("c_state")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CTitle)
                    .HasColumnName("c_title")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CZip)
                    .HasColumnName("c_zip")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CcCode)
                    .HasColumnName("cc_code")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CcExp)
                    .HasColumnName("cc_exp")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CcNum)
                    .HasColumnName("cc_num")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CcType)
                    .HasColumnName("cc_type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Deposit)
                    .HasColumnName("deposit")
                    .HasColumnType("decimal(9,2) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsReturn)
                    .HasColumnName("is_return")
                    .HasColumnType("enum('T','F')")
                    .HasDefaultValueSql("'''F'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsSent)
                    .HasColumnName("is_sent")
                    .HasColumnType("enum('T','F')")
                    .HasDefaultValueSql("'''F'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentMethod)
                    .HasColumnName("payment_method")
                    .HasColumnType("enum('paypal','authorize','creditcard','cash','bank')")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PickupId)
                    .HasColumnName("pickup_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'")
                    .HasComment("Location ID");

                entity.Property(e => e.ProcessedOn)
                    .HasColumnName("processed_on")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ReturnDate)
                    .HasColumnName("return_date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ReturnId)
                    .HasColumnName("return_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'")
                    .HasComment("Location ID");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("enum('confirmed','cancelled','pending')")
                    .HasDefaultValueSql("'''pending'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StopDatetime)
                    .HasColumnName("stop_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubTotal)
                    .HasColumnName("sub_total")
                    .HasColumnType("decimal(9,2) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tax)
                    .HasColumnName("tax")
                    .HasColumnType("decimal(9,2) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(9,2) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TxnId)
                    .HasColumnName("txn_id")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Uuid)
                    .HasColumnName("uuid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<BusScheduleBookingsPayments>(entity =>
            {
                entity.ToTable("bus_schedule_bookings_payments");

                entity.HasIndex(e => e.BookingId)
                    .HasName("booking_id");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(9,2) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BookingId)
                    .HasColumnName("booking_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentMethod)
                    .HasColumnName("payment_method")
                    .HasColumnType("enum('paypal','authorize','creditcard','bank','cash')")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentType)
                    .HasColumnName("payment_type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("enum('paid','notpaid')")
                    .HasDefaultValueSql("'''paid'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BusScheduleBookingsSeats>(entity =>
            {
                entity.ToTable("bus_schedule_bookings_seats");

                entity.HasIndex(e => e.BookingId)
                    .HasName("booking_id");

                entity.HasIndex(e => e.EndLocationId)
                    .HasName("end_location_id");

                entity.HasIndex(e => e.SeatId)
                    .HasName("seat_id");

                entity.HasIndex(e => e.StartLocationId)
                    .HasName("start_location_id");

                entity.HasIndex(e => e.TicketId)
                    .HasName("ticket_id");

                entity.HasIndex(e => new { e.BookingId, e.SeatId, e.TicketId, e.StartLocationId })
                    .HasName("booking_id_2")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BookingId)
                    .HasColumnName("booking_id")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EndLocationId)
                    .HasColumnName("end_location_id")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IsReturn)
                    .IsRequired()
                    .HasColumnName("is_return")
                    .HasColumnType("enum('T','F')")
                    .HasDefaultValueSql("'''F'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SeatId)
                    .HasColumnName("seat_id")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.StartLocationId)
                    .HasColumnName("start_location_id")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticket_id")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<BusScheduleBookingsTickets>(entity =>
            {
                entity.ToTable("bus_schedule_bookings_tickets");

                entity.HasIndex(e => e.TicketId)
                    .HasName("ticket_id");

                entity.HasIndex(e => new { e.BookingId, e.TicketId })
                    .HasName("booking_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(9,2)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BookingId)
                    .HasColumnName("booking_id")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IsReturn)
                    .IsRequired()
                    .HasColumnName("is_return")
                    .HasColumnType("enum('T','F')")
                    .HasDefaultValueSql("'''F'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticket_id")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<BusScheduleBusTypes>(entity =>
            {
                entity.ToTable("bus_schedule_bus_types");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.SeatsCount)
                    .HasColumnName("seats_count")
                    .HasColumnType("int(4)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SeatsMap)
                    .HasColumnName("seats_map")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('T','F')")
                    .HasDefaultValueSql("'''T'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BusScheduleBuses>(entity =>
            {
                entity.ToTable("bus_schedule_buses");

                entity.HasIndex(e => e.BusTypeId)
                    .HasName("bus_type_id");

                entity.HasIndex(e => e.RouteId)
                    .HasName("route_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ArrivalTime)
                    .HasColumnName("arrival_time")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BusTypeId)
                    .HasColumnName("bus_type_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DepartureTime)
                    .HasColumnName("departure_time")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("decimal(9,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Recurring)
                    .HasColumnName("recurring")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RouteId)
                    .HasColumnName("route_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SetSeatsCount)
                    .HasColumnName("set_seats_count")
                    .HasColumnType("enum('T','F')")
                    .HasDefaultValueSql("'''F'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<BusScheduleBusesDates>(entity =>
            {
                entity.ToTable("bus_schedule_buses_dates");

                entity.HasIndex(e => new { e.BusId, e.Date })
                    .HasName("bus_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BusId)
                    .HasColumnName("bus_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<BusScheduleBusesLocations>(entity =>
            {
                entity.ToTable("bus_schedule_buses_locations");

                entity.HasIndex(e => e.LocationId)
                    .HasName("location_id");

                entity.HasIndex(e => new { e.BusId, e.LocationId })
                    .HasName("bus_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ArrivalTime)
                    .HasColumnName("arrival_time")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BusId)
                    .HasColumnName("bus_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DepartureTime)
                    .HasColumnName("departure_time")
                    .HasColumnType("time")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LocationId)
                    .HasColumnName("location_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<BusScheduleCities>(entity =>
            {
                entity.ToTable("bus_schedule_cities");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('T','F')")
                    .HasDefaultValueSql("'''T'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BusScheduleFields>(entity =>
            {
                entity.ToTable("bus_schedule_fields");

                entity.HasIndex(e => e.Key)
                    .HasName("key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Label)
                    .HasColumnName("label")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modified)
                    .HasColumnName("modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("enum('script','plugin')")
                    .HasDefaultValueSql("'''script'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("enum('backend','frontend','arrays')")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BusScheduleMultiLang>(entity =>
            {
                entity.ToTable("bus_schedule_multi_lang");

                entity.HasIndex(e => e.Field)
                    .HasName("field");

                entity.HasIndex(e => e.ForeignId)
                    .HasName("foreign_key");

                entity.HasIndex(e => e.Locale)
                    .HasName("locale");

                entity.HasIndex(e => e.Model)
                    .HasName("model");

                entity.HasIndex(e => new { e.ForeignId, e.Model, e.Locale, e.Field })
                    .HasName("foreign_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Field)
                    .HasColumnName("field")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ForeignId)
                    .HasColumnName("foreign_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("enum('script','plugin','data')")
                    .HasDefaultValueSql("'''script'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BusScheduleOptions>(entity =>
            {
                entity.HasKey(e => new { e.ForeignId, e.Key })
                    .HasName("PRIMARY");

                entity.ToTable("bus_schedule_options");

                entity.Property(e => e.ForeignId)
                    .HasColumnName("foreign_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''''''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsVisible)
                    .HasColumnName("is_visible")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Label)
                    .HasColumnName("label")
                    .HasColumnType("text")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Style)
                    .HasColumnName("style")
                    .HasColumnType("varchar(500)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TabId)
                    .HasColumnName("tab_id")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('string','text','int','float','enum','bool')")
                    .HasDefaultValueSql("'''string'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("text")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BusSchedulePluginCountry>(entity =>
            {
                entity.ToTable("bus_schedule_plugin_country");

                entity.HasIndex(e => e.Alpha2)
                    .HasName("alpha_2")
                    .IsUnique();

                entity.HasIndex(e => e.Alpha3)
                    .HasName("alpha_3")
                    .IsUnique();

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Alpha2)
                    .HasColumnName("alpha_2")
                    .HasColumnType("varchar(2)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Alpha3)
                    .HasColumnName("alpha_3")
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('T','F')")
                    .HasDefaultValueSql("'''T'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BusSchedulePluginLocale>(entity =>
            {
                entity.ToTable("bus_schedule_plugin_locale");

                entity.HasIndex(e => e.LanguageIso)
                    .HasName("language_iso")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Dir)
                    .HasColumnName("dir")
                    .HasColumnType("enum('ltr','rtl')")
                    .HasDefaultValueSql("'''ltr'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDefault)
                    .HasColumnName("is_default")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LanguageIso)
                    .HasColumnName("language_iso")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sort)
                    .HasColumnName("sort")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<BusSchedulePluginLocaleLanguages>(entity =>
            {
                entity.ToTable("bus_schedule_plugin_locale_languages");

                entity.HasIndex(e => e.Iso)
                    .HasName("iso")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CountryAbbr)
                    .HasColumnName("country_abbr")
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Dir)
                    .HasColumnName("dir")
                    .HasColumnType("enum('ltr','rtl')")
                    .HasDefaultValueSql("'''ltr'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.File)
                    .HasColumnName("file")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Iso)
                    .HasColumnName("iso")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LanguageAbbr)
                    .HasColumnName("language_abbr")
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Native)
                    .HasColumnName("native")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BusSchedulePluginLog>(entity =>
            {
                entity.ToTable("bus_schedule_plugin_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Function)
                    .HasColumnName("function")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("text")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BusSchedulePluginLogConfig>(entity =>
            {
                entity.ToTable("bus_schedule_plugin_log_config");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BusSchedulePluginOneAdmin>(entity =>
            {
                entity.ToTable("bus_schedule_plugin_one_admin");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("blob")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BusSchedulePluginPaypal>(entity =>
            {
                entity.ToTable("bus_schedule_plugin_paypal");

                entity.HasIndex(e => e.TxnId)
                    .HasName("txn_id")
                    .IsUnique();

                entity.HasIndex(e => new { e.ForeignId, e.SubscrId, e.TxnId, e.TxnType })
                    .HasName("fid")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Dt)
                    .HasColumnName("dt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ForeignId)
                    .HasColumnName("foreign_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.McCurrency)
                    .HasColumnName("mc_currency")
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.McGross)
                    .HasColumnName("mc_gross")
                    .HasColumnType("decimal(9,2) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PayerEmail)
                    .HasColumnName("payer_email")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubscrId)
                    .HasColumnName("subscr_id")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TxnId)
                    .HasColumnName("txn_id")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TxnType)
                    .HasColumnName("txn_type")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BusSchedulePluginSms>(entity =>
            {
                entity.ToTable("bus_schedule_plugin_sms");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BusSchedulePrices>(entity =>
            {
                entity.ToTable("bus_schedule_prices");

                entity.HasIndex(e => e.BusId)
                    .HasName("bus_id");

                entity.HasIndex(e => e.FromLocationId)
                    .HasName("from_location_id");

                entity.HasIndex(e => e.ToLocationId)
                    .HasName("to_location_id");

                entity.HasIndex(e => new { e.TicketId, e.FromLocationId, e.ToLocationId })
                    .HasName("ticket_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BusId)
                    .HasColumnName("bus_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FromLocationId)
                    .HasColumnName("from_location_id")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IsReturn)
                    .IsRequired()
                    .HasColumnName("is_return")
                    .HasColumnType("enum('T','F')")
                    .HasDefaultValueSql("'''F'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(9,2)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticket_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ToLocationId)
                    .HasColumnName("to_location_id")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<BusScheduleRoles>(entity =>
            {
                entity.ToTable("bus_schedule_roles");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('T','F')")
                    .HasDefaultValueSql("'''T'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BusScheduleRouteDetails>(entity =>
            {
                entity.ToTable("bus_schedule_route_details");

                entity.HasIndex(e => e.FromLocationId)
                    .HasName("from_location_id");

                entity.HasIndex(e => e.ToLocationId)
                    .HasName("to_location_id");

                entity.HasIndex(e => new { e.RouteId, e.FromLocationId, e.ToLocationId })
                    .HasName("route_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FromLocationId)
                    .HasColumnName("from_location_id")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RouteId)
                    .HasColumnName("route_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ToLocationId)
                    .HasColumnName("to_location_id")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<BusScheduleRoutes>(entity =>
            {
                entity.ToTable("bus_schedule_routes");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('T','F')")
                    .HasDefaultValueSql("'''T'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BusScheduleRoutesCities>(entity =>
            {
                entity.ToTable("bus_schedule_routes_cities");

                entity.HasIndex(e => e.CityId)
                    .HasName("city_id");

                entity.HasIndex(e => new { e.RouteId, e.CityId, e.Order })
                    .HasName("route_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CityId)
                    .HasColumnName("city_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RouteId)
                    .HasColumnName("route_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<BusScheduleSeats>(entity =>
            {
                entity.ToTable("bus_schedule_seats");

                entity.HasIndex(e => e.BusTypeId)
                    .HasName("bus_type_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BusTypeId)
                    .HasColumnName("bus_type_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Left)
                    .HasColumnName("left")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Top)
                    .HasColumnName("top")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<BusScheduleTickets>(entity =>
            {
                entity.ToTable("bus_schedule_tickets");

                entity.HasIndex(e => e.BusId)
                    .HasName("bus_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BusId)
                    .HasColumnName("bus_id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SeatsCount)
                    .HasColumnName("seats_count")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<BusScheduleUsers>(entity =>
            {
                entity.ToTable("bus_schedule_users");

                entity.HasIndex(e => e.Email)
                    .HasName("email")
                    .IsUnique();

                entity.HasIndex(e => e.RoleId)
                    .HasName("role_id");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasColumnType("enum('T','F')")
                    .HasDefaultValueSql("'''F'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastLogin)
                    .HasColumnName("last_login")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("blob")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'NULL'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('T','F')")
                    .HasDefaultValueSql("'''T'''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
