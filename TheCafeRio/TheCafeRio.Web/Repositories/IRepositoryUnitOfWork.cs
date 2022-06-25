using TheCafeRio.Web.Data;

namespace TheCafeRio.Web.Repositories
{
    public interface IRepositoryUnitOfWork : IUnitOfWork<ApplicationDbContext>
    {
        IReservationRepository ReservationRepository { get; }
    }
}
