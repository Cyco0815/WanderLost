﻿using WanderLost.Shared.Data;

namespace WanderLost.Shared.Interfaces
{
    public interface IMerchantHubClient
    {
        Task UpdateMerchantGroup(string server, ActiveMerchantGroup merchantGroup);
        Task UpdateVoteTotal(Guid merchantId, int voteTotal);
        Task UpdateVoteSelf(Guid merchantId, VoteType voteType);
    }
}
