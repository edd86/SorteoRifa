namespace SorteoRifa.Data.Entities
{
    using System;
    public class Ticket : IEntity
    {
        public int Id { get; set; }
        public string Number { get; set; }

        public Persona Persona { get; set; }
    }
}
