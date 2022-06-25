using TheCafeRio.Web.Data;

namespace TheCafeRio.Web.Repositories
{
    public class RepositoryUnitOfWork : UnitOfWork<ApplicationDbContext>, IRepositoryUnitOfWork
    {

        public IReservationRepository ReservationRepository { get; set; }
        public RepositoryUnitOfWork(string connectionString)
        {
            ReservationRepository = new ReservationRepository(_dbContext);
        }
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }
}
