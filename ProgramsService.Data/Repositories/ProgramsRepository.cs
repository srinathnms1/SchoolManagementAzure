namespace ProgramsService.Data.Repositories
{
    using ProgramsService.Domain;
    using ProgramsService.Domain.Models;

    public class ProgramsRepository : GenericRepository<Programs>, IProgramsRepository
    {
        public ProgramsRepository(ProgramsContext vehicleContext)
        : base(vehicleContext)
        {
        }
    }
}
