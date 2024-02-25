using System;

namespace Demos.Orlando.ToDo.Models.Users
{
    public class User
    {
        public Guid Id { get; set; }

        // TODO: Add your properties here. 


        public Guid CreatedByUserId { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public Guid UpdatedByUserId { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }

    }
}
