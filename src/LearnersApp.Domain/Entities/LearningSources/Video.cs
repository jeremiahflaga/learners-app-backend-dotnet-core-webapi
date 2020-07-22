using System;
using System.Collections.Generic;
using System.Text;

namespace LearnersApp.Domain.Entities
{
    public class Video : LearningMedium
    {
        public Video(Guid id) : base(id)
        {
        }

        public override string Type => nameof(Video);
    }
}
