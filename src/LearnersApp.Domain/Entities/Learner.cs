using System;
using System.Collections.Generic;
using System.Text;

namespace LearnersApp.Domain.Entities
{
    public class Learner
    {
        public Guid Id { get; protected set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
