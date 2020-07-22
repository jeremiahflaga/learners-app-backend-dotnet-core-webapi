using System;
using System.Collections.Generic;
using System.Text;

namespace LearnersApp.Domain.Entities
{
    public class Article : LearningMedium
    {
        public Article(Guid id) : base(id)
        {
        }

        public override string Type => nameof(Article);
    }
}
