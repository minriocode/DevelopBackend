using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TheCafeRio.Web.Data;
using TheCafeRio.Web.Entities;

namespace TheCafeRio.Web.Repositories
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        public ApplicationDbContext _context;
        public ReservationRepository(ApplicationDbContext context)
            :base(context)
        {
            _context = context;
        }
        public IEnumerable<Reservation> GetAllReservation()
        {
            return _context.Reservations.ToList();
        }
    }
}
