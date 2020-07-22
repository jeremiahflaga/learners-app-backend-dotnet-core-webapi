using System;
using System.Collections.Generic;
using System.Text;

namespace LearnersApp.Domain.Entities
{
    public class LearningPartner
    {
        public Guid LearnerHistoryIdFrom { get; protected set; }
        public Guid LearnerHistoryIdTo { get; protected set; }
        public int RequestStatus { get; protected set; }
    }
}
