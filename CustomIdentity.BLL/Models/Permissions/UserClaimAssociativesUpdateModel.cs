﻿using System;
using System.Collections.Generic;

namespace CustomIdentity.BLL.Models.Permissions
{
    public class UserClaimAssociativesUpdateModel
    {
        public Guid UserId { get; set; }
        public IEnumerable<int> ClaimIds { get; set; }
    }
}
