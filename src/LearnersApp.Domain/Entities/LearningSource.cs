using System;
using System.Collections.Generic;
using System.Text;

namespace LearnersApp.Domain.Entities
{
    public abstract class LearningSource
    {
        public Guid Id { get; protected set; }
        public string Title { get; set; }
    }
}
