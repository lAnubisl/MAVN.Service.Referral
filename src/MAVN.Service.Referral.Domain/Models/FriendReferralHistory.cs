using System;
using System.Collections.Generic;

namespace MAVN.Service.Referral.Domain.Models
{
    public class FriendReferralHistory
    {
        public string ReferrerId { get; set; }

        public IReadOnlyList<string> ReferredIds { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
