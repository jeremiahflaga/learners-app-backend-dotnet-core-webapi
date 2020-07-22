using System;
using System.Collections.Generic;
using System.Text;

namespace LearnersApp.Domain.Entities
{
    public abstract class LearningMedium
    {
        public Guid Id { get; protected set; }
        public string Title { get; set; }
        public string Author { get; set; } // You might later want to make this as AuthorId, pointing to an Individual
    }
}
