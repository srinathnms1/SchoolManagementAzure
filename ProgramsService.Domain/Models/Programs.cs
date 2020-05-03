namespace ProgramsService.Domain.Models
{
    using SchoolManagement.Core;
    using System;

    public class Programs : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
