using System.Collections.Generic;
using TheCafeRio.Web.Entities;

namespace TheCafeRio.Web.Repositories
{
    public interface IReservationRepository
    {
        IEnumerable<Reservation> GetAll();
        Reservation GetById(int id);
        void Create(Reservation reservation);
        void Update(Reservation reservation);
        void Delete(int id);
        void Save();
    }
}
