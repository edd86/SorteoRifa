namespace SorteoRifa.Data.Entities
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Persona : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

    }
}
