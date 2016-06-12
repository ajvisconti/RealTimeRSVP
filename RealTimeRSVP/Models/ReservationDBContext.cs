using System.Data.Common;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace RealTimeRSVP.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string FirstName { get; set; }
        [Required, MaxLength(20)]
        public string LastName { get; set; }
        [Required]
        public int Row { get; set; }
        [Required, MaxLength(1)]
        public string Seat { get; set; }
    }

    public class ReservationDBContext : DbContext
    {
        public ReservationDBContext()
            : base()
        {

        }

        public ReservationDBContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }

        public IDbSet<Reservation> Reservations { get; set; }
    }
}