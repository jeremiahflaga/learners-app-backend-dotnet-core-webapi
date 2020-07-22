using System;
using System.Collections.Generic;
using System.Text;

namespace LearnersApp.Domain.Entities
{
    public class LearnerHistory
    {
        public LearnerHistory(Guid learnerId, Guid mentorId)
        {
            this.LearnerId = learnerId;
            this.MentorIds = new List<Guid> { mentorId };
        }

        public LearnerHistory(Guid learnerId, ICollection<Guid> mentorIds)
        {
            this.LearnerId = learnerId;
            this.MentorIds = mentorIds;
        }

        // For learning history where there is no mentor
        // The author of the learning medium can be considered as the mentor in this case
        public LearnerHistory(Guid learnerId, LearningMedium learningMedium)
        {
            this.LearnerId = learnerId;
            this.LearningMedium = learningMedium;
        }

        public Guid LearnerId { get; protected set; } // Individual
        public ICollection<Guid> MentorIds { get; protected set; } // Individuals
        public LearningMedium LearningMedium { get; set; }

        public DateTimeOffset DateFrom { get; set; }
        public DateTimeOffset DateTo { get; set; }
        public string TimeZoneId { get; set; }
    }
}
