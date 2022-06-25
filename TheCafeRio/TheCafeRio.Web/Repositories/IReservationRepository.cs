using System.Collections.Generic;
using TheCafeRio.Web.Entities;

namespace TheCafeRio.Web.Repositories
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        IEnumerable<Reservation> GetAllReservation();
    }
}
