using System;
using Core.Entities;

namespace Core.Entities.Concreate
{
    public class UserOperationClaim : IEntity
    {
            public int UserOperationClaimId { get; set; }
            public int UserId { get; set; }
            public int OperationClaimId { get; set; }
     }
    
}

