using System;
using System.Collections.Generic;
using System.Text;

namespace LearnersApp.Domain.Entities
{
    public class LearnerHistory
    {
        public LearnerHistory(Guid learnerId, Guid learningSourceId)
        {
            this.LearnerId = learnerId;
            this.LearningSourceId = learningSourceId;
        }

        public Guid LearnerId { get; protected set; }
        public Guid LearningSourceId { get; protected set; }
        public DateTimeOffset DateFrom { get; set; }
        public DateTimeOffset DateTo { get; set; }
        public string TimeZoneId { get; set; }
    }
}
