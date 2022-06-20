using System.Collections.Generic;
using TheCafeRio.Web.Data;
using TheCafeRio.Web.Entities;

namespace TheCafeRio.Web.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        public ApplicationDbContext _context;
        public ReservationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            Save();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Reservation> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Reservation GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Reservation reservation)
        {
            throw new System.NotImplementedException();
        }
    }
}
