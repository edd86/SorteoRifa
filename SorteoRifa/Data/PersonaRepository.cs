namespace SorteoRifa.Data
{
    using SorteoRifa.Data.Entities;

    public class PersonaRepository : GenericRepository<Persona>, IPersonaRepository
    {
        public PersonaRepository(DataContext context) : base(context)
        {

        }
    }
}
