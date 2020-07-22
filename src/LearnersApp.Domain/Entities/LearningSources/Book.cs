using System;
using System.Collections.Generic;
using System.Text;

namespace LearnersApp.Domain.Entities
{
    public class Book : LearningMedium
    {
        public Book(Guid id) : base(id)
        {
        }

        public override string Type => nameof(Book);
    }
}
